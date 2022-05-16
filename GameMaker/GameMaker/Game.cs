using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMaker
{
    public class Game
    {
        public Game(string nazwa, int szerokoscBitmapy, int wysokoscBitmapy,List<Shape> listaObiektow, List<String> listaSterowanie)
        {
            Nazwa = nazwa;
            SzerokoscBitmapy = szerokoscBitmapy;
            WysokoscBitmapy = wysokoscBitmapy;
            _ListaObiektow = listaObiektow;
            Sterowanie = listaSterowanie;
        }
        public Game(Game gra)
        {
            _Nazwa = gra.Nazwa;
            _SzerokoscBitmapy = gra.SzerokoscBitmapy;
            _WysokoscBitmapy = gra.WysokoscBitmapy;

            _ListaObiektow = new List<Shape>();
            foreach (Shape item in gra.ListaObiektow)
            {
                _ListaObiektow.Add(new Shape(item));
            }

            _Sterowanie = new List<String>();
            foreach (String item in gra.Sterowanie)
            {
                _Sterowanie.Add(item);
            }

            _NumerObiektuSterowanego = gra.NumerObiektuSterowanego;
        }

        string _Nazwa = "";
        int _SzerokoscBitmapy = -1;
        int _WysokoscBitmapy = -1;
        List<Shape> _ListaObiektow = null;
        List<String> _Sterowanie = null;

        int _NumerObiektuSterowanego = -1;

        public List<Shape> ListaObiektow { get => _ListaObiektow; set => _ListaObiektow = value; }
        public string Nazwa { get => _Nazwa; set => _Nazwa = value; }
        public int SzerokoscBitmapy { get => _SzerokoscBitmapy; set => _SzerokoscBitmapy = value; }
        public int WysokoscBitmapy { get => _WysokoscBitmapy; set => _WysokoscBitmapy = value; }
        public List<string> Sterowanie { get => _Sterowanie; set => _Sterowanie = value; }
        public int NumerObiektuSterowanego { get => _NumerObiektuSterowanego; set => _NumerObiektuSterowanego = value; }
    }
}
