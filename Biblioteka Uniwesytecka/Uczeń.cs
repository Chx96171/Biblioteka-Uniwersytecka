using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{

    public class Student : Uzytkownicy
    {
        public string StudentId { get; private set; }

        public Student(string imie, string studentId) : base(imie)
        {
            StudentId = studentId;
        }
    }
}
