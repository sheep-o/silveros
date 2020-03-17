using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core.Lua.Library
{
    class SilverSystem
    {
        public void ExecuteLua(string code) 
        {
            LuaMain.DoString(code);
        }
    }
}
