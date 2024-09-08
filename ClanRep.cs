using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaApp
{
    public class ClanRep
    {
        private string conString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";

        public void dodajClana(Clan clan)
        {
            string upit = "INSERT INTO Clan (id,ime, prezime, telefon, email, adresa) VALUES (@Id, @Ime, @Prezime, @BrojTelefona, @Email, @Adresa)";

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd=new SqlCommand(upit, con);
                cmd.Parameters.AddWithValue("@Id", clan.Id);
                cmd.Parameters.AddWithValue("@Ime", clan.Ime);
                cmd.Parameters.AddWithValue("@Prezime", clan.Prezime);
                cmd.Parameters.AddWithValue("@BrojTelefona", clan.BrojTelefona);
                cmd.Parameters.AddWithValue("@Email", clan.Email);
                cmd.Parameters.AddWithValue("@Adresa", clan.Adresa);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
