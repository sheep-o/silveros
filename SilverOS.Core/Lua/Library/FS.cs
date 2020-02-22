using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core.Lua.Library
{
    class FS
    {
        public string ReadAllText(string path)
        {
            string read = string.Empty;

            try
            {
                read = File.ReadAllText(Utility.NormalizePath(path));
            }
            catch (Exception)
            {
                throw;
            }

            return read;
        }

        public bool WriteAllText(string path, string text_to_write)
        {
            try
            {
                File.WriteAllText(Utility.NormalizePath(path), text_to_write);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteFile(string path)
        {
            try
            {
                File.Delete(Utility.NormalizePath(path));
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }

        public bool CopyFile(string source_path, string destination_path)
        {
            try
            {
                File.Copy(Utility.NormalizePath(source_path), destination_path);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
    }
}
