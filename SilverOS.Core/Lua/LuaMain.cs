using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;

namespace SilverOS.Core.Lua
{
    static class LuaMain
    {
        private static NLua.Lua L;

        public static void InitializeState() 
        {
            L = new NLua.Lua();
            L["Controls"] = new Library.Controls();
            L["System"] = new Library.SilverSystem();
            L["Units"] = new Library.Units();
            L["Forms"] = new Library.Forms();
            L["FS"] = new Library.FS();
        }

        public static NLua.Lua GetState() 
        {
            return L;
        }

        public static void DoString(string script) 
        {
            try
            {
                L.DoString(script);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void DoFile(string path) 
        {
            try
            {
                L.DoFile(path);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
