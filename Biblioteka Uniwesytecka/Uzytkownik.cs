using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public interface Uzytkownik
    {
        string Imie { get; }
        string Login{ get; }
        string HasloHash { get; }
        string Rola { get; }
        void Pozyczone(Ksiazka ksiazka);
    }
}
