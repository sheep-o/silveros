using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverOS.Core.Applications;
using SilverOS.UI;

namespace SilverOS.Core
{
    public class SystemSettings
    {
        private Dictionary<string, SilverForm> defaultApplications = new Dictionary<string, SilverForm>();

        public static readonly int RequestTimeout = 30000;

        public SystemSettings()
        {
        }

        public void SetDefaultApplication(string extension, SilverForm app)
        {
            defaultApplications.Add(extension, app);
        }

        public SilverForm GetDefaultApplication(string extension)
        {
            if (!defaultApplications.ContainsKey(extension)) return null;
            return defaultApplications[extension];
        }
    }
}
