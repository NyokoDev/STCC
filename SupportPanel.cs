using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STCC
{
    public partial class SupportPanel : Form
    {
        public SupportPanel()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Catalogv1\BCK.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SupportButton.BackgroundImage = Image.FromFile(@"UI\SupportNormal.png");
            this.OpenLogLocation.BackgroundImage = Image.FromFile(@"UI\Buttons\LogLocationNormal.png");
            this.OpenLog.BackgroundImage = Image.FromFile(@"UI\Buttons\OpenLogNormal.png");
            InitializeLog();

        }
        private void SupportPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainform = new Form1();
            mainform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }



        private void SupportButton_MouseLeave(object sender, EventArgs e)
        {
            SupportButton.BackgroundImage = Image.FromFile(@"UI\SupportNormal.png");
        }

        private void SupportButton_MouseHover(object sender, EventArgs e)
        {
            SupportButton.BackgroundImage = Image.FromFile(@"UI\SupportHovered.png");
        }

        private void CompButton_MouseLeave(object sender, EventArgs e)
        {
            CompButton.BackgroundImage = Image.FromFile(@"UI\CompNormal.png");
        }

        private void CompButton_MouseHover(object sender, EventArgs e)
        {
            CompButton.BackColor = Color.FromArgb(100, 255, 255, 255);
            CompButton.BackgroundImage = Image.FromFile(@"UI\CompHovered.png");
        }


        /*
         * 
         
Establish the structure for opening the log location.
         */

        private void OpenLog_MouseClick(object sender, MouseEventArgs e)
        {
            OpenLog.BackColor = Color.FromArgb(100, 255, 255, 255);
            OpenLog.BackgroundImage = Image.FromFile(@"UI\Buttons\OpenLogHovered.png");
        }

        private void OpenLogLocation_Click(object sender, EventArgs e)
        {
            OpenLogLocation.BackColor = Color.FromArgb(0, 255, 255, 255);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string gameFolder = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II");

            try
            {
                Process.Start(gameFolder);

                OpenLogLocation.BackgroundImage = Image.FromFile(@"UI\Buttons\LogLocationNormal.png");
                OpenLogLocation.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                OpenLogLocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur when trying to open the folder
                Console.WriteLine("Error opening folder: " + ex.Message);
            }
        }



        private void OpenLogLocation_MouseLeave(object sender, EventArgs e)
        {
            OpenLogLocation.BackColor = Color.FromArgb(0, 255, 255, 255);
            OpenLogLocation.BackgroundImage = Image.FromFile(@"UI\Buttons\LogLocationNormal.png");

        }

        private void OpenLogLocation_MouseHover(object sender, EventArgs e)
        {
            OpenLogLocation.BackColor = Color.FromArgb(0, 255, 255, 255);
            OpenLogLocation.BackgroundImage = Image.FromFile(@"UI\Buttons\LogLocationHovered.png");
        }

        private void OpenLog_Click(object sender, EventArgs e)
        {
            OpenLog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.BackColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string gameFolder = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II\Player.log");

            try
            {
                Process.Start(gameFolder);

                OpenLog.BackgroundImage = Image.FromFile(@"UI\Buttons\OpenLogNormal.png");
                OpenLog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                OpenLog.BackColor = Color.FromArgb(0, 255, 255, 255);
                OpenLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur when trying to open the folder
                Console.WriteLine("Error opening file: " + ex.Message);
            }


        }

        private void OpenLog_MouseHover(object sender, EventArgs e)
        {
            OpenLog.BackgroundImage = Image.FromFile(@"UI\Buttons\OpenLogHovered.png");
            OpenLog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.BackColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void OpenLog_MouseLeave(object sender, EventArgs e)
        {
            OpenLog.BackgroundImage = Image.FromFile(@"UI\Buttons\OpenLogNormal.png");
            OpenLog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.BackColor = Color.FromArgb(0, 255, 255, 255);
            OpenLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
        }


        private void InitializeLog()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string gameFolder = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II\Player.log");

            try
            {
                if (File.Exists(gameFolder))
                {
                    // Read the content of Player.log file
                    string logContent = File.ReadAllText(gameFolder);

                    // Display the content in richTextBox1
                    richTextBox1.Text = logContent;
                }
                else
                {
                    // If the file doesn't exist, show a message
                    richTextBox1.Text = "Player.log file not found.";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during file reading
                richTextBox1.Text = $"Error reading file: {ex.Message}";
            }

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string gameFolder = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II\Player.log");

            try
            {
                if (File.Exists(gameFolder))
                {
                    // Read the content of Player.log file
                    string logContent = File.ReadAllText(gameFolder);

                    // Display the content in richTextBox1
                    richTextBox1.Text = logContent;
                }
                else
                {
                    // If the file doesn't exist, show a message
                    richTextBox1.Text = "Player.log file not found.";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during file reading
                richTextBox1.Text = $"Error reading file: {ex.Message}";
            }
        }

        private void CopyLogs_Click(object sender, EventArgs e)
        {
            // Get the path to the LocalApplicationData folder
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string logFolderPath = Path.Combine(@"LogFolder\");

            // Check if the directory exists; if not, create it
            if (!Directory.Exists(logFolderPath))
            {
                Directory.CreateDirectory(logFolderPath);
            }

            // Paths for the log files and zip file
            string gameLogPath = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II\Player.log");
            string logsFolderPath = Path.Combine(folderPath, @"..\LocalLow\Colossal Order\Cities Skylines II\Logs");
            string zipPath = Path.Combine(logFolderPath, "STCCLogs.zip");

            // Create a zip file
            try
            {
                ZipFile.CreateFromDirectory(logsFolderPath, zipPath);
                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                {
                    archive.CreateEntryFromFile(gameLogPath, Path.GetFileName(gameLogPath));
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during zip file creation
                Console.WriteLine("Error creating zip file: " + ex.Message);
             
                return;
            }

            // Read the zipped file into memory
            byte[] zipBytes;
            try
            {
                zipBytes = File.ReadAllBytes(zipPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading zip file: " + ex.Message);
                return;
            }

            // Copy the zipped file bytes to the clipboard
            try
            {
                DataObject dataObject = new DataObject();
                MemoryStream stream = new MemoryStream(zipBytes);
                dataObject.SetData(DataFormats.FileDrop, new string[] { zipPath }); // Providing file paths for legacy handling
                dataObject.SetData("Preferred DropEffect", DragDropEffects.Copy);
                dataObject.SetData("FileGroupDescriptorW", stream);
                Clipboard.SetDataObject(dataObject, true);
                stream.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error copying zip file to clipboard: " + ex.Message);
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string logFolderPath = @"LogFolder\";
            Process.Start(logFolderPath);
        }


        /*
        * 

End of structure.
        */
    }
    }
