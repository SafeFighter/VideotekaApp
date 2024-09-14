using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotekaApp
{
    public class PosudbaRep
    {

        public bool PosudiFilm(int id,int idClan, int idFilm, DateTime datumPosudbe, DateTime rokPovratka)
        {
            string connectionString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string queryProvjera = "SELECT broj_kopija FROM Film WHERE id_film = @idFilm";
                SqlCommand cmdProvjera = new SqlCommand(queryProvjera, con);
                cmdProvjera.Parameters.AddWithValue("@idFilm", idFilm);

                int brojKopija = (int)cmdProvjera.ExecuteScalar();

                if (brojKopija > 0)
                {
                    string queryUpdate = "UPDATE Film SET broj_kopija = broj_kopija - 1 WHERE id_film = @idFilm";
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                    cmdUpdate.Parameters.AddWithValue("@idFilm", idFilm);
                    cmdUpdate.ExecuteNonQuery();

                    string queryPosudba = "INSERT INTO Iznajmljivanje (id_iznajmljivanje, id_clan, id_film, datum_iznajmljivanja, datum_povratka) VALUES (@id,@idClan, @idFilm, @datumPosudbe, @rokPovratka)";
                    SqlCommand cmdPosudba = new SqlCommand(queryPosudba, con);
                    cmdPosudba.Parameters.AddWithValue("@idClan", idClan);
                    cmdPosudba.Parameters.AddWithValue("@idFilm", idFilm);
                    cmdPosudba.Parameters.AddWithValue("@datumPosudbe", datumPosudbe);
                    cmdPosudba.Parameters.AddWithValue("@rokPovratka", rokPovratka);
                    cmdPosudba.Parameters.AddWithValue("@id", id);
                    cmdPosudba.ExecuteNonQuery();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void VratiFilm(int idFilm,int idPosudbe)
        {
            string connectionString = "Data Source=MASTER2\\SQLEXPRESS;Initial Catalog=VideotekaDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string queryUpdate = "UPDATE Film SET broj_kopija= broj_kopija + 1 WHERE id_film = @idFilm";
                
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                cmdUpdate.Parameters.AddWithValue("@idFilm", idFilm);
                cmdUpdate.ExecuteNonQuery();

                string queryDelete = "DELETE FROM Iznajmljivanje WHERE id_iznajmljivanje=@idPosudbe";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, con);
                cmdDelete.Parameters.AddWithValue("@idPosudbe", idPosudbe);
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Film je uspjesno vracen");
            }
        }



    }
    
}
