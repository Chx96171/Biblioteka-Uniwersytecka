namespace Biblioteka_Uniwesytecka
{

        partial class ListaKsiazekForm
        {
            private DataGridView dgvKsiazki;

            private void InitializeComponent()
            {
                this.dgvKsiazki = new DataGridView();
                ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).BeginInit();
                this.SuspendLayout();
                
                // dgvKsiazki
                
                this.dgvKsiazki.AllowUserToAddRows = false;
                this.dgvKsiazki.AllowUserToDeleteRows = false;
                this.dgvKsiazki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgvKsiazki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvKsiazki.Location = new Point(12, 12);
                this.dgvKsiazki.Name = "dgvKsiazki";
                this.dgvKsiazki.ReadOnly = true;
                this.dgvKsiazki.RowTemplate.Height = 25;
                this.dgvKsiazki.Size = new Size(560, 320);
                this.dgvKsiazki.TabIndex = 0;
                
                // ListaKsiazekForm
                
                this.AutoScaleDimensions = new SizeF(7F, 15F);
                this.ClientSize = new Size(584, 361);
                this.Controls.Add(this.dgvKsiazki);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Name = "ListaKsiazekForm";
                this.StartPosition = FormStartPosition.CenterParent;
                this.Text = "Lista książek";
                ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).EndInit();
                this.ResumeLayout(false);
            }
        }
 }
