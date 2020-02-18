using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOS.Core
{
    public class Process
    {
        private int processID;
        private Form mainForm;

        public Process(Form form)
        {
            mainForm = form;
        }

        public void Start()
        {
            processID = Desktop.GetProcessManager().GetProcesses().Count;
            Desktop.GetProcessManager().StartProcess(this);
        }

        public void Stop()
        {
            Desktop.GetProcessManager().StopProcess(this);
            processID = -1;
        }

        public int GetProcessID() { return processID; }
        public Form GetMainForm() { return mainForm; }
    }
}
