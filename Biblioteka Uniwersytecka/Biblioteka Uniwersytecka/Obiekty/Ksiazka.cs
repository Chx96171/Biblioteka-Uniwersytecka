using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwersytecka.Obiekty
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul {  get; set; }
        public string Autor { get; set; }
        public bool Dostepna { get; set; } = true;

        public Ksiazka(int id, string tytul, string autor)
        {
            Id = id;
            Tytul = tytul;
            Autor = autor;
            
        }
    }
}
