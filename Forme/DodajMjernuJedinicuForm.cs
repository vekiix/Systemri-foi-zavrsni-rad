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
    public partial class DodajMjernuJedinicuForm : Form
    {
        public DodajMjernuJedinicuForm()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxAdresa_Enter(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "Unesite naziv...") 
            {
                textBoxNaziv.Text = "";
            }
        }

        private void textBoxAdresa_Leave(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
            {
                textBoxNaziv.Text = "Unesite naziv...";
            }
        }

        private void textBoxKratica_Leave(object sender, EventArgs e)
        {
            if (textBoxKratica.Text == "")
            {
                textBoxKratica.Text = "Unesite kraticu...";
            }
        }

        private void textBoxKratica_Enter(object sender, EventArgs e)
        {
            if (textBoxKratica.Text == "Unesite kraticu...") 
            {
                textBoxKratica.Text = "";
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxKratica.Text != "" && textBoxKratica.Text != "Unesite kraticu..."
                && textBoxNaziv.Text != "" && textBoxNaziv.Text != "Unesite naziv...")
            {
                Mjerna_Jedinica mjerna = new Mjerna_Jedinica();
                mjerna.Naziv_mjerne_jedinice = textBoxNaziv.Text;
                mjerna.ID_mjerne_jedinice = textBoxKratica.Text;
                DBRepository.DodajMjernuJedinicu(mjerna);
                Close();
            }
            else 
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
        }
    }
}
