using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotekaApp
{
    public partial class PosudiFilm : Form
    {
        public PosudiFilm()
        {
            InitializeComponent();
        }

        private void PosudiFilm_Load(object sender, EventArgs e)
        {
            ucitajTablicu();
        }

        public void ucitajTablicu()
        {
            string connectionString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";

            string upit1 = "SELECT * FROM Clan";
            string upit2 = "SELECT * FROM Film";
            string upit3 = "SELECT * FROM Iznajmljivanje";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da1 = new SqlDataAdapter(upit1, con);
                SqlDataAdapter da2 = new SqlDataAdapter(upit2, con);
                SqlDataAdapter da3 = new SqlDataAdapter(upit3, con);

                con.Open();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                da1.Fill(dt1);
                da2.Fill(dt2);
                da3.Fill(dt3);

                dataGridView1.DataSource = dt1;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIdPosudbe.Text);
            int idFilm = int.Parse(tbFilmId.Text);
            int idClan = int.Parse(tbClanId.Text);
            DateTime datumPosudbe = dtDanPosudbe.Value;
            DateTime rokPovratka = dtRokPovratka.Value;

            PosudbaRep rep = new PosudbaRep();

            bool uspjesno = rep.PosudiFilm(id,idClan, idFilm, datumPosudbe, rokPovratka);

            if (uspjesno)
            {
                MessageBox.Show("Film je uspješno posuđen!");
            }
            else
            {
                MessageBox.Show("Film nije dostupan za posudbu.");
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Form2 forma2=new Form2();
            forma2.Show();
            this.Hide();
        }
    }
}
