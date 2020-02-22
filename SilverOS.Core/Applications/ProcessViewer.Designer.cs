namespace SilverOS.Core
{
    partial class ProcessViewer
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
            this.btnEndProcess = new MetroSuite.MetroButton();
            this.processView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnEndProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEndProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnEndProcess.DefaultColor = System.Drawing.Color.White;
            this.btnEndProcess.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEndProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEndProcess.HoverColor = System.Drawing.Color.White;
            this.btnEndProcess.Location = new System.Drawing.Point(321, 432);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEndProcess.RoundingArc = 31;
            this.btnEndProcess.Size = new System.Drawing.Size(91, 31);
            this.btnEndProcess.TabIndex = 0;
            this.btnEndProcess.Text = "End Process";
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // processView
            // 
            this.processView.AllowColumnReorder = true;
            this.processView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.processId});
            this.processView.FullRowSelect = true;
            this.processView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.processView.HideSelection = false;
            this.processView.Location = new System.Drawing.Point(12, 37);
            this.processView.MultiSelect = false;
            this.processView.Name = "processView";
            this.processView.Size = new System.Drawing.Size(400, 389);
            this.processView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.processView.TabIndex = 1;
            this.processView.UseCompatibleStateImageBehavior = false;
            this.processView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 120;
            // 
            // processId
            // 
            this.processId.Text = "PID";
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
            this.btnRefresh.Location = new System.Drawing.Point(224, 432);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.RoundingArc = 31;
            this.btnRefresh.Size = new System.Drawing.Size(91, 31);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ProcessViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 475);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.processView);
            this.Controls.Add(this.btnEndProcess);
            this.MinimumSize = new System.Drawing.Size(220, 200);
            this.Name = "ProcessViewer";
            this.Text = "Process Viewer";
            this.Load += new System.EventHandler(this.ProcessViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSuite.MetroButton btnEndProcess;
        private System.Windows.Forms.ListView processView;
        private System.Windows.Forms.ColumnHeader name;
        private MetroSuite.MetroButton btnRefresh;
        private System.Windows.Forms.ColumnHeader processId;
    }
}