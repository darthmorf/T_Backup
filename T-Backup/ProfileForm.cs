using System;
using System.Diagnostics;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Backup
{
    public partial class ProfileForm : Form
    {
        TBSettings MySettings;

        public ProfileForm(TBSettings lMySettings )
        {
            InitializeComponent();

            MySettings = lMySettings;

            //Get the current profile name and display it
            ProfileNameBox.Text = MySettings.CurrentProfileName;

            //fetches an array of all existing profiles
            string[] profiles = MySettings.getProfiles();

            //creates the default x-position variable
            int xPos = 0;
            foreach (string profile in profiles)
            {//for each profile that exists
                //create a new button
                Button profileButton = new Button();
                //with 75x25 size
                profileButton.Size = new Size(75, 25);
                //sets the name and text of the button to the profile name
                profileButton.Name = profile;
                profileButton.Text = profile;
                //positions it after the previous button
                profileButton.Location = new Point(xPos, 0);
                //sets its 'on click' function to the namelabel_Click function
                profileButton.Click += namelabel_Click;
                //updates x-position
                xPos += profileButton.Width;
                panel1.Controls.Add(profileButton);
            }
        }

        void namelabel_Click(object sender, EventArgs e)
        {//load new profile
            //Gets the name of the activating button 
            Control C = (Control)sender;
            //calls the load profile function
            MySettings.loadProfile(C.Text);
            //updates the textbox.
            ProfileNameBox.Text = C.Text;

            MessageBox.Show("Switched profiles.",
                                     "Process complete.",
                                     MessageBoxButtons.OK);
        }

        

        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            // call the new profile function
            MySettings.newProfile(ProfileLoadBox.Text);
            //updates textboxes
            ProfileNameBox.Text = ProfileLoadBox.Text;
            ProfileLoadBox.Text = "";

            MessageBox.Show("Created new profile, and loaded.",
                                     "Process complete.",
                                     MessageBoxButtons.OK);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
     
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void profilesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
