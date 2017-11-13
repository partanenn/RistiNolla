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
    public partial class Game : Form
    {

        bool vuoro = true;
        public Game()
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
            Results();
        }

        private void Results()
        {
            // Horistontaaliset voitot
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                MessageBox.Show("Congratulations " + A1.Text + ", you won!", "Winner!");
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
                MessageBox.Show("Congratulations " + A1.Text + ", you won!", "Winner!");
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && A3.Text != "")
                MessageBox.Show("Congratulations " + A3.Text + ", you won!", "Winner!");
        }
            
                private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämä peli on Aleksi Partasen tekemä", "About");
        }

        private void vs1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Close();
        }
    }
}
