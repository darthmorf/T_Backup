using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

struct profileData
{
	//a struct to contain all the data needed to save a profile
	public string profileName;

	public string filesPath;
	public string savesPath;
	public string backupPath;
	public string restorePath;
	public int    maxBackups;

	public bool   backupWorlds;
	public bool   backupPlayers;
	public bool   backupFiles;
	public bool   backupCaptures;
	public bool   backupMisc;

	public bool   runOnStartup;
};


namespace T_Backup_2._0
{ 
	public partial class mainForm : Form
	{

		public string filesPath;
		public string savesPath;
		public string backupPath;
		public string restorePath;
		public int maxBackups = 0;
		List<profileData> profiles = new List<profileData>();
		profileData loadedProfile;

		public string myDocuments = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		public string programFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

		public mainForm()
		{
			InitializeComponent();
		}

		private void saveProfiles()
		{
			//write the profiles to file, all nicely formatted
			var json = JsonConvert.SerializeObject(profiles, Formatting.Indented);
			System.IO.File.WriteAllText(@"profiles.json", json);
		}

		private void loadProfiles()
		{
			//if profile file exists, load it otherwise construct a default profile
			if(File.Exists("profiles.json"))
			{
				string json = File.ReadAllText("profiles.json");
				profiles = JsonConvert.DeserializeObject<List<profileData>>(json);
			}

			else
			{
				profiles.Add(constructDefaultProfile());
			}

			//attempt to load previously selected profile
			bool loaded = false;
			foreach(profileData profile in profiles)
			{
				if(profile.profileName == T_Backup_2._0.Properties.Settings.Default.loadedProfile)
				{
					loadedProfile = profile;
					setupProfile();
					loaded = true;
				}
			}
			//if the previously selected profile is not loaded
			if (loaded == false)
			{
				//attempt to load the first
				if(profiles[0].profileName != null)
				{
					loadedProfile = profiles[0];
					setupProfile();
				}
				//otherwise load default
				else
				{
					loadedProfile = constructDefaultProfile();
					setupProfile();
				}
			}
		}

		//sets up textboxes etc with loaded profile
		private void setupProfile()
		{
			T_Backup_2._0.Properties.Settings.Default.loadedProfile = loadedProfile.profileName;
			this.Text = "T-Backup - Profile: " + loadedProfile.profileName;

			filesPathTextBox.Text = loadedProfile.filesPath;
			savesPathTextBox.Text = loadedProfile.savesPath;
			backupPathTextBox.Text = loadedProfile.backupPath;
			maxBackupsCounter.Value = loadedProfile.maxBackups;

			backupWorldsChkBox.Checked = loadedProfile.backupWorlds;
			backupPlayersChkBox.Checked = loadedProfile.backupPlayers;
			backupFilesChkBox.Checked = loadedProfile.backupFiles;
			backupCapturesChkBox.Checked = loadedProfile.backupCaptures;
			backupDataChkBox.Checked = loadedProfile.backupMisc;

			runOnStartupChkBox.Checked = loadedProfile.runOnStartup;

			restorePathTextBox.Text = loadedProfile.restorePath;
		}

		//makes a struct with default data
		private profileData constructDefaultProfile()
		{
			profileData defaultProfile;
			defaultProfile.profileName = "default";

			defaultProfile.filesPath = programFiles + @"\Steam\Steamapps\common\Terraria";
			defaultProfile.savesPath = myDocuments + @"\My Games\Terraria";
			defaultProfile.backupPath = myDocuments + @"\Terraria Backups";
			defaultProfile.restorePath = myDocuments + @"\Terraria Backups";
			defaultProfile.maxBackups = 0;

			defaultProfile.backupWorlds = true;
			defaultProfile.backupPlayers = true;
			defaultProfile.backupFiles = true;
			defaultProfile.backupCaptures = true;
			defaultProfile.backupMisc = true;

			defaultProfile.runOnStartup = false;

			return defaultProfile;
		}

		public void mainForm_Load(object sender, EventArgs e)
		{
			loadProfiles();
		}

		private string openfolder(string path)
		{
			//opens a folder dialog at given path then returns the new path if changed
			//folderBrowserDialog is ugly but I can't find any easy to impliment alternatives
			folderBrowserDialog.SelectedPath = path;
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK) path = folderBrowserDialog.SelectedPath;
			return path;
		}

		private void toggleInteraction()
		{
			settingsGroupBox.Enabled = !settingsGroupBox.Enabled;
			backupGroupBox.Enabled = !backupGroupBox.Enabled;
			restoreGroupBox.Enabled = !restoreGroupBox.Enabled;
			profileButton.Enabled = !profileButton.Enabled;
		}

		//browse folder buttons for text boxes
		private void openFilesFolderButton_Click(object sender, EventArgs e) { filesPathTextBox.Text = openfolder(filesPathTextBox.Text); }
		private void openSavesFolderButton_Click(object sender, EventArgs e) { savesPathTextBox.Text = openfolder(savesPathTextBox.Text); }
		private void openBackupFolderButton_Click(object sender, EventArgs e) { backupPathTextBox.Text = openfolder(backupPathTextBox.Text); }
		private void openRestorePathFolderButton_Click(object sender, EventArgs e) { restorePathTextBox.Text = openfolder(restorePathTextBox.Text); }

		private void profileButton_Click(object sender, EventArgs e)
		{

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			saveProfiles();
		}
	}
}
