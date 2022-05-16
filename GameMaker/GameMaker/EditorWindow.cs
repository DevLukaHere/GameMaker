using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GameMaker
{
    public partial class EditorWindow : Form
    {
        public EditorWindow(Game gra)
        {
            InitializeComponent();
            ListOfObjects.View = View.LargeIcon;

            if (gra != null)
            {
                Gra = gra;

                WyswietlListeObiektow();
            }
            else
            {
                Gra = new Game("Nowa gra",1000,600,new List<Shape>(),PodstawoweSterowanie());
            }

            MapUpdate();

            textBox1.Text = Gra.Nazwa;
            UzupelnijComboBox();
            Przybornik = new Toolbar(ref _Map,ref _Gra);
        }

        Bitmap _Map;
        Game _Gra;
        bool _CzyZapisacPlansze = false;

        Toolbar Przybornik;

        public Bitmap Map { get => _Map; set => _Map = value; }
        public bool CzyZapisacPlansze { get => _CzyZapisacPlansze; set => _CzyZapisacPlansze = value; }
        public Game Gra { get => _Gra; set => _Gra = value; }

        private void EditorWindow_Load(object sender, EventArgs e)
        {

        }
        private void MapUpdate()
        {
            Map = new Bitmap(Gra.SzerokoscBitmapy, Gra.WysokoscBitmapy);
            foreach (Shape item in Gra.ListaObiektow)
            {
                for (int i = 0; i < item.Wysokosc; i++)
                {
                    for (int j = 0; j < item.Szerokosc; j++)
                    {
                            GetSetPixel.Set(Map, item.X+j, item.Y+i, GetSetPixel.Get(item.Obrazek, j, i,item.Szerokosc,item.Wysokosc),Gra.SzerokoscBitmapy,Gra.WysokoscBitmapy);
                    }
                }
            }
            PictureBoxEditor.Image = new Bitmap(Gra.SzerokoscBitmapy, Gra.WysokoscBitmapy);
            PictureBoxEditor.Image = Map;

        } //zaktualizowanie pictureboxa
        private Point GetMousePosition()
        {
            Point pos = PictureBoxEditor.PointToClient(Cursor.Position);

            return pos;
        }
        private void PictureBoxEditor_MouseDown(object sender, MouseEventArgs e)
        {
            Przybornik.MouseDown(e.Location.X, e.Location.Y);
        }
        private void PictureBoxEditor_MouseMove(object sender, MouseEventArgs e)
        {
            CoordsLabel.Text = "X:" + GetMousePosition().X + "   " + "Y:" + GetMousePosition().Y;
            Przybornik.MouseMove(e.Location.X, e.Location.Y);
        }
        private void PictureBoxEditor_MouseUp(object sender, MouseEventArgs e)
        {
            Przybornik.MouseUp(e.Location.X, e.Location.Y);
            if(Przybornik.ObiektZwrotny != null)
            {
                DodajObiektDoListy("Object", Przybornik.ObiektZwrotny, Przybornik.ObliczLewyGorny()[0], Przybornik.ObliczLewyGorny()[1],1);
            }

            Przybornik = new Toolbar(ref _Map, ref _Gra);
            MapUpdate();
        }
        private void ButtonTlo_Click(object sender, EventArgs e)
        {
            string directory = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                directory = openFile.FileName;
            }

            if (directory != "")
            {
                Shape tlo = new Shape();
                tlo.Name = Path.GetFileName(directory).Split('.')[0];
                tlo.Obrazek = (Bitmap)Image.FromFile(directory);
                tlo.Szerokosc = tlo.Obrazek.Width;
                tlo.Wysokosc = tlo.Obrazek.Height;
                tlo.Warstwa = 0;
                tlo.Typ = 0;

                if (Gra.ListaObiektow.Count == 0)
                {
                    Gra.ListaObiektow.Add(tlo);
                }
                else
                {
                    Gra.ListaObiektow[0] = tlo;
                }


                WyswietlListeObiektow();
                MapUpdate();
            }

        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                NumerObiektuSterowanego(comboBox1.SelectedItem.ToString());
            }

            Gra.Nazwa = textBox1.Text;
            CzyZapisacPlansze = true;
            this.Close();
        }
        private void ButtonWstaw_Click(object sender, EventArgs e)
        {
            if (Gra.ListaObiektow.Count != 0)
            {
                InsertObject Wstawianie = new InsertObject(Gra.ListaObiektow.Count);
                Wstawianie.ShowDialog();

                if (Wstawianie.CzyWstawic)
                {
                    DodajObiektDoListy(Wstawianie.Nazwa, Wstawianie.Obrazek, Wstawianie.X, Wstawianie.Y,Wstawianie.Typ);
                    WyswietlListeObiektow();
                    MapUpdate();
                }
            }
            else
            {
                MessageBox.Show("Najpierw musisz dodac tlo!");
            }
        }
        private void DodajObiektDoListy(string name,Bitmap obiekt, int x, int y,int typ)
        {
            Shape Nowy = new Shape(name,obiekt,x,y,typ);
            Gra.ListaObiektow.Add(Nowy);
            UzupelnijComboBox();
        }
        private void WyswietlListeObiektow()
        {
            ListOfObjects.Clear();

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(150, 150);

            int licznik = 0;
            foreach (Shape item in Gra.ListaObiektow)
            {
                imgs.Images.Add(item.Obrazek);
                ListOfObjects.Items.Add(item.Name, licznik);
                item.Warstwa = licznik;
                licznik++;
            }

            ListOfObjects.LargeImageList = imgs;
        } //tutaj nadaje sie numer warstwy
        private void ListOfObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ButtonZmianaNarzedzia_Click(object sender, EventArgs e)
        {
            Button przycisk = (sender as Button);
            Przybornik.Tool = przycisk.Text;

            NarzedzieLabel.Text = "Narzedzie: " + przycisk.Text;
        }
        private List<String> PodstawoweSterowanie()
        {
            List<String> lista = new List<String>();

            lista.Add("24;MoveUp"); //strzalka w gore
            lista.Add("26;MoveDown"); //strzalka w dol
            lista.Add("25;MoveRight"); //strzalka w prawo
            lista.Add("23;MoveLeft"); //strzalka w lewo
            lista.Add("18;Action"); //spacja
            lista.Add("59;Pause"); //literka P
            lista.Add("13;Exit"); // ESC

            return lista;
        }
        private void UzupelnijComboBox()
        {
            bool pominTlo = true;
            comboBox1.Items.Clear();
            foreach (var item in Gra.ListaObiektow)
            {
                if (pominTlo)
                {
                    pominTlo = false;
                }
                else
                {
                    comboBox1.Items.Add(item.Name);
                }
            }
            if (Gra.ListaObiektow.Count != 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
        private void NumerObiektuSterowanego(string nazwa)
        {
            int licznik = 0;
            foreach (var item in Gra.ListaObiektow)
            {
                if (item.Name == nazwa)
                {
                    Gra.NumerObiektuSterowanego = licznik;
                    break;
                }
                licznik++;
            }
        }
    }
}
