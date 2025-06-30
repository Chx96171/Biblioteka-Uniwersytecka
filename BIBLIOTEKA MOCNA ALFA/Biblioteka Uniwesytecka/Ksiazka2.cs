using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Ksiazka2
    {
        public class KsiazkaImpl : Ksiazka
        {
            public int Id { get; set; }
            public string Tytul { get; private set; }
            public string Autor { get; private set; }
            public bool Dostepna { get; set; }

            public KsiazkaImpl(int id, string tytul, string autor, bool dostepna)
            {
                Id = id;
                Tytul = tytul;
                Autor = autor;
                Dostepna = dostepna;
            }

            public override string ToString()
            {
                return $"{Tytul} - {Autor} {(Dostepna ? "(dostępna)" : "(niedostępna)")}";
            }
        }
    }
}
