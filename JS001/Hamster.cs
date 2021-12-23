using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS001
{
    public class Hamster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Farbe { get; set; }
        public string Geschlecht { get; set; }
        public int Alter { get; set; }
    }

    public class HamsterRepository
    {
        public static IEnumerable<Hamster> GetHamster()
        {
            yield return new Hamster() { Id = 1, Name = "Horst", Alter = 1, Farbe = "gelb", Geschlecht = "m" };
            yield return new Hamster() { Id = 2, Name = "Winfried", Alter = 16, Farbe = "grün", Geschlecht = "m" };
            yield return new Hamster() { Id = 3, Name = "Friedrich", Alter = 2, Farbe = "blau", Geschlecht = "w" };
            yield return new Hamster() { Id = 4, Name = "Angela", Alter = 3, Farbe = "grau", Geschlecht = "w" };
            yield return new Hamster() { Id = 5, Name = "Angelo", Alter = 6, Farbe = "braun", Geschlecht = "m" };
        }
    }
}
