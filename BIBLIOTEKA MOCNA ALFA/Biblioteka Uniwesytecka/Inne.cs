using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Inne : Baza
    {
        public int NumerID { get; }

        public Inne(string tytul, string autor, int rokwydania, int numerid)
            : base(tytul, autor, rokwydania)
        {
            NumerID = numerid;
        }

        public override string ToString()
        {
            return $" {Tytul} autorstwa {Autor} ({RokWydania})";
        }
    
    }
}
