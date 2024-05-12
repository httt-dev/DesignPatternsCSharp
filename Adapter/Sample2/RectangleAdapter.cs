using System;

namespace Adapter.Sample2
{
    public class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            this._legacyRectangle = legacyRectangle;
        }
        public void Draw(int x1, int y1, int x2, int y2)
        {
            // convert x1, y1 , x2 , y2 to x , y , w , h
            // xac dinh top / left
            /*
                point1 = x1,y1
                point2 = x2,y2 
                legacy rectangle need : 
             */
            
            int x = Math.Min(x1, x2);
            int y = Math.Max(y1, y2);

            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);
            
            _legacyRectangle.Draw(x,y,w,h);
            
        }
    }
}