﻿namespace T_Backup_2._0
{
	partial class mainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.logoBox = new System.Windows.Forms.PictureBox();
			this.creditLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.settingsGroupBox = new System.Windows.Forms.GroupBox();
			this.maxBackupsCounter = new System.Windows.Forms.NumericUpDown();
			this.openBackupFolderButton = new System.Windows.Forms.Button();
			this.openSavesFolderButton = new System.Windows.Forms.Button();
			this.openFilesFolderButton = new System.Windows.Forms.Button();
			this.backupMax = new System.Windows.Forms.Label();
			this.backupPathTextBox = new System.Windows.Forms.TextBox();
			this.backupFolderPathLabel = new System.Windows.Forms.Label();
			this.savesPathTextBox = new System.Windows.Forms.TextBox();
			this.filesPathTextBox = new System.Windows.Forms.TextBox();
			this.filesPathLabel = new System.Windows.Forms.Label();
			this.savesPathLabel = new System.Windows.Forms.Label();
			this.tooltips = new System.Windows.Forms.ToolTip(this.components);
			this.backupDataChkBox = new System.Windows.Forms.CheckBox();
			this.runOnStartupChkBox = new System.Windows.Forms.CheckBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.backupGroupBox = new System.Windows.Forms.GroupBox();
			this.openBackupButton = new System.Windows.Forms.Button();
			this.backupButton = new System.Windows.Forms.Button();
			this.backupCapturesChkBox = new System.Windows.Forms.CheckBox();
			this.backupFilesChkBox = new System.Windows.Forms.CheckBox();
			this.backupPlayersChkBox = new System.Windows.Forms.CheckBox();
			this.backupWorldsChkBox = new System.Windows.Forms.CheckBox();
			this.restoreGroupBox = new System.Windows.Forms.GroupBox();
			this.openRestorePathFolderButton = new System.Windows.Forms.Button();
			this.restoreButton = new System.Windows.Forms.Button();
			this.restorePathTextBox = new System.Windows.Forms.TextBox();
			this.restoreLabel = new System.Windows.Forms.Label();
			this.profileButton = new System.Windows.Forms.Button();
			this.fluffLabel = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
			this.settingsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxBackupsCounter)).BeginInit();
			this.backupGroupBox.SuspendLayout();
			this.restoreGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoBox
			// 
			this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
			this.logoBox.InitialImage = null;
			this.logoBox.Location = new System.Drawing.Point(12, 4);
			this.logoBox.Name = "logoBox";
			this.logoBox.Size = new System.Drawing.Size(252, 81);
			this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.logoBox.TabIndex = 0;
			this.logoBox.TabStop = false;
			// 
			// creditLabel
			// 
			this.creditLabel.AutoSize = true;
			this.creditLabel.BackColor = System.Drawing.Color.Transparent;
			this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creditLabel.Location = new System.Drawing.Point(24, 101);
			this.creditLabel.Name = "creditLabel";
			this.creditLabel.Size = new System.Drawing.Size(131, 13);
			this.creditLabel.TabIndex = 2;
			this.creditLabel.Text = "Sam Poirier AKA darthmorf";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.copyrightLabel.Location = new System.Drawing.Point(9, 98);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(19, 18);
			this.copyrightLabel.TabIndex = 3;
			this.copyrightLabel.Text = "©";
			// 
			// settingsGroupBox
			// 
			this.settingsGroupBox.Controls.Add(this.maxBackupsCounter);
			this.settingsGroupBox.Controls.Add(this.openBackupFolderButton);
			this.settingsGroupBox.Controls.Add(this.openSavesFolderButton);
			this.settingsGroupBox.Controls.Add(this.openFilesFolderButton);
			this.settingsGroupBox.Controls.Add(this.backupMax);
			this.settingsGroupBox.Controls.Add(this.backupPathTextBox);
			this.settingsGroupBox.Controls.Add(this.backupFolderPathLabel);
			this.settingsGroupBox.Controls.Add(this.savesPathTextBox);
			this.settingsGroupBox.Controls.Add(this.filesPathTextBox);
			this.settingsGroupBox.Controls.Add(this.filesPathLabel);
			this.settingsGroupBox.Controls.Add(this.savesPathLabel);
			this.settingsGroupBox.Location = new System.Drawing.Point(12, 121);
			this.settingsGroupBox.Name = "settingsGroupBox";
			this.settingsGroupBox.Size = new System.Drawing.Size(252, 219);
			this.settingsGroupBox.TabIndex = 4;
			this.settingsGroupBox.TabStop = false;
			// 
			// maxBackupsCounter
			// 
			this.maxBackupsCounter.Location = new System.Drawing.Point(9, 183);
			this.maxBackupsCounter.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.maxBackupsCounter.Name = "maxBackupsCounter";
			this.maxBackupsCounter.Size = new System.Drawing.Size(237, 20);
			this.maxBackupsCounter.TabIndex = 11;
			this.maxBackupsCounter.ValueChanged += new System.EventHandler(this.maxBackupsCounter_ValueChanged);
			// 
			// openBackupFolderButton
			// 
			this.openBackupFolderButton.Location = new System.Drawing.Point(219, 135);
			this.openBackupFolderButton.Name = "openBackupFolderButton";
			this.openBackupFolderButton.Size = new System.Drawing.Size(29, 20);
			this.openBackupFolderButton.TabIndex = 12;
			this.openBackupFolderButton.Text = "...";
			this.openBackupFolderButton.UseVisualStyleBackColor = true;
			this.openBackupFolderButton.Click += new System.EventHandler(this.openBackupFolderButton_Click);
			// 
			// openSavesFolderButton
			// 
			this.openSavesFolderButton.Location = new System.Drawing.Point(219, 83);
			this.openSavesFolderButton.Name = "openSavesFolderButton";
			this.openSavesFolderButton.Size = new System.Drawing.Size(29, 20);
			this.openSavesFolderButton.TabIndex = 11;
			this.openSavesFolderButton.Text = "...";
			this.openSavesFolderButton.UseVisualStyleBackColor = true;
			this.openSavesFolderButton.Click += new System.EventHandler(this.openSavesFolderButton_Click);
			// 
			// openFilesFolderButton
			// 
			this.openFilesFolderButton.Location = new System.Drawing.Point(218, 32);
			this.openFilesFolderButton.Name = "openFilesFolderButton";
			this.openFilesFolderButton.Size = new System.Drawing.Size(29, 20);
			this.openFilesFolderButton.TabIndex = 7;
			this.openFilesFolderButton.Text = "...";
			this.openFilesFolderButton.UseVisualStyleBackColor = true;
			this.openFilesFolderButton.Click += new System.EventHandler(this.openFilesFolderButton_Click);
			// 
			// backupMax
			// 
			this.backupMax.AutoSize = true;
			this.backupMax.Location = new System.Drawing.Point(6, 167);
			this.backupMax.Name = "backupMax";
			this.backupMax.Size = new System.Drawing.Size(99, 13);
			this.backupMax.TabIndex = 7;
			this.backupMax.Text = "Maximum Backups:";
			this.tooltips.SetToolTip(this.backupMax, "The amount of backups to keep before the old ones are deleted - Set to 0 for neve" +
        "r");
			// 
			// backupPathTextBox
			// 
			this.backupPathTextBox.Location = new System.Drawing.Point(9, 135);
			this.backupPathTextBox.Name = "backupPathTextBox";
			this.backupPathTextBox.Size = new System.Drawing.Size(208, 20);
			this.backupPathTextBox.TabIndex = 9;
			this.backupPathTextBox.TextChanged += new System.EventHandler(this.backupPathTextBox_TextChanged);
			// 
			// backupFolderPathLabel
			// 
			this.backupFolderPathLabel.AutoSize = true;
			this.backupFolderPathLabel.Location = new System.Drawing.Point(7, 119);
			this.backupFolderPathLabel.Name = "backupFolderPathLabel";
			this.backupFolderPathLabel.Size = new System.Drawing.Size(103, 13);
			this.backupFolderPathLabel.TabIndex = 6;
			this.backupFolderPathLabel.Text = "Folder to Backup to:";
			this.tooltips.SetToolTip(this.backupFolderPathLabel, "Folder to save backups to");
			// 
			// savesPathTextBox
			// 
			this.savesPathTextBox.Location = new System.Drawing.Point(10, 83);
			this.savesPathTextBox.Name = "savesPathTextBox";
			this.savesPathTextBox.Size = new System.Drawing.Size(207, 20);
			this.savesPathTextBox.TabIndex = 8;
			this.savesPathTextBox.TextChanged += new System.EventHandler(this.savesPathTextBox_TextChanged);
			// 
			// filesPathTextBox
			// 
			this.filesPathTextBox.Location = new System.Drawing.Point(9, 32);
			this.filesPathTextBox.Name = "filesPathTextBox";
			this.filesPathTextBox.Size = new System.Drawing.Size(208, 20);
			this.filesPathTextBox.TabIndex = 8;
			this.filesPathTextBox.TextChanged += new System.EventHandler(this.filesPathTextBox_TextChanged);
			// 
			// filesPathLabel
			// 
			this.filesPathLabel.AutoSize = true;
			this.filesPathLabel.Location = new System.Drawing.Point(6, 16);
			this.filesPathLabel.Name = "filesPathLabel";
			this.filesPathLabel.Size = new System.Drawing.Size(137, 13);
			this.filesPathLabel.TabIndex = 0;
			this.filesPathLabel.Text = "Terraria Program Files Path:";
			this.tooltips.SetToolTip(this.filesPathLabel, "Path to the Terraria program files");
			// 
			// savesPathLabel
			// 
			this.savesPathLabel.AutoSize = true;
			this.savesPathLabel.Location = new System.Drawing.Point(6, 67);
			this.savesPathLabel.Name = "savesPathLabel";
			this.savesPathLabel.Size = new System.Drawing.Size(104, 13);
			this.savesPathLabel.TabIndex = 5;
			this.savesPathLabel.Text = "Terraria Saves Path:";
			this.tooltips.SetToolTip(this.savesPathLabel, "Path to the Terraria saves folder");
			// 
			// tooltips
			// 
			this.tooltips.AutoPopDelay = 0;
			this.tooltips.InitialDelay = 500;
			this.tooltips.ReshowDelay = 100;
			// 
			// backupDataChkBox
			// 
			this.backupDataChkBox.AutoSize = true;
			this.backupDataChkBox.Location = new System.Drawing.Point(6, 111);
			this.backupDataChkBox.Name = "backupDataChkBox";
			this.backupDataChkBox.Size = new System.Drawing.Size(153, 17);
			this.backupDataChkBox.TabIndex = 7;
			this.backupDataChkBox.Text = "Backup Misc Terraria Data";
			this.tooltips.SetToolTip(this.backupDataChkBox, "This includes \'achievments.dat\', \'config.json\', \'favourites.json\', \'input profile" +
        "s.json\' & \'servers.dat\'");
			this.backupDataChkBox.UseVisualStyleBackColor = true;
			this.backupDataChkBox.CheckedChanged += new System.EventHandler(this.backupDataChkBox_CheckedChanged);
			// 
			// runOnStartupChkBox
			// 
			this.runOnStartupChkBox.AutoSize = true;
			this.runOnStartupChkBox.Location = new System.Drawing.Point(6, 192);
			this.runOnStartupChkBox.Name = "runOnStartupChkBox";
			this.runOnStartupChkBox.Size = new System.Drawing.Size(143, 17);
			this.runOnStartupChkBox.TabIndex = 8;
			this.runOnStartupChkBox.Text = "Run on Terraria Startup?";
			this.tooltips.SetToolTip(this.runOnStartupChkBox, "Requires a PC restart to take effect");
			this.runOnStartupChkBox.UseVisualStyleBackColor = true;
			this.runOnStartupChkBox.CheckedChanged += new System.EventHandler(this.runOnStartupChkBox_CheckedChanged);
			// 
			// saveButton
			// 
			this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
			this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.saveButton.Location = new System.Drawing.Point(270, 3);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(25, 23);
			this.saveButton.TabIndex = 11;
			this.tooltips.SetToolTip(this.saveButton, "Saves all loaded profiles");
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// backupGroupBox
			// 
			this.backupGroupBox.Controls.Add(this.runOnStartupChkBox);
			this.backupGroupBox.Controls.Add(this.openBackupButton);
			this.backupGroupBox.Controls.Add(this.backupButton);
			this.backupGroupBox.Controls.Add(this.backupDataChkBox);
			this.backupGroupBox.Controls.Add(this.backupCapturesChkBox);
			this.backupGroupBox.Controls.Add(this.backupFilesChkBox);
			this.backupGroupBox.Controls.Add(this.backupPlayersChkBox);
			this.backupGroupBox.Controls.Add(this.backupWorldsChkBox);
			this.backupGroupBox.Location = new System.Drawing.Point(270, 26);
			this.backupGroupBox.Name = "backupGroupBox";
			this.backupGroupBox.Size = new System.Drawing.Size(165, 214);
			this.backupGroupBox.TabIndex = 6;
			this.backupGroupBox.TabStop = false;
			// 
			// openBackupButton
			// 
			this.openBackupButton.Location = new System.Drawing.Point(6, 163);
			this.openBackupButton.Name = "openBackupButton";
			this.openBackupButton.Size = new System.Drawing.Size(153, 23);
			this.openBackupButton.TabIndex = 7;
			this.openBackupButton.Text = "Open Backup Location";
			this.openBackupButton.UseVisualStyleBackColor = true;
			// 
			// backupButton
			// 
			this.backupButton.Location = new System.Drawing.Point(6, 134);
			this.backupButton.Name = "backupButton";
			this.backupButton.Size = new System.Drawing.Size(153, 23);
			this.backupButton.TabIndex = 7;
			this.backupButton.Text = "Backup";
			this.backupButton.UseVisualStyleBackColor = true;
			// 
			// backupCapturesChkBox
			// 
			this.backupCapturesChkBox.AutoSize = true;
			this.backupCapturesChkBox.Location = new System.Drawing.Point(6, 88);
			this.backupCapturesChkBox.Name = "backupCapturesChkBox";
			this.backupCapturesChkBox.Size = new System.Drawing.Size(108, 17);
			this.backupCapturesChkBox.TabIndex = 7;
			this.backupCapturesChkBox.Text = "Backup Captures";
			this.backupCapturesChkBox.UseVisualStyleBackColor = true;
			this.backupCapturesChkBox.CheckedChanged += new System.EventHandler(this.backupCapturesChkBox_CheckedChanged);
			// 
			// backupFilesChkBox
			// 
			this.backupFilesChkBox.AutoSize = true;
			this.backupFilesChkBox.Location = new System.Drawing.Point(6, 65);
			this.backupFilesChkBox.Name = "backupFilesChkBox";
			this.backupFilesChkBox.Size = new System.Drawing.Size(126, 17);
			this.backupFilesChkBox.TabIndex = 7;
			this.backupFilesChkBox.Text = "Backup Terraria Files";
			this.backupFilesChkBox.UseVisualStyleBackColor = true;
			this.backupFilesChkBox.CheckedChanged += new System.EventHandler(this.backupFilesChkBox_CheckedChanged);
			// 
			// backupPlayersChkBox
			// 
			this.backupPlayersChkBox.AutoSize = true;
			this.backupPlayersChkBox.Location = new System.Drawing.Point(6, 42);
			this.backupPlayersChkBox.Name = "backupPlayersChkBox";
			this.backupPlayersChkBox.Size = new System.Drawing.Size(100, 17);
			this.backupPlayersChkBox.TabIndex = 7;
			this.backupPlayersChkBox.Text = "Backup Players";
			this.backupPlayersChkBox.UseVisualStyleBackColor = true;
			this.backupPlayersChkBox.CheckedChanged += new System.EventHandler(this.backupPlayersChkBox_CheckedChanged);
			// 
			// backupWorldsChkBox
			// 
			this.backupWorldsChkBox.AutoSize = true;
			this.backupWorldsChkBox.Location = new System.Drawing.Point(6, 19);
			this.backupWorldsChkBox.Name = "backupWorldsChkBox";
			this.backupWorldsChkBox.Size = new System.Drawing.Size(99, 17);
			this.backupWorldsChkBox.TabIndex = 0;
			this.backupWorldsChkBox.Text = "Backup Worlds";
			this.backupWorldsChkBox.UseVisualStyleBackColor = true;
			this.backupWorldsChkBox.CheckedChanged += new System.EventHandler(this.backupWorldsChkBox_CheckedChanged);
			// 
			// restoreGroupBox
			// 
			this.restoreGroupBox.Controls.Add(this.openRestorePathFolderButton);
			this.restoreGroupBox.Controls.Add(this.restoreButton);
			this.restoreGroupBox.Controls.Add(this.restorePathTextBox);
			this.restoreGroupBox.Controls.Add(this.restoreLabel);
			this.restoreGroupBox.Location = new System.Drawing.Point(270, 239);
			this.restoreGroupBox.Name = "restoreGroupBox";
			this.restoreGroupBox.Size = new System.Drawing.Size(165, 101);
			this.restoreGroupBox.TabIndex = 7;
			this.restoreGroupBox.TabStop = false;
			// 
			// openRestorePathFolderButton
			// 
			this.openRestorePathFolderButton.Location = new System.Drawing.Point(130, 32);
			this.openRestorePathFolderButton.Name = "openRestorePathFolderButton";
			this.openRestorePathFolderButton.Size = new System.Drawing.Size(29, 20);
			this.openRestorePathFolderButton.TabIndex = 13;
			this.openRestorePathFolderButton.Text = "...";
			this.openRestorePathFolderButton.UseVisualStyleBackColor = true;
			this.openRestorePathFolderButton.Click += new System.EventHandler(this.openRestorePathFolderButton_Click);
			// 
			// restoreButton
			// 
			this.restoreButton.Location = new System.Drawing.Point(6, 62);
			this.restoreButton.Name = "restoreButton";
			this.restoreButton.Size = new System.Drawing.Size(153, 23);
			this.restoreButton.TabIndex = 2;
			this.restoreButton.Text = "Restore Backup";
			this.restoreButton.UseVisualStyleBackColor = true;
			// 
			// restorePathTextBox
			// 
			this.restorePathTextBox.Location = new System.Drawing.Point(5, 32);
			this.restorePathTextBox.Name = "restorePathTextBox";
			this.restorePathTextBox.Size = new System.Drawing.Size(122, 20);
			this.restorePathTextBox.TabIndex = 1;
			this.restorePathTextBox.TextChanged += new System.EventHandler(this.restorePathTextBox_TextChanged);
			// 
			// restoreLabel
			// 
			this.restoreLabel.AutoSize = true;
			this.restoreLabel.Location = new System.Drawing.Point(3, 16);
			this.restoreLabel.Name = "restoreLabel";
			this.restoreLabel.Size = new System.Drawing.Size(99, 13);
			this.restoreLabel.TabIndex = 0;
			this.restoreLabel.Text = "Backup to Restore:";
			// 
			// profileButton
			// 
			this.profileButton.Location = new System.Drawing.Point(301, 3);
			this.profileButton.Name = "profileButton";
			this.profileButton.Size = new System.Drawing.Size(134, 23);
			this.profileButton.TabIndex = 8;
			this.profileButton.Text = "Change Profile";
			this.profileButton.UseVisualStyleBackColor = true;
			this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
			// 
			// fluffLabel
			// 
			this.fluffLabel.AutoSize = true;
			this.fluffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fluffLabel.Location = new System.Drawing.Point(12, 78);
			this.fluffLabel.Name = "fluffLabel";
			this.fluffLabel.Size = new System.Drawing.Size(203, 16);
			this.fluffLabel.TabIndex = 9;
			this.fluffLabel.Text = "A Terraria Backup utility program";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 346);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(423, 23);
			this.progressBar1.TabIndex = 10;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 379);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.fluffLabel);
			this.Controls.Add(this.profileButton);
			this.Controls.Add(this.backupGroupBox);
			this.Controls.Add(this.settingsGroupBox);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.logoBox);
			this.Controls.Add(this.creditLabel);
			this.Controls.Add(this.restoreGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "mainForm";
			this.Text = "T-Backup";
			this.Load += new System.EventHandler(this.mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
			this.settingsGroupBox.ResumeLayout(false);
			this.settingsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxBackupsCounter)).EndInit();
			this.backupGroupBox.ResumeLayout(false);
			this.backupGroupBox.PerformLayout();
			this.restoreGroupBox.ResumeLayout(false);
			this.restoreGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoBox;
		private System.Windows.Forms.Label creditLabel;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.Label backupMax;
		private System.Windows.Forms.Label backupFolderPathLabel;
		private System.Windows.Forms.Label savesPathLabel;
		private System.Windows.Forms.Label filesPathLabel;
		private System.Windows.Forms.ToolTip tooltips;
		private System.Windows.Forms.TextBox filesPathTextBox;
		private System.Windows.Forms.TextBox savesPathTextBox;
		private System.Windows.Forms.TextBox backupPathTextBox;
		private System.Windows.Forms.GroupBox backupGroupBox;
		private System.Windows.Forms.CheckBox backupDataChkBox;
		private System.Windows.Forms.CheckBox backupCapturesChkBox;
		private System.Windows.Forms.CheckBox backupFilesChkBox;
		private System.Windows.Forms.CheckBox backupPlayersChkBox;
		private System.Windows.Forms.CheckBox backupWorldsChkBox;
		private System.Windows.Forms.Button openBackupButton;
		private System.Windows.Forms.Button backupButton;
		private System.Windows.Forms.Button openSavesFolderButton;
		private System.Windows.Forms.Button openFilesFolderButton;
		private System.Windows.Forms.GroupBox restoreGroupBox;
		private System.Windows.Forms.CheckBox runOnStartupChkBox;
		private System.Windows.Forms.Button restoreButton;
		private System.Windows.Forms.TextBox restorePathTextBox;
		private System.Windows.Forms.Label restoreLabel;
		private System.Windows.Forms.Button openBackupFolderButton;
		private System.Windows.Forms.Button openRestorePathFolderButton;
		private System.Windows.Forms.Button profileButton;
		private System.Windows.Forms.Label fluffLabel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.NumericUpDown maxBackupsCounter;
		private System.Windows.Forms.Button saveButton;
	}
}

