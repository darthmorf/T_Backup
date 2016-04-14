using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace T_Backup //By Sam Poirier AKA darthmorf
{
    public partial class MainForm : Form
    {
        TBSettings MySettings ;

        public string error = "\n \n If you frequently encounter this error, please post the error on the official thread: ";
        public string tbackupthread = "http://goo.gl/VrDNIY";


        public MainForm()
        {
            try
            {
                InitializeComponent();
                MySettings = new TBSettings();

                MySettings.Startup();

                //import settings from TBSettings class
                TexepathBox.Text = MySettings.Texepath;
                TFilesPathBox.Text = MySettings.TFilesPath;
                BackupToPathBox.Text = MySettings.BackupToPath;

                string NobackupsStr = string.Format("{0}", MySettings.Nobackups);
                NobackupsBox.Text = NobackupsStr;

                currentProfileLabel.Text = "Current Profile: " + MySettings.CurrentProfileName;

            }
            catch(Exception e)
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {//saves values

            try
            {
                MySettings.Save();

                MessageBox.Show("Saved values!",
                                         "Process complete.",
                                         MessageBoxButtons.OK); ;
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            
        }

        private void BackupWorldsButton_Click(object sender, EventArgs e)
        {//backs up worlds
            try
            {
                backupWorlds();
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void BackupPlayersButton_Click(object sender, EventArgs e)
        {//backs up players
            try
            {
                backupPlayers();
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void BackupBothButton_Click(object sender, EventArgs e)
        {//backs up both
            try
            {
                backupBoth();
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error); 
            }
        }

        private void BackupFilesButton_Click(object sender, EventArgs e)
        {//opens the backup files location in file explorer
            try
            {
                Process.Start("explorer", @MySettings.BackupToPath);
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void LaunchTerrariaButton_Click(object sender, EventArgs e)
        {//Launches Terraria
            System.Diagnostics.Process.Start(MySettings.Texepath);
            MessageBox.Show("Launched Terraria!",
                                     "Process complete.",
                                     MessageBoxButtons.OK); ;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {//opens the restore form (window)
            try
            {
                RestoreForm restoreForm = new RestoreForm(MySettings);
                restoreForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {//opens the profile form (window)
            try
            {
                ProfileForm settingsForm = new ProfileForm(MySettings);
                settingsForm.ShowDialog();
                //after the actions of the profile form, refreshes the textboxes.
                TexepathBox.Text = MySettings.Texepath;
                TFilesPathBox.Text = MySettings.TFilesPath;
                BackupToPathBox.Text = MySettings.BackupToPath;

                string NobackupsStr = string.Format("{0}", MySettings.Nobackups);
                NobackupsBox.Text = NobackupsStr;
                currentProfileLabel.Text = "Current Profile: " + MySettings.CurrentProfileName;
            }
            catch
            {
                MessageBox.Show("Error: \n" + e + error + tbackupthread,
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        public void backupWorlds()
        {//backup worlds function
            //gets the current date time as a string
            string dateTime = DateTime.Now.ToString("MM\\_dd\\_yyyy h\\_mm\\_ss");
            //creates the folder to place the backup in
            Directory.CreateDirectory(MySettings.BackupToPath + "\\Backup " + dateTime + "\\Worlds");
            //sets the source and target directories for the copy function
            string SourceDir = MySettings.TFilesPath + "\\Worlds";
            string TargetDir = MySettings.BackupToPath + "\\Backup " + dateTime + "\\Worlds";
            //calls the copy fuction
            DirectoryCopy(SourceDir, TargetDir, true);
            limitBackups();

            MessageBox.Show("Backed up Worlds!",
                                     "Process complete.",
                                     MessageBoxButtons.OK); ;
        }

        public void backupPlayers()
        {//backup players function
            //gets the current date time as a string
            string dateTime = DateTime.Now.ToString("MM\\_dd\\_yyyy h\\_mm\\_ss");
            //creates the folder to place the backup in
            Directory.CreateDirectory(MySettings.BackupToPath + "\\Backup " + dateTime + "\\Players");
            //sets the source and target directories for the copy function
            string SourceDir = MySettings.TFilesPath + "\\Players";
            string TargetDir = MySettings.BackupToPath + "\\Backup " + dateTime + "\\Players";
            //calls the copy function
            DirectoryCopy(SourceDir, TargetDir, true);
            limitBackups();

            MessageBox.Show("Backed up Players!",
                                     "Process complete.",
                                     MessageBoxButtons.OK); 
        }

        public void backupBoth()
        {//backup both function
            //gets the current datetime as a string
            string dateTime = DateTime.Now.ToString("MM\\_dd\\_yyyy h\\_mm\\_ss");
            //creates the folder to place the backups in
            Directory.CreateDirectory(MySettings.BackupToPath + "\\Backup " + dateTime + "\\Worlds");
            Directory.CreateDirectory(MySettings.BackupToPath + "\\Backup " + dateTime + "\\Players");
            //sets the source and target directories for the world copy
            string SourceDir = MySettings.TFilesPath + "\\Worlds";
            string TargetDir = MySettings.BackupToPath + "\\Backup " + dateTime + "\\Worlds";
            //calls the copy fuction
            DirectoryCopy(SourceDir, TargetDir, true);
            //sets the source and target directories for the player copy
            SourceDir = MySettings.TFilesPath + "\\Players";
            TargetDir = MySettings.BackupToPath + "\\Backup " + dateTime + "\\Players";
            //calls the copy function again
            DirectoryCopy(SourceDir, TargetDir, true);
            limitBackups();

            MessageBox.Show("Backed up Worlds and PLayers!",
                                     "Process complete.",
                                     MessageBoxButtons.OK); ;
        }

        public void limitBackups()
        {//limit backups function
            //Keeps only x amounts of backups.
            int directoryCount = System.IO.Directory.GetDirectories(@MySettings.BackupToPath).Length;

            while (directoryCount > MySettings.Nobackups)
            {
                var backups = new List<string>();
                foreach (string s in Directory.GetDirectories(MySettings.BackupToPath))
                {
                    backups.Add(s);
                }
                backups.Sort();

                var oldfile = backups.First();
                Directory.Delete(oldfile, true);
                directoryCount = System.IO.Directory.GetDirectories(@MySettings.BackupToPath).Length;
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        { //Copy function
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        //updates variables whenever the text in boxes is changed.
        private void NoBackupsBox_TextChanged(object sender, EventArgs e)
        {
            MySettings.Nobackups = int.Parse(NobackupsBox.Text);
        }

        private void TexepathBox_TextChanged(object sender, EventArgs e)
        {
            MySettings.Texepath = TexepathBox.Text;
        }

        private void TFilesPathBox_TextChanged(object sender, EventArgs e)
        {
            MySettings.TFilesPath = TFilesPathBox.Text;
        }

        private void BackupToPathBox_TextChanged(object sender, EventArgs e)
        {
            MySettings.BackupToPath = BackupToPathBox.Text;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
