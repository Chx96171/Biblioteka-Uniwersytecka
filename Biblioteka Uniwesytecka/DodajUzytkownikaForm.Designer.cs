using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Uniwesytecka
{
    partial class DodajUzytkownikaForm
    {
        private TextBox txtLogin, txtHaslo, txtImie, txtStudentId;
        private Button btnZatwierdz;
        private Label lblLogin, lblHaslo, lblImie, lblStudentId;

        private void InitializeComponent()
        {
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblHaslo = new Label();
            txtHaslo = new TextBox();
            lblImie = new Label();
            txtImie = new TextBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            btnZatwierdz = new Button();
            SuspendLayout();
            
            // lblLogin
            
            lblLogin.Location = new Point(10, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(100, 23);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            
            // txtLogin
            
            txtLogin.Location = new Point(116, 20);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(134, 23);
            txtLogin.TabIndex = 1;
            
            // lblHaslo
            
            lblHaslo.Location = new Point(10, 60);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(100, 23);
            lblHaslo.TabIndex = 2;
            lblHaslo.Text = "Hasło:";
            
            // txtHaslo
            
            txtHaslo.Location = new Point(116, 60);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.PasswordChar = '*';
            txtHaslo.Size = new Size(134, 23);
            txtHaslo.TabIndex = 3;
            
            // lblImie
            
            lblImie.Location = new Point(10, 100);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(100, 23);
            lblImie.TabIndex = 4;
            lblImie.Text = "Imię:";
             
            // txtImie
            
            txtImie.Location = new Point(116, 100);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(134, 23);
            txtImie.TabIndex = 5;
            
            // lblStudentId
            
            lblStudentId.Location = new Point(10, 140);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 23);
            lblStudentId.TabIndex = 6;
            lblStudentId.Text = "Nr studenta:";
            
            // txtStudentId
            
            txtStudentId.Location = new Point(116, 140);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(134, 23);
            txtStudentId.TabIndex = 7;
            
            // btnZatwierdz
            
            btnZatwierdz.Location = new Point(100, 190);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(150, 23);
            btnZatwierdz.TabIndex = 8;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.Click += BtnZatwierdz_Click;
            
            // DodajUzytkownikaForm
            
            ClientSize = new Size(300, 250);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblHaslo);
            Controls.Add(txtHaslo);
            Controls.Add(lblImie);
            Controls.Add(txtImie);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(btnZatwierdz);
            Name = "DodajUzytkownikaForm";
            Text = "Dodaj użytkownika";
            ResumeLayout(false);
            PerformLayout();
        }
    }

}