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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VsKone k = new VsKone();
            k.Show();
            this.Hide();
        }

        private void btnKauppa_Click(object sender, EventArgs e)
        {
            Kauppa k = new Kauppa();
            k.Show();
            this.Hide();
        }

        private void btnVsKaveri_Click(object sender, EventArgs e)
        {
            Nimet game = new Nimet();
            Hide();
            game.Show();
        }
    }
}
