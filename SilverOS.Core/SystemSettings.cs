using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SilverOS.Core.Applications;
using SilverOS.UI;

namespace SilverOS.Core
{
    public class SystemSettings
    {
        private Dictionary<string, string> mimeTypes = new Dictionary<string, string>();

        public SystemSettings()
        {
            mimeTypes = Utility.ParseFile(Properties.Resources.mime);
        }

        public string GetMimeByExtension(string extension)
        {
            if (!mimeTypes.ContainsKey(extension)) return null;
            return mimeTypes[extension];
        }
    }
}
