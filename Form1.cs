using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.Http;
using HtmlAgilityPack;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;

namespace STCC
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> modsData;

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
            try
            {
                string url = "https://stcc-developer-control.onrender.com";

                modsData = GetModsFromHTMLUrl(url);

                if (modsData != null)
                {
                    modsData = modsData.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                    listView1.View = View.List;
                    listView1.Columns.Add("Mod Name").Width = 150;

                    foreach (var mod in modsData.Keys)
                    {
                        ListViewItem item = new ListViewItem(mod);
                        listView1.Items.Add(item);
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    MessageBox.Show("No mods found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private Dictionary<string, string> GetModsFromHTMLUrl(string url)
        {
            var mods = new Dictionary<string, string>();

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            HtmlNodeCollection rows = doc.DocumentNode.SelectNodes("//table//tr");

            if (rows != null)
            {
                foreach (HtmlNode row in rows)
                {
                    HtmlNodeCollection cols = row.SelectNodes("td");
                    if (cols != null && cols.Count == 2)
                    {
                        string modName = cols[0].InnerText.Trim();
                        string stability = cols[1].InnerText.Trim();

                        // Check if the key already exists before adding
                        if (!mods.ContainsKey(modName))
                        {
                            mods.Add(modName, stability);
                        }
                        else
                        {
                            // Handle duplicates if needed
                            // For example, modify the modName slightly to make it unique
                            string modifiedModName = modName + "_Duplicate";
                            mods.Add(modifiedModName, stability);
                        }
                    }
                }
            }

            return mods;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedMod = listView1.SelectedItems[0].Text;
                ModLabel.Text = $"{selectedMod}";

                if (modsData.TryGetValue(selectedMod, out string stability))
                {
                    StatusLabel.Text = $"Stability: {stability}";
                }
                else
                {
                    StatusLabel.Text = "Status information not available.";
                }
            }
        }

        private Dictionary<string, string> GetModsFromHTMLFile(string filePath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(filePath);

            var mods = new Dictionary<string, string>();

            HtmlNodeCollection rows = doc.DocumentNode.SelectNodes("//table//tr");

            if (rows != null)
            {
                foreach (HtmlNode row in rows)
                {
                    HtmlNodeCollection cols = row.SelectNodes("td");
                    if (cols != null && cols.Count == 2)
                    {
                        string modName = cols[0].InnerText.Trim();
                        string stability = cols[1].InnerText.Trim();
                        mods.Add(modName, stability);
                    }
                }
            }

            return mods;
        
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
        
