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
    public partial class GlavnaForma : Form
    {
        private Button trenutnaTipka;
        private Form trenutnaForma;
        private int uloga;

        public GlavnaForma()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            uloga = UpravljanjePodacima.VratiIDUloge(PrijavljeniKorisnik.VratiUlogu());
            trenutnaTipka = buttonPocetnaStranica;
            UpravljanjeGlavnomFormom.PromijeniTextLabele(labelUsername, PrijavljeniKorisnik.VratiKorIme());
            UpravljanjeGlavnomFormom.PromijeniTextLabele(labelVrstaKorisnika, PrijavljeniKorisnik.VratiUlogu());
            UpravljanjeGlavnomFormom.PromijeniTextLabele(labelPoduzece, PrijavljeniKorisnik.VratiImePoduzeca());
            UpravljanjeGlavnomFormom.PromijeniTextLabele(labelPodruznica,"Broj podruznice: " + PrijavljeniKorisnik.VratiIDPodruznice().ToString());
            switch (uloga) 
            {
                case 1: 
                    {
                        buttonNovaTransakcija.Visible = false; 
                        buttonUpravljanjeKorisnicima.Visible = false; 
                        buttonUpravljanjePodruznicama.Visible = false;
                        break;
                    } 
                case 2:
                    {
                        buttonUpravljanjeKorisnicima.Visible = false;
                        buttonUpravljanjePodruznicama.Visible = false;
                        break;
                    }
                case 3:
                    {
                        buttonUpravljanjePodruznicama.Visible = false;
                        break;
                    }
            }
            switch (uloga) 
            {
                case 1: OtvoriFormu(new SkladistarPocetnaStranicaForm(), trenutnaTipka);break;
                case 2:
                    {
                        BlagajnikPocetnaStranicaForm blagajnikPocetna = new BlagajnikPocetnaStranicaForm();
                        OtvoriFormu(blagajnikPocetna, trenutnaTipka);
                        blagajnikPocetna.NovaTransakcija += new EventHandler(OtvoriNovuTransakciju);
                        break;
                    } 
                case 3: OtvoriFormu(new AdministratorPocetnaStranicaForm(), trenutnaTipka);break;
                case 4: OtvoriFormu(new AdministratorPocetnaStranicaForm(), trenutnaTipka);break;
                default: OtvoriFormu(new SkladistarPocetnaStranicaForm(), trenutnaTipka); break;
            }
        }

        private void OtvoriFormu(Form childForm,object btnSender) 
        {
            if (btnSender != null) 
            {
                if (trenutnaForma != null) 
                {
                    trenutnaForma.Close();
                }
                UpravljanjeGlavnomFormom.DeaktivirajTipku(trenutnaTipka);
                trenutnaTipka = (Button)btnSender;
                UpravljanjeGlavnomFormom.AktivirajTipku(trenutnaTipka);
                trenutnaForma = childForm;
                UpravljanjeGlavnomFormom.AktivirajFormu(trenutnaForma, panelForma);
            }
        }

        

        private void buttonPocetnaStranica_Click(object sender, EventArgs e)
        {
            switch (uloga)
            {
                case 1: OtvoriFormu(new SkladistarPocetnaStranicaForm(), sender); break;
                case 2: 
                    {
                        BlagajnikPocetnaStranicaForm blagajnikPocetna = new BlagajnikPocetnaStranicaForm();
                        OtvoriFormu(blagajnikPocetna, sender); 
                        blagajnikPocetna.NovaTransakcija += new EventHandler(OtvoriNovuTransakciju);
                        break;
                    } 
                case 3: OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender); break;
                case 4: OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender); break;
                default: OtvoriFormu(new SkladistarPocetnaStranicaForm(), sender); break;
            }
        }

        private void buttonSkladiste_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new SkladisteForm(), sender);        
        }

        private void buttonNovaTransakcija_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new NovaTransakcijaForm(), sender);
        }

        private void buttonUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new UpravljanjeKorisnicimaForm(), sender);
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {      
            this.Close();          
        }

        private void buttonUpravljanjePodruznicama_Click(object sender, EventArgs e)
        {
            UpravljanjePodruznicamaForm upravljanjePodruznicamaForm = new UpravljanjePodruznicamaForm();
            OtvoriFormu(upravljanjePodruznicamaForm, sender);
            upravljanjePodruznicamaForm.PromijenjenaPodruznica += new EventHandler(PromijeniIDPodruznice);
        }

        void PromijeniIDPodruznice(object sender, EventArgs e)
        {
            UpravljanjeGlavnomFormom.PromijeniTextLabele(labelPodruznica, "Broj podruznice: " + PrijavljeniKorisnik.VratiIDPodruznice().ToString());
        }

        private void labelPromijeni_Click(object sender, EventArgs e)
        {
            PromijeniLozinkuForm form = new PromijeniLozinkuForm();
            form.ShowDialog();
        }

        private void OtvoriNovuTransakciju(object sender, EventArgs e)
        {
            buttonNovaTransakcija.PerformClick();
        }
    }
}
