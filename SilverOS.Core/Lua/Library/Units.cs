using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core.Lua.Library
{
    class Units
    {
        public System.Drawing.Point NewPoint(int x, int y) 
        {
            return new System.Drawing.Point(x, y);
        }

        public System.Drawing.Size NewSize(int width, int height)
        {
            return new System.Drawing.Size(width, height);
        }
    }
}
