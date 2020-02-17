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

namespace SilverOS.Core
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
            fs = new FS();
        }

        private FS fs;

        private void DockTimer_Tick(object sender, EventArgs e)
        {
            dockTime.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
        }
    }
}
