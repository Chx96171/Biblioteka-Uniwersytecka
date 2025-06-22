using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Biblioteka
    {
        private List<Ksiazka> ksiazki = new List<Ksiazka>();

        public void AddItem(Ksiazka ksiazka)
        {
            ksiazki.Add(ksiazka);
        }

        public IEnumerable<Ksiazka> Search(string keyword)
        {
            return ksiazki.Where(i => i.Tytul.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }


    }
}
