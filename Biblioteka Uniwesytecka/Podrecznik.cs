using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Podrecznik : Baza
    {
        public string ISBN { get; private set; }

        public Podrecznik(string tytul, string autor, int rokwydania, string isbn)
            : base(tytul, autor, rokwydania)
        {
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $" {Tytul} autorstwa: {Autor} ({RokWydania}) - ISBN: {ISBN}";
        }
    }
}
