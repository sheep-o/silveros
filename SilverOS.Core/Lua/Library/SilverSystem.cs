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
