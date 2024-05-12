using System;

namespace Adapter.Sample2
{
    public class LegacyRectangle
    {
        public LegacyRectangle()
        {
            
        }

        public void Draw(int x, int y, int w, int h)
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}