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
        LuaMain() 
        {
            
        }

        private static NLua.Lua L = new NLua.Lua();

        public static void LoadString(string script) 
        {
            L.DoString(script);
        }

        public static void LoadFile(string path) 
        {
            L.DoFile(path);
        }
    }
}
