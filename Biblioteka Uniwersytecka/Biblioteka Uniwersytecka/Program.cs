using Biblioteka_Uniwersytecka;
using Biblioteka_Uniwersytecka.Obiekty;
using System.Reflection.PortableExecutable;
class Program
{
    static void Main()
    {
    Biblioteka biblioteka = new();

        // Dodaj przykładowe dane
        biblioteka.DodajKsiazke(new Ksiazka(1, "Franklin", "Franklin"));
        biblioteka.DodajKsiazke(new Ksiazka(2, "Illiada", "Homer"));
        biblioteka.DodajCzytelnika(new Czytelnik(1, "Michał","Kowal" ));

        // Wypożyczenie
        biblioteka.Wypozycz(1, 1);
        Console.WriteLine("Wypożyczono książkę 1");

        // Zwrot
        biblioteka.Zwroc(1, 1);
        Console.WriteLine("Zwrócono książkę 1");

        // Wyświetlenie wszystkich książek
        foreach (var ksiazka in biblioteka.Ksiazki)
        {
            Console.WriteLine($"{ksiazka.Tytul} - {(ksiazka.Dostepna ? "Dostępna" : "Wypożyczona")}");
        }
    }
}