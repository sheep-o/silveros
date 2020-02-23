using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverOS.Core.Lua.Library
{
    class Controls
    {
        public MetroSuite.MetroButton Button(UI.SilverForm form) 
        {
            MetroSuite.MetroButton control = new MetroSuite.MetroButton();
            form.Controls.Add(control);
            return control;
        }

        public ListView ListView(UI.SilverForm form) 
        {
            ListView control = new ListView();
            form.Controls.Add(control);
            return control;
        }
    }
}
