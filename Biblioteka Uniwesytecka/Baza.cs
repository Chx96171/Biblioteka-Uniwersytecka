using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public abstract class Baza : Ksiazka
    {
        public string Tytul { get; private set; }
        public string Autor { get; private set; }
        public int RokWydania { get; private set; }

        protected Baza(string tytul, string autor, int rokwydania)
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokwydania;
        }

        public abstract string ToString(); // polimorfizm
    }
}
