namespace Biblioteka_Uniwesytecka
{
    partial class DodajKsiazkeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTytul;
        private TextBox txtTytul;
        private Label lblAutor;
        private TextBox txtAutor;
        private Button btnDodaj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTytul = new Label();
            this.txtTytul = new TextBox();
            this.lblAutor = new Label();
            this.txtAutor = new TextBox();
            this.btnDodaj = new Button();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Location = new Point(20, 20);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new Size(35, 15);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "Tytuł:";
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new Point(80, 17);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new Size(220, 23);
            this.txtTytul.TabIndex = 1;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new Point(20, 60);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new Size(40, 15);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new Point(80, 57);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new Size(220, 23);
            this.txtAutor.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new Point(80, 100);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new Size(100, 30);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj książkę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajKsiazkeForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(340, 160);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.lblTytul);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajKsiazkeForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Dodaj książkę";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}