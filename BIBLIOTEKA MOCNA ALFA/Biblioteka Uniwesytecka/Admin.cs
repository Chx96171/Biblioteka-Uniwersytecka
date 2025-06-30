using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    public class Admin : Uzytkownicy
    {
        public string Login { get; private set; }
        public string HasloHash { get; private set; }
        public override string Rola => "Admin";
       
        public Admin(string login, string hasloHash, string imie, string uprawnienia = "Admin") : base(login,hasloHash,imie)
        {
            Login = login;
            HasloHash = hasloHash;
        }

        public override void Pozyczone(Ksiazka ksiazka)
        {
            base.Pozyczone(ksiazka);
            
        }

        public static void AddAdmin()
        {
            using (var conn = new SQLiteConnection("Data Source=library.db"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                string hashedPassword = PasswordHelper.Hash("admin123");

                cmd.CommandText = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)";
                cmd.Parameters.AddWithValue("@u", "admin");
                cmd.Parameters.AddWithValue("@p", hashedPassword);
                cmd.Parameters.AddWithValue("@r", "Admin");

                cmd.ExecuteNonQuery();
            }
        }
    }
}
