﻿using NLua;
using ScintillaNET;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SilverOS.Core.Lua.Library
{
    class Controls
    {
        public Dictionary<Control, LuaFunction> controlToLua = new Dictionary<Control, LuaFunction>();

        public MetroSuite.MetroButton Button(UI.SilverForm form) 
        {
            MetroSuite.MetroButton control = new MetroSuite.MetroButton();
            form.Controls.Add(control);
            return control;
        }

        public MetroSuite.MetroTextbox Textbox(UI.SilverForm form)
        {
            MetroSuite.MetroTextbox control = new MetroSuite.MetroTextbox();
            form.Controls.Add(control);
            return control;
        }

        public RichTextBox RichTextBox(UI.SilverForm form)
        {
            RichTextBox control = new RichTextBox();
            form.Controls.Add(control);
            return control;
        }

        public ScintillaNET.Scintilla Scintilla(UI.SilverForm form)
        {
            ScintillaNET.Scintilla control = new ScintillaNET.Scintilla();

            // sheep, what is this stupid

            var alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Not sure what the next 3 lines are :/
            var numericChars = "0123456789";
            var accentedChars = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";

            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            control.StyleResetDefault();
            control.Styles[Style.Default].Font = "Consolas";
            control.Styles[Style.Default].Size = 15;

            control.StyleClearAll();



            // Configure the Lua lexer styles
            control.Styles[Style.Lua.Default].ForeColor = Color.Silver;
            control.Styles[Style.Lua.Comment].ForeColor = Color.Green;
            control.Styles[Style.Lua.CommentLine].ForeColor = Color.Green;
            control.Styles[Style.Lua.Number].ForeColor = Color.Olive;
            control.Styles[Style.Lua.Word].ForeColor = Color.Blue;
            control.Styles[Style.Lua.Word2].ForeColor = Color.BlueViolet;
            control.Styles[Style.Lua.Word3].ForeColor = Color.DarkSlateBlue;
            control.Styles[Style.Lua.Word4].ForeColor = Color.DarkSlateBlue;
            control.Styles[Style.Lua.String].ForeColor = Color.Red;
            control.Styles[Style.Lua.Character].ForeColor = Color.Red;
            control.Styles[Style.Lua.LiteralString].ForeColor = Color.Red;
            control.Styles[Style.Lua.StringEol].BackColor = Color.Pink;
            control.Styles[Style.Lua.Operator].ForeColor = Color.Purple;
            control.Styles[Style.Lua.Preprocessor].ForeColor = Color.Maroon;
            control.Lexer = Lexer.Lua;
            control.WordChars = alphaChars + numericChars + accentedChars;

            // Console.WriteLine(scintilla1.DescribeKeywordSets());

            // Keywords
            control.SetKeywords(0, "not and break do else elseif end for function if in local nil not or repeat return then until while" + " false true" + " goto");
            // Basic Functions
            control.SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug" + " getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
            // String Manipulation & Mathematical
            control.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan" + " string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult" + " bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift" + " utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
            // Input and Output Facilities and System Facilities
            control.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname" + " coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath" + " require package.cpath package.loaded package.loadlib package.path package.preload");

            // Instruct the lexer to calculate folding
            control.SetProperty("fold", "1");
            control.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            control.Margins[2].Type = MarginType.Symbol;
            control.Margins[2].Mask = Marker.MaskFolders;
            control.Margins[2].Sensitive = true;
            control.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                control.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                control.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            control.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            control.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            control.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            control.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            control.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            control.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            control.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;




            // Enable automatic folding
            control.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            form.Controls.Add(control);
            return control;
        }
        public FastColoredTextBoxNS.FastColoredTextBox FCTB(UI.SilverForm form)
        {
            FastColoredTextBoxNS.FastColoredTextBox control = new FastColoredTextBoxNS.FastColoredTextBox();
            control.Language = FastColoredTextBoxNS.Language.Lua;
            form.Controls.Add(control);
            return control;
        }

        public ListView ListView(UI.SilverForm form) 
        {
            ListView control = new ListView();
            form.Controls.Add(control);
            return control;
        }

        public void BindClick(Control control, NLua.LuaFunction function) 
        {
            control.MouseClick += Control_MouseClick;
            controlToLua.Add(control, function);
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            LuaFunction luaFunction;
            controlToLua.TryGetValue((Control)sender, out luaFunction);

            luaFunction.Call();
        }
    }
}
