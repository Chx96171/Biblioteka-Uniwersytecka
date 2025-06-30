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
        public string Login { get; private set; }
        public string HasloHash { get; private set; }
        public string Imie { get; private set; }
        public abstract string Rola { get; }

        protected List<Ksiazka> pozyczone = new List<Ksiazka>();

        public Uzytkownicy(string login, string hasloHash, string imie)
        {
            Login = login;
            HasloHash = hasloHash;
            Imie = imie;
        }

        public virtual void Pozyczone(Ksiazka ksiazka)
        {
            pozyczone.Add(ksiazka);
            Console.WriteLine($"{Imie} wypożyczył: {ksiazka.ToString()}");
        }
    }
}