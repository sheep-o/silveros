using System;
using System.IO;

namespace SilverOS.IO
{
    public class Directory
    {
        private string systemDirectory = Environment.GetEnvironmentVariable("appdata").Replace("\\", "/") + "/SilverOS/drive/";

        public string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(systemDirectory + path);
        }

        public string[] GetDirectories(string path)
        {
            return System.IO.Directory.GetDirectories(systemDirectory + path);
        }

        public bool Exists(string path)
        {
            return System.IO.Directory.Exists(systemDirectory + path);
        }

        public void Delete(string path)
        {
            System.IO.Directory.Delete(systemDirectory + path);
        }
    }
}
