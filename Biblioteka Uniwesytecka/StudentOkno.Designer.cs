using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteka_Uniwesytecka.Ksiazka2;

namespace Biblioteka_Uniwesytecka
{
    partial class StudentForm
    {
        private DataGridView dgvKsiazki;
        private Button btnWypozycz;
        private Button btnOddaj;
        private Label lblPowitanie;
        private TextBox txtSzukaj2;


        private void InitializeComponent()
        {
            dgvKsiazki = new DataGridView();
            btnWypozycz = new Button();
            btnOddaj = new Button();
            lblPowitanie = new Label();
            txtSzukaj2 = new TextBox();
            dgvWypozyczone = new DataGridView();
            Historia = new Label();
            btnHaslo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKsiazki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWypozyczone).BeginInit();
            SuspendLayout();
            
            // dgvKsiazki
            
            dgvKsiazki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKsiazki.Location = new Point(20, 50);
            dgvKsiazki.Name = "dgvKsiazki";
            dgvKsiazki.ReadOnly = true;
            dgvKsiazki.Size = new Size(550, 200);
            dgvKsiazki.TabIndex = 0;

            
            // btnWypozycz
            
            btnWypozycz.Location = new Point(20, 270);
            btnWypozycz.Name = "btnWypozycz";
            btnWypozycz.Size = new Size(100, 30);
            btnWypozycz.TabIndex = 1;
            btnWypozycz.Text = "Wypożycz";
            btnWypozycz.Click += btnWypozycz_Click;
            
            // btnOddaj
            
            btnOddaj.Location = new Point(140, 270);
            btnOddaj.Name = "btnOddaj";
            btnOddaj.Size = new Size(100, 30);
            btnOddaj.TabIndex = 2;
            btnOddaj.Text = "Oddaj";
            btnOddaj.Click += btnOddaj_Click;
           
            // lblPowitanie
            
            lblPowitanie.AutoSize = true;
            lblPowitanie.Location = new Point(20, 10);
            lblPowitanie.Name = "lblPowitanie";
            lblPowitanie.Size = new Size(34, 15);
            lblPowitanie.TabIndex = 3;
            lblPowitanie.Text = "Witaj";
            
            // txtSzukaj2
            
            txtSzukaj2.Location = new Point(339, 21);
            txtSzukaj2.Name = "txtSzukaj2";
            txtSzukaj2.PlaceholderText = "Wyszukaj...";
            txtSzukaj2.Size = new Size(231, 23);
            txtSzukaj2.TabIndex = 4;
            txtSzukaj2.TextChanged += txtSzukaj_TextChanged;
            
            // dgvWypozyczone
            
            dgvWypozyczone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWypozyczone.Location = new Point(20, 388);
            dgvWypozyczone.Name = "dgvWypozyczone";
            dgvWypozyczone.ReadOnly = true;
            dgvWypozyczone.Size = new Size(550, 150);
            dgvWypozyczone.TabIndex = 5;
            
            // Historia
            
            Historia.AutoSize = true;
            Historia.Location = new Point(20, 355);
            Historia.Name = "Historia";
            Historia.Size = new Size(48, 15);
            Historia.TabIndex = 6;
            Historia.Text = "Historia";
            
            // btnHaslo
            
            btnHaslo.Location = new Point(429, 270);
            btnHaslo.Name = "btnHaslo";
            btnHaslo.Size = new Size(100, 30);
            btnHaslo.TabIndex = 7;
            btnHaslo.Text = "Zmień Hasło";
            btnHaslo.UseVisualStyleBackColor = true;
            btnHaslo.Click += btnZmienHaslo_Click;
            
            // StudentForm
           
            ClientSize = new Size(600, 559);
            Controls.Add(btnHaslo);
            Controls.Add(Historia);
            Controls.Add(dgvWypozyczone);
            Controls.Add(txtSzukaj2);
            Controls.Add(dgvKsiazki);
            Controls.Add(btnWypozycz);
            Controls.Add(btnOddaj);
            Controls.Add(lblPowitanie);
            Name = "StudentForm";
            Text = "Panel studenta";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKsiazki).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWypozyczone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridView dgvWypozyczone;
        private Label Historia;
        private Button btnHaslo;
    }
}
