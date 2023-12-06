﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STCC
{
    public partial class Form1 : Form
    {

        private List<Mod> mods = new List<Mod>(); // Initialize the mods list

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Catalogv1\BCK.png");
            listView1.BackgroundImage = Image.FromFile(@"Catalogv1\TRP.png"); // Replace with your image path
            listView1.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = @"Catalogv1\cc.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                RootObject root = JsonConvert.DeserializeObject<RootObject>(jsonContent);

                if (root != null && root.mods != null)
                {
                    // Assign the mods list
                    mods = root.mods;

                    // Set the listView1 to display as a list
                    listView1.View = View.List;

                    // Add mods' names to listView1
                    foreach (var mod in mods)
                    {
                        ListViewItem item = new ListViewItem(mod.name);
                        listView1.Items.Add(item);
                    }

                    // Sort the items alphabetically
                    listView1.Sorting = SortOrder.Ascending;
                    listView1.Sort();
                }
                else
                {
                    MessageBox.Show("No mods found in the JSON file.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during file reading or JSON deserialization
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected in listView1
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item and update ModLabel with the mod name
                string selectedModName = listView1.SelectedItems[0].Text;
                ModLabel.Text = selectedModName;

                // Find the selected mod object from the mods list
                Mod selectedMod = mods.Find(mod => mod.name == selectedModName);

                // Update StatusLabel with the mod status
                if (selectedMod != null && selectedMod.statuses != null)
                {
                    string stableInfo = $"Stability: {selectedMod.statuses.Stable}";
                    StatusLabel.Text = stableInfo;

                    string lastUpdated = selectedMod.statuses.LastUpdated;

                }
                else
                {
                    StatusLabel.Text = "Status information not available.";

                }
            }
        }



        // Classes representing the JSON structure
        public class Statuses
        {
            public string Stable { get; set; }
            public string LastUpdated { get; set; }
        }

        public class Mod
        {
            public string name { get; set; }
            public Statuses statuses { get; set; }
        }

        public class RootObject
        {
            public List<Mod> mods { get; set; }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/33RcCzm5WT");
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportPanel supportForm = new SupportPanel();
            supportForm.ShowDialog();
            this.Dispose();

        }

        private void CompButton_Click(object sender, EventArgs e)
        {

        }

        private void CompButton_MouseHover(object sender, EventArgs e)
        {
            CompButton.BackgroundImage = Image.FromFile(@"UI\CompHovered.png");
        }

        private void CompButton_MouseLeave(object sender, EventArgs e)
        {
            CompButton.BackgroundImage = Image.FromFile(@"UI\CompNormal.png");
        }


        private void SupportButton_MouseLeave(object sender, EventArgs e)
        {
            SupportButton.BackgroundImage = Image.FromFile(@"UI\SupportNormal.png");
        }

        private void SupportButton_MouseHover(object sender, EventArgs e)
        {
            SupportButton.BackgroundImage = Image.FromFile(@"UI\SupportHovered.png");
        }

    }
}
        
