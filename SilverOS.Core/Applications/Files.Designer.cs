namespace SilverOS.Core.Applications
{
    partial class Files
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Files));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnUp = new MetroSuite.MetroNavigationButton();
            this.directoryLocation = new MetroSuite.MetroTextbox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList;
            this.listView1.Location = new System.Drawing.Point(7, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 407);
            this.listView1.SmallImageList = this.imageList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder");
            this.imageList.Images.SetKeyName(1, "image-x-generic");
            this.imageList.Images.SetKeyName(2, "package-x-generic");
            this.imageList.Images.SetKeyName(3, "text-x-generic");
            // 
            // btnUp
            // 
            this.btnUp.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnUp.ArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.btnUp.ArrowHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUp.ArrowPressedColor = System.Drawing.Color.White;
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnUp.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUp.BorderPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUp.DefaultColor = System.Drawing.Color.White;
            this.btnUp.DisabledArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnUp.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUp.Location = new System.Drawing.Point(7, 31);
            this.btnUp.Name = "btnUp";
            this.btnUp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // directoryLocation
            // 
            this.directoryLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.directoryLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.directoryLocation.DefaultColor = System.Drawing.Color.White;
            this.directoryLocation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.directoryLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.directoryLocation.HideSelection = false;
            this.directoryLocation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.directoryLocation.Location = new System.Drawing.Point(37, 32);
            this.directoryLocation.Name = "directoryLocation";
            this.directoryLocation.PasswordChar = '\0';
            this.directoryLocation.Size = new System.Drawing.Size(696, 23);
            this.directoryLocation.TabIndex = 2;
            this.directoryLocation.KeyDown += new MetroSuite.MetroTextbox.KeyDownEventHandler(this.directoryLocation_KeyDown);
            // 
            // Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 480);
            this.Controls.Add(this.directoryLocation);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listView1);
            this.Name = "Files";
            this.Text = "Files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MetroSuite.MetroNavigationButton btnUp;
        private MetroSuite.MetroTextbox directoryLocation;
        private System.Windows.Forms.ImageList imageList;
    }
}