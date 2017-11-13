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
    public partial class VsKaveri : Form
    {
        public int pelaaja1 = 0;
        public int pelaaja2 = 0;
        bool vuoro = true;

        public VsKaveri()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (vuoro)
                b.Text = "X";
            else
                b.Text = "O";
            vuoro = !vuoro;
            b.Enabled = false;
            Tulokset();
        }

        private void Tulokset()
        {
            // Haetaan pelaajien nimet Tulokset-tiedostosta
            StreamReader p1 = new StreamReader("Tulokset\\Tulokset.txt");
            StreamReader p2 = new StreamReader("Tulokset\\Tulokset.txt");
            //string line = "";
            //File.ReadLines("Tulokset\\Tulokset.txt").All("Player1");

            // Horistontaaliset voitot
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                MessageBox.Show("Congratulations " + p1.ReadLine() + ", you won!", "Winner!");
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                MessageBox.Show("Congratulations " + B1.Text + ", you won!", "Winner!");
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                MessageBox.Show("Congratulations " + C1.Text + ", you won!", "Winner!");

            // Pystyviivaiset voitot
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                MessageBox.Show("Congratulations " + A1.Text + ", you won!", "Winner!");
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                MessageBox.Show("Congratulations " + A2.Text + ", you won!", "Winner!");
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                MessageBox.Show("Congratulations " + A3.Text + ", you won!", "Winner!");

            // Vinot voitot

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
            {
                MessageBox.Show("Congratulations " + A1.Text + ", you won!", "Winner!");
                UusiPeli();
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && A3.Text != "")
                MessageBox.Show("Congratulations " + A3.Text + ", you won!", "Winner!");

            p1.Close();
            p2.Close();
        }
            
                private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämä peli on Aleksi Partasen tekemä", "Tietoja");
        }

        private void vs1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VsKaveri game = new VsKaveri();
            game.Show();
            this.Close();
        }

        private void UusiPeli()
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
        }
    }
}
