using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HamsterApp
{
    public enum Geschlecht
    {
        Unbekannt,
        Weiblich,
        Männlich
    }
    public enum Farbe
    {
        blau, grün, rot, braun, schwarz
    }
    public class Hamster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Farbe Farbe { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public int Alter { get; set; }
        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1} Farbe: {2} Alter: {3} Geschlecht: {4}", Id, Name, Farbe, Alter, Geschlecht);
        }

        public void CreateSqlInsertCommand(SqlCommand cmd)
        {
            string sql = @"INSERT INTO TblHamster(Name, Farbe, [Alter], Geschlecht) VALUES(@Name, @Farbe, @Alter, @Geschlecht)";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Farbe", Farbe);
            cmd.Parameters.AddWithValue("@Alter", Alter);
            cmd.Parameters.AddWithValue("@Geschlecht", Geschlecht);

        }
        public static void CreateSqlSelectCommand(SqlCommand cmd)
        {
            string sql = @"SELECT Id, Name, Farbe, [Alter], Geschlecht FROM TblHamster";
            cmd.CommandText = sql;

        }

        public static Hamster CreateHamster(SqlDataReader reader)
        {
            Hamster h = new Hamster();
            h.Id = (int)reader["Id"];
            h.Name = (string)reader["Name"];
            h.Alter = (int)reader["Alter"];
            h.Farbe = (Farbe)reader["Farbe"];
            h.Geschlecht = (Geschlecht)reader["Geschlecht"];
            return h;
        }

        public static void CreateSqlDeleteCommand(SqlCommand cmd, int id)
        {
            string sql = @"delete from tblHamster where Id = @Id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Id", id);
        }
    }
}