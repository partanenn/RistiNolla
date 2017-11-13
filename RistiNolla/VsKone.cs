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
    public partial class VsKone : Form
    {
        public int pelaaja = 0;
        public VsKone()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämä peli on Aleksi Partasen tekemä", "Tietoja");
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Menu k = new Menu();
            k.Show();
            this.Hide();
        }

        private void vs1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VsKone game = new VsKone();
            game.Show();
            this.Close();
        }

        private void kauppaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kauppa k = new Kauppa(this);
            k.Show();
            this.Close();
        }

        private void uusiPeliToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void valikkoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tulokset()
        {
            // Horistontaaliset voitot
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
            {
                if (B1.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
            {
                if (C1.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }

            // Pystyviivaiset voitot
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
            {
                if (A2.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
            {
                if (A3.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }

            // Vinot voitot

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && A3.Text != "")
            {
                if (A3.Text == "X")
                {
                    MessageBox.Show("Onnittelut, voitit!", "Tulos");
                    pelaaja++;
                }
                else
                    MessageBox.Show("Hävisit :(", "Tulos");
                UusiPeli();
            }
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != "" && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                MessageBox.Show("Tasapeli", "Tulos");
                UusiPeli();
            }
            lbPisteet.Text = pelaaja.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
            Tulokset();
            Kone();
            Tulokset();
            label1.Text = pelaaja.ToString();
        }
        
        private void Kone()
        {
            // Ensimmäinen(A) rivi
            if (A1.Text != "X" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
            }
            else if (A2.Text != "X" && A2.Enabled == true)
            {
                A2.Text = "O";
                A2.Enabled = false;
            }
            else if (A3.Text != "X" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
            }

            // Toinen(B) rivi
            else if (B1.Text != "X" && B1.Enabled == true)
            {
                B1.Text = "O";
                B1.Enabled = false;
            }
            else if (B2.Text != "X" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
            }
            else if (B3.Text != "X" && B3.Enabled == true)
            {
                B3.Text = "O";
                B3.Enabled = false;
            }

            // Kolmas(C) rivi
            else if (C1.Text != "X" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
            }
            else if (C2.Text != "X" && C2.Enabled == true)
            {
                C2.Text = "O";
                C2.Enabled = false;
            }
            else if (C3.Text != "X" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
            }
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
