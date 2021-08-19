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
    public partial class DodajProizvodacaForm : Form
    {
        public DodajProizvodacaForm()
        {
            InitializeComponent();
        }

        public void DodajDobavljacaForm() 
        {
            label4.Text = "Dodaj novog dobavljaca";
            this.Text = "Dodavanje dobavljaca";
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
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

        private void textBoxKontakt_Enter(object sender, EventArgs e)
        {
            if (textBoxKontakt.Text == "Unesite kontakt...") 
            {
                textBoxKontakt.Text = "";
            }
        }

        private void textBoxKontakt_Leave(object sender, EventArgs e)
        {
            if (textBoxKontakt.Text == "")
            {
                textBoxKontakt.Text = "Unesite kontakt...";
            }
        }

        private void textBoxAdresa_Leave(object sender, EventArgs e)
        {
            if (textBoxAdresa.Text == "")
            {
                textBoxAdresa.Text = "Unesite adresu...";
            }
        }

        private void textBoxAdresa_Enter(object sender, EventArgs e)
        {
            if (textBoxAdresa.Text == "Unesite adresu...")
            {
                textBoxAdresa.Text = "";
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text != "" && textBoxNaziv.Text != "Unesite naziv..."
                && textBoxAdresa.Text != "" && textBoxAdresa.Text != "Unesite adresu..."
                && textBoxKontakt.Text != "" && textBoxKontakt.Text != "Unesite kontakt...") 
            {
                if (label4.Text != "Dodaj novog dobavljaca")
                {
                    Proizvodac proizvodac = new Proizvodac();
                    proizvodac.Naziv_proizvodaca = textBoxNaziv.Text;
                    proizvodac.Kontakt_proizvodaca = textBoxKontakt.Text;
                    proizvodac.Adresa_proizvodaca = textBoxAdresa.Text;
                    DBRepository.DodajProizvodaca(proizvodac);
                }
                else 
                {
                    Dobavljac dobavljac = new Dobavljac();
                    dobavljac.Naziv_dobavljaca = textBoxNaziv.Text;
                    dobavljac.Kontakt_dobavljaca = textBoxKontakt.Text;
                    dobavljac.Adresa_dobavljaca = textBoxAdresa.Text;
                    DBRepository.DodajDobavljaca(dobavljac);
                }
                
                Close();
            }
            else
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
        }
    }
}
