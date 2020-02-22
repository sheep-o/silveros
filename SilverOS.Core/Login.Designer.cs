namespace SilverOS.Core
{
    partial class Login
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
            this.tabControl = new MetroSuite.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.confirmPassword = new MetroSuite.MetroTextbox();
            this.registerPassword = new MetroSuite.MetroTextbox();
            this.registerUsername = new MetroSuite.MetroTextbox();
            this.registerEmail = new MetroSuite.MetroTextbox();
            this.Register = new MetroSuite.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.signinPassword = new MetroSuite.MetroTextbox();
            this.signinUsername = new MetroSuite.MetroTextbox();
            this.SignIn = new MetroSuite.MetroButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.tabControl.Appearance = System.Windows.Forms.Appearance.Normal;
            this.tabControl.AutoStyle = false;
            this.tabControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabControl.HasAnimation = false;
            this.tabControl.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(115)))), ((int)(((byte)(124)))));
            this.tabControl.HeaderItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControl.HotTrack = true;
            this.tabControl.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControl.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControl.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabControl.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabControl.ItemSize = new System.Drawing.Size(212, 45);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControl.SelectedForeColor = System.Drawing.Color.White;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControl.SelectedItemLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControl.SelectedTabIsBold = false;
            this.tabControl.Size = new System.Drawing.Size(429, 375);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Style = MetroSuite.Design.Style.Custom;
            this.tabControl.TabContainerColor = System.Drawing.Color.Transparent;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.confirmPassword);
            this.tabPage1.Controls.Add(this.registerPassword);
            this.tabPage1.Controls.Add(this.registerUsername);
            this.tabPage1.Controls.Add(this.registerEmail);
            this.tabPage1.Controls.Add(this.Register);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.confirmPassword.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.confirmPassword.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.confirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.confirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.confirmPassword.HideSelection = false;
            this.confirmPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.confirmPassword.LineOnly = true;
            this.confirmPassword.Location = new System.Drawing.Point(62, 191);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '\0';
            this.confirmPassword.ShortcutsEnabled = false;
            this.confirmPassword.Size = new System.Drawing.Size(298, 30);
            this.confirmPassword.Style = MetroSuite.Design.Style.Dark;
            this.confirmPassword.TabIndex = 12;
            this.confirmPassword.UseSystemPasswordChar = true;
            this.confirmPassword.Watermark = "Confirm Password";
            this.confirmPassword.WordWrap = false;
            // 
            // registerPassword
            // 
            this.registerPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.registerPassword.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registerPassword.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.registerPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.registerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.registerPassword.HideSelection = false;
            this.registerPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.registerPassword.LineOnly = true;
            this.registerPassword.Location = new System.Drawing.Point(62, 140);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '\0';
            this.registerPassword.ShortcutsEnabled = false;
            this.registerPassword.Size = new System.Drawing.Size(298, 30);
            this.registerPassword.Style = MetroSuite.Design.Style.Dark;
            this.registerPassword.TabIndex = 11;
            this.registerPassword.UseSystemPasswordChar = true;
            this.registerPassword.Watermark = "Password";
            this.registerPassword.WordWrap = false;
            // 
            // registerUsername
            // 
            this.registerUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.registerUsername.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registerUsername.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.registerUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.registerUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.registerUsername.HideSelection = false;
            this.registerUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.registerUsername.LineOnly = true;
            this.registerUsername.Location = new System.Drawing.Point(61, 88);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.PasswordChar = '\0';
            this.registerUsername.ShortcutsEnabled = false;
            this.registerUsername.Size = new System.Drawing.Size(298, 30);
            this.registerUsername.Style = MetroSuite.Design.Style.Dark;
            this.registerUsername.TabIndex = 10;
            this.registerUsername.UseSystemPasswordChar = true;
            this.registerUsername.Watermark = "Display Name";
            this.registerUsername.WordWrap = false;
            // 
            // registerEmail
            // 
            this.registerEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.registerEmail.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registerEmail.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.registerEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.registerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.registerEmail.HideSelection = false;
            this.registerEmail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.registerEmail.LineOnly = true;
            this.registerEmail.Location = new System.Drawing.Point(61, 37);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.PasswordChar = '\0';
            this.registerEmail.ShortcutsEnabled = false;
            this.registerEmail.Size = new System.Drawing.Size(298, 30);
            this.registerEmail.Style = MetroSuite.Design.Style.Dark;
            this.registerEmail.TabIndex = 9;
            this.registerEmail.Watermark = "Email";
            this.registerEmail.WordWrap = false;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Register.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Register.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Register.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Register.Location = new System.Drawing.Point(147, 245);
            this.Register.Name = "Register";
            this.Register.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Register.RoundingArc = 41;
            this.Register.Size = new System.Drawing.Size(122, 41);
            this.Register.Style = MetroSuite.Design.Style.Dark;
            this.Register.TabIndex = 8;
            this.Register.Text = "Register";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.signinPassword);
            this.tabPage2.Controls.Add(this.signinUsername);
            this.tabPage2.Controls.Add(this.SignIn);
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign In";
            // 
            // signinPassword
            // 
            this.signinPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signinPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.signinPassword.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.signinPassword.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.signinPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.signinPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.signinPassword.HideSelection = false;
            this.signinPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.signinPassword.LineOnly = true;
            this.signinPassword.Location = new System.Drawing.Point(61, 120);
            this.signinPassword.Name = "signinPassword";
            this.signinPassword.PasswordChar = '\0';
            this.signinPassword.ShortcutsEnabled = false;
            this.signinPassword.Size = new System.Drawing.Size(298, 30);
            this.signinPassword.Style = MetroSuite.Design.Style.Dark;
            this.signinPassword.TabIndex = 6;
            this.signinPassword.UseSystemPasswordChar = true;
            this.signinPassword.Watermark = "Password";
            this.signinPassword.WordWrap = false;
            // 
            // signinUsername
            // 
            this.signinUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signinUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.signinUsername.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.signinUsername.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.signinUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.signinUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.signinUsername.HideSelection = false;
            this.signinUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.signinUsername.LineOnly = true;
            this.signinUsername.Location = new System.Drawing.Point(61, 69);
            this.signinUsername.Name = "signinUsername";
            this.signinUsername.PasswordChar = '\0';
            this.signinUsername.ShortcutsEnabled = false;
            this.signinUsername.Size = new System.Drawing.Size(298, 30);
            this.signinUsername.Style = MetroSuite.Design.Style.Dark;
            this.signinUsername.TabIndex = 5;
            this.signinUsername.Watermark = "Username";
            this.signinUsername.WordWrap = false;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Transparent;
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.SignIn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SignIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SignIn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.SignIn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SignIn.Location = new System.Drawing.Point(146, 213);
            this.SignIn.Name = "SignIn";
            this.SignIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SignIn.RoundingArc = 41;
            this.SignIn.Size = new System.Drawing.Size(122, 41);
            this.SignIn.Style = MetroSuite.Design.Style.Dark;
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "Sign In";
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(429, 375);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSuite.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroSuite.MetroTextbox confirmPassword;
        private MetroSuite.MetroTextbox registerPassword;
        private MetroSuite.MetroTextbox registerUsername;
        private MetroSuite.MetroTextbox registerEmail;
        private MetroSuite.MetroButton Register;
        private MetroSuite.MetroTextbox signinPassword;
        private MetroSuite.MetroTextbox signinUsername;
        private MetroSuite.MetroButton SignIn;
    }
}