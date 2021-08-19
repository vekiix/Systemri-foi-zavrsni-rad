using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemri.Forme
{
    public partial class DodajKategorijuForm : Form
    {
        public DodajKategorijuForm()
        {
            InitializeComponent();
        }

        private void textBoxNaziv_Enter(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "Unesite naziv...") 
            {
                textBoxNaziv.Text = "";
            }
        }

        private void textBoxNaziv_Leave(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
            {
                textBoxNaziv.Text = "Unesite naziv...";
            }
        }

        private void textBoxOpis_Leave(object sender, EventArgs e)
        {
            if (textBoxOpis.Text == "")
            {
                textBoxOpis.Text = "Unesite opis...";
            }
        }

        private void textBoxOpis_Enter(object sender, EventArgs e)
        {
            if (textBoxOpis.Text == "Unesite opis...")
            {
                textBoxOpis.Text = "";
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text != "" && textBoxNaziv.Text != "Unesite naziv..."
                && textBoxOpis.Text != "" && textBoxOpis.Text != "Unesite opis...")
            {
                Kategorija_Proizvoda kategorija = new Kategorija_Proizvoda();
                kategorija.Naziv_kategorije_proizvoda = textBoxNaziv.Text;
                kategorija.Opis = textBoxOpis.Text;
                DBRepository.DodajKategorijuProizvoda(kategorija);
                Close();
            }
            else 
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
            
        }
    }
}
