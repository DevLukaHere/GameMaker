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

namespace GameMaker
{
    public partial class ControlWindow : Form
    {
        public ControlWindow(ref Game gra)
        {
            InitializeComponent();
            Gra = gra;
        }

        Game _Gra;
        public Game Gra { get => _Gra; set => _Gra = value; }

        private void SterowanieWindow_Load(object sender, EventArgs e)
        {
            Lista.Items.Add("Klawisz    |    Reakcja");
            if(Gra != null)
            {
                foreach (string item in Gra.Sterowanie)
                {
                    Lista.Items.Add(((Key)int.Parse(item.Split(';')[0])).ToString() + "    -    " + item.Split(';')[1]);

                }
            }
        }
    }
}
