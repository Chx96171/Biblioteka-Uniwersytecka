using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Admin : Uzytkownicy
    {
        public string Uprawnienia { get; private set; }

        public Admin(string imie, string uprawnienia) : base(imie)
        {
            Uprawnienia = uprawnienia;
        }

        public override void Pozyczone(Ksiazka ksiazka)
        {
            base.Pozyczone(ksiazka);
        }
    }
}
