using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GameMaker
{
    public partial class GameMaker : Form
    {
        public GameMaker()
        {
            InitializeComponent();

            player = new System.Media.SoundPlayer();
            player.SoundLocation = "Music/backgroundmusic1.wav";
            player.Play();
        }

        //Zmienne
        Game AktualnaGra = null;
        Bitmap Plansza;
        System.Media.SoundPlayer player;

        private void ButtonEditor_Click(object sender, EventArgs e)
        {
            EditorWindow Edytor = new EditorWindow(AktualnaGra);
            Edytor.ShowDialog();

            if(Edytor.CzyZapisacPlansze)
            {
                AktualnaGra = Edytor.Gra;
                MapUpdate();
            }

        } //uruchomienie edytora
        private void MapUpdate()
        {
            Plansza = new Bitmap(AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
            foreach (Shape item in AktualnaGra.ListaObiektow)
            {
                for (int i = 0; i < item.Wysokosc; i++)
                {
                    for (int j = 0; j < item.Szerokosc; j++)
                    {
                        GetSetPixel.Set(Plansza, item.X + j, item.Y + i, GetSetPixel.Get(item.Obrazek, j, i,item.Szerokosc,item.Wysokosc), AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
                    }
                }
            }
            GameName.Text = "Nazwa gry: " + AktualnaGra.Nazwa;

            PictureBoxMain.Image = new Bitmap(AktualnaGra.SzerokoscBitmapy, AktualnaGra.WysokoscBitmapy);
            PictureBoxMain.Image = Plansza;
            PictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
        } //zaktualizowanie podgladu gry
        private void GameMaker_Load(object sender, EventArgs e)
        {


        }
        private void ButtonSave_Click(object sender, EventArgs e) //zapis gry do pliku
        {
            if (AktualnaGra != null)
            {
                try
                {
                    string direction = AppDomain.CurrentDomain.BaseDirectory + AktualnaGra.Nazwa + ".txt";

                    if (!File.Exists(direction))
                    {
                        StreamWriter sw = File.CreateText(direction);

                        sw.WriteLine("GAMEMAKER PRODUCT");
                        sw.WriteLine("Nazwa gry:" + AktualnaGra.Nazwa);
                        sw.WriteLine("Szerokosc gry:" + AktualnaGra.SzerokoscBitmapy);
                        sw.WriteLine("Wysokosc gry:" + AktualnaGra.WysokoscBitmapy);

                        if (AktualnaGra.ListaObiektow.Count != 0)  //zapisuje wszystkie obiekty
                        {
                            sw.WriteLine("Liczba obiektow:" + AktualnaGra.ListaObiektow.Count);
                            foreach (Shape item in AktualnaGra.ListaObiektow)
                            {
                                sw.WriteLine("Nazwa:" + item.Name);
                                sw.WriteLine("Obrazek:" + ImageToBase64(item.Obrazek, System.Drawing.Imaging.ImageFormat.Png));
                                sw.WriteLine("Pozycja X:" + item.X);
                                sw.WriteLine("Pozycja Y:" + item.Y);
                                sw.WriteLine("Szerokosc:" + item.Szerokosc);
                                sw.WriteLine("Wysokosc:" + item.Wysokosc);
                                sw.WriteLine("Warstwa:" + item.Warstwa);
                                sw.WriteLine("Typ:" + item.Typ);
                                sw.WriteLine("CzyWidzialny:" + item.CzyWidzialny);
                            }
                        }
                        else
                        {
                            sw.WriteLine("Liczba obiektow:" + 0);
                        }

                        if (AktualnaGra.Sterowanie.Count != 0) //zapsiuje sterowanie
                        {
                            sw.WriteLine("Liczba sterowan:" + AktualnaGra.Sterowanie.Count);
                            foreach (String item in AktualnaGra.Sterowanie)
                            {
                                sw.WriteLine(item);
                            }
                        }
                        else
                        {
                            sw.WriteLine("Liczba sterowan:" + 0);
                        }

                        sw.WriteLine("Numer obiektu sterowanego:" + AktualnaGra.NumerObiektuSterowanego.ToString());

                        sw.Close();
                        MessageBox.Show("Zapisano grę!");
                    }
                    else
                    {
                        MessageBox.Show("Gra o takiej nazwie juz istnieje!");
                    }
                }
                catch (Exception Ex)
                {

                    throw Ex;
                }
            }
            else
            {
                MessageBox.Show("Nie ma gry do zapisania!");
            }
        }
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            GameLoader Load = new GameLoader();
            Load.ShowDialog();

            if(Load.CzyWczytywanieUdane)
            {
                AktualnaGra = Load.NowaGra;
                MapUpdate();
            }
        }
        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        private void ButtonSterowanie_Click(object sender, EventArgs e)
        {
            ControlWindow Ster = new ControlWindow(ref AktualnaGra);
            Ster.ShowDialog();
        }
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if(AktualnaGra != null)
            {
                if (AktualnaGra.NumerObiektuSterowanego == -1)
                {
                    MessageBox.Show("Nie wybrano obiektu sterowanego");
                }
                else
                {
                    GamePanel NowaGra = new GamePanel(new Game(AktualnaGra));
                    NowaGra.ShowDialog();

                    if (NowaGra.CzyWygrana)
                    {
                        MessageBox.Show("Gratulacje! Przeszedles gre!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano gry!");
            }
        }
        private void nutka1_Click(object sender, EventArgs e)
        {
                nutka1.Visible = false;
                player.Stop();
        }
        private void nutka2_Click(object sender, EventArgs e)
        {
            nutka1.Visible = true;
            player.Play();
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            AktualnaGra = null;

            if (File.Exists("MainImage.jpeg"))
            {
                PictureBoxMain.Image = Image.FromFile("MainImage.jpeg");
            }
            else
            {
                PictureBoxMain.Image = new Bitmap(1000, 600);
            }
        }
    }
}
