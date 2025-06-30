using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Zarzadzanie
    {
        private Biblioteka biblioteka;

        public Zarzadzanie(Biblioteka biblioteka)
        {
            this.biblioteka = biblioteka;
        }

        public void Pozyczone(Uzytkownik uzytkownik, string keyword)
        {
            var szukaj = biblioteka.Search(keyword).FirstOrDefault();
            if (szukaj != null)
            {
                uzytkownik.Pozyczone(szukaj);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}
