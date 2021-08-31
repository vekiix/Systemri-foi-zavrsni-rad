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
    public partial class PromijeniLozinkuForm : Form
    {
        public PromijeniLozinkuForm()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxLozinka_Enter(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == "Unesite lozinku...") 
            {
                textBoxLozinka.Text = "";
            }
        }

        private void textBoxLozinka_Leave(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == "")
            {
                textBoxLozinka.Text = "Unesite lozinku...";
            }
        }

        private void textBoxPonovljenaLozinka_Leave(object sender, EventArgs e)
        {
            if (textBoxPonovljenaLozinka.Text == "") 
            {
                textBoxPonovljenaLozinka.Text = "Ponovite lozinku...";
            }
        }

        private void textBoxPonovljenaLozinka_Enter(object sender, EventArgs e)
        {
            if (textBoxPonovljenaLozinka.Text == "Ponovite lozinku...")
            {
                textBoxPonovljenaLozinka.Text = "";
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == textBoxPonovljenaLozinka.Text) 
            {
                DBRepository.PromijeniLozinku(textBoxLozinka.Text);
                MessageBox.Show("Lozinka uspjesno promjenjena!");
                Close();
            }
            else
            {
                MessageBox.Show("Unesene lozinke moraju biti jednake!");
            }
        }
    }
}
