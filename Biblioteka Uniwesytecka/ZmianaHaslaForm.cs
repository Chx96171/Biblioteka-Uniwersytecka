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
    public partial class ZmianaHaslaForm : Form
    {
        private readonly string login;

        public ZmianaHaslaForm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            string stare = txtStareHaslo.Text;
            string nowe = txtNoweHaslo.Text;

            if (string.IsNullOrWhiteSpace(nowe))
            {
                MessageBox.Show("Nowe hasło nie może być puste.");
                return;
            }

            if (DatabaseHelper.SprawdzHaslo(login, stare))
            {
                DatabaseHelper.ZmienHaslo(login, nowe);
                MessageBox.Show("Hasło zostało zmienione.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne stare hasło.");
            }
        }
    }
}