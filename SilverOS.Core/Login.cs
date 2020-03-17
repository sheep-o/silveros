using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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
            RestClient client = new RestClient("https://silverapi-one.glitch.me/accounts/login");
            client.Timeout = 10000;

            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", signinUsername.Text);
            request.AddParameter("password", signinPassword.Text);

            IRestResponse response = client.Execute(request);
            
            authenticated = true;
        }
    }
}
