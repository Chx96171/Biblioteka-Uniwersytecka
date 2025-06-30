namespace Biblioteka_Uniwesytecka
{
    partial class Logowanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            buttonLogin = new Button();
            txtHaslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(332, 106);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(344, 228);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Zaloguj";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += btnLogin_Click;
            // 
            // txtHaslo
            // 
            txtHaslo.Location = new Point(332, 162);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.Size = new Size(100, 23);
            txtHaslo.TabIndex = 3;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 109);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 165);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Hasło:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 23F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(304, 45);
            label3.MaximumSize = new Size(300, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 40);
            label3.TabIndex = 6;
            label3.Text = "Biblioteka";
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHaslo);
            Controls.Add(buttonLogin);
            Controls.Add(txtLogin);
            Name = "Logowanie";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Button buttonLogin;
        private TextBox txtHaslo;
        private Label label1;
        private Label label2;
        protected internal Label label3;
    }
}