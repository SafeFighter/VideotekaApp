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
    public partial class Form1 : Form
    {
        string conString= "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string upit = "SELECT * FROM Zaposlenik WHERE korisnicko_ime=@IME AND lozinka=@LOZINKA";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(upit, con))
                {
                    cmd.Parameters.AddWithValue("@IME", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@LOZINKA", tbPass.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            MessageBox.Show("Uspjesna prijava");
                        }
                        else MessageBox.Show("Neuspjesna prijava pokusajte opet");
                    }
                }
                con.Close();
            }


           
        }
    }
}
