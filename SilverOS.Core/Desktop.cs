using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilverOS.IO;
using SilverOS.UI;
using SilverOS.Core.Applications;

namespace SilverOS.Core
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
            fs = new FS();
            processManager = new ProcessManager(this);
            this.Hide();
            Lua.LuaMain.InitializeState();
        }

        public Dictionary<SilverImageButton, Form> dockForms = new Dictionary<SilverImageButton, Form>();
        private static FS fs;

        private static ProcessManager processManager;
        //private static SystemSettings settings;

        public static FS GetFileSystem()
        {
            return fs;
        }

        public static ProcessManager GetProcessManager()
        {
            return processManager;
        }

        public void AddToDock(Form form)
        {
            SilverImageButton icon = new SilverImageButton();
            icon.Size = new Size(40, 40);
            icon.Image = form.Icon.ToBitmap();

            openFormsPanel.Controls.Add(icon);
            dockForms.Add(icon, form);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dockPanel.Hide();

            Login login = new Login();
            if (login.ShowDialog(this) != DialogResult.OK && !login.Authenticated)
                Application.Exit();

            dockPanel.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void DockTimer_Tick(object sender, EventArgs e)
        {
            dockTime.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
        }

        private void Desktop_DoubleClick(object sender, EventArgs e)
        {
            new DoubleClickMenu().ShowDialog(this);
        }

        private void Desktop_Load(object sender, EventArgs e)
        {

        }

        private void Desktop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control)
            {
                
            }
        }
    }
}
