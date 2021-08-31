using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemri
{
    public partial class DodajPodruznicuForm : Form
    {
        public DodajPodruznicuForm()
        {
            InitializeComponent();
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

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxAdresa.Text != "Unesite adresu...")
            {
                Podruznica podruznica = new Podruznica();
                podruznica.Adresa_podruznice = textBoxAdresa.Text;
                DBRepository.DodajPodruznicu(podruznica);
                Close();
            }
            else 
            {
                MessageBox.Show("Morate unijeti adresu!");
            }
        }
    }
}
