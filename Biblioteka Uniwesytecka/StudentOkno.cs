using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteka_Uniwesytecka.Ksiazka2;


namespace Biblioteka_Uniwesytecka
{


    public partial class StudentForm : Form
    {
        private readonly Student student;
        private List<KsiazkaImpl> wszystkieKsiazki;
        private List<KsiazkaImpl> wypozyczoneKsiazki;

        public StudentForm(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dgvWypozyczone.DataSource = DatabaseHelper.PobierzWypozyczeniaDlaUzytkownika(student.Login);
            wszystkieKsiazki = DatabaseHelper.PobierzKsiazki();
            dgvKsiazki.DataSource = wszystkieKsiazki;

           
            if (dgvWypozyczone.Columns.Count > 0)
            {
                dgvWypozyczone.Columns["Tytul"].HeaderText = "Tytuł książki";
                dgvWypozyczone.Columns["Autor"].HeaderText = "Autor";
                dgvWypozyczone.Columns["BorrowDate"].HeaderText = "Data wypożyczenia";
                dgvWypozyczone.Columns["ReturnDate"].HeaderText = "Data zwrotu";
            }

            
       

            lblPowitanie.Text = $"Witaj, {student.Imie}";
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            if (dgvKsiazki.CurrentRow?.DataBoundItem is KsiazkaImpl ksiazka)
            {
                bool success = DatabaseHelper.WypozyczKsiazke(ksiazka.Id, student.Login);
                MessageBox.Show(success ? "Wypożyczono książkę!" : "Książka niedostępna.");
                dgvKsiazki.DataSource = DatabaseHelper.PobierzKsiazki();
                dgvWypozyczone.DataSource = DatabaseHelper.PobierzWypozyczeniaDlaUzytkownika(student.Login);

            }
        }

        private void btnOddaj_Click(object sender, EventArgs e)
        {
            if (dgvKsiazki.CurrentRow?.DataBoundItem is KsiazkaImpl ksiazka)
            {
                bool success = DatabaseHelper.OddajKsiazke(ksiazka.Id, student.Login);
                MessageBox.Show(success ? "Zwrócono książkę." : "Nie masz tej książki.");
                dgvKsiazki.DataSource = DatabaseHelper.PobierzKsiazki();
                dgvWypozyczone.DataSource = DatabaseHelper.PobierzWypozyczeniaDlaUzytkownika(student.Login);
            }
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string query = txtSzukaj2.Text.ToLower();

            var filtered = wszystkieKsiazki
                .Where(k => k.Tytul.ToLower().Contains(query) || k.Autor.ToLower().Contains(query))
                .ToList();

            dgvKsiazki.DataSource = filtered;
        }
        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            using (var form = new ZmianaHaslaForm(student.Login))
            {
                form.ShowDialog();
            }
        }
    }

}