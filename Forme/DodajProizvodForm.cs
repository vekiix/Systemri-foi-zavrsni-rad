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
    public partial class DodajProizvodForm : Form
    {
        private readonly Proizvod stariProizvod;
        public DodajProizvodForm()
        {
            InitializeComponent();
            NapuniComboBoxove();
        }

        public DodajProizvodForm(Proizvod proizvod)
        {
            InitializeComponent();
            NapuniComboBoxove();
            stariProizvod = proizvod;
            textBoxNaziv.Text = stariProizvod.Naziv_proizvoda;
            textBoxCijena.Text = stariProizvod.Cijena_proizvoda.ToString();
            textBoxKolicina.Text = stariProizvod.Kolicina_proizvoda.ToString();
            comboBoxKategorija.SelectedIndex = comboBoxKategorija.FindStringExact(DBRepository.DohvatiImeKategorije(stariProizvod.Kategorija_proizvoda_ID).ToString());
            comboBoxDobavljaci.SelectedIndex = comboBoxDobavljaci.FindStringExact(DBRepository.DohvatiImeDobavljaca(stariProizvod.Dobavljac_ID).ToString());
            comboBoxProizvodaci.SelectedIndex = comboBoxProizvodaci.FindStringExact(DBRepository.DohvatiImeProizvodaca(stariProizvod.Proizvodac_ID).ToString());
            comboBoxMjerneJedinice.SelectedIndex = comboBoxMjerneJedinice.FindStringExact(DBRepository.DohvatiImeMjerneJedinice(stariProizvod.Mjerna_jedinica_ID).ToString());
            label1.Text = "Izmijeni proizvod";
            buttonDodaj.Text = "Izmijeni proizvod";
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void NapuniKategorijeComboBox() 
        {
            if(comboBoxKategorija.Items != null) comboBoxKategorija.Items.Clear();
            foreach (var item in DBRepository.DohvatiSveKategorijeProizvoda())
            {
                comboBoxKategorija.Items.Add(item);
            }
        }

        private void NapuniMjerneJediniceComboBox() 
        {
            if (comboBoxMjerneJedinice.Items != null) comboBoxMjerneJedinice.Items.Clear();
            foreach (var item in DBRepository.DohvatiMjerneJedinice())
            {
                comboBoxMjerneJedinice.Items.Add(item);
            }
            
        }

        private void NapuniProizvodaciComboBox() 
        {
            if (comboBoxProizvodaci.Items != null) comboBoxProizvodaci.Items.Clear();
            foreach (var item in DBRepository.DohvatiProizvodace())
            {
                comboBoxProizvodaci.Items.Add(item);
            }
        }

        private void NapuniDobavljaciComboBox() 
        {
            if (comboBoxDobavljaci.Items != null) comboBoxDobavljaci.Items.Clear();
            foreach (var item in DBRepository.DohvatiDobavljace())
            {
                comboBoxDobavljaci.Items.Add(item);
            }
        }

        private void NapuniComboBoxove() 
        {
            NapuniKategorijeComboBox();
            NapuniMjerneJediniceComboBox();
            NapuniProizvodaciComboBox();
            NapuniDobavljaciComboBox();
        }


        private void comboBoxKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxKategorija.SelectedItem != null) 
            {
                buttonObrisiKategoriju.Visible = true;
            }
        }

        private void comboBoxDobavljaci_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxDobavljaci.SelectedItem != null)
            {
                buttonObrisiDobavljaca.Visible = true;
            }
        }

        private void comboBoxProizvodaci_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxProizvodaci.SelectedItem != null)
            {
                buttonObrisiProizvodaca.Visible = true;
            }
        }

        private void comboBoxMjerneJedinice_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxMjerneJedinice.SelectedItem != null) 
            {
                buttonObrisiMjernuJedinicu.Visible = true;
            }
        }

        private void buttonObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.VratiUlogu() != "Blagajnik") 
            {
                DBRepository.ObrisiKategoriju(comboBoxKategorija.SelectedItem as Kategorija_Proizvoda);
                NapuniKategorijeComboBox();
            }
            else
            {
                MessageBox.Show("Nemate ovlasti za brisanje!");
            }
        }

        private void buttonObrisiDobavljaca_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.VratiUlogu() != "Blagajnik")
            {
                DBRepository.ObrisiDobavljaca(comboBoxDobavljaci.SelectedItem as Dobavljac);
                NapuniDobavljaciComboBox();
            }
            else
            {
                MessageBox.Show("Nemate ovlasti za brisanje!");
            }
        }

        private void buttonObrisiProizvodaca_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.VratiUlogu() != "Blagajnik")
            {
                DBRepository.ObrisiProizvodaca(comboBoxProizvodaci.SelectedItem as Proizvodac);
                NapuniProizvodaciComboBox();
            }
            else 
            {
                MessageBox.Show("Nemate ovlasti za brisanje!");
            }
        }

        private void buttonObrisiMjernuJedinicu_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.VratiUlogu() != "Blagajnik")
            {
                DBRepository.ObrisiMjernuJedinicu(comboBoxMjerneJedinice.SelectedItem as Mjerna_Jedinica);
                NapuniMjerneJediniceComboBox();
            }
            else
            {
                MessageBox.Show("Nemate ovlasti za brisanje!");
            }
        }

        private void textBoxNaziv_Leave(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "")
            {
                textBoxNaziv.Text = "Unesite naziv...";
            }
        }

        private void textBoxNaziv_Enter(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text == "Unesite naziv...") 
            {
                textBoxNaziv.Text = "";
            }
        }

        private void textBoxCijena_Leave(object sender, EventArgs e)
        {
            if (textBoxCijena.Text == "")
            {
                textBoxCijena.Text = "Unesite cijenu...";
            }
        }

        private void textBoxCijena_Enter(object sender, EventArgs e)
        {
            if (textBoxCijena.Text == "Unesite cijenu...") 
            {
                textBoxCijena.Text = "";
            }
        }

        private void textBoxKolicina_Leave(object sender, EventArgs e)
        {
            if (textBoxKolicina.Text == "") 
            {
                textBoxKolicina.Text = "Unesite kolicinu...";
            }
        }

        private void textBoxKolicina_Enter(object sender, EventArgs e)
        {
            if (textBoxKolicina.Text == "Unesite kolicinu...")
            {
                textBoxKolicina.Text = "";
            }
        }

        private void buttonDodajKategoriju_Click(object sender, EventArgs e)
        {
            Forme.DodajKategorijuForm form = new Forme.DodajKategorijuForm();
            form.ShowDialog();
            NapuniKategorijeComboBox();
        }

        private void buttonDodajDobavljaca_Click(object sender, EventArgs e)
        {
            Forme.DodajProizvodacaForm form = new Forme.DodajProizvodacaForm();
            form.DodajDobavljacaForm();
            form.ShowDialog();
            NapuniDobavljaciComboBox();
        }

        private void buttonDodajProizvodaca_Click(object sender, EventArgs e)
        {
            Forme.DodajProizvodacaForm forma = new Forme.DodajProizvodacaForm();
            forma.ShowDialog();
            NapuniProizvodaciComboBox();
        }

        private void buttonDodajMjernuJedinicu_Click(object sender, EventArgs e)
        {
            Forme.DodajMjernuJedinicuForm forma = new Forme.DodajMjernuJedinicuForm();
            forma.ShowDialog();
            NapuniMjerneJediniceComboBox();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

            if (textBoxNaziv.Text != "" && textBoxNaziv.Text != "Unesite naziv..."
                && textBoxCijena.Text != "" && textBoxCijena.Text != "Unesite cijenu..."
                && textBoxKolicina.Text != "" && textBoxKolicina.Text != "Unesite kolicinu...")
            {
                Proizvod proizvod = new Proizvod();
                proizvod.Naziv_proizvoda = textBoxNaziv.Text;
                try
                {
                    proizvod.Cijena_proizvoda = double.Parse(textBoxCijena.Text);
                    proizvod.Kolicina_proizvoda = int.Parse(textBoxKolicina.Text);
                    proizvod.Popust = 0;
                    if (comboBoxKategorija.SelectedItem != null && comboBoxDobavljaci.SelectedItem != null
                        && comboBoxMjerneJedinice.SelectedItem != null && comboBoxProizvodaci.SelectedItem != null)
                    {
                        proizvod.Kategorija_proizvoda_ID = UpravljanjePodacima.VratiIDKategorije(comboBoxKategorija.SelectedItem as Kategorija_Proizvoda);
                        proizvod.Dobavljac_ID = UpravljanjePodacima.VratiIDDobavljaca(comboBoxDobavljaci.SelectedItem as Dobavljac);
                        proizvod.Proizvodac_ID = UpravljanjePodacima.VratiIDProizvodaca(comboBoxProizvodaci.SelectedItem as Proizvodac);
                        proizvod.Mjerna_jedinica_ID = UpravljanjePodacima.VratiIDMjerneJedinice(comboBoxMjerneJedinice.SelectedItem as Mjerna_Jedinica);
                        proizvod.Podruznica_ID = PrijavljeniKorisnik.VratiIDPodruznice();
                        proizvod.Popust = 0;
                        proizvod.Postotak_popusta = 0;
                        if (label1.Text == "Dodaj novi proizvod")
                        {
                            DBRepository.DodajProizvod(proizvod);
                        }
                        else 
                        {
                            DBRepository.AzurirajProizvod(stariProizvod, proizvod);
                        }
                        
                        Close();
                    }
                    else 
                    {
                        MessageBox.Show("Niste unijeli sve podatke!");
                    }     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }        
            }
            else 
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }                     
        }
    }
}
