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
            yield return new Hamster() { Id = 1, Name = "Horst", Alter = 1, Farbe = "Grün", Geschlecht = "m" };
            yield return new Hamster() { Id = 2, Name = "Winfried", Alter = 16, Farbe = "Gelb", Geschlecht = "m" };
            yield return new Hamster() { Id = 3, Name = "Hans", Alter = 2, Farbe = "Weiß", Geschlecht = "w" };
            yield return new Hamster() { Id = 4, Name = "Angela", Alter = 3, Farbe = "Grün", Geschlecht = "w" };
        }
    }
}
