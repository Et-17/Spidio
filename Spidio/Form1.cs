using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace CSVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void SettingsSelectFolderButton_Click(object sender, EventArgs e)
        //{
        //    folderBrowserDialog1.ShowDialog();
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            RunButton.Enabled = false;
            foreach (Control setting in SettingsTab.Controls)
            {
                setting.Enabled = false;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void SettingsOutputFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void ConsolidateFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (ConsolidateFiles.Checked) RemoveDuplicates.Enabled = true;
            else RemoveDuplicates.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.Run();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GUI.Print("Done!");
            GUI.ChangeRunButton("Run");
            foreach (Control setting in SettingsTab.Controls)
            {
                setting.Enabled = true;
            }
            RunButton.Enabled = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}