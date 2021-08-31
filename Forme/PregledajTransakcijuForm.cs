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
    public partial class PregledajTransakcijuForm : Form
    {
        private Racun racun = new Racun();
        private List<Proizvod> proizvods = DBRepository.DohvatiProizvode();
        public PregledajTransakcijuForm(Racun racuncic)
        {
            InitializeComponent();
            racun = racuncic;
            NapuniPodatke();
        }

        private void NapuniPodatke() 
        {
            labelID.Text = racun.ID_racuna.ToString();
            labelDatum.Text = racun.Datum.ToString("dd-MM-yyyy");
            labelKorime.Text = racun.Korisnik_ID.ToString();

            dataGridViewStavke.DataSource = DBRepository.DohvatiStavke(racun);
            dataGridViewStavke.Columns[0].HeaderText = "ID";
            dataGridViewStavke.Columns[2].HeaderText = "Ukupan iznos";
            dataGridViewStavke.Columns[3].HeaderText = "Naziv proizvoda";
            dataGridViewStavke.Columns[4].Visible = false;
            dataGridViewStavke.Columns[5].Visible = false;
            dataGridViewStavke.Columns[6].Visible = false;
        }

        private void dataGridViewStavke_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 3) 
            {
                int id = int.Parse(dataGridViewStavke.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = proizvods.FirstOrDefault(x => x.ID_proizvoda == id).Naziv_proizvoda.ToString();
            }
        }


    }
}
