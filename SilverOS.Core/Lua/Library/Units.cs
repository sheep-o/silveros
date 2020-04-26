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

        public System.Drawing.Color NewRGB(int r, int g, int b)
        {
            return System.Drawing.Color.FromArgb(r, g, b);
        }

        public System.Drawing.Font NewFont(string fontName, int size) 
        {
            return new System.Drawing.Font(fontName, size, System.Drawing.FontStyle.Regular);
        }
    }
}
