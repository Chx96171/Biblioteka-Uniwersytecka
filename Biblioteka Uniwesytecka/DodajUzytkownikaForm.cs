using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_Uniwesytecka
{
    public partial class DodajUzytkownikaForm : Form

    {
        public DodajUzytkownikaForm()
        {
            InitializeComponent(); 
        }

        private void BtnZatwierdz_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;
            string imie = txtImie.Text;
            string studentId = txtStudentId.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Login i hasło są wymagane.");
                return;
            }

            try
            {
                DatabaseHelper.DodajUzytkownika(login, haslo, "Student", imie, studentId);
                MessageBox.Show("Użytkownik dodany pomyślnie.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy dodawaniu: " + ex.Message);
            }
        }
        private void DodajUzytkownikaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
