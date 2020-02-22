using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SilverOS.UI;

namespace SilverOS.Core.Applications
{
    public partial class Notes : SilverForm
    {
        public Notes()
        {
            InitializeComponent();
        }

        public Notes(string path)
        {
            InitializeComponent();
            OpenFile(path);
        }

        public void OpenFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            textBox1.Text = sr.ReadToEnd();
        }
    }
}
