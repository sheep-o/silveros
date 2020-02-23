using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;

namespace SilverOS.Core.Lua
{
    class LuaMain
    {
        public LuaMain() 
        {
            L["Controls"] = new Library.Controls();
            L["Units"]    = new Library.Units();
            L["Forms"]    = new Library.Forms();
            L["FS"]       = new Library.FS();

            DoFile("C:/FileManager.lua");
        }

        private static NLua.Lua L = new NLua.Lua();
        
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

        public static void LoadFile(string path) 
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
