using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{

    public class Student : Uzytkownik
    {
        public string Imie { get; private set; }
        public string Login { get; private set; }
        public string HasloHash { get; private set; }
        public string Rola => "Student";

        private List<Ksiazka> pozyczone = new List<Ksiazka>();
        public string StudentId { get; private set; }

        public Student(string login, string hasloHash, string imie, string studentId)
        {
            Login = login;
            HasloHash = hasloHash;
            Imie = imie;
            StudentId = studentId;
        }

        public void Pozyczone(Ksiazka ksiazka)
        {
            pozyczone.Add(ksiazka);
            Console.WriteLine($"{Imie} wypożyczył: {ksiazka}");
        }
    }
}

