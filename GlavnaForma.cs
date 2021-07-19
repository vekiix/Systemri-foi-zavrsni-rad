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


        public GlavnaForma()
        {
            InitializeComponent();
            trenutnaTipka = buttonPocetnaStranica;
            OtvoriFormu(new AdministratorPocetnaStranicaForm(), trenutnaTipka);
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
            OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender);
        }

        private void buttonSkladiste_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender);
        }

        private void buttonNovaTransakcija_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender);
        }

        private void buttonUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new AdministratorPocetnaStranicaForm(), sender);
        }


    }
}
