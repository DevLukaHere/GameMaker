using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMaker
{
    public partial class InsertObject : Form
    {
        public InsertObject(int liczbaObiektow)
        {
            InitializeComponent();
            NazwaTextBox.Text = "Object" + liczbaObiektow;
        }

        bool _CzyWstawic = false;

        string _Nazwa = "";
        Bitmap _Obrazek = null;
        int _Wysokosc = -1;
        int _Szerokosc = -1;
        int _X = 0;
        int _Y = 0;
        int _Typ = -1;

        public bool CzyWstawic { get => _CzyWstawic; set => _CzyWstawic = value; }
        public string Nazwa { get => _Nazwa; set => _Nazwa = value; }
        public Bitmap Obrazek { get => _Obrazek; set => _Obrazek = value; }
        public int Wysokosc { get => _Wysokosc; set => _Wysokosc = value; }
        public int Szerokosc { get => _Szerokosc; set => _Szerokosc = value; }
        public int X { get => _X; set => _X = value; }
        public int Y { get => _Y; set => _Y = value; }
        public int Typ { get => _Typ; set => _Typ = value; }

        private void WstawObiekt_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            string directory = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                directory = openFile.FileName;
            }

            Nazwa = NazwaTextBox.Text;

            Obrazek = (Bitmap)Image.FromFile(directory);

            Wysokosc = Obrazek.Height;
            Szerokosc = Obrazek.Width;

            if (Wysokosc > 500 || Szerokosc >500)
            {
                MessageBox.Show("Obrazek nie miesci sie w podgladzie! (Nie wplywa to na wynik importowania)");
            }
            Podglad.Image = Image.FromFile(directory);

            WysokoscLabel.Text = "Wysokosc: " + Wysokosc + " px";
            SzerokoscLabel.Text = "Szerokosc: " + Szerokosc + " px";
 
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(Obrazek != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Przenikanie")
                {
                    Typ = 0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Sciana")
                {
                    Typ = 1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Znikacz")
                {
                    Typ = 2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Przejscie")
                {
                    Typ = 3;
                }

                CzyWstawic = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Musisz importowac obrazek!");
            }
        }
    }
}
