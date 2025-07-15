using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteka_Uniwesytecka
{
    public class AdminForm : Form
    {
        private Admin _admin;
        private TextBox txtWyszukaj;
        private DataGridView dgvWypozyczenia;
        private Button btnDodajUzytkownika;
        private Button btnUsunUzytkownika;
        private Button btnDodajKsiazke;
        private Button button1;
        private Button btnZmienHasloAdmina;
        private DataTable wypozyczeniaTable;

        public AdminForm(Admin admin)
        {
            _admin = admin;
            this.Text = "Panel Administratora";
            this.Width = 800;
            this.Height = 600;

            InitializeComponent();

            var label = new Label();
            label.Text = $"Witaj, {_admin.Imie} (Admin)";
            label.AutoSize = true;
            label.Location = new Point(10, 10);
            this.Controls.Add(label);

            // Podpięcie zdarzenia Load
            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Pobranie danych z bazy i wyświetlenie w DataGridView
            wypozyczeniaTable = DatabaseHelper.PobierzWypozyczenia();
            dgvWypozyczenia.DataSource = wypozyczeniaTable;
            // Opcjonalnie: zmiana nazw kolumn
            if (dgvWypozyczenia.Columns.Count > 0)
            {
                dgvWypozyczenia.Columns["Imie"].HeaderText = "Imię";
                dgvWypozyczenia.Columns["Login"].HeaderText = "Login";
                dgvWypozyczenia.Columns["Tytul"].HeaderText = "Tytuł";
                dgvWypozyczenia.Columns["Autor"].HeaderText = "Autor";
                dgvWypozyczenia.Columns["BorrowDate"].HeaderText = "Data wypożyczenia";
                dgvWypozyczenia.Columns["ReturnDate"].HeaderText = "Data zwrotu";
            }
        }

        private void InitializeComponent()
        {
            dgvWypozyczenia = new DataGridView();
            txtWyszukaj = new TextBox();
            btnDodajUzytkownika = new Button();
            btnUsunUzytkownika = new Button();
            btnDodajKsiazke = new Button();
            button1 = new Button();
            btnZmienHasloAdmina = new Button();
            ((ISupportInitialize)dgvWypozyczenia).BeginInit();
            SuspendLayout();
            // 
            // dgvWypozyczenia
            // 
            dgvWypozyczenia.AllowUserToAddRows = false;
            dgvWypozyczenia.AllowUserToDeleteRows = false;
            dgvWypozyczenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWypozyczenia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWypozyczenia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWypozyczenia.Location = new Point(12, 77);
            dgvWypozyczenia.Name = "dgvWypozyczenia";
            dgvWypozyczenia.ReadOnly = true;
            dgvWypozyczenia.Size = new Size(921, 429);
            dgvWypozyczenia.TabIndex = 0;
            dgvWypozyczenia.CellContentClick += dgvWypozyczenia_CellContentClick;
            // 
            // txtWyszukaj
            // 
            txtWyszukaj.Location = new Point(12, 48);
            txtWyszukaj.Name = "txtWyszukaj";
            txtWyszukaj.PlaceholderText = "Wyszukaj";
            txtWyszukaj.Size = new Size(379, 23);
            txtWyszukaj.TabIndex = 1;
            txtWyszukaj.TextChanged += textBox1_TextChanged;
            // 
            // btnDodajUzytkownika
            // 
            btnDodajUzytkownika.Location = new Point(966, 152);
            btnDodajUzytkownika.Name = "btnDodajUzytkownika";
            btnDodajUzytkownika.Size = new Size(129, 23);
            btnDodajUzytkownika.TabIndex = 2;
            btnDodajUzytkownika.Text = "Dodaj Studenta";
            btnDodajUzytkownika.UseVisualStyleBackColor = true;
            btnDodajUzytkownika.Click += btnDodajUzytkownika_Click;
            // 
            // btnUsunUzytkownika
            // 
            btnUsunUzytkownika.Location = new Point(966, 181);
            btnUsunUzytkownika.Name = "btnUsunUzytkownika";
            btnUsunUzytkownika.Size = new Size(129, 23);
            btnUsunUzytkownika.TabIndex = 3;
            btnUsunUzytkownika.Text = "Usuń Studenta";
            btnUsunUzytkownika.UseVisualStyleBackColor = true;
            btnUsunUzytkownika.Click += btnUsunUzytkownika_Click;
            // 
            // btnDodajKsiazke
            // 
            btnDodajKsiazke.Location = new Point(966, 210);
            btnDodajKsiazke.Name = "btnDodajKsiazke";
            btnDodajKsiazke.Size = new Size(129, 23);
            btnDodajKsiazke.TabIndex = 4;
            btnDodajKsiazke.Text = "Dodaj Książke";
            btnDodajKsiazke.UseVisualStyleBackColor = true;
            btnDodajKsiazke.Click += btnDodajKsiazke_Click;
            // 
            // button1
            // 
            button1.Location = new Point(966, 239);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 5;
            button1.Text = "Lista Książek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnListaKsiazek;
            // 
            // btnZmienHasloAdmina
            // 
            btnZmienHasloAdmina.Location = new Point(966, 268);
            btnZmienHasloAdmina.Name = "btnZmienHasloAdmina";
            btnZmienHasloAdmina.Size = new Size(129, 23);
            btnZmienHasloAdmina.TabIndex = 6;
            btnZmienHasloAdmina.Text = "Zmień Hasło ";
            btnZmienHasloAdmina.UseVisualStyleBackColor = true;
            btnZmienHasloAdmina.Click += btnZmienHasloAdmina_Click;
            // 
            // AdminForm
            // 
            ClientSize = new Size(1121, 518);
            Controls.Add(btnZmienHasloAdmina);
            Controls.Add(button1);
            Controls.Add(btnDodajKsiazke);
            Controls.Add(btnUsunUzytkownika);
            Controls.Add(btnDodajUzytkownika);
            Controls.Add(txtWyszukaj);
            Controls.Add(dgvWypozyczenia);
            Name = "AdminForm";
            ((ISupportInitialize)dgvWypozyczenia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvWypozyczenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                string filterText = txtWyszukaj.Text.Trim().Replace("'", "''"); 

                if (wypozyczeniaTable == null) return;

                if (string.IsNullOrEmpty(filterText))
                {
                    dgvWypozyczenia.DataSource = wypozyczeniaTable;
                }
                else
                {
                    DataView view = new DataView(wypozyczeniaTable);
                    view.RowFilter = $@"
                     Imie LIKE '%{filterText}%' OR
                     Login LIKE '%{filterText}%' OR
                     Tytul LIKE '%{filterText}%' OR
                     Autor LIKE '%{filterText}%'";
                    dgvWypozyczenia.DataSource = view;
                }

            }
        }

        private void btnDodajUzytkownika_Click(object sender, EventArgs e)
        {
            var form = new DodajUzytkownikaForm();
            form.ShowDialog();
        }

        private void btnUsunUzytkownika_Click(object sender, EventArgs e)
        {

            if (dgvWypozyczenia.CurrentRow == null)
            {
                MessageBox.Show("Wybierz użytkownika z listy.");
                return;
            }

            string login = dgvWypozyczenia.CurrentRow.Cells["Login"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Nie można odczytać loginu.");
                return;
            }

            var confirm = MessageBox.Show($"Czy na pewno chcesz usunąć użytkownika '{login}'?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = DatabaseHelper.UsunUzytkownika(login);
                if (success)
                {
                    MessageBox.Show("Użytkownik usunięty.");
                    wypozyczeniaTable = DatabaseHelper.PobierzWypozyczenia();
                    dgvWypozyczenia.DataSource = wypozyczeniaTable;
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć użytkownika (może ma wypożyczone książki?).");
                }
            }
        }

        private void btnDodajKsiazke_Click(object sender, EventArgs e)
        {
            var form = new DodajKsiazkeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Książka została dodana.");
                wypozyczeniaTable = DatabaseHelper.PobierzWypozyczenia();
                dgvWypozyczenia.DataSource = wypozyczeniaTable;
            }
        }

        private void btnListaKsiazek(object sender, EventArgs e)
        {
            var form = new ListaKsiazekForm();
            form.ShowDialog();
        }

        private void btnZmienHasloAdmina_Click(object sender, EventArgs e)
        {
            var form = new ZmianaHaslaForm(_admin.Login);
            form.ShowDialog();
        }
    }
}