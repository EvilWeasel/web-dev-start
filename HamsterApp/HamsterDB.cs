using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HamsterApp
{
    public class HamsterDB : IDisposable
    {
        private SqlConnection Connection { get; set; }
        private string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HamsterDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public HamsterDB()
        {
            Connection = new SqlConnection(strCon);

        }

        public IEnumerable<Hamster> GetHamster()
        {

            Connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            Hamster.CreateSqlSelectCommand(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Hamster h = new Hamster();
                //h.Id = (int)reader["Id"];
                //h.Name = (string)reader["Name"];
                //h.Alter = (int)reader["Alter"];
                //h.Farbe = (Farbe)reader["Farbe"];
                //h.Geschlecht = (Geschlecht)reader["Geschlecht"];
                yield return Hamster.CreateHamster(reader);
            }
            reader.Close();
            Connection?.Close();
        }

        public bool InsertHamster(Hamster h)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection;
                h.CreateSqlInsertCommand(cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                Connection?.Close();
            }
        }




        public void Dispose()
        {
            Connection?.Close();
        }
    }
}