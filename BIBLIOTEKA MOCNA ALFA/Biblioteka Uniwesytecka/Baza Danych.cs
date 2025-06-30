using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteka_Uniwesytecka.Ksiazka2;


namespace Biblioteka_Uniwesytecka
{
    public static class DatabaseHelper
    {
        public static void CreateDatabase()
        {
            if (!File.Exists("Biblioteka.db"))
            {
                SQLiteConnection.CreateFile("Biblioteka.db");
                using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();

                    cmd.CommandText = @"
                    CREATE TABLE Uzytkownicy (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT NOT NULL,
                    HasloHash TEXT NOT NULL,
                    Rola TEXT NOT NULL,
                    Imie TEXT,        
                    StudentId TEXT    
                    );

                    CREATE TABLE Ksiazki (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Tytul TEXT NOT NULL,
                        Autor TEXT NOT NULL,
                        Dostepna? INTEGER NOT NULL
                    );

                    CREATE TABLE Loans (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UzytkownikId INTEGER NOT NULL,
                        KsiazkaId INTEGER NOT NULL,
                        BorrowDate TEXT,
                        ReturnDate TEXT,
                        FOREIGN KEY(UzytkownikId) REFERENCES Uzytkownicy(Id),
                        FOREIGN KEY(KsiazkaId) REFERENCES Ksiazki(Id)
                    );";

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void AddAdmin()
        {
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                string hashedPassword = PasswordHelper.Hash("admin123");

                cmd.CommandText = "INSERT INTO Uzytkownicy (Login, HasloHash, Rola, Imie) VALUES (@u, @p, @r, @i)";
                cmd.Parameters.AddWithValue("@u", "admin");
                cmd.Parameters.AddWithValue("@p", hashedPassword);
                cmd.Parameters.AddWithValue("@r", "Admin");
                cmd.Parameters.AddWithValue("@i", "Administrator");

                cmd.ExecuteNonQuery();
            }
        }
        public static UzytkownikDTO PobierzUzytkownikaZBazy(string login, string haslo)
        {
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT Login, HasloHash, Rola, Imie, StudentId FROM Uzytkownicy WHERE Login=@login";
                cmd.Parameters.AddWithValue("@login", login);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader.GetString(reader.GetOrdinal("HasloHash"));
                        string providedHash = PasswordHelper.Hash(haslo);

                        if (storedHash == providedHash)
                        {
                            return new UzytkownikDTO
                            {
                                Login = reader.GetString(reader.GetOrdinal("Login")),
                                HasloHash = storedHash,
                                Rola = reader.GetString(reader.GetOrdinal("Rola")),
                                Imie = reader.IsDBNull(reader.GetOrdinal("Imie")) ? null : reader.GetString(reader.GetOrdinal("Imie")),
                                StudentId = reader.IsDBNull(reader.GetOrdinal("StudentId")) ? null : reader.GetString(reader.GetOrdinal("StudentId"))
                            };
                        }
                    }
                }
            }
            return null; 
        }
        public class UzytkownikDTO
        {
            public string Login { get; set; }
            public string HasloHash { get; set; }
            public string Rola { get; set; }
            public string Imie { get; set; }
            public string StudentId { get; set; }
        }
        public static void DodajUzytkownika(string login, string haslo, string rola, string imie, string studentId = null)
        {
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();

                var cmd = conn.CreateCommand();

                string hasloHash = PasswordHelper.Hash(haslo); 

                cmd.CommandText = @"
            INSERT INTO Uzytkownicy (Login, HasloHash, Rola, Imie, StudentId)
            VALUES (@login, @hasloHash, @rola, @imie, @studentId)";

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@hasloHash", hasloHash);
                cmd.Parameters.AddWithValue("@rola", rola);
                cmd.Parameters.AddWithValue("@imie", imie);
                if (studentId != null)
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                else
                    cmd.Parameters.AddWithValue("@studentId", DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
        public static List<KsiazkaImpl> PobierzKsiazki()
        {
            var lista = new List<KsiazkaImpl>();
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Tytul, Autor, Dostepna FROM Ksiazki";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new KsiazkaImpl(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3) == 1
                        ));
                    }
                }
            }
            return lista;
        }
        public static DataTable PobierzWypozyczenia()
        {
            var dt = new DataTable();
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            SELECT u.Imie, u.Login, k.Tytul, k.Autor, l.BorrowDate, l.ReturnDate
            FROM Loans l
            JOIN Uzytkownicy u ON l.UzytkownikId = u.Id
            JOIN Ksiazki k ON l.KsiazkaId = k.Id
            ORDER BY l.BorrowDate DESC";

                var adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public static bool WypozyczKsiazke(int ksiazkaId, string login)
        {
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();

                
                var check = new SQLiteCommand("SELECT Dostepna FROM Ksiazki WHERE Id = @id", conn);
                check.Parameters.AddWithValue("@id", ksiazkaId);
                var dostepna = Convert.ToInt32(check.ExecuteScalar());

                if (dostepna == 0)
                    return false;

               
                var trans = conn.BeginTransaction();

                var cmd1 = new SQLiteCommand("INSERT INTO Loans (UzytkownikId, KsiazkaId, BorrowDate) VALUES (@uid, @kid, @date)", conn);
                cmd1.Parameters.AddWithValue("@uid", login);
                cmd1.Parameters.AddWithValue("@kid", ksiazkaId);
                cmd1.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd1.ExecuteNonQuery();

                var cmd2 = new SQLiteCommand("UPDATE Ksiazki SET Dostepna = 0 WHERE Id = @id", conn);
                cmd2.Parameters.AddWithValue("@id", ksiazkaId);
                cmd2.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
        }
        public static bool OddajKsiazke(int ksiazkaId, string login)
        {
            using (var conn = new SQLiteConnection("Data Source=Biblioteka.db"))
            {
                conn.Open();

                var cmdCheck = new SQLiteCommand("SELECT Id FROM Loans WHERE UzytkownikId=@uid AND KsiazkaId=@kid AND ReturnDate IS NULL", conn);
                cmdCheck.Parameters.AddWithValue("@uid", login);
                cmdCheck.Parameters.AddWithValue("@kid", ksiazkaId);
                var loanId = cmdCheck.ExecuteScalar();

                if (loanId == null) return false;

                var trans = conn.BeginTransaction();

                var cmd1 = new SQLiteCommand("UPDATE Loans SET ReturnDate = @date WHERE Id = @id", conn);
                cmd1.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd1.Parameters.AddWithValue("@id", loanId);
                cmd1.ExecuteNonQuery();

                var cmd2 = new SQLiteCommand("UPDATE Ksiazki SET Dostepna = 1 WHERE Id = @id", conn);
                cmd2.Parameters.AddWithValue("@id", ksiazkaId);
                cmd2.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
        }
    }
}
