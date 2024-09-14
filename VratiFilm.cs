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
    public partial class VratiFilm : Form
    {
        public VratiFilm()
        {
            InitializeComponent();
        }

        private void VratiFilm_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }
        public void Ucitaj()
        {
            string connectionString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";
            string upit1 = "SELECT * FROM Iznajmljivanje";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da1 = new SqlDataAdapter(upit1, con);
    
                con.Open();
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idFilm = int.Parse(tbIdFilma.Text);
            int idPosudba = int.Parse(tbIdPosudbe.Text);

            PosudbaRep vrati = new PosudbaRep();
            vrati.VratiFilm(idFilm,idPosudba);
            Ucitaj();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
            this.Hide();
        }
    }
}
