using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilverOS.UI;

namespace SilverOS.Core.Applications
{
    public partial class Files : SilverForm
    {
        public Files()
        {
            InitializeComponent();
        }

        private string currentDirectory = "";
        private string CurrentDirectory
        {
            get { return currentDirectory.Replace("drive://", Environment.GetEnvironmentVariable("appdata") + "/SilverOS/drive/").Replace("\\", "/"); }
            set { currentDirectory = value; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            currentDirectory = "drive://";
            directoryLocation.Text = currentDirectory;

            RefreshDirectory();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            RefreshDirectory();
        }

        private void directoryLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            RefreshDirectory();
        }

        private void RefreshDirectory()
        {
            string path = CurrentDirectory;
            DirectoryInfo root = new DirectoryInfo(path);
            listView1.Clear();

            foreach (DirectoryInfo dir in root.GetDirectories())
            {
                listView1.Items.Add(new ListViewItem(dir.Name, imageList.Images.IndexOfKey("folder")));
            }

            foreach (FileInfo file in root.GetFiles())
            {
                int i;
                string mime = Desktop.GetSettings().GetMimeByExtension(file.Extension.Substring(1));
                if (mime != null)
                    i = imageList.Images.IndexOfKey(mime);
                else
                    i = imageList.Images.IndexOfKey("file");
                listView1.Items.Add(new ListViewItem(file.Name, i));
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem == null) return;

            if (Path.GetExtension(selectedItem.Text) == ".txt")
                new Process("Notes", new Notes(CurrentDirectory + selectedItem.Text)).Start();
        }
    }
}
