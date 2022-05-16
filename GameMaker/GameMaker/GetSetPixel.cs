using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMaker
{
    static public class GetSetPixel
    {
        static public Color Get(Bitmap map, int x, int y, int Xmax, int Ymax)
        {
            if(x>=0 && x<Xmax && y>=0 && y<Ymax)
            return map.GetPixel(x, y);

            return Color.Empty;
        }

        static public void Set(Bitmap map, int x, int y, Color color,int Xmax, int Ymax)
        {
                if (x >= 0 && x < Xmax && y >= 0 && y < Ymax)
                if (color.ToString() != Color.FromArgb(0, 0, 0, 0).ToString()) //czy kanal alfa
                {
                    map.SetPixel(x, y, color);
                }

        }
        static public Color GetColorOfObject(Shape obiekt, int x, int y, int Xmax, int Ymax)
        {
            if (x >= 0 && x < Xmax && y >= 0 && y < Ymax)
            if (obiekt.Obrazek.GetPixel(x, y).ToString() != Color.FromArgb(0, 0, 0, 0).ToString()) //czy kanal alfa
            {
               return obiekt.Obrazek.GetPixel(x, y);
            }
            return Color.FromArgb(0, 0, 0, 0);
        }
    }
}
