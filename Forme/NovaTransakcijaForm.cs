using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Systemri
{
    public partial class NovaTransakcijaForm : Form
    {
        private readonly List<Proizvod> racun = new List<Proizvod>();
        private List<Proizvod> proizvodi = new List<Proizvod>();
        private double ukupno;
        private double koeficijent;
        public NovaTransakcijaForm()
        {
            InitializeComponent();
        }

        private void textBoxPretrazivanje_Leave(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "")
            {
                textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
                OsvjeziDGVProizvodi();
            }
        }

        private void textBoxPretrazivanje_Enter(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "Pretrazite proizvod po imenu...") 
            {
                textBoxPretrazivanje.Text = "";
            }
        }

        private void SakrijPodatke(DataGridView dataGridView) 
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Naziv";
            dataGridView.Columns[2].HeaderText = "Cijena";
            dataGridView.Columns[3].HeaderText = "Količina";
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Iznos popusta";
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].HeaderText = "Mjerna jedinica";
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            dataGridView.Columns[14].Visible = false;
            dataGridView.Columns[15].Visible = false;
            dataGridView.Columns[16].Visible = false;
        }

        private void OsvjeziDGVProizvodi() 
        {
            dataGridViewProizvodi.DataSource = proizvodi.ToList();
            SakrijPodatke(dataGridViewProizvodi);
            
        }

        private void OsvjeziDGVRacun() 
        {
            dataGridViewRacun.DataSource = racun.ToList();
            panelStavke.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(Color.FromArgb(46, 51, 73), -koeficijent);
            labelUkupno.Text = ukupno.ToString() + " kn";
            SakrijPodatke(dataGridViewRacun);
        }

        private void buttonDodajJedinicu_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvodi.CurrentRow != null)
            {
                Proizvod odabrani = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
                try
                {
                    UpravljanjePodacima.DodajNaRacun(odabrani, racun, 1);
                    ukupno += odabrani.Cijena_proizvoda;
                    koeficijent += 0.01;
                    OsvjeziDGVProizvodi();
                    OsvjeziDGVRacun();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
        }

        private void dataGridViewProizvodi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int temp = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (temp == 0) e.CellStyle.BackColor = Color.PaleVioletRed;
            }
            if (e.ColumnIndex == 5)
            {
                e.FormattingApplied = true;
                if (dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
                {
                    float id = float.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    e.Value = (id * 100).ToString() + " %";
                }
            }
            
        }

        private void dataGridViewRacun_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.FormattingApplied = true;
                float id = float.Parse(dataGridViewRacun.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = (id * 100).ToString() + " %";
            }
        }

        private void buttonDodajVise_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvodi.CurrentRow != null)
            {
                Proizvod odabrani = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
                if (odabrani.Kolicina_proizvoda != 0) 
                {
                    try
                    {
                        using (var form = new Forme.UnesiKolicinuForm(odabrani.Kolicina_proizvoda))
                        {
                            var rez = form.ShowDialog();
                            if (rez == DialogResult.OK)
                            {
                                UpravljanjePodacima.DodajNaRacun(odabrani, racun, form.kolicina);
                                ukupno += (form.kolicina * odabrani.Cijena_proizvoda);
                                koeficijent += (0.01 * form.kolicina);
                                OsvjeziDGVProizvodi();
                                OsvjeziDGVRacun();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
            
        }

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text != "Pretrazite proizvod po imenu...")
            {
                proizvodi.Clear();
                proizvodi = DBRepository.DohvatiPretrazeneProizvode(textBoxPretrazivanje.Text);
                UpravljanjePodacima.OduzmiKolicinuSaProizvoda(proizvodi,racun);
                OsvjeziDGVProizvodi();
            }
        }

        private void buttonObrisiJedinicu_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.CurrentCell != null) 
            {
                Proizvod proizvod = dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod;
                if (proizvod.Kolicina_proizvoda > 1)
                {
                    proizvod.Kolicina_proizvoda -= 1;   
                }
                else 
                {
                    racun.Remove(proizvod); 
                }
                UpravljanjePodacima.DodajJedanProizodaNaProizvode(proizvodi, proizvod);
                ukupno -= proizvod.Cijena_proizvoda;
                koeficijent -= 0.01;
                OsvjeziDGVRacun();
                OsvjeziDGVProizvodi();
            }
            else
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
        }

        private void buttonObrisiVise_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.CurrentCell != null)
            {
                Proizvod proizvod = dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod;
                UpravljanjePodacima.DodajKolicinuProizodaNaProizvode(proizvodi,proizvod);
                ukupno -= (proizvod.Cijena_proizvoda * proizvod.Kolicina_proizvoda);
                koeficijent -= (0.01 * proizvod.Kolicina_proizvoda);
                racun.Remove(proizvod);
                OsvjeziDGVRacun();
                OsvjeziDGVProizvodi();
            }
            else 
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
        }

        private void buttonIzvrsiTransakciju_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Izrsiti transakciju u iznosu od: " + ukupno + "?", "Upozorenje o izvrsavanju transakcija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    DBRepository.NapraviRacun(racun);
                    racun.Clear();
                    ukupno = 0;
                    koeficijent = 0;
                    OsvjeziDGVRacun();
                } 
            }
            else 
            {
                MessageBox.Show("Nema proizvoda u kosarici!");
            }
        }

        private void NovaTransakcijaForm_Load(object sender, EventArgs e)
        {
            proizvodi = DBRepository.DohvatiProizvode();
            ukupno = 0;
            koeficijent = 0;
            OsvjeziDGVProizvodi();
            OsvjeziDGVRacun();
        }
    }
}
