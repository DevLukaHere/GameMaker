using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMaker
{
    class Toolbar
    {
        public Toolbar(ref Bitmap map,ref Game gra)
        {
            _Map = map;
            _CopyObjectsList = gra.ListaObiektow;
        }

        Bitmap _Map; //mapa
        List<Shape> _CopyObjectsList;

        string _Tool = "Przesun"; //domyslne narzedzie
        Color _MainColor = Color.Red; //domyslny kolor

        int _XPoczatkowe;
        int _YPoczatkowe;
        int _XKoncowe;
        int _YKoncowe;

        //Pedzel
        bool _IsPainting = false; //malowanie przy pedzlu
        List<Point> Punkty = new List<Point>();
        Bitmap _ObiektZwrotny = null;
        //Przesun
        string NazwaObiektu;

        public Bitmap Map { get => _Map; set => _Map = value; }
        public string Tool { get => _Tool; set => _Tool = value; }
        public bool IsPainting { get => _IsPainting; set => _IsPainting = value; }
        public int XPoczatkowe { get => _XPoczatkowe; set => _XPoczatkowe = value; }
        public int YPoczatkowe { get => _YPoczatkowe; set => _YPoczatkowe = value; }
        public Color MainColor { get => _MainColor; set => _MainColor = value; }
        public Bitmap ObiektZwrotny { get => _ObiektZwrotny; set => _ObiektZwrotny = value; }
        public int XKoncowe { get => _XKoncowe; set => _XKoncowe = value; }
        public int YKoncowe { get => _YKoncowe; set => _YKoncowe = value; }
        public List<Shape> CopyObjectsList { get => _CopyObjectsList; set => _CopyObjectsList = value; }

        public void MouseDown(int x, int y)
        {
            switch (Tool)
            {
                case "Pedzel":
                    {
                        IsPainting = true;
                        Punkty.Add(new Point(x, y));

                        XPoczatkowe = x;
                        YPoczatkowe = y;

                        break;
                    }
                case "Przesun":
                    {
                        XPoczatkowe = x;
                        YPoczatkowe = y;
                        NazwaObiektu = PodajNazweObiektu(x, y);
                        break;
                    }
                case "Linia":
                    {
                        System.Windows.Forms.MessageBox.Show(GetSetPixel.Get(Map, x, y,Map.Width,Map.Height).ToString());
                        break;
                    }
                default:
                    break;
            }
        }
        public void MouseMove(int x, int y)
        {
            switch (Tool)
            {
                case "Pedzel":
                    {
                        if (IsPainting == true)
                        {
                            Punkty.Add(new Point(x, y)); //na potrzeby stworzenia obiektu
                            GetSetPixel.Set(_Map, x, y, Color.Black,Map.Width,Map.Height);
                        }
                        break;
                    }
                case "Przesun":
                    {

                        break;
                    }
                default:
                    break;
            }

        }
        public void MouseUp(int x, int y)
        {
            switch (Tool)
            {
                case "Pedzel":
                    {
                        IsPainting = false;
                        Punkty.Add(new Point(x, y));

                        XKoncowe = x;
                        YKoncowe = y;

                        ObiektZwrotny = StworzKreske();
                        break;
                    }
                case "Przesun":
                    {
                        XKoncowe = x;
                        YKoncowe = y;

                        foreach (Shape item in CopyObjectsList)
                        {
                            if(item.Name == NazwaObiektu)
                            {
                                item.X += XKoncowe - XPoczatkowe;
                                item.Y += YKoncowe - YPoczatkowe;
                                break;
                            }
                        }

                        break;
                    }
                case "Linia":
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        private Bitmap StworzKreske()
        {
            int Xmax, Ymax, Xmin, Ymin;

            Xmax = Punkty[0].X;
            Ymax = Punkty[0].Y;
            Xmin = Punkty[0].X;
            Ymin = Punkty[0].Y;

            foreach (Point punkt in Punkty) //szukanie max & min punktow
            {
                if(punkt.X > Xmax)
                {
                    Xmax = punkt.X;
                }
                if (punkt.X < Xmin)
                {
                    Xmin = punkt.X;
                }
                if (punkt.Y > Ymax)
                {
                    Ymax = punkt.Y;
                }
                if (punkt.Y < Ymin)
                {
                    Ymin = punkt.Y;
                }
            }

            int wysokosc, szerokosc;
            
            if((Ymax >= 0 && Ymin >=0) || (Ymax < 0 && Ymin < 0)) //obliczanie miar powstalej kreski
            {
                wysokosc = Math.Abs(Ymax) - Math.Abs(Ymin);
            }
            else
            {
                wysokosc = Math.Abs(Ymax) + Math.Abs(Ymin);
            }

            if ((Xmax >= 0 && Xmin >= 0) || (Xmax < 0 && Xmin < 0))
            {
                szerokosc = Math.Abs(Xmax) - Math.Abs(Xmin);
            }
            else
            {
                szerokosc = Math.Abs(Xmax) + Math.Abs(Xmin);
            }

            Bitmap Obiekt = new Bitmap(1+szerokosc, 1+wysokosc);


            foreach (Point punkt in Punkty) //rysowanie punktow
            {
                GetSetPixel.Set(Obiekt, punkt.X - Math.Abs(Xmin), punkt.Y - Math.Abs(Ymin), MainColor,Obiekt.Width,Obiekt.Height);
            }

            return Obiekt;
        }
        public int[] ObliczLewyGorny()
        {
            int[] Wynik = new int[2];

            int Xmin, Ymin;

            Xmin = Punkty[0].X;
            Ymin = Punkty[0].Y;

            foreach (Point punkt in Punkty) //szukanie max & min punktow
            {
                if (punkt.X < Xmin)
                {
                    Xmin = punkt.X;
                }
                if (punkt.Y < Ymin)
                {
                    Ymin = punkt.Y;
                }
            }

            Wynik[0] = Xmin;
            Wynik[1] = Ymin;

            return Wynik;
        }
        private string PodajNazweObiektu(int x, int y)
        {
            List<Shape> Lista = new List<Shape>();

            foreach (Shape item in CopyObjectsList)
            {
                for (int i = item.X; i < item.X + item.Obrazek.Width; i++)
                {
                    for (int j = item.Y; j < item.Y + item.Obrazek.Height; j++)
                    {
                        if (i == x && j == y)
                        {
                            Lista.Add(item);
                        }
                    }
                }
            }

            if (Lista.Count != 0)
            {
                string MaxNazwa = "Tlo"; //wartosci poczatkowe
                int MaxWarstwa = 0;

                foreach (Shape item in Lista)
                {
                    if (item.Warstwa > MaxWarstwa)
                    {
                        MaxWarstwa = item.Warstwa;
                        MaxNazwa = item.Name;
                    }
                }
                return MaxNazwa;
            }

            return "";
        }
    }
}
