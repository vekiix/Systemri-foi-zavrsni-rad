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
    public partial class SkladistarPocetnaStranicaForm : Form
    {
        public SkladistarPocetnaStranicaForm()
        {
            InitializeComponent();
            
        }

        private void NapuniSPodacima() 
        {
            bindChart();
            Korisnik korisnik = DBRepository.DohvatiPrijavljenogKorisnika();
            labelID.Text = korisnik.ID_korisnik.ToString();
            labelIme.Text = korisnik.Ime;
            labelPrezime.Text = korisnik.Prezime;
            labelKorIme.Text = korisnik.Korisnicko_ime;
            labelKontakt.Text = korisnik.Kontakt;
            labelDatumRodenja.Text = korisnik.Datum_rodenja.ToString("dd-MM-yyyy");
            labelMjestoStanovanja.Text = korisnik.Mjesto_stanovanja;
            labelOIB.Text = korisnik.OIB;
            labelEmail.Text = korisnik.Email;
            labelUloga.Text = PrijavljeniKorisnik.VratiUlogu();
            if (korisnik.UgovorDo != null)
            {
                labelUgovorDo.Text = korisnik.UgovorDo.ToString();
            }
            else labelUgovorDo.Text = "Nije odredeno";

            labelBrojProizvodaSaSmanjenomZalihom.Text = DBRepository.DohvatiProizvodeSaSmanjenomZalihom().Count().ToString();
            labelbrojProizvodaNaPopustu.Text = DBRepository.DohvatiProizvodeNaPopustu().Count().ToString();
        }

        private void bindChart() 
        {
            chartProizvodaPoKategorijama.Series.Clear();
            chartProizvodaPoKategorijama.Series.Add("Kolicina");

            List<Klase.PodaciGrafikon> proizvodiZaGraf = DBRepository.DohvatiKategorijeIKolicinuDostupnihProizvoda();
            foreach (var item in proizvodiZaGraf)
            {
                chartProizvodaPoKategorijama.Series["Kolicina"].Points.AddXY(item.Naziv_kategorije, item.Kolicina);
            }
        }

        private void SkladistarPocetnaStranicaForm_Load(object sender, EventArgs e)
        {
            NapuniSPodacima();
            this.chartProizvodaPoKategorijama.BackColor = Color.FromArgb(37, 42, 64);
            this.chartProizvodaPoKategorijama.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(37, 42, 64);
            this.chartProizvodaPoKategorijama.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(37, 42, 64);
        }
    }
}
