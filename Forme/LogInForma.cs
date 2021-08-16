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
    public partial class LogInForma : Form
    {
        public LogInForma()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {        
            try
            {
                if (PrijavljeniKorisnik.Prijava(textBoxKorisnickoIme.Text, textBoxLozinka.Text)) 
                {
                    this.Hide();
                    GlavnaForma forma = new GlavnaForma();
                    forma.ShowDialog();
                    PrijavljeniKorisnik.Odjava();
                    VratiKorIme();
                    VratiLozinku();              
                    this.Show();
                };         
            }
            catch(Exception ex)      
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void labelZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VratiLozinku() 
        {
            textBoxLozinka.Text = "password";
            textBoxLozinka.ForeColor = Color.DimGray;
            textBoxLozinka.PasswordChar = default;
        }

        private void VratiKorIme()
        {
            textBoxKorisnickoIme.Text = "username";
            textBoxKorisnickoIme.ForeColor = Color.DimGray;
        }

        private void OcistiLozinku() 
        {
            textBoxLozinka.Text = "";
            textBoxLozinka.ForeColor = Color.Black;
            textBoxLozinka.PasswordChar = '*';
        }

        private void OcistiKorIme() 
        {
            textBoxKorisnickoIme.Text = "";
            textBoxKorisnickoIme.ForeColor = Color.Black;
        }

        private void textBoxLozinka_Enter(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == "password") 
            {
                OcistiLozinku();
            }
        }

        private void textBoxKorisnickoIme_Enter(object sender, EventArgs e)
        {
            if (textBoxKorisnickoIme.Text == "username")
            {
                OcistiKorIme();
            }
        }

        private void textBoxKorisnickoIme_Leave(object sender, EventArgs e)
        {
            if (textBoxKorisnickoIme.Text == "")
            {
                VratiKorIme();
            }
        }

        private void textBoxLozinka_Leave(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == "")
            {
                VratiLozinku();
            }
        }
    }
}
