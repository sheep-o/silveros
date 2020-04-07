namespace SilverOS.Core.Applications
{
    partial class FileManagerTest
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRefresh = new MetroSuite.MetroButton();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.signinUsername = new MetroSuite.MetroTextbox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1256, 611);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnRefresh.DefaultColor = System.Drawing.Color.White;
            this.btnRefresh.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.HoverColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 658);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.RoundingArc = 26;
            this.btnRefresh.Size = new System.Drawing.Size(50, 26);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "<";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton1.DefaultColor = System.Drawing.Color.White;
            this.metroButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.HoverColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(68, 658);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton1.RoundingArc = 26;
            this.metroButton1.Size = new System.Drawing.Size(50, 26);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = ">";
            // 
            // signinUsername
            // 
            this.signinUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signinUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.signinUsername.DefaultColor = System.Drawing.Color.White;
            this.signinUsername.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.signinUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.signinUsername.ForeColor = System.Drawing.Color.Black;
            this.signinUsername.HideSelection = false;
            this.signinUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.signinUsername.LineOnly = true;
            this.signinUsername.Location = new System.Drawing.Point(124, 658);
            this.signinUsername.Name = "signinUsername";
            this.signinUsername.PasswordChar = '\0';
            this.signinUsername.ShortcutsEnabled = false;
            this.signinUsername.Size = new System.Drawing.Size(1144, 26);
            this.signinUsername.TabIndex = 6;
            this.signinUsername.WordWrap = false;
            // 
            // FileManagerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1280, 696);
            this.Controls.Add(this.signinUsername);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listView1);
            this.Name = "FileManagerTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MetroSuite.MetroButton btnRefresh;
        private MetroSuite.MetroButton metroButton1;
        private MetroSuite.MetroTextbox signinUsername;
    }
}