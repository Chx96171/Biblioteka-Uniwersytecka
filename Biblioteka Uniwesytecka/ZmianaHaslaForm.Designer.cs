namespace Biblioteka_Uniwesytecka
{
    partial class ZmianaHaslaForm
    {
        private TextBox txtStareHaslo;
        private TextBox txtNoweHaslo;
        private Button btnZmien;

        private void InitializeComponent()
        {
            txtStareHaslo = new TextBox();
            txtNoweHaslo = new TextBox();
            btnZmien = new Button();
            SuspendLayout();
            
            // txtStareHaslo
            
            txtStareHaslo.Location = new Point(72, 12);
            txtStareHaslo.Name = "txtStareHaslo";
            txtStareHaslo.PasswordChar = '*';
            txtStareHaslo.PlaceholderText = "Stare hasło";
            txtStareHaslo.Size = new Size(100, 23);
            txtStareHaslo.TabIndex = 0;
             
            // txtNoweHaslo
            
            txtNoweHaslo.Location = new Point(72, 56);
            txtNoweHaslo.Name = "txtNoweHaslo";
            txtNoweHaslo.PasswordChar = '*';
            txtNoweHaslo.PlaceholderText = "Nowe hasło";
            txtNoweHaslo.Size = new Size(100, 23);
            txtNoweHaslo.TabIndex = 1;
            
            // btnZmien
            
            btnZmien.Location = new Point(84, 94);
            btnZmien.Name = "btnZmien";
            btnZmien.Size = new Size(75, 23);
            btnZmien.TabIndex = 2;
            btnZmien.Text = "Zmień";
            btnZmien.Click += btnZmien_Click;
            
            // ZmianaHaslaForm
            
            ClientSize = new Size(250, 150);
            Controls.Add(txtStareHaslo);
            Controls.Add(txtNoweHaslo);
            Controls.Add(btnZmien);
            Name = "ZmianaHaslaForm";
            Text = "Zmiana hasła";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}