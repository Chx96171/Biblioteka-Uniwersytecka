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
            textBoxName = new TextBox();
            comboBoxUserType = new ComboBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(24, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Podaj Imie";
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Location = new Point(24, 134);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(121, 23);
            comboBoxUserType.TabIndex = 1;
            comboBoxUserType.Text = "Wybierz Profesje";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(44, 232);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Zaloguj";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(comboBoxUserType);
            Controls.Add(textBoxName);
            Name = "Logowanie";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private ComboBox comboBoxUserType;
        private Button buttonLogin;
    }
}