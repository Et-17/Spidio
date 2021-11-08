using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CSVersion
{
    internal static class Program
    {
        public static Form1 _main;
        public static readonly Stopwatch ElapsedTime = new();
        public static readonly DateTime starttime = DateTime.Now;

        public static void Run()
        {
            if (!MandatoryOptionsSet()) return;
            ElapsedTime.Start();
            InitializeOutputManagement(out int fileNumber, out int currentFileNumber, out StreamReader primaryr);
            CrawlSites(new HtmlWeb(), ref fileNumber, ref currentFileNumber, ref primaryr);
            if (_main.ConsolidateFiles.Checked)
                ConsolidateCollectedLinks();
            FinishUp();
            ElapsedTime.Stop();
        }

        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _main = new Form1();
            Application.Run(_main);
        }

        private static void FinishUp()
        {
            GUI.Print("Finished collecting links");
        }

        private static bool MandatoryOptionsSet()
        {
            if (string.IsNullOrEmpty(_main.folderBrowserDialog1.SelectedPath)) { GUI.Print("ERROR: Please select a folder to save output files to"); return false; }
            else if (string.IsNullOrEmpty(_main.SettingsSourceUrlTextBox.Text)) { GUI.Print("ERROR: Please enter in a url to start the searching at"); return false; }
            else if (_main.SettingsSourceUrlTextBox.Text[0] != 'h') { GUI.Print("ERROR: The url to start with must start with \"https://\" or \"http://\""); return false; }
            else if ((int)_main.SettingsProcessLinksUpDown.Value <= 0) { GUI.Print("ERROR: The amount of urls to process must be above zero"); return false; }
            else if (_main.RemoveDuplicates.Checked && _main.RemoveDuplicates.Enabled && !_main.ConsolidateFiles.Checked) { GUI.Print("ERROR: An error has occurred in the settings, please restart the program and try again"); return false; }
            return true;
        }

        private static void InitializeOutputManagement(out int fileNumber, out int currentFileNumber, out StreamReader primaryr)
        {
            fileNumber = 0;
            currentFileNumber = 0;
            FileStream primary = new(_main.folderBrowserDialog1.SelectedPath + fileNumber + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter primaryw = new(primary);
            primaryw.WriteLine(_main.SettingsSourceUrlTextBox.Text);
            primaryw.Flush();
            primary.Seek(0, SeekOrigin.Begin);
            primaryr = new(primary);
        }

        private static void CrawlSites(HtmlWeb web, ref int fileNumber, ref int currentFileNumber, ref StreamReader primaryr)
        {
            _main.Invoke((Action)(() =>
            {
                _main.progressBar1.Value = 0;
                _main.progressBar1.Maximum = (int)_main.SettingsProcessLinksUpDown.Value;
            }));
            _main.progressBar1.Value = 0;
            _main.progressBar1.Maximum = (int)_main.SettingsProcessLinksUpDown.Value;
            for (var i = 0; i < (int)_main.SettingsProcessLinksUpDown.Value; i++)
            {
                GUI.ChangeRunButton("Establishing store point");
                List<string> collectedLinks = new();
                string nextAddress = primaryr.ReadLine();
                //Check for EOF
                if (string.IsNullOrEmpty(nextAddress))
                {
                    FixEOF(ref currentFileNumber, out _, out primaryr, ref i);
                    continue;
                }
                else
                {
                    int nextNumber = CollectLinksFromNextSite(web, fileNumber, collectedLinks, nextAddress);
                    if (nextNumber == 0)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        fileNumber = nextNumber;
                    }
                }
                WriteCollectedLinksToFile(fileNumber, collectedLinks);
                GUI.UpdateDetailsPanel(i, ElapsedTime, starttime);
            }
        }

        private static int CollectLinksFromNextSite(HtmlWeb web, int fileNumber, List<string> collectedLinks, string nextAddress)
        {
            GUI.ChangeRunButton("Collecting links");
            HtmlNodeCollection links = null;
            try
            {
                links = web.Load(nextAddress).DocumentNode.SelectNodes("//a[@href]");
            }
            catch { }
            GUI.ChangeRunButton("Storing links");
            if (links == null || links.Count <= 0)
            {
                return 0;
            }
            else
            {
                //Loop through all of the links on the site
                foreach (HtmlNode link in links)
                {
                    if (string.IsNullOrEmpty(link.Attributes["href"].Value)) continue;
                    if (link.Attributes["href"].Value[0] == '#') continue;
                    if (link.Attributes["href"].Value[0] != 'h')
                    {
                        try
                        {
                            collectedLinks.Add(new Uri(new Uri(nextAddress), link.Attributes["href"].Value).AbsoluteUri.Trim());
                        }
                        catch { }
                    }
                    else if (link.Attributes["href"].Value[0] == 'h')
                    {
                        collectedLinks.Add(link.Attributes["href"].Value.Trim());
                    }
                }
                GUI.Print("INFO: Processed " + nextAddress);
                _main.Invoke((Action)(() => { _main.progressBar1.Value++; }));
                fileNumber++;
                return fileNumber;
            }
        }

        private static void FixEOF(ref int currentFileNumber, out FileStream primary, out StreamReader primaryr, ref int i)
        {
            GUI.Print("INFO: EOF detected, moving to next file");
            currentFileNumber++;
            primary = new FileStream(_main.folderBrowserDialog1.SelectedPath + "\\" + Convert.ToString(currentFileNumber) + ".txt", FileMode.Open, FileAccess.Read);
            primaryr = new StreamReader(primary);
            i--;
        }

        private static StreamWriter WriteCollectedLinksToFile(int fileNumber, List<string> collectedLinks)
        {
            StreamWriter primaryw = new(_main.folderBrowserDialog1.SelectedPath + "\\" + Convert.ToString(fileNumber) + ".txt");
            foreach (string line in collectedLinks)
            {
                primaryw.WriteLine(line);
            }
            primaryw.Flush();
            primaryw.Close();
            return primaryw;
        }

        private static void ConsolidateCollectedLinks()
        {
            string[] outputFilePaths = Directory.GetFiles(_main.folderBrowserDialog1.SelectedPath);
            string ConsolidatedPath = _main.folderBrowserDialog1.SelectedPath + "Consolidated.txt";
            string ConsolidatedNoDuplicatesPath = _main.folderBrowserDialog1.SelectedPath + "HashConsolidated.txt";
            StreamWriter consolidatedStream = new(new FileStream(ConsolidatedPath, FileMode.OpenOrCreate, FileAccess.Write));
            foreach (string filePath in outputFilePaths)
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    consolidatedStream.WriteLine(line);
                }
                consolidatedStream.Flush();
            }
            consolidatedStream.Close();
            RemoveDuplicates(ConsolidatedPath, ConsolidatedNoDuplicatesPath);
        }

        private static void RemoveDuplicates(string OriginalFile, string NewFile)
        {
            if (OriginalFile.Equals(NewFile))
            {
                throw new ArgumentException("The original file and the new file cannot be the same.");
            }
            if (_main.RemoveDuplicates.Checked)
            {
                GUI.Print("INFO: Finished consolidating links");
                GUI.Print("INFO: Removing duplicates");
                Dictionary<int, string> SeivedLinks = new();
                StreamReader consolidatedReader = new(OriginalFile);
                while (!consolidatedReader.EndOfStream)
                {
                    string nextLine = consolidatedReader.ReadLine();
                    int nextHash = nextLine.GetHashCode();
                    if (!SeivedLinks.ContainsKey(nextHash))
                    {
                        SeivedLinks.Add(nextHash, nextLine);
                    }
                }
                GUI.Print("Breakpoint");
                File.WriteAllLines(NewFile, SeivedLinks.Values);
                GUI.Print("INFO: Completed");
            }
        }
    }
}