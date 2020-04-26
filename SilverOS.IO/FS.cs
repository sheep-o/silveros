using System;
using System.IO;

namespace SilverOS.IO
{
    public class FS
    {
        private string systemDirectory = Environment.GetEnvironmentVariable("appdata").Replace("\\", "/") + "/SilverOS/drive/";

        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(systemDirectory + path);
        }

        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(systemDirectory + path);
        }

        public bool Exists(string path)
        {
            return Directory.Exists(systemDirectory + path);
        }

        public void Delete(string path)
        {
            Directory.Delete(systemDirectory + path);
        }
    }
}
