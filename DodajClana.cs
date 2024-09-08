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
    public partial class DodajClana : Form
    {
        public DodajClana()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int id;
            
            if(int.TryParse(tbId.Text,out id))
            {
                Clan noviClan = new Clan()
                {
                    Id = id,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    BrojTelefona = tbTelefon.Text,
                    Email = tbEmail.Text,
                    Adresa = tbAdresa.Text,
                };
                
                ClanRep clanRep= new ClanRep();
                clanRep.dodajClana(noviClan);
                MessageBox.Show("Clan uspjesno dodan");

            }
            else
            {
                MessageBox.Show("Unesite ispravnu vrijednost za id!");
            }
           
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
