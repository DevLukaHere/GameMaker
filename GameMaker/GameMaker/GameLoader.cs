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
    public partial class GameLoader : Form
    {
        public GameLoader()
        {
            InitializeComponent();
        }

        Game _NowaGra = new Game("", 0, 0, new List<Shape>(), new List<String>());
        bool _CzyWczytywanieUdane = false;

        public Game NowaGra { get => _NowaGra; set => _NowaGra = value; }
        public bool CzyWczytywanieUdane { get => _CzyWczytywanieUdane; set => _CzyWczytywanieUdane = value; }

        private void GameLoader_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo di = new DirectoryInfo(baseDirectory);

            List<string> nazwyPlikow = new List<string>();
            foreach (var files in di.GetFiles("*.txt*"))
            {
                nazwyPlikow.Add(files.Name);
            }

            foreach (string item in nazwyPlikow)
            {
                StreamReader sr = File.OpenText(baseDirectory+item);

                if(sr.ReadLine() == "GAMEMAKER PRODUCT")
                {
                    Lista.Items.Add(item.Split('.')[0]);
                }

                sr.Close();
            }

            if (Lista.Items.Count == 0)
            {
                Lista.Items.Add("Nie znaleziono gier ;<");
            }

            Lista.SelectedIndex = 0;
        }
        private void ButtonEditor_Click(object sender, EventArgs e)
        {
            if (Lista.Items[Lista.SelectedIndex].ToString() != "Nie znaleziono zadnej gry ;<")
            {
                try
                {
                    string direction = AppDomain.CurrentDomain.BaseDirectory + Lista.Items[Lista.SelectedIndex] + ".txt";

                    StreamReader sr = File.OpenText(direction);

                    string ttt = sr.ReadLine(); //Zeby pominac GAMEMAKER PRODUCT
                    NowaGra.Nazwa = sr.ReadLine().Split(':')[1];
                    NowaGra.SzerokoscBitmapy = int.Parse(sr.ReadLine().Split(':')[1]);
                    NowaGra.WysokoscBitmapy = int.Parse(sr.ReadLine().Split(':')[1]);

                    for (int i = int.Parse(sr.ReadLine().Split(':')[1]); i > 0; i--) //pobiera liczbe obiektow
                    {
                        Shape Obiekt = new Shape();

                        Obiekt.Name = sr.ReadLine().Split(':')[1];
                        Obiekt.Obrazek = (Bitmap)Base64ToImage(sr.ReadLine().Split(':')[1]);
                        Obiekt.X = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.Y = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.Szerokosc = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.Wysokosc = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.Warstwa = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.Typ = int.Parse(sr.ReadLine().Split(':')[1]);
                        Obiekt.CzyWidzialny = bool.Parse(sr.ReadLine().Split(':')[1]);

                        NowaGra.ListaObiektow.Add(Obiekt);
                    }

                    for (int i = int.Parse(sr.ReadLine().Split(':')[1]); i > 0; i--)
                    {
                        NowaGra.Sterowanie.Add(sr.ReadLine().Split(':')[0]);
                    }

                    NowaGra.NumerObiektuSterowanego = int.Parse(sr.ReadLine().Split(':')[1]);

                    sr.Close();

                    CzyWczytywanieUdane = true;
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                this.Close();
            }
        }
        public Image Base64ToImage(string input)
        {
            byte[] imageBytes = Convert.FromBase64String(input);
            MemoryStream ms = new MemoryStream(imageBytes);

            return Image.FromStream(ms);
        }
    }
}
