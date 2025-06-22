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

                Uzytkownik student = new Student("Jan Kowalski", "S123");
                Uzytkownik admin = new Admin("Dr Anna Nowak", "Computer Science");

                Zarzadzanie manager = new Zarzadzanie(biblioteka);

                Console.WriteLine("\nBorrowing process:");
                manager.Pozyczone(student, "C#");
                manager.Pozyczone(admin, "Science");
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Logowanie());
        }
    }
}