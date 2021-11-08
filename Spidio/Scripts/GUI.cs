using System;
using System.Diagnostics;

namespace CSVersion
{
    internal static class GUI
    {
        private static readonly Form1 _main = Program._main;

        public static void UpdateDetailsPanel(int i, Stopwatch ElapsedTime, DateTime StartTime)
        {
            Program._main.Invoke((Action)(() =>
            {
                _main.ElapsedTimeLabel.Text = "Elapsed time: " + string.Format("{0:00}:{1:00}:{2:00}", ElapsedTime.Elapsed.Hours, ElapsedTime.Elapsed.Minutes, ElapsedTime.Elapsed.Seconds);
                int secondsLeft = (int)((DateTime.Now - StartTime).TotalSeconds / (i + 1) * (double)(_main.SettingsProcessLinksUpDown.Value - i));
                _main.ETALabel.Text = "Estimated time left: " + string.Format("{0:00}:{1:00}:{2:00}", ((secondsLeft) / 60) / 60, (secondsLeft / 60) % 60, secondsLeft % 360 % 60);
                _main.ProcessedLabel.Text = "Amount processed: " + (i + 1).ToString();
                _main.LeftLabel.Text = "Amount left: " + ((int)_main.SettingsProcessLinksUpDown.Value - i - 1).ToString();
                _main.SpeedLabel.Text = "";
            }));
        }

        public static void Print(string text)
        {
            Program._main.Invoke((Action)(() =>
            {
                Program._main.ConsoleOutputBox.AppendText(System.Environment.NewLine + text);
                Program._main.ConsoleOutputBox.SelectionStart = Program._main.ConsoleOutputBox.Text.Length;
                Program._main.ConsoleOutputBox.ScrollToCaret();
            }));
        }

        public static void ChangeRunButton(string text)
        {
            Program._main.Invoke((Action)(() => { Program._main.RunButton.Text = text; }));
        }
    }
}