using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaApp
{
    public class FilmRep
    {
        private string conString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";

        public void dodajFilm(Film film)
        {
            string upit = "INSERT INTO Film (id_film, naslov, godina, zanr, trajanje, redatelj, ocjena,broj_kopija) VALUES (@Id, @Naslov, @Godina, @Zanr, @Trajanje, @Redatelj,@Ocjena,@BrojKopija)";

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd= new SqlCommand(upit, con);
                cmd.Parameters.AddWithValue("Id", film.Id);
                cmd.Parameters.AddWithValue("Naslov", film.Naslov);
                cmd.Parameters.AddWithValue("Godina", film.Godina);
                cmd.Parameters.AddWithValue("Zanr", film.Zanr);
                cmd.Parameters.AddWithValue("Trajanje", film.Trajanje);
                cmd.Parameters.AddWithValue("Redatelj", film.Redatelj);
                cmd.Parameters.AddWithValue("Ocjena", film.Ocjena);
                cmd.Parameters.AddWithValue("BrojKopija", film.BrojKopija);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
