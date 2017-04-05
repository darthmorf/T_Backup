using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Backup_2._0
{
	public partial class profileForm : Form
	{
		List<profileData> profiles = new List<profileData>();
		profileData loadedProfile;

		public List<profileData> ReturnValue1 { get; set; }
		public profileData ReturnValue2 { get; set; }

		public profileForm(List<profileData> passedProfiles, profileData passedLoadedProfile)
		{
			InitializeComponent();
			profiles = passedProfiles;
			loadedProfile = passedLoadedProfile;
		}

		private void profileForm_Load(object sender, EventArgs e)
		{
			loadDropDownBox();
			this.Text = "Profile: " + loadedProfile.profileName;
		}

		//setup profile dropdown
		private void loadDropDownBox()
		{
			profileComboBox.Items.Clear();
			foreach (profileData profile in profiles)
			{
				profileComboBox.Items.Add(profile.profileName);
			}
			profileComboBox.SelectedIndex = 0;
		}

		//generates a new profile from the current loaded one
		private void newProfileButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(newProfileTextBox.Text))
			{
				MessageBox.Show("Please enter a profile name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (profileComboBox.Items.Contains(newProfileTextBox.Text))
			{
				MessageBox.Show("That profile name already exists", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				profileData newProfile = loadedProfile;
				newProfile.profileName = newProfileTextBox.Text;
				profiles.Add(newProfile);
				loadDropDownBox();
			}
		}

		//deletes selected profile
		private void profileDeleteButton_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(profileComboBox.Text))
			{
				MessageBox.Show("Please select a profile", "Invalid selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int i = 0;
				foreach (profileData profile in profiles)
				{
					if (profile.profileName == profileComboBox.Text)
					{
						profiles.RemoveAt(i);
						loadDropDownBox();
						MessageBox.Show("Deleted profile " + profileComboBox.Text, "Profile Deleted");
						break;
					}
					i++;
				}
			}
		}

		//load selected profile
		private void profileLoadButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(profileComboBox.Text))
			{
				MessageBox.Show("Please select a profile", "Invalid selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int i = 0;
				foreach (profileData profile in profiles)
				{
					if (profile.profileName == profileComboBox.Text)
					{
						loadedProfile = profile;
						loadDropDownBox();
						this.Text = "Profile: " + loadedProfile.profileName;
						MessageBox.Show("Loaded profile " + loadedProfile.profileName, "Profile Loaded");
						break;
					}
					i++;
				}
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.ReturnValue1 = profiles;
			this.ReturnValue2 = loadedProfile;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
