using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteka_Uniwesytecka.Ksiazka2;


namespace Biblioteka_Uniwesytecka
{
    public class StudentForm : Form
    {
        private readonly Student student;
        private DataGridView dgvKsiazki;
        private Button btnWypozycz;
        private Button btnOddaj;
        private Label lblPowitanie;

        public StudentForm(Student student)
        {
            this.student = student;

            InitializeComponent();
            Load += StudentForm_Load;
        }

        private void InitializeComponent()
        {
            
            dgvKsiazki = new DataGridView
            {
                Name = "dgvKsiazki",
                Dock = DockStyle.Top,
                Height = 200,
                ReadOnly = true,
                AutoGenerateColumns = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            btnWypozycz = new Button
            {
                Text = "Wypożycz książkę",
                Dock = DockStyle.Left,
                Width = 150
            };
            btnWypozycz.Click += btnWypozycz_Click;

            btnOddaj = new Button
            {
                Text = "Oddaj książkę",
                Dock = DockStyle.Right,
                Width = 150
            };
            btnOddaj.Click += btnOddaj_Click;

            lblPowitanie = new Label
            {
                Text = $"Witaj, {student.Imie}",
                AutoSize = true,
                Location = new Point(10, 210)
            };

            
            this.Text = "Panel studenta";
            this.ClientSize = new Size(600, 400);
            this.Controls.Add(dgvKsiazki);
            this.Controls.Add(lblPowitanie);
            this.Controls.Add(btnWypozycz);
            this.Controls.Add(btnOddaj);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dgvKsiazki.DataSource = DatabaseHelper.PobierzKsiazki();
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            if (dgvKsiazki.CurrentRow?.DataBoundItem is KsiazkaImpl ksiazka)
            {
                bool success = DatabaseHelper.WypozyczKsiazke(ksiazka.Id, student.Login );
                MessageBox.Show(success ? "Wypożyczono książkę!" : "Książka niedostępna.");
                dgvKsiazki.DataSource = DatabaseHelper.PobierzKsiazki();
            }
        }

        private void btnOddaj_Click(object sender, EventArgs e)
        {
            if (dgvKsiazki.CurrentRow?.DataBoundItem is KsiazkaImpl ksiazka)
            {
                bool success = DatabaseHelper.OddajKsiazke(ksiazka.Id,student.Login) ;
                MessageBox.Show(success ? "Zwrócono książkę." : "Nie masz tej książki.");
                dgvKsiazki.DataSource = DatabaseHelper.PobierzKsiazki();
            }
        }
    }
}
