using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core
{
    public class ProcessManager
    {
        private Desktop desktop;
        private List<Process> processes;

        public ProcessManager(Desktop desktop)
        {
            this.desktop = desktop;
            processes = new List<Process>();
            processes.Add(new Process(desktop));
        }

        public void StartProcess(Process process)
        {
            processes.Add(process);
            process.GetMainForm().TopMost = true;
            process.GetMainForm().Show(desktop);
        }

        public void StopProcess(Process process)
        {
            process.GetMainForm().Close();
            processes.Remove(process);
        }

        public List<Process> GetProcesses()
        {
            return processes;
        }

        public Process GetProcessById(int id)
        {
            return processes[id];
        }
    }
}
