using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistiNolla
{
    public partial class Kauppa : Form
    {
        public VsKone kone;
        public Kauppa(VsKone kone)
        {
            InitializeComponent();
            this.kone = kone;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if(kone.pelaaja >= 10)
            {
                int a = int.Parse(kone.label1.Text);
                Image kuva = new Bitmap(@"Kuvat\Taustakuva1.jpg");
                this.BackgroundImage = kuva;
                a -= 10;
            }
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            Hide();
            m.Show();
        }
    }
}
