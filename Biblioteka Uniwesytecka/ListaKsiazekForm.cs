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
    public partial class ListaKsiazekForm : Form
    {
        public ListaKsiazekForm()
        {
            InitializeComponent();
            ZaladujKsiazki();
        }

        private void ZaladujKsiazki()
        {
            var lista = DatabaseHelper.PobierzKsiazki();
            var table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Tytuł", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Dostępna", typeof(string));

            foreach (var ksiazka in lista)
            {
                table.Rows.Add(
                    ksiazka.Id,
                    ksiazka.Tytul,
                    ksiazka.Autor,
                    ksiazka.Dostepna ? "Tak" : "Nie"
                );
            }

            dgvKsiazki.DataSource = table;
        }
    }
}
