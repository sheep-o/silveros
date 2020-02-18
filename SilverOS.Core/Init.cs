using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SilverOS.Core
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            new Desktop().Show();
            Hide();
        }
    }
}
