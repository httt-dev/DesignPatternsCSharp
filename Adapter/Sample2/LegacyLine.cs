using System;

namespace Adapter.Sample2
{
    public class LegacyLine
    {
        public LegacyLine()
        {
            
        }
        public void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Drawing line");
        }
    }
}