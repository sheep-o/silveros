namespace SilverOS.Core
{
    partial class Desktop
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
            this.DockTimer = new System.Windows.Forms.Timer(this.components);
            this.dockTime = new System.Windows.Forms.Label();
            this.dockPanel = new System.Windows.Forms.Panel();
            this.startButton = new SilverOS.UI.SilverImageButton();
            this.openFormsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DockTimer
            // 
            this.DockTimer.Enabled = true;
            this.DockTimer.Interval = 500;
            this.DockTimer.Tick += new System.EventHandler(this.DockTimer_Tick);
            // 
            // dockTime
            // 
            this.dockTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dockTime.AutoSize = true;
            this.dockTime.BackColor = System.Drawing.Color.Transparent;
            this.dockTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dockTime.ForeColor = System.Drawing.Color.White;
            this.dockTime.Location = new System.Drawing.Point(1183, 11);
            this.dockTime.Name = "dockTime";
            this.dockTime.Size = new System.Drawing.Size(69, 20);
            this.dockTime.TabIndex = 0;
            this.dockTime.Text = "00:00 PM";
            this.dockTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dockPanel
            // 
            this.dockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dockPanel.Controls.Add(this.startButton);
            this.dockPanel.Controls.Add(this.dockTime);
            this.dockPanel.Controls.Add(this.openFormsPanel);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockPanel.Location = new System.Drawing.Point(0, 641);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1264, 40);
            this.dockPanel.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Image = global::SilverOS.Core.Properties.Resources.start;
            this.startButton.ImageActive = null;
            this.startButton.Location = new System.Drawing.Point(9, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(30, 40);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startButton.TabIndex = 2;
            this.startButton.TabStop = false;
            this.startButton.Zoom = 10;
            // 
            // openFormsPanel
            // 
            this.openFormsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openFormsPanel.Location = new System.Drawing.Point(45, 641);
            this.openFormsPanel.Name = "openFormsPanel";
            this.openFormsPanel.Size = new System.Drawing.Size(1132, 40);
            this.openFormsPanel.TabIndex = 3;
            this.openFormsPanel.WrapContents = false;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SilverOS.Core.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dockPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SilverOS";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.DoubleClick += new System.EventHandler(this.Desktop_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Desktop_KeyDown);
            this.dockPanel.ResumeLayout(false);
            this.dockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DockTimer;
        private System.Windows.Forms.Label dockTime;
        private System.Windows.Forms.Panel dockPanel;
        private SilverOS.UI.SilverImageButton startButton;
        private System.Windows.Forms.FlowLayoutPanel openFormsPanel;
    }
}