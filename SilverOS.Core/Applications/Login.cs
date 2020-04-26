using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilverOS.UI;
using CefSharp.WinForms;

namespace SilverOS.Core.Applications
{
    public partial class Login : SilverForm
    {
        public Login()
        {
            InitializeComponent();

            ChromiumWebBrowser browser = new ChromiumWebBrowser("localhost:5000/oauth");
            browser.Dock = DockStyle.Fill;
            Controls.Add(browser);
        }
    }
}
