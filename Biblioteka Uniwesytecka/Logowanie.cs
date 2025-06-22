using Biblioteka_Uniwesytecka;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_Uniwesytecka;
public partial class Logowanie : Form
{
    public Uzytkownik LoggedUser { get; private set; }

    public Logowanie()
    {
        InitializeComponent();
        comboBoxUserType.Items.Add("Student");
        comboBoxUserType.Items.Add("Admin");
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        string imie = textBoxName.Text.Trim();
        string type = comboBoxUserType.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(type))
        {
            MessageBox.Show("Wprowadź dane");
            return;
        }

        // Tworzymy użytkownika
        if (type == "Student")
            LoggedUser = new Student(imie, "S001");
        else if (type == "Admin")
            LoggedUser = new Admin(imie, "Informatyka");

        // Otwórz formularz główny
        Główny_EKran glownyEkran = new Główny_EKran(LoggedUser);
        this.Hide();
        glownyEkran.ShowDialog();
        this.Close();
    }
}