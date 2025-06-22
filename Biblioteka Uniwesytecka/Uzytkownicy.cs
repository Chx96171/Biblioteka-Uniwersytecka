using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public abstract class Uzytkownicy : Uzytkownik
    {
        public string Imie { get; private set; }
        protected List<Ksiazka> pozyczone = new List<Ksiazka>();

        public Uzytkownicy(string imie)
        {
            Imie = imie;
        }

        public virtual void Pozyczone(Ksiazka ksiazka)
        {
            pozyczone.Add(ksiazka);
            Console.WriteLine($"{Imie} wypożyczył: {ksiazka.ToString()}");
        }
    }
}
