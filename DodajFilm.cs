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
    public partial class DodajFilm : Form
    {
        public DodajFilm()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
            this.Hide();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int id;
            int trajanje;
            decimal ocjena;
            int broj_kopija;
            if (int.TryParse(tbId.Text, out id) && int.TryParse(tbTrajanje.Text, out trajanje)
                && int.TryParse(tbBrojKopija.Text, out broj_kopija) && decimal.TryParse(tbOcjena.Text, out ocjena))
            {

                Film filmovi = new Film()
                {
                    Id = id,
                    Trajanje = trajanje,
                    Ocjena = ocjena,
                    BrojKopija = broj_kopija,
                    Redatelj = tbRedatelj.Text,
                    Godina = tbGodina.Text,
                    Zanr = tbZanr.Text,
                    Naslov = tbNaslov.Text,
                };

                FilmRep filmRep = new FilmRep();
                filmRep.dodajFilm(filmovi);
                MessageBox.Show("Film uspjesno dodan");
                setPlaceholder();
                
            }
            else MessageBox.Show("Film nije dodan");
        }

        public void setPlaceholder()
        {
            tbId.Text = "ID";
            tbTrajanje.Text = "Trajanje";
            tbOcjena.Text = "Ocjena";
            tbBrojKopija.Text = "Broj kopija";
            tbRedatelj.Text = "Redatelj";
            tbGodina.Text = "Godina";
            tbZanr.Text = "Zanr";
            tbNaslov.Text = "Naslov";
        }

        private void DodajFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
