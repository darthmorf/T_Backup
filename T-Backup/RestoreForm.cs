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
namespace T_Backup
{
    public partial class RestoreForm : Form
    {
        TBSettings MySettings;
        public RestoreForm(TBSettings lMySettings)
        {
            InitializeComponent();
            MySettings = lMySettings;

            //Load the default paths from settings
            textBox2.Text = MySettings.TFilesPath;
        }

        private void viewBackupFilesButton_Click(object sender, EventArgs e)
        {
            //opens the backup files location in file explorer
            Process.Start("explorer", @MySettings.BackupToPath);
        }

        private void backFilesButton_Click(object sender, EventArgs e)
        {//backup files
            string backupPath = textBox1.Text;

            //Are you sure you want to restore?
            var confirmResult = MessageBox.Show("Are you sure You want to restore backups?",
                                     "Restore backups?",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            //If yes
            if (confirmResult == DialogResult.Yes)
            {
                //If Backup contains worlds
                if (Directory.Exists(backupPath + "\\Worlds"))
                {
                    //calls the clean directory function
                    cleanDirectory(MySettings.TFilesPath + "\\Worlds");
                    //calls the directory copy function
                    DirectoryCopy(backupPath + "\\Worlds", MySettings.TFilesPath + "\\Worlds", true);
                    MessageBox.Show("Restored Worlds!",
                                     "Process complete.",
                                     MessageBoxButtons.OK); ;
                }
                
                //If Backup contains players
                if (Directory.Exists(backupPath + "\\Players"))
                {
                    //calls the clean directory function
                    cleanDirectory(MySettings.TFilesPath + "\\Players");
                    //calls the directory copy function
                    DirectoryCopy(backupPath + "\\Players", MySettings.TFilesPath + "\\Players", true);
                    MessageBox.Show("Restored Players!",
                                     "Process complete.",
                                     MessageBoxButtons.OK);
                }
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

        private static void cleanDirectory(string path)
        {//Clean directory function
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

                    //Deletes all files
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    //Deletes all folders
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
