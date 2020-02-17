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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.DockTimer = new System.Windows.Forms.Timer(this.components);
            this.dockPanel = new System.Windows.Forms.Panel();
            this.dockTime = new System.Windows.Forms.Label();
            this.dockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DockTimer
            // 
            this.DockTimer.Enabled = true;
            this.DockTimer.Interval = 500;
            this.DockTimer.Tick += new System.EventHandler(this.DockTimer_Tick);
            // 
            // dockPanel
            // 
            this.dockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dockPanel.Controls.Add(this.dockTime);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockPanel.Location = new System.Drawing.Point(0, 636);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1264, 45);
            this.dockPanel.TabIndex = 0;
            // 
            // dockTime
            // 
            this.dockTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dockTime.AutoSize = true;
            this.dockTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dockTime.ForeColor = System.Drawing.Color.White;
            this.dockTime.Location = new System.Drawing.Point(1179, 13);
            this.dockTime.Name = "dockTime";
            this.dockTime.Size = new System.Drawing.Size(69, 20);
            this.dockTime.TabIndex = 0;
            this.dockTime.Text = "00:00 PM";
            this.dockTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dockPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SilverOS";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dockPanel.ResumeLayout(false);
            this.dockPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DockTimer;
        private System.Windows.Forms.Panel dockPanel;
        private System.Windows.Forms.Label dockTime;
    }
}