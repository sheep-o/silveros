using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core
{
    class Utility
    {
        public static string FixPath(string realPath) 
        {
            string silverPath = realPath.Replace(Environment.GetEnvironmentVariable("appdata").Replace("\\", "/") + "/SilverOS/files/Drives/C/", "C:/");
            silverPath = realPath.Replace(Environment.GetEnvironmentVariable("appdata").Replace("\\", "/") + "/SilverOS/files/Drives/C", "C:/");
            return silverPath;
        }

        public static string NormalizePath(string silverPath) 
        {
            string realPath = silverPath.Replace("C:/", Environment.GetEnvironmentVariable("appdata").Replace("\\", "/") + "/SilverOS/files/Drives/C/");
            return realPath;
        }

        public static Dictionary<string, string> ParseFile(string contents)
        {
            Dictionary<string, string> rows = new Dictionary<string, string>();
            foreach (string row in contents.Split('\n'))
            {
                string[] columns = row.Split(',');
                rows.Add(columns[0].Trim(), columns[1].Trim());
            }
            return rows;
        }
    }
}
