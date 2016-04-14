namespace T_Backup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BackupWorldsButton = new System.Windows.Forms.Button();
            this.BackupPlayersButton = new System.Windows.Forms.Button();
            this.BackupBothButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BackupFilesButton = new System.Windows.Forms.Button();
            this.LaunchTerrariaButton = new System.Windows.Forms.Button();
            this.BackupToPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TFilesPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TexepathBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NobackupsBox = new System.Windows.Forms.TextBox();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentProfileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackupWorldsButton
            // 
            this.BackupWorldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackupWorldsButton.Location = new System.Drawing.Point(12, 265);
            this.BackupWorldsButton.Name = "BackupWorldsButton";
            this.BackupWorldsButton.Size = new System.Drawing.Size(83, 68);
            this.BackupWorldsButton.TabIndex = 4;
            this.BackupWorldsButton.Text = "Backup Worlds";
            this.BackupWorldsButton.UseVisualStyleBackColor = true;
            this.BackupWorldsButton.Click += new System.EventHandler(this.BackupWorldsButton_Click);
            // 
            // BackupPlayersButton
            // 
            this.BackupPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackupPlayersButton.Location = new System.Drawing.Point(101, 265);
            this.BackupPlayersButton.Name = "BackupPlayersButton";
            this.BackupPlayersButton.Size = new System.Drawing.Size(83, 68);
            this.BackupPlayersButton.TabIndex = 5;
            this.BackupPlayersButton.Text = "Backup Players";
            this.BackupPlayersButton.UseVisualStyleBackColor = true;
            this.BackupPlayersButton.Click += new System.EventHandler(this.BackupPlayersButton_Click);
            // 
            // BackupBothButton
            // 
            this.BackupBothButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackupBothButton.Location = new System.Drawing.Point(190, 265);
            this.BackupBothButton.Name = "BackupBothButton";
            this.BackupBothButton.Size = new System.Drawing.Size(83, 68);
            this.BackupBothButton.TabIndex = 6;
            this.BackupBothButton.Text = "Backup Both";
            this.BackupBothButton.UseVisualStyleBackColor = true;
            this.BackupBothButton.Click += new System.EventHandler(this.BackupBothButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andy MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Written by Sam Poirer (darthmorf)";
            // 
            // BackupFilesButton
            // 
            this.BackupFilesButton.Location = new System.Drawing.Point(11, 364);
            this.BackupFilesButton.Name = "BackupFilesButton";
            this.BackupFilesButton.Size = new System.Drawing.Size(262, 23);
            this.BackupFilesButton.TabIndex = 14;
            this.BackupFilesButton.Text = "Open backup location";
            this.BackupFilesButton.UseVisualStyleBackColor = true;
            this.BackupFilesButton.Click += new System.EventHandler(this.BackupFilesButton_Click);
            // 
            // LaunchTerrariaButton
            // 
            this.LaunchTerrariaButton.Font = new System.Drawing.Font("Andy MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchTerrariaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LaunchTerrariaButton.Location = new System.Drawing.Point(12, 393);
            this.LaunchTerrariaButton.Name = "LaunchTerrariaButton";
            this.LaunchTerrariaButton.Size = new System.Drawing.Size(261, 46);
            this.LaunchTerrariaButton.TabIndex = 17;
            this.LaunchTerrariaButton.Text = "Launch Terraria!";
            this.LaunchTerrariaButton.UseVisualStyleBackColor = true;
            this.LaunchTerrariaButton.Click += new System.EventHandler(this.LaunchTerrariaButton_Click);
            // 
            // BackupToPathBox
            // 
            this.BackupToPathBox.Location = new System.Drawing.Point(13, 200);
            this.BackupToPathBox.Name = "BackupToPathBox";
            this.BackupToPathBox.Size = new System.Drawing.Size(227, 20);
            this.BackupToPathBox.TabIndex = 3;
            this.BackupToPathBox.TextChanged += new System.EventHandler(this.BackupToPathBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup to path:";
            // 
            // TFilesPathBox
            // 
            this.TFilesPathBox.Location = new System.Drawing.Point(13, 161);
            this.TFilesPathBox.Name = "TFilesPathBox";
            this.TFilesPathBox.Size = new System.Drawing.Size(227, 20);
            this.TFilesPathBox.TabIndex = 1;
            this.TFilesPathBox.TextChanged += new System.EventHandler(this.TFilesPathBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terraria Files Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Terraria exe path:";
            // 
            // TexepathBox
            // 
            this.TexepathBox.Location = new System.Drawing.Point(15, 121);
            this.TexepathBox.Name = "TexepathBox";
            this.TexepathBox.Size = new System.Drawing.Size(225, 20);
            this.TexepathBox.TabIndex = 15;
            this.TexepathBox.TextChanged += new System.EventHandler(this.TexepathBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number of backups to keep";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NobackupsBox
            // 
            this.NobackupsBox.Location = new System.Drawing.Point(12, 239);
            this.NobackupsBox.Name = "NobackupsBox";
            this.NobackupsBox.Size = new System.Drawing.Size(228, 20);
            this.NobackupsBox.TabIndex = 19;
            this.NobackupsBox.TextChanged += new System.EventHandler(this.NoBackupsBox_TextChanged);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(11, 335);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(262, 23);
            this.RestoreButton.TabIndex = 20;
            this.RestoreButton.Text = "Restore Backups";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(208, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(75, 23);
            this.profileButton.TabIndex = 21;
            this.profileButton.Text = "Profiles";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Image = global::T_Backup.Properties.Resources.saveicon;
            this.SaveButton.Location = new System.Drawing.Point(246, 121);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(27, 138);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 98);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // currentProfileLabel
            // 
            this.currentProfileLabel.AutoSize = true;
            this.currentProfileLabel.Location = new System.Drawing.Point(0, 0);
            this.currentProfileLabel.Name = "currentProfileLabel";
            this.currentProfileLabel.Size = new System.Drawing.Size(118, 13);
            this.currentProfileLabel.TabIndex = 22;
            this.currentProfileLabel.Text = "Current Profile: ERROR";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 445);
            this.Controls.Add(this.currentProfileLabel);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.NobackupsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LaunchTerrariaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TexepathBox);
            this.Controls.Add(this.BackupFilesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackupBothButton);
            this.Controls.Add(this.BackupPlayersButton);
            this.Controls.Add(this.BackupWorldsButton);
            this.Controls.Add(this.BackupToPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFilesPathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "T-Backup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackupWorldsButton;
        private System.Windows.Forms.Button BackupPlayersButton;
        private System.Windows.Forms.Button BackupBothButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackupFilesButton;
        private System.Windows.Forms.Button LaunchTerrariaButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button profileButton;
        internal System.Windows.Forms.TextBox BackupToPathBox;
        internal System.Windows.Forms.TextBox TFilesPathBox;
        internal System.Windows.Forms.TextBox TexepathBox;
        internal System.Windows.Forms.TextBox NobackupsBox;
        private System.Windows.Forms.Label currentProfileLabel;
    }
}

