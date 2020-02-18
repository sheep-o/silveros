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
        private int ID;
        private Form mainForm;
        private string Name;

        public Process(string name, Form form)
        {
            Name = name;
            mainForm = form;
        }

        public void Start()
        {
            ID = Desktop.GetProcessManager().GetProcesses().Count;
            Desktop.GetProcessManager().StartProcess(this);
        }

        public void Stop()
        {
            Desktop.GetProcessManager().StopProcess(this);
            ID = -1;
        }

        public int GetID() { return ID; }
        public Form GetMainForm() { return mainForm; }
        public string GetName() { return Name; }
    }
}
