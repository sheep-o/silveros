using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace SilverOS.Core
{
    public partial class Login : Form
    {
        private bool authenticated = false;
        public bool Authenticated { get { return authenticated; } }

        public Login()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotImplemented", "Exception");
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skipping authentication!", ":(");
            authenticated = true;
        }
    }
}
