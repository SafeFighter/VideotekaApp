using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotekaApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prijava forma1 = new Prijava();
            forma1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajClana dodajClana = new DodajClana();
            dodajClana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajFilm d = new DodajFilm();
            d.Show();
            this.Hide();
        }
    }
}
