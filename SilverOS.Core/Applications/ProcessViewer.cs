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

namespace SilverOS.Core
{
    public partial class ProcessViewer : SilverForm
    {
        public ProcessViewer()
        {
            InitializeComponent();
        }

        private void ProcessViewer_Load(object sender, EventArgs e)
        {
            foreach (Process p in Desktop.GetProcessManager().GetProcesses())
            {
                processView.Items.Add(new ListViewItem(new string[] { p.GetName(), p.GetID().ToString() }));
            }
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            if (processView.SelectedItems.Count > 0)
            {
                Process p = Desktop.GetProcessManager().GetProcessById(int.Parse(processView.SelectedItems[0].SubItems[1].Text));
                p.Stop();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            processView.Items.Clear();
            foreach (Process p in Desktop.GetProcessManager().GetProcesses())
            {
                processView.Items.Add(new ListViewItem(new string[] { p.GetName(), p.GetID().ToString() }));
            }
        }
    }
}
