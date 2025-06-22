namespace Biblioteka_Uniwesytecka
{
    partial class Główny_EKran
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
            listBoxItems = new ListBox();
            buttonBorrow = new Button();
            listBoxBorrowed = new ListBox();
            labelUser = new Label();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 15;
            listBoxItems.Location = new Point(0, 106);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(276, 334);
            listBoxItems.TabIndex = 0;
            // 
            // buttonBorrow
            // 
            buttonBorrow.Location = new Point(364, 294);
            buttonBorrow.Name = "buttonBorrow";
            buttonBorrow.Size = new Size(75, 23);
            buttonBorrow.TabIndex = 1;
            buttonBorrow.Text = "Wypożycz";
            buttonBorrow.UseVisualStyleBackColor = true;
            buttonBorrow.Click += buttonBorrow_Click;
            // 
            // listBoxBorrowed
            // 
            listBoxBorrowed.FormattingEnabled = true;
            listBoxBorrowed.ItemHeight = 15;
            listBoxBorrowed.Location = new Point(528, 106);
            listBoxBorrowed.Name = "listBoxBorrowed";
            listBoxBorrowed.Size = new Size(270, 319);
            listBoxBorrowed.TabIndex = 2;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(342, 43);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(0, 15);
            labelUser.TabIndex = 3;
            // 
            // Główny_EKran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUser);
            Controls.Add(listBoxBorrowed);
            Controls.Add(buttonBorrow);
            Controls.Add(listBoxItems);
            Name = "Główny_EKran";
            Text = "Główny_EKran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxItems;
        private Button buttonBorrow;
        private ListBox listBoxBorrowed;
        private Label labelUser;
    }
}