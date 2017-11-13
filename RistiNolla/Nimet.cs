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

namespace RistiNolla
{
    public partial class Nimet : Form
    {
        public string pelaaja1Nimi = "";
        public string pelaaja2Nimi = "";

        public struct Pelaaja
        {
            public string nimi;

        }
        public Nimet()
        {
            InitializeComponent();
        }

        private void btnAloita_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Tulokset\\Tulokset.txt");
            sw.WriteLine("Pelaaja1 = " + tbPelaaja1Nimi.Text);
            sw.WriteLine("Pelaaja2 = " + tbPelaaja2Nimi.Text);
            VsKaveri k = new VsKaveri();
            sw.Close();
            Hide();
            k.Show();
        }
    }
}