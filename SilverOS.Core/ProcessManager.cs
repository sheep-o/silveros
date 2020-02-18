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
            processes.Add(new Process("Desktop", desktop));
        }

        public void StartProcess(Process process)
        {
            processes.Add(process);

            if (process.GetMainForm() != null)
                process.GetMainForm().Show(desktop); process.GetMainForm().TopMost = true;
        }

        public void StopProcess(Process process)
        {
            if (process.GetMainForm() != null)
                process.GetMainForm().Close();

            processes.Remove(process);
        }

        public List<Process> GetProcesses()
        {
            return processes;
        }

        public Process GetProcessById(int id)
        {
            Process proc;
            try
            {
                proc = processes[id];
            }
            catch (Exception)
            {
                proc = null;
            }

            return proc;
        }
    }
}
