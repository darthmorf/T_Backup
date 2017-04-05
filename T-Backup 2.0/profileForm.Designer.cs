namespace T_Backup_2._0
{
	partial class profileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
			this.profileLabel = new System.Windows.Forms.Label();
			this.profileComboBox = new System.Windows.Forms.ComboBox();
			this.profileLoadButton = new System.Windows.Forms.Button();
			this.profileDeleteButton = new System.Windows.Forms.Button();
			this.newProfileLabel = new System.Windows.Forms.Label();
			this.newProfileTextBox = new System.Windows.Forms.TextBox();
			this.newProfileButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// profileLabel
			// 
			this.profileLabel.AutoSize = true;
			this.profileLabel.Location = new System.Drawing.Point(12, 9);
			this.profileLabel.Name = "profileLabel";
			this.profileLabel.Size = new System.Drawing.Size(44, 13);
			this.profileLabel.TabIndex = 0;
			this.profileLabel.Text = "Profiles:";
			// 
			// profileComboBox
			// 
			this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.profileComboBox.FormattingEnabled = true;
			this.profileComboBox.Location = new System.Drawing.Point(12, 25);
			this.profileComboBox.Name = "profileComboBox";
			this.profileComboBox.Size = new System.Drawing.Size(260, 21);
			this.profileComboBox.TabIndex = 1;
			// 
			// profileLoadButton
			// 
			this.profileLoadButton.Location = new System.Drawing.Point(12, 52);
			this.profileLoadButton.Name = "profileLoadButton";
			this.profileLoadButton.Size = new System.Drawing.Size(260, 23);
			this.profileLoadButton.TabIndex = 2;
			this.profileLoadButton.Text = "Load";
			this.profileLoadButton.UseVisualStyleBackColor = true;
			this.profileLoadButton.Click += new System.EventHandler(this.profileLoadButton_Click);
			// 
			// profileDeleteButton
			// 
			this.profileDeleteButton.Location = new System.Drawing.Point(12, 81);
			this.profileDeleteButton.Name = "profileDeleteButton";
			this.profileDeleteButton.Size = new System.Drawing.Size(260, 23);
			this.profileDeleteButton.TabIndex = 3;
			this.profileDeleteButton.Text = "Delete";
			this.profileDeleteButton.UseVisualStyleBackColor = true;
			this.profileDeleteButton.Click += new System.EventHandler(this.profileDeleteButton_Click);
			// 
			// newProfileLabel
			// 
			this.newProfileLabel.AutoSize = true;
			this.newProfileLabel.Location = new System.Drawing.Point(9, 107);
			this.newProfileLabel.Name = "newProfileLabel";
			this.newProfileLabel.Size = new System.Drawing.Size(64, 13);
			this.newProfileLabel.TabIndex = 4;
			this.newProfileLabel.Text = "New Profile:";
			// 
			// newProfileTextBox
			// 
			this.newProfileTextBox.Location = new System.Drawing.Point(12, 123);
			this.newProfileTextBox.Name = "newProfileTextBox";
			this.newProfileTextBox.Size = new System.Drawing.Size(179, 20);
			this.newProfileTextBox.TabIndex = 5;
			// 
			// newProfileButton
			// 
			this.newProfileButton.Location = new System.Drawing.Point(197, 121);
			this.newProfileButton.Name = "newProfileButton";
			this.newProfileButton.Size = new System.Drawing.Size(75, 23);
			this.newProfileButton.TabIndex = 6;
			this.newProfileButton.Text = "Create";
			this.newProfileButton.UseVisualStyleBackColor = true;
			this.newProfileButton.Click += new System.EventHandler(this.newProfileButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(197, 167);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 7;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(116, 167);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 8;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// profileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 202);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.newProfileButton);
			this.Controls.Add(this.newProfileTextBox);
			this.Controls.Add(this.newProfileLabel);
			this.Controls.Add(this.profileDeleteButton);
			this.Controls.Add(this.profileLoadButton);
			this.Controls.Add(this.profileComboBox);
			this.Controls.Add(this.profileLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "profileForm";
			this.Text = "Profiles";
			this.Load += new System.EventHandler(this.profileForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label profileLabel;
		public System.Windows.Forms.ComboBox profileComboBox;
		private System.Windows.Forms.Button profileLoadButton;
		private System.Windows.Forms.Button profileDeleteButton;
		private System.Windows.Forms.Label newProfileLabel;
		private System.Windows.Forms.TextBox newProfileTextBox;
		private System.Windows.Forms.Button newProfileButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
	}
}