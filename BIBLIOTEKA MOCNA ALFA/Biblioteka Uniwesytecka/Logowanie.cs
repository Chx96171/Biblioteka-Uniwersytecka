using Biblioteka_Uniwesytecka;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_Uniwesytecka;
public partial class Logowanie : Form 
{
    public Uzytkownik LoggedUser { get; private set; }
    public Logowanie()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text;
        string haslo = txtHaslo.Text;

        var daneZBazy = DatabaseHelper.PobierzUzytkownikaZBazy(login, haslo);

        if (daneZBazy != null)
        {
            Uzytkownik uzytkownik = null;

            if (daneZBazy.Rola == "Student")
            {
                uzytkownik = new Student(
                    daneZBazy.Login,
                    daneZBazy.HasloHash,
                    daneZBazy.Imie,
                    daneZBazy.StudentId
                );

                new StudentForm((Student)uzytkownik).Show();
            }
            else if (daneZBazy.Rola == "Admin")
            {
                uzytkownik = new Admin(
                    daneZBazy.Login,
                    daneZBazy.HasloHash,
                    daneZBazy.Imie
                );

                new AdminForm((Admin)uzytkownik).Show();
            }

            this.Hide();
        }
        else
        {
            MessageBox.Show("Nieprawidłowy login lub hasło");
        }
    }
}