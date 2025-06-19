using Biblioteka_Uniwersytecka.Obiekty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwersytecka
{
    public class Biblioteka
    {
        public List<Ksiazka> Ksiazki { get; } = new();
        public List<Czytelnik> Czytelnicy { get; } = new();

        public void DodajKsiazke(Ksiazka ksiazka)
        {
            Ksiazki.Add(ksiazka);
        }
        public void DodajCzytelnika(Czytelnik czytelnik)
        {
            Czytelnicy.Add(czytelnik);
        }
        public bool Wypozycz(int ksiazkaID, int czytelnikId)
        {
            var ksiazka = Ksiazki.FirstOrDefault(k => k.Id == ksiazkaID && k.Dostepna);
            var czytelnik = Czytelnicy.FirstOrDefault(r => r.Id == czytelnikId);

            if (ksiazka != null && czytelnik != null)

            {
                ksiazka.Dostepna = false;
                czytelnik.Pozyczone.Add(ksiazka);
                return true;
            }
            return false;
        }

        public bool Zwroc(int ksiazkaId, int czytelnikId)
        {
            var czytelnik = Czytelnicy.FirstOrDefault(c => c.Id == czytelnikId);
            var ksiazka = czytelnik?.Pozyczone.FirstOrDefault(k => k.Id == ksiazkaId);

            if (ksiazka != null)
            {
                ksiazka.Dostepna = true;
                czytelnik.Pozyczone.Remove(ksiazka);
                return true;
            }

            return false;
        }
    }
}