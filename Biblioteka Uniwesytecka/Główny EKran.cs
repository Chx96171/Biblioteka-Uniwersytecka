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

namespace Biblioteka_Uniwesytecka
{
    public partial class Główny_EKran : Form
    {
        private Uzytkownik obecnyuzytkownik;
        private Biblioteka biblioteka = new Biblioteka(); // biblioteka z książkami

        public Główny_EKran(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            obecnyuzytkownik = uzytkownik;
            labelUser.Text = $"Zalogowany: {uzytkownik.Imie}";

            // Dodajemy testowe dane
            biblioteka.AddItem(new Podrecznik("C# Programming", "Jan Kowalski", 2020, "111"));
            biblioteka.AddItem(new Inne("IT World", "Redakcja", 2022, 4));

            LoadLibraryItems();
        }

        private void LoadLibraryItems()
        {
            listBoxItems.Items.Clear();
            foreach (var ksiazka in biblioteka.Search("")) // wszystkie
            {
                listBoxItems.Items.Add(ksiazka);

                listBoxItems.DisplayMember = "Tytul";
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem is Ksiazka selectedItem)
            {
                obecnyuzytkownik.Pozyczone(selectedItem);
                listBoxBorrowed.Items.Add(selectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Wybierz pozycję.");
            }
        }
    }
}
