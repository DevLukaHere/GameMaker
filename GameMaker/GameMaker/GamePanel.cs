using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
namespace GameMaker
{
    public partial class GamePanel : Form
    {
        public GamePanel(Game aktualnaGra)
        {
            InitializeComponent();
            AktualnaGra = aktualnaGra;

            this.Text = aktualnaGra.Nazwa;
            this.Width = SzerokoscPlanszy;
            this.Height = WysokoscPlanszy;
            PanelGame.Width = SzerokoscPlanszy;
            PanelGame.Height = WysokoscPlanszy;
            GamePictureBox.Width = SzerokoscPlanszy;
            GamePictureBox.Height = WysokoscPlanszy;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            PoprzedniaPozycjaObiektuSterowanego = new Shape(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego]);
            MapStartFrame();
            MapaKolizji = GenerujMapeKolizji();

        }

        int SzerokoscPlanszy = 1600;
        int WysokoscPlanszy = 900;

        Game _AktualnaGra;
        Bitmap _KlatkaStartowa;
        String[,] MapaKolizji;

        //zmienne techniczne
        int FPS = 0;
        List<string> _Ruchy = new List<string>();
        Shape _PoprzedniaPozycjaObiektuSterowanego;
        int _IlePixeliPrzesunac = 5;
        Bitmap _KlatkaStartowaBezZnikaczy;
        int _iloscZnikaczy = 0;
        bool _CzyWygrana = false;

        public Game AktualnaGra { get => _AktualnaGra; set => _AktualnaGra = value; }
        public Bitmap KlatkaStartowa { get => _KlatkaStartowa; set => _KlatkaStartowa = value; }
        public int IlePixeliPrzesunac { get => _IlePixeliPrzesunac; set => _IlePixeliPrzesunac = value; }
        public List<string> Ruchy { get => _Ruchy; set => _Ruchy = value; }
        public Shape PoprzedniaPozycjaObiektuSterowanego { get => _PoprzedniaPozycjaObiektuSterowanego; set => _PoprzedniaPozycjaObiektuSterowanego = value; }
        public int IloscZnikaczy { get => _iloscZnikaczy; set => _iloscZnikaczy = value; }
        public Bitmap KlatkaStartowaBezZnikaczy { get => _KlatkaStartowaBezZnikaczy; set => _KlatkaStartowaBezZnikaczy = value; }
        public bool CzyWygrana { get => _CzyWygrana; set => _CzyWygrana = value; }

        private void GamePanel_Load(object sender, EventArgs e)
        {

        }
        private void MapStartFrame()
        {
            KlatkaStartowa = new Bitmap(AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
            KlatkaStartowaBezZnikaczy = new Bitmap(AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
            foreach (Shape item in AktualnaGra.ListaObiektow)
            {
                for (int i = 0; i < item.Wysokosc; i++)
                {
                    for (int j = 0; j < item.Szerokosc; j++)
                    {
                        if (item != AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego] && item.CzyWidzialny == true)
                        {
                            GetSetPixel.Set(KlatkaStartowa, item.X + j, item.Y + i, GetSetPixel.Get(item.Obrazek, j, i, item.Szerokosc, item.Wysokosc), AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
                        }
                    }
                }

                for (int i = 0; i < item.Wysokosc; i++)
                {
                    for (int j = 0; j < item.Szerokosc; j++)
                    {
                        if (item != AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego] && item.CzyWidzialny == true && item.Typ != 2)
                        {
                            GetSetPixel.Set(KlatkaStartowaBezZnikaczy, item.X + j, item.Y + i, GetSetPixel.Get(item.Obrazek, j, i, item.Szerokosc, item.Wysokosc), AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
                        }
                    }
                }
            }

            GamePictureBox.Image = new Bitmap(AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
            GamePictureBox.Image = new Bitmap(KlatkaStartowa);

        } //generowanie klatki startowej (statycznej)
        private void RenderFrame() //Wyswietlenie obecnego stanu gry (nowa klatka)
        {
            WstawObiektSterowany();

            GamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void WykonajRuchy(string czynnosc)
        {
            switch (czynnosc)
            {
                case "MoveUp":
                    {
                        Przesun(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego], czynnosc);
                        break;
                    }
                case "MoveDown":
                    {
                        Przesun(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego], czynnosc);
                        break;
                    }
                case "MoveLeft":
                    {
                        Przesun(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego], czynnosc);
                        break;
                    }
                case "MoveRight":
                    {
                        Przesun(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego], czynnosc);
                        break;
                    }
                case "Pause":
                    {
                        MessageBox.Show("Pauza!");
                        break;
                    }
                case "Exit":
                    {
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }
        private void Przesun(Shape obiekt, string kierunek)
        {
            try
            {
                switch (kierunek)
                {
                    case "MoveUp":
                        {
                            if (obiekt.Y - IlePixeliPrzesunac >= 0) //normalny ruch
                            {
                                obiekt.Y -= IlePixeliPrzesunac;
                            }
                            else
                            {
                                for (int i = 0; i < IlePixeliPrzesunac; i++)
                                {
                                    if(obiekt.Y - 1 >= 0) //pixele mniejsze niz jedno przesuniecie || obiekt ,,sciana'
                                    {
                                        obiekt.Y--;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            for (int i = 0; i < IlePixeliPrzesunac; i++)
                            {
                                if (TypObiektu(CzyJestKolizja()) == 1)
                                {
                                    obiekt.Y++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            break;
                        }
                    case "MoveDown":
                        {
                            if (obiekt.Y + IlePixeliPrzesunac < AktualnaGra.WysokoscBitmapy - AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Wysokosc)
                            {
                                obiekt.Y += IlePixeliPrzesunac;
                            }
                            else
                            {
                                for (int i = 0; i < IlePixeliPrzesunac; i++)
                                {
                                    if (obiekt.Y + 1 < AktualnaGra.WysokoscBitmapy - AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Wysokosc)
                                    {
                                        obiekt.Y++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            for (int i = 0; i < IlePixeliPrzesunac; i++)
                            {
                                if (TypObiektu(CzyJestKolizja()) == 1)
                                {
                                    obiekt.Y--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            break;
                        }
                    case "MoveLeft":
                        {
                            if (obiekt.X - IlePixeliPrzesunac >= 0)
                            {
                                obiekt.X -= IlePixeliPrzesunac;
                            }
                            else
                            {
                                for (int i = 0; i < IlePixeliPrzesunac; i++)
                                {
                                    if (obiekt.X - 1 >= 0)
                                    {
                                        obiekt.X--;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            for (int i = 0; i < IlePixeliPrzesunac; i++)
                            {
                                if (TypObiektu(CzyJestKolizja()) == 1)
                                {
                                    obiekt.X++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            break;
                        }
                    case "MoveRight":
                        {
                            if (obiekt.X + IlePixeliPrzesunac < AktualnaGra.SzerokoscBitmapy - AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Szerokosc)
                            {
                                obiekt.X += IlePixeliPrzesunac;
                            }
                            else
                            {
                                for (int i = 0; i < IlePixeliPrzesunac; i++)
                                {
                                    if (obiekt.X + 1 < AktualnaGra.SzerokoscBitmapy - AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Szerokosc)
                                    {
                                        obiekt.X++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            for (int i = 0; i < IlePixeliPrzesunac; i++)
                            {
                                if (TypObiektu(CzyJestKolizja()) == 1)
                                {
                                    obiekt.X--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Blad przy przesuwaniu obiektu sterowanego!");
                throw Ex;
            }
        }
        private void WstawObiektSterowany()  
        {
            for (int i = 0; i < PoprzedniaPozycjaObiektuSterowanego.Wysokosc; i++) //usun z planszy
            {
                for (int j = 0; j < PoprzedniaPozycjaObiektuSterowanego.Szerokosc; j++)
                {
                    GetSetPixel.Set((Bitmap)GamePictureBox.Image, PoprzedniaPozycjaObiektuSterowanego.X + j, PoprzedniaPozycjaObiektuSterowanego.Y + i, GetSetPixel.Get(KlatkaStartowa, PoprzedniaPozycjaObiektuSterowanego.X + j, PoprzedniaPozycjaObiektuSterowanego.Y + i, KlatkaStartowa.Width, KlatkaStartowa.Height), GamePictureBox.Image.Width, GamePictureBox.Image.Height);
                }
            }

            for (int i = 0; i < AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Wysokosc; i++) //wklej na planszę
            {
                for (int j = 0; j < AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Szerokosc; j++)
                {
                    GetSetPixel.Set((Bitmap)GamePictureBox.Image, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].X + j, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Y + i, GetSetPixel.Get(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Obrazek, j, i, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Szerokosc, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Wysokosc), GamePictureBox.Image.Width, GamePictureBox.Image.Height);
                }
            }

            PoprzedniaPozycjaObiektuSterowanego = new Shape(AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego]);
            GamePictureBox.Refresh();
        } //usuniecie obecnego obiektu sterujacego, wklejenie go na nowej pozycji
        private void GamePanel_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) //dodaje klikniety ruch do listy
        {
            foreach (string item in AktualnaGra.Sterowanie)
            {
                if (Keyboard.IsKeyDown((Key)int.Parse(item.Split(';')[0])))
                {
                    if (!Ruchy.Contains(item.Split(';')[1]))
                    {
                        Ruchy.Add(item.Split(';')[1]);
                    }
                }
            }
        }
        private void GamePanel_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            foreach (string item in AktualnaGra.Sterowanie)
            {
                if (Keyboard.IsKeyUp((Key)int.Parse(item.Split(';')[0])))
                {
                    if (Ruchy.Contains(item.Split(';')[1]))
                    {
                        Ruchy.Remove(item.Split(';')[1]);
                    }
                }
            }
        }// usuwa klikniety ruch z listy
        private void FPSTimer_Tick(object sender, EventArgs e)
        {
            FPSLabel.Text = "FPS:" + FPS.ToString();
            FPS = 0;
        } //timer - obliczanie fps
        private void RenderTimer_Tick(object sender, EventArgs e) //timer - renderowanie klatki
        {
            RenderFrame();
            FPS++;
        }
        private void MoveTimer_Tick(object sender, EventArgs e) //timer - ruch obiektu sterowanego
        {
            foreach (string item in Ruchy)
            {
                WykonajRuchy(item);
            }
            if (CzyJestKolizja() != "BACKGROUND")
            {
                KolizjaLabel.Text = "Jest kolizja z " + CzyJestKolizja();
            }
            else
            {
                KolizjaLabel.Text = "BACKGROUND";
            }

            if (TypObiektu(CzyJestKolizja()) == 2)
            {
                LicznikLabel.Visible = true;

                foreach (var item in AktualnaGra.ListaObiektow)
                {
                    if (item.Name == CzyJestKolizja())
                    {
                        item.Typ = 0;
                        for (int i = 0; i < item.Wysokosc; i++) //usun z planszy
                        {
                            for (int j = 0; j < item.Szerokosc; j++)
                            {
                                GetSetPixel.Set(KlatkaStartowa, item.X + j, item.Y + i, GetSetPixel.Get(KlatkaStartowaBezZnikaczy, item.X + j, item.Y + i, KlatkaStartowa.Width, KlatkaStartowa.Height), GamePictureBox.Image.Width, GamePictureBox.Image.Height);
                            }
                        }
                        GamePictureBox.Image = new Bitmap(KlatkaStartowa);
                    }
                }

                IloscZnikaczy++;
                LicznikLabel.Text = "Licznik: " + IloscZnikaczy;
            }
            if (TypObiektu(CzyJestKolizja()) == 3)
            {
                int ileZnikaczy = 0;
                foreach (Shape item in AktualnaGra.ListaObiektow)
                {
                    if (item.Typ == 2)
                    {
                        ileZnikaczy++;
                    }
                }
                if (ileZnikaczy == 0)
                {
                    CzyWygrana = true;
                    this.Close();
                }
            }
        }
        private String[,] GenerujMapeKolizji()
        {
            String[,] mapaKolizji = new String[AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy];

            {
                foreach (Shape item in AktualnaGra.ListaObiektow) 
                {
                    if (item != AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego])
                    {
                        for (int i = 0; i < item.Wysokosc; i++)
                        {
                            for (int j = 0; j < item.Szerokosc; j++)
                            {
                                if (GetSetPixel.GetColorOfObject(item,j,i,item.Szerokosc,item.Wysokosc).ToString() != Color.FromArgb(0, 0, 0, 0).ToString())
                                {
                                    if (item.X + j >= 0 && item.X + j < AktualnaGra.SzerokoscBitmapy && item.Y + i >= 0 && item.Y + i < AktualnaGra.WysokoscBitmapy)
                                    {
                                        mapaKolizji[item.X + j, item.Y + i] = item.Name;
                                    }
                                }
                            }
                        }
                    }
                }
            } //tworzenie mapy kolizji

            return mapaKolizji;
        }
        private string CzyJestKolizja()
        {
            for (int i = 0; i < AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Wysokosc; i++) 
            {
                for (int j = 0; j < AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Szerokosc; j++)
                {
                    if (MapaKolizji[AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].X + j, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Y + i] != AktualnaGra.ListaObiektow[0].Name)
                    {
                        return MapaKolizji[AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].X + j, AktualnaGra.ListaObiektow[AktualnaGra.NumerObiektuSterowanego].Y + i];
                    }
                }
            }
            return "BACKGROUND";
        }
        private int TypObiektu(string nazwa)
        {
            foreach (Shape item in AktualnaGra.ListaObiektow)
            {
                if (item.Name == nazwa)
                {
                    return item.Typ;
                }
            }
            return -1;
        }
    }
}
