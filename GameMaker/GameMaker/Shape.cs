using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMaker
{
    public class Shape
    {
        string _Name = ""; //zmienne orientacyjne
        Bitmap _Obrazek = null;
        int _X = -1;
        int _Y = -1;
        int _Szerokosc = -1;
        int _Wysokosc = -1;

        int _Warstwa = -1; //zmienne inne
        int _Typ = -1;
        bool _CzyWidzialny = true;

        public Shape()
        {
            Name = "";
            Obrazek = null;
            X = 0;
            Y = 0;
            Szerokosc = 0;
            Wysokosc = 0;
        }
        public Shape(string name, Bitmap obrazek,int x, int y,int typ)
        {
            Name = name;
            Obrazek = new Bitmap(obrazek);
            X = x;
            Y = y;
            Szerokosc = obrazek.Width;
            Wysokosc = obrazek.Height;
            Typ = typ;
        }
        public Shape(Shape shape)
        {
            _Name = shape.Name;
            _Obrazek = new Bitmap(shape.Obrazek);
            _X = shape.X;
            _Y = shape.Y;
            _Szerokosc = shape.Szerokosc;
            _Wysokosc = shape.Wysokosc;

            _Warstwa = shape.Warstwa;
            _Typ = shape.Typ;
            CzyWidzialny = shape.CzyWidzialny;
        }

        public string Name { get => _Name; set => _Name = value; }
        public Bitmap Obrazek { get => _Obrazek; set => _Obrazek = value; }
        public int X { get => _X; set => _X = value; }
        public int Y { get => _Y; set => _Y = value; }
        public int Szerokosc { get => _Szerokosc; set => _Szerokosc = value; }
        public int Wysokosc { get => _Wysokosc; set => _Wysokosc = value; }
        public int Warstwa { get => _Warstwa; set => _Warstwa = value; }
        public int Typ { get => _Typ; set => _Typ = value; }
        public bool CzyWidzialny { get => _CzyWidzialny; set => _CzyWidzialny = value; }
    }
}
