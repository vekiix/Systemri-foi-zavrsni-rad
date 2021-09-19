using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemri.Izvjesca
{
    public partial class RacunReport : Form
    {
        private Racun racun = new Racun();
        public RacunReport(Racun racuncic)
        {
            InitializeComponent();
            racun = racuncic;
        }

        private void RacunReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("imePoduzeca", PrijavljeniKorisnik.VratiImePoduzeca()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("IDPodruznice", PrijavljeniKorisnik.VratiIDPodruznice().ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumRacuna", racun.Datum.ToString("dd-MM-yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("IDRacuna", racun.ID_racuna.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Vrijeme", racun.Vrijeme.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("IDKorisnik", PrijavljeniKorisnik.VratiIDKorisnika().ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("KorisnickoIme", PrijavljeniKorisnik.VratiKorIme()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("UkupanIznosRacuna", racun.Ukupan_iznos.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Adresa", DBRepository.VratiAdresuPodruznice()));


            ReportDataSource rds = new ReportDataSource("DataSetStavka", DBRepository.DohvatiStavke(racun).OrderByDescending(x => x.Proizvod_ID));
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            ReportDataSource ds1 = new ReportDataSource("DataSetProizvodi", DBRepository.DohvatiProizvodeSaRacuna(racun).OrderByDescending(x => x.ID_proizvoda));
            this.reportViewer1.LocalReport.DataSources.Add(ds1);

            this.reportViewer1.RefreshReport();
        }
    }
}
