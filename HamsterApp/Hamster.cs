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
    }
}