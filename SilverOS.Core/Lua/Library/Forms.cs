using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverOS.Core.Lua.Library
{
    class Forms
    {
        public UI.SilverForm New() 
        {
            return new UI.SilverForm();
        }
    }
}
