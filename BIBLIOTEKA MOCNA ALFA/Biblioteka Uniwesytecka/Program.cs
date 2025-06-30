namespace Biblioteka_Uniwesytecka
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
      
        {
          
            {
                Biblioteka biblioteka = new Biblioteka();
                biblioteka.AddItem(new Podrecznik("C# Programming", "A. Developer", 2020, "123456789"));
                biblioteka.AddItem(new Inne("Science Today", "B. Writer", 2022, 45));

                Uzytkownik student = new Student("JanKowalski", "S123", "Janek", "12");
                Uzytkownik admin = new Admin("Nowak321", "ComputerScience", "Anna");

                Zarzadzanie manager = new Zarzadzanie(biblioteka);

                Console.WriteLine("\nBorrowing process:");
                manager.Pozyczone(student, "C#");
                manager.Pozyczone(admin, "Science");
            }
            DatabaseHelper.DodajUzytkownika("admin", "admin123", "Admin", "Jan Kowalski");
            DatabaseHelper.DodajUzytkownika("bebok", "1234", "Student","Blazej");
            ApplicationConfiguration.Initialize();
            Application.Run(new Logowanie());
            DatabaseHelper.CreateDatabase();
        }
    }
}