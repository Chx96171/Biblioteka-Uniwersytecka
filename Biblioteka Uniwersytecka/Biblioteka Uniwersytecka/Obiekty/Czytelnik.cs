using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwersytecka.Obiekty
{
    public class Czytelnik
    {
        public int Id { get; set; }
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public List<Ksiazka> Pozyczone { get; } = new();

        public Czytelnik(int id, string imie, string nazwisko)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }
}
