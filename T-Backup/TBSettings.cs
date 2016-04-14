using System;
using Microsoft.Win32;
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
    public class TBSettings
    {
        public string TFilesPath;
        public string BackupToPath;
        public string Texepath;
        public int Nobackups;
        public string CurrentProfileName;
        //imports the registry path to a variable
        public string regPath = Registry.CurrentUser + "\\SOFTWARE\\T_Backup";
        

        public TBSettings()
        {
        }

 
        public void Save()
        {//saves each setting to the registry
            Registry.SetValue(regPath + "\\" + CurrentProfileName, "TFilesPath", TFilesPath);
            Registry.SetValue(regPath + "\\" + CurrentProfileName, "BackupToPath", BackupToPath);
            Registry.SetValue(regPath + "\\" + CurrentProfileName, "Texepath", Texepath);
            Registry.SetValue(regPath + "\\" + CurrentProfileName, "Nobackups", Nobackups);
            Registry.SetValue(regPath, "CurrentProfileName", CurrentProfileName);
        }

        public void Load()
        {//fills each variable with value from the registry
            CurrentProfileName = (string)Registry.GetValue(regPath, "ProfileName", CurrentProfileName);
            TFilesPath = (string)Registry.GetValue(regPath + "\\" + CurrentProfileName, "TFilesPath", "");
            BackupToPath = (string)Registry.GetValue(regPath + "\\" + CurrentProfileName, "BackupToPath", "");
            Texepath = (string)Registry.GetValue(regPath + "\\" + CurrentProfileName, "Texepath", "");
            Nobackups = (int)Registry.GetValue(regPath + "\\" + CurrentProfileName, "Nobackups", "");
        }

        public void Startup()
        {//runs on program startup
            //trys to fill a string with the current profile name from registry
            string regTest = CurrentProfileName = (string)Registry.GetValue(regPath, "ProfileName", CurrentProfileName);

            //if the T_Backup registry does not exist (ie this is the first run of the program)
            if(regTest == null)
            {
                //fetches the current user's My Documents path
                string mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Sets up the default Terraria folders
                TFilesPath = mydocs + "\\My Games\\Terraria";
                //creates the folder to store the backups in
                Directory.CreateDirectory(mydocs + "\\Terraria Backups");
                BackupToPath = mydocs + "\\Terraria Backups";
                //Loads the defaults for the rest
                Texepath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Terraria\\Terraria.exe";
                Nobackups = 10;
                CurrentProfileName = "Default";
                Save();
            }
            Load();
        }

        public void newProfile(string newProfileName)
        {//create a new profile function
            //sets the name to the new name
            CurrentProfileName = newProfileName;
            Save();
            Load();
        }

        public void loadProfile(string loadProfileName)
        {//load function
            //sets the name to the profile to load name
            CurrentProfileName = loadProfileName;
            Load();
        }

        public string[] getProfiles()
        {//fetches all saved profiles
            string[] ret;
            //gets the default registry key
            RegistryKey Key;
            //Opens the registry
            Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\T_Backup");
            //adds all profiles (subkeys) to the array
            ret = Key.GetSubKeyNames();
            //returns the array
            return ret;
        }
    }
}
