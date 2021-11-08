
namespace CSVersion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrimaryTabControl = new System.Windows.Forms.TabControl();
            this.WebCrawlerTab = new System.Windows.Forms.TabPage();
            this.ConsoleOutputBox = new System.Windows.Forms.RichTextBox();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.ProcessedLabel = new System.Windows.Forms.Label();
            this.ETALabel = new System.Windows.Forms.Label();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.RemoveDuplicates = new System.Windows.Forms.CheckBox();
            this.ConsolidateFiles = new System.Windows.Forms.CheckBox();
            this.SettingsProcessLinksLabel = new System.Windows.Forms.Label();
            this.SettingsProcessLinksUpDown = new System.Windows.Forms.NumericUpDown();
            this.SettingsOutputFolderButton = new System.Windows.Forms.Button();
            this.SettingsOutputFolderLabel = new System.Windows.Forms.Label();
            this.SettingsSourceUrlTextBox = new System.Windows.Forms.TextBox();
            this.SettingsSourceUrlLabel = new System.Windows.Forms.Label();
            this.CreditsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PrimaryTabControl.SuspendLayout();
            this.WebCrawlerTab.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsProcessLinksUpDown)).BeginInit();
            this.CreditsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryTabControl
            // 
            this.PrimaryTabControl.Controls.Add(this.WebCrawlerTab);
            this.PrimaryTabControl.Controls.Add(this.SettingsTab);
            this.PrimaryTabControl.Controls.Add(this.CreditsTab);
            this.PrimaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.PrimaryTabControl.Multiline = true;
            this.PrimaryTabControl.Name = "PrimaryTabControl";
            this.PrimaryTabControl.SelectedIndex = 0;
            this.PrimaryTabControl.Size = new System.Drawing.Size(1292, 790);
            this.PrimaryTabControl.TabIndex = 0;
            // 
            // WebCrawlerTab
            // 
            this.WebCrawlerTab.Controls.Add(this.ConsoleOutputBox);
            this.WebCrawlerTab.Controls.Add(this.DetailsGroupBox);
            this.WebCrawlerTab.Controls.Add(this.progressBar1);
            this.WebCrawlerTab.Location = new System.Drawing.Point(4, 34);
            this.WebCrawlerTab.Name = "WebCrawlerTab";
            this.WebCrawlerTab.Padding = new System.Windows.Forms.Padding(3);
            this.WebCrawlerTab.Size = new System.Drawing.Size(1284, 752);
            this.WebCrawlerTab.TabIndex = 0;
            this.WebCrawlerTab.Text = "Web Crawler";
            this.WebCrawlerTab.UseVisualStyleBackColor = true;
            // 
            // ConsoleOutputBox
            // 
            this.ConsoleOutputBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.ConsoleOutputBox.DetectUrls = false;
            this.ConsoleOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleOutputBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleOutputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsoleOutputBox.Location = new System.Drawing.Point(3, 37);
            this.ConsoleOutputBox.Name = "ConsoleOutputBox";
            this.ConsoleOutputBox.ReadOnly = true;
            this.ConsoleOutputBox.Size = new System.Drawing.Size(978, 712);
            this.ConsoleOutputBox.TabIndex = 2;
            this.ConsoleOutputBox.Text = "Welcome!";
            this.ConsoleOutputBox.WordWrap = false;
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.SpeedLabel);
            this.DetailsGroupBox.Controls.Add(this.LeftLabel);
            this.DetailsGroupBox.Controls.Add(this.ProcessedLabel);
            this.DetailsGroupBox.Controls.Add(this.ETALabel);
            this.DetailsGroupBox.Controls.Add(this.ElapsedTimeLabel);
            this.DetailsGroupBox.Controls.Add(this.RunButton);
            this.DetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailsGroupBox.Location = new System.Drawing.Point(981, 37);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(300, 712);
            this.DetailsGroupBox.TabIndex = 4;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Details";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(8, 142);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(66, 25);
            this.SpeedLabel.TabIndex = 8;
            this.SpeedLabel.Text = "Speed:";
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(8, 114);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(111, 25);
            this.LeftLabel.TabIndex = 7;
            this.LeftLabel.Text = "Amount left:";
            // 
            // ProcessedLabel
            // 
            this.ProcessedLabel.AutoSize = true;
            this.ProcessedLabel.Location = new System.Drawing.Point(8, 86);
            this.ProcessedLabel.Name = "ProcessedLabel";
            this.ProcessedLabel.Size = new System.Drawing.Size(167, 25);
            this.ProcessedLabel.TabIndex = 6;
            this.ProcessedLabel.Text = "Amount processed:";
            // 
            // ETALabel
            // 
            this.ETALabel.AutoSize = true;
            this.ETALabel.Location = new System.Drawing.Point(8, 56);
            this.ETALabel.Name = "ETALabel";
            this.ETALabel.Size = new System.Drawing.Size(164, 25);
            this.ETALabel.TabIndex = 5;
            this.ETALabel.Text = "Estimated time left:";
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(6, 27);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(117, 25);
            this.ElapsedTimeLabel.TabIndex = 4;
            this.ElapsedTimeLabel.Text = "Elapsed time:";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(3, 656);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(294, 50);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1278, 34);
            this.progressBar1.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.RemoveDuplicates);
            this.SettingsTab.Controls.Add(this.ConsolidateFiles);
            this.SettingsTab.Controls.Add(this.SettingsProcessLinksLabel);
            this.SettingsTab.Controls.Add(this.SettingsProcessLinksUpDown);
            this.SettingsTab.Controls.Add(this.SettingsOutputFolderButton);
            this.SettingsTab.Controls.Add(this.SettingsOutputFolderLabel);
            this.SettingsTab.Controls.Add(this.SettingsSourceUrlTextBox);
            this.SettingsTab.Controls.Add(this.SettingsSourceUrlLabel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 34);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(1284, 752);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // RemoveDuplicates
            // 
            this.RemoveDuplicates.AutoSize = true;
            this.RemoveDuplicates.Location = new System.Drawing.Point(9, 156);
            this.RemoveDuplicates.Name = "RemoveDuplicates";
            this.RemoveDuplicates.Size = new System.Drawing.Size(500, 29);
            this.RemoveDuplicates.TabIndex = 8;
            this.RemoveDuplicates.Text = "Remove duplicates from consolidated file (will take longer)";
            this.RemoveDuplicates.UseVisualStyleBackColor = true;
            // 
            // ConsolidateFiles
            // 
            this.ConsolidateFiles.AutoSize = true;
            this.ConsolidateFiles.Checked = true;
            this.ConsolidateFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConsolidateFiles.Location = new System.Drawing.Point(9, 122);
            this.ConsolidateFiles.Name = "ConsolidateFiles";
            this.ConsolidateFiles.Size = new System.Drawing.Size(340, 29);
            this.ConsolidateFiles.TabIndex = 7;
            this.ConsolidateFiles.Text = "Consolidate output files after finishing";
            this.ConsolidateFiles.UseVisualStyleBackColor = true;
            this.ConsolidateFiles.CheckedChanged += new System.EventHandler(this.ConsolidateFiles_CheckedChanged);
            // 
            // SettingsProcessLinksLabel
            // 
            this.SettingsProcessLinksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsProcessLinksLabel.AutoSize = true;
            this.SettingsProcessLinksLabel.Location = new System.Drawing.Point(9, 82);
            this.SettingsProcessLinksLabel.Name = "SettingsProcessLinksLabel";
            this.SettingsProcessLinksLabel.Size = new System.Drawing.Size(227, 25);
            this.SettingsProcessLinksLabel.TabIndex = 6;
            this.SettingsProcessLinksLabel.Text = "Amount of links to process";
            // 
            // SettingsProcessLinksUpDown
            // 
            this.SettingsProcessLinksUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsProcessLinksUpDown.Location = new System.Drawing.Point(242, 81);
            this.SettingsProcessLinksUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SettingsProcessLinksUpDown.Name = "SettingsProcessLinksUpDown";
            this.SettingsProcessLinksUpDown.Size = new System.Drawing.Size(1034, 31);
            this.SettingsProcessLinksUpDown.TabIndex = 5;
            // 
            // SettingsOutputFolderButton
            // 
            this.SettingsOutputFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsOutputFolderButton.Location = new System.Drawing.Point(222, 44);
            this.SettingsOutputFolderButton.Name = "SettingsOutputFolderButton";
            this.SettingsOutputFolderButton.Size = new System.Drawing.Size(1053, 32);
            this.SettingsOutputFolderButton.TabIndex = 4;
            this.SettingsOutputFolderButton.Text = "Select Folder";
            this.SettingsOutputFolderButton.UseVisualStyleBackColor = true;
            this.SettingsOutputFolderButton.Click += new System.EventHandler(this.SettingsOutputFolderButton_Click);
            // 
            // SettingsOutputFolderLabel
            // 
            this.SettingsOutputFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsOutputFolderLabel.AutoSize = true;
            this.SettingsOutputFolderLabel.Location = new System.Drawing.Point(9, 46);
            this.SettingsOutputFolderLabel.Name = "SettingsOutputFolderLabel";
            this.SettingsOutputFolderLabel.Size = new System.Drawing.Size(207, 25);
            this.SettingsOutputFolderLabel.TabIndex = 3;
            this.SettingsOutputFolderLabel.Text = "Folder to store output in";
            // 
            // SettingsSourceUrlTextBox
            // 
            this.SettingsSourceUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsSourceUrlTextBox.Location = new System.Drawing.Point(106, 6);
            this.SettingsSourceUrlTextBox.Name = "SettingsSourceUrlTextBox";
            this.SettingsSourceUrlTextBox.Size = new System.Drawing.Size(1170, 31);
            this.SettingsSourceUrlTextBox.TabIndex = 1;
            this.SettingsSourceUrlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SettingsSourceUrlLabel
            // 
            this.SettingsSourceUrlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsSourceUrlLabel.AutoSize = true;
            this.SettingsSourceUrlLabel.Location = new System.Drawing.Point(9, 9);
            this.SettingsSourceUrlLabel.Name = "SettingsSourceUrlLabel";
            this.SettingsSourceUrlLabel.Size = new System.Drawing.Size(91, 25);
            this.SettingsSourceUrlLabel.TabIndex = 0;
            this.SettingsSourceUrlLabel.Text = "Source url";
            // 
            // CreditsTab
            // 
            this.CreditsTab.Controls.Add(this.groupBox1);
            this.CreditsTab.Location = new System.Drawing.Point(4, 34);
            this.CreditsTab.Name = "CreditsTab";
            this.CreditsTab.Size = new System.Drawing.Size(1284, 752);
            this.CreditsTab.TabIndex = 2;
            this.CreditsTab.Text = "Credits";
            this.CreditsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 752);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary developers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leland Payne Kilborn\r\n    Founder. Started program on 11/2/21";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1292, 790);
            this.Controls.Add(this.PrimaryTabControl);
            this.Name = "Form1";
            this.Text = "Spidio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PrimaryTabControl.ResumeLayout(false);
            this.WebCrawlerTab.ResumeLayout(false);
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsProcessLinksUpDown)).EndInit();
            this.CreditsTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox ConsoleOutputBox;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.TabControl PrimaryTabControl;
        public System.Windows.Forms.TabPage WebCrawlerTab;
        public System.Windows.Forms.TabPage SettingsTab;
        public System.Windows.Forms.TabPage CreditsTab;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox SettingsSourceUrlTextBox;
        public System.Windows.Forms.Label SettingsSourceUrlLabel;
        public System.Windows.Forms.Button SettingsOutputFolderButton;
        public System.Windows.Forms.Label SettingsOutputFolderLabel;
        public System.Windows.Forms.Label SettingsProcessLinksLabel;
        public System.Windows.Forms.NumericUpDown SettingsProcessLinksUpDown;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        public System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.Label LeftLabel;
        public System.Windows.Forms.Label ProcessedLabel;
        public System.Windows.Forms.Label ETALabel;
        public System.Windows.Forms.Label ElapsedTimeLabel;
        public System.Windows.Forms.CheckBox RemoveDuplicates;
        public System.Windows.Forms.CheckBox ConsolidateFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

