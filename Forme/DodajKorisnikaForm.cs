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
    public partial class DodajKorisnikaForm : Form
    {
        private bool promjenjen = false;
        private Korisnik stariKorisnik;
        public DodajKorisnikaForm()
        {
            InitializeComponent();
            NapuniComboBoxove();
        }

        public DodajKorisnikaForm(Korisnik korisnik) 
        {
            InitializeComponent();
            stariKorisnik = korisnik;
            NapuniComboBoxove();
            this.Text = "Izmijeni korisnika";
            buttonDodaj.Text = "Izmijeni korisnika";
            labelNaslov.Text = "Izmijeni korisnika";
            textBoxIme.Text = korisnik.Ime;
            textBoxPrezime.Text = korisnik.Prezime;
            textBoxEmail.Text = korisnik.Email;
            textBoxOIB.Text = korisnik.OIB;
            textBoxMjestoStanovanja.Text = korisnik.Mjesto_stanovanja;
            textBoxKontakt.Text = korisnik.Kontakt;
            textBoxKorisnickoIme.Text = korisnik.Korisnicko_ime;
            dateTimePickerUgovorOd.Value = (DateTime)korisnik.UgovorOd;
            dateTimePickerDatumRodenja.Value = (DateTime)korisnik.Datum_rodenja;
            if (korisnik.UgovorDo != null) dateTimePickerUgovorDo.Value = (DateTime)korisnik.UgovorDo;
            comboBoxUloga.SelectedIndex = comboBoxUloga.FindStringExact(UpravljanjePodacima.VratiUlogu(korisnik.Uloga_ID));  
        }

        private void NapuniComboBoxove() 
        {
            string uloga = PrijavljeniKorisnik.VratiUlogu();
            foreach (Uloga item in DBRepository.DohvatiUloge()) 
            {
                if (uloga == "Upravitelj") 
                {
                    if (item.Naziv_uloge != "Administrator" && item.Naziv_uloge != "Upravitelj") 
                    {
                        comboBoxUloga.Items.Add(item);
                    }
                }
                else if(item.Naziv_uloge != "Administrator")
                {
                    comboBoxUloga.Items.Add(item);
                }
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void textBoxIme_Leave(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "") textBoxIme.Text = "Unesite ime...";
        }

        private void textBoxIme_Enter(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "Unesite ime...") textBoxIme.Text = "";
        }

        private void textBoxPrezime_Leave(object sender, EventArgs e)
        {
            if (textBoxPrezime.Text == "") textBoxPrezime.Text = "Unesite prezime...";
        }

        private void textBoxPrezime_Enter(object sender, EventArgs e)
        {
            if (textBoxPrezime.Text == "Unesite prezime...") textBoxPrezime.Text = "";
        }

        private void textBoxKontakt_Leave(object sender, EventArgs e)
        {
            if (textBoxKontakt.Text == "") textBoxKontakt.Text = "Unesite kontakt...";
        }

        private void textBoxKontakt_Enter(object sender, EventArgs e)
        {
            if (textBoxKontakt.Text == "Unesite kontakt...") textBoxKontakt.Text = "";
        }

        private void textBoxMjestoStanovanja_Leave(object sender, EventArgs e)
        {
            if (textBoxMjestoStanovanja.Text == "") textBoxMjestoStanovanja.Text = "Unesite mjesto stanovanja...";
        }

        private void textBoxMjestoStanovanja_Enter(object sender, EventArgs e)
        {
            if (textBoxMjestoStanovanja.Text == "Unesite mjesto stanovanja...") textBoxMjestoStanovanja.Text = "";
        }

        private void textBoxOIB_Leave(object sender, EventArgs e)
        {
            if (textBoxOIB.Text == "") textBoxOIB.Text = "Unesite OIB...";
        }

        private void textBoxOIB_Enter(object sender, EventArgs e)
        {
            if (textBoxOIB.Text == "Unesite OIB...") textBoxOIB.Text = "";
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "") textBoxEmail.Text = "Unesite email...";
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Unesite email...") textBoxEmail.Text = "";
        }

        private void textBoxKorisnickoIme_Leave(object sender, EventArgs e)
        {
            if (textBoxKorisnickoIme.Text == "") textBoxKorisnickoIme.Text = "Unesite korisnicko ime...";
        }

        private void textBoxKorisnickoIme_Enter(object sender, EventArgs e)
        {
            if (textBoxKorisnickoIme.Text == "Unesite korisnicko ime...") textBoxKorisnickoIme.Text = "";
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

            if (textBoxIme.Text != "Unesite korisnicko ime..." && textBoxPrezime.Text != null
                        && textBoxKorisnickoIme.Text != "Unesite korisnicko ime..." && textBoxMjestoStanovanja.Text != "Unesite mjesto stanovanja..."
                        && textBoxOIB.Text != "Unesite OIB..." && textBoxEmail.Text != "Unesite email..."
                        && textBoxKontakt.Text != "Unesite kontakt..." && comboBoxUloga.Text != "Odaberite ulogu")
            {
               try
               {
                  Korisnik noviKorisnik = new Korisnik
                  {
                        Ime = textBoxIme.Text,
                        Prezime = textBoxPrezime.Text,
                        Email = textBoxEmail.Text,
                        Korisnicko_ime = textBoxKorisnickoIme.Text,
                        Mjesto_stanovanja = textBoxMjestoStanovanja.Text,
                        OIB = textBoxOIB.Text,
                        Kontakt = textBoxKontakt.Text,
                        Datum_rodenja = dateTimePickerDatumRodenja.Value,
                        UgovorOd = dateTimePickerUgovorOd.Value,
                        Uloga_ID = UpravljanjePodacima.VratiIDUloge(comboBoxUloga.SelectedItem.ToString()),
                        Podruznica_ID = PrijavljeniKorisnik.VratiIDPodruznice(),
                   };

                   if (promjenjen) noviKorisnik.UgovorDo = dateTimePickerUgovorDo.Value;

                   if (buttonDodaj.Text == "Izmijeni korisnika")
                   {
                        if (noviKorisnik.Korisnicko_ime != stariKorisnik.Korisnicko_ime) 
                        {
                            if (DBRepository.ProvjeriKorisnickoIme(textBoxKorisnickoIme.Text)) 
                            {
                                DBRepository.IzmijeniKorisnika(stariKorisnik, noviKorisnik);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Korisnicko ime vec postoji!");
                            }
                        }
                        else
                        {
                            DBRepository.IzmijeniKorisnika(stariKorisnik, noviKorisnik);
                            Close();
                        }
                   }
                   else if(buttonDodaj.Text == "Dodaj korisnika")
                   {
                        if (DBRepository.ProvjeriKorisnickoIme(textBoxKorisnickoIme.Text)) 
                        {
                            string lozinka = UpravljanjePodacima.GenerirajLozinku(8);
                            noviKorisnik.Lozinka = PrijavljeniKorisnik.SHA(lozinka);
                            MessageBox.Show("Uspjesno generirana nova lozinka!\n" + lozinka);
                            DBRepository.DodajKorisnika(noviKorisnik);
                            Close();
                        }
                        else 
                        {
                            MessageBox.Show("Korisnicko ime vec postoji!");
                        }
                   }

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
            }
            else 
            {
              MessageBox.Show("Nepravilno uneseni podaci!");
            }
        }

        private void dateTimePickerUgovorDo_ValueChanged(object sender, EventArgs e)
        {
            promjenjen = true;
        }
    }
}
