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
    public partial class DodajKsiazkeForm : Form
    {
        public DodajKsiazkeForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string tytul = txtTytul.Text.Trim();
            string autor = txtAutor.Text.Trim();

            if (string.IsNullOrWhiteSpace(tytul) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Proszę uzupełnić tytuł i autora.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper.DodajKsiazke(tytul, autor);
            MessageBox.Show("Książka została dodana pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}