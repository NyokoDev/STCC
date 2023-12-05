using System;

namespace STCC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ModLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ModLabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.CompButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::STCC.Properties.Resources.STCC;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Mollen Personal Use", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 76);
            this.listView1.MaximumSize = new System.Drawing.Size(298, 410);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(298, 362);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(20, 20);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ModLabel
            // 
            this.ModLabel.AutoSize = true;
            this.ModLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModLabel.Font = new System.Drawing.Font("Mollen Personal Use", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModLabel.Location = new System.Drawing.Point(385, 76);
            this.ModLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(174, 34);
            this.ModLabel.TabIndex = 1;
            this.ModLabel.Text = "Select a Mod";
            this.ModLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Mollen Personal Use", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Location = new System.Drawing.Point(386, 125);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(300, 200);
            this.StatusLabel.MinimumSize = new System.Drawing.Size(300, 200);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(300, 200);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Select a mod";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // ModLabel3
            // 
            this.ModLabel3.AutoSize = true;
            this.ModLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ModLabel3.Font = new System.Drawing.Font("Mollen Personal Use", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModLabel3.Location = new System.Drawing.Point(385, 49);
            this.ModLabel3.MaximumSize = new System.Drawing.Size(500, 500);
            this.ModLabel3.Name = "ModLabel3";
            this.ModLabel3.Size = new System.Drawing.Size(154, 34);
            this.ModLabel3.TabIndex = 3;
            this.ModLabel3.Text = "Mod Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mollen Personal Use", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 357);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Short Term Compatibility Checker";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DiscordButton
            // 
            this.DiscordButton.BackColor = System.Drawing.Color.Transparent;
            this.DiscordButton.Font = new System.Drawing.Font("Mollen Personal Use", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordButton.Location = new System.Drawing.Point(460, 395);
            this.DiscordButton.MaximumSize = new System.Drawing.Size(236, 43);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(236, 43);
            this.DiscordButton.TabIndex = 5;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.UseVisualStyleBackColor = false;
            this.DiscordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.Color.Transparent;
            this.SupportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SupportButton.BackgroundImage")));
            this.SupportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SupportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupportButton.FlatAppearance.BorderSize = 0;
            this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportButton.ForeColor = System.Drawing.Color.Transparent;
            this.SupportButton.Location = new System.Drawing.Point(-15, 23);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(869, 23);
            this.SupportButton.TabIndex = 7;
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            this.SupportButton.MouseLeave += new System.EventHandler(this.SupportButton_MouseLeave);
            this.SupportButton.MouseHover += new System.EventHandler(this.SupportButton_MouseHover);
            // 
            // CompButton
            // 
            this.CompButton.BackColor = System.Drawing.Color.Transparent;
            this.CompButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompButton.BackgroundImage")));
            this.CompButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompButton.FlatAppearance.BorderSize = 0;
            this.CompButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompButton.ForeColor = System.Drawing.Color.Transparent;
            this.CompButton.Location = new System.Drawing.Point(0, 0);
            this.CompButton.Name = "CompButton";
            this.CompButton.Size = new System.Drawing.Size(816, 23);
            this.CompButton.TabIndex = 6;
            this.CompButton.UseMnemonic = false;
            this.CompButton.UseVisualStyleBackColor = false;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            this.CompButton.MouseLeave += new System.EventHandler(this.CompButton_MouseLeave);
            this.CompButton.MouseHover += new System.EventHandler(this.CompButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.CompButton);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModLabel3);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ModLabel);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short-Term Compatibility Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label ModLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ModLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DiscordButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button CompButton;
    }
}

