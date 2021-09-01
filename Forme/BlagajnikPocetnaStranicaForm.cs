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
    public partial class BlagajnikPocetnaStranicaForm : Form
    {
        public event EventHandler NovaTransakcija;
        public BlagajnikPocetnaStranicaForm()
        {
            InitializeComponent();
        }

        private void BlagajnikPocetnaStranicaForm_Load(object sender, EventArgs e)
        {
            NapuniPodacima();
            dataGridViewRacuni.Columns[3].Visible = false;
            dataGridViewRacuni.Columns[4].HeaderText = "Ukupan iznos";
            dataGridViewRacuni.Columns[5].Visible = false;
            dataGridViewRacuni.Columns[6].Visible = false;
            this.chartProizvoda.BackColor = Color.FromArgb(37, 42, 64);
            this.chartProizvoda.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(37, 42, 64);
            this.chartProizvoda.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(37, 42, 64);
        }

        private void NapuniPodacima() 
        {
            bindChart();
            labelBrojProizvodaSaSmanjenomZalihom.Text = DBRepository.DohvatiProizvodeSaSmanjenomZalihom().Count().ToString();
            labelDnevniPromet.Text = DBRepository.IzracunajDnevniPromet().ToString();
            dataGridViewRacuni.DataSource = DBRepository.DohvatiStvoreneRacune();
            var najnoviji = DBRepository.DohvatiRacune().OrderByDescending(x => x.ID_racuna)
                                        .FirstOrDefault();
            labelIznosPosljednjegRacuna.Text = najnoviji.Ukupan_iznos.ToString();
        }

        private void bindChart() 
        {
            chartProizvoda.Series.Clear();
            chartProizvoda.Series.Add("Proizvodi na popustu");

            List<Klase.PodaciGrafikon> proizvodiZaGraf = DBRepository.DohvatiKategorijeIBrojProizvodaNaPopustu();
            proizvodiZaGraf.Distinct().ToList();
            foreach (var item in proizvodiZaGraf)
            {
                chartProizvoda.Series["Proizvodi na popustu"].Points.AddXY(item.Naziv_kategorije, item.Kolicina);
            }
        }

        private void buttonPregledaj_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacuni.CurrentCell != null)
            {
                Racun racun = dataGridViewRacuni.CurrentRow.DataBoundItem as Racun;
                PregledajTransakcijuForm form = new PregledajTransakcijuForm(racun);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati prozivod!");
            }
        }

        private void buttonNovaTransakcija_Click(object sender, EventArgs e)
        {
            EventHandler handler = NovaTransakcija;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void dataGridViewRacuni_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.FormattingApplied = true;
                float temp = float.Parse(dataGridViewRacuni.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = (temp.ToString()) + " kn";
                e.CellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            }
        }
    }
}
