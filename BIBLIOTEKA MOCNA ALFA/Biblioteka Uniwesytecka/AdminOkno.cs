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
    public class AdminForm : Form
    {
        private Admin _admin;

        public AdminForm(Admin admin)
        {
            _admin = admin;
            this.Text = "Panel Administratora";
            this.Width = 400;
            this.Height = 300;


            var label = new Label();
            label.Text = $"Witaj, {_admin.Imie} (Admin)";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 10);

            this.Controls.Add(label);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvWypozyczenia.DataSource = DatabaseHelper.PobierzWypozyczenia();
        }
        private DataGridView dgvWypozyczenia;

        private void InitializeComponent()
        {
            dgvWypozyczenia = new DataGridView();
            ((ISupportInitialize)dgvWypozyczenia).BeginInit();
            SuspendLayout();
           
          
            dgvWypozyczenia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWypozyczenia.Location = new Point(22, 0);
            dgvWypozyczenia.Name = "dgvWypozyczenia";
            dgvWypozyczenia.Size = new Size(240, 150);
            dgvWypozyczenia.TabIndex = 0;
            
            ClientSize = new Size(284, 261);
            Controls.Add(dgvWypozyczenia);
            Name = "AdminForm";
            ((ISupportInitialize)dgvWypozyczenia).EndInit();
            ResumeLayout(false);

        }
    }
}
