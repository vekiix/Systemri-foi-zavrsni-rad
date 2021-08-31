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
        private List<Proizvod> racun = new List<Proizvod>();
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
        }

        private void OsvjeziDGVRacun() 
        {
            dataGridViewRacun.DataSource = racun.ToList();
            panelStavke.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(Color.FromArgb(46, 51, 73), -koeficijent);
            labelUkupno.Text = Math.Round(ukupno,2).ToString() + " kn";            
        }

        private void buttonDodajJedinicu_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvodi.CurrentRow != null)
            {
                Proizvod odabrani = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
                try
                {
                    racun = UpravljanjePodacima.DodajNaRacun(odabrani, racun, 1);
                    ukupno += Math.Round(odabrani.Postotak_popusta != null ? (double)(odabrani.Cijena_proizvoda * (1-odabrani.Postotak_popusta)):(double)odabrani.Cijena_proizvoda,2);
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
                                ukupno += Math.Round(odabrani.Postotak_popusta != null ? (double)(odabrani.Cijena_proizvoda * (1- odabrani.Postotak_popusta))*form.kolicina : (double)odabrani.Cijena_proizvoda, 2);
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
                if (dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod != null) 
                {
                    Proizvod odabrani = dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod;
                    if (odabrani.Kolicina_proizvoda > 1)
                    {
                         odabrani.Kolicina_proizvoda -= 1;
                    }
                    else
                    {
                        MessageBox.Show("Brisem!");
                        racun.Remove(odabrani);
                    }
                    UpravljanjePodacima.DodajJedanProizodaNaProizvode(proizvodi, odabrani);
                    ukupno -= Math.Round(odabrani.Postotak_popusta != null ? (double)(odabrani.Cijena_proizvoda * (1 - odabrani.Postotak_popusta)) : (double)odabrani.Cijena_proizvoda, 2);
                    koeficijent -= 0.01;
                    OsvjeziDGVRacun();
                    OsvjeziDGVProizvodi();
                }
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
                if (dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod != null)
                {
                    Proizvod odabrani = dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod;
                    UpravljanjePodacima.DodajKolicinuProizodaNaProizvode(proizvodi, odabrani);
                    ukupno -= Math.Round(odabrani.Postotak_popusta != null ? (double)(odabrani.Cijena_proizvoda * (1 - odabrani.Postotak_popusta)) * odabrani.Kolicina_proizvoda : (double)odabrani.Cijena_proizvoda, 2);
                    koeficijent -= (0.01 * odabrani.Kolicina_proizvoda);
                    racun.Remove(odabrani);
                    OsvjeziDGVRacun();
                    OsvjeziDGVProizvodi();
                }
                else 
                {
                    MessageBox.Show("Niste odabrali proizvod!");
                }
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
                    Izvjesca.RacunReport report = new Izvjesca.RacunReport(DBRepository.NapraviRacun(racun));
                    racun.Clear();
                    ukupno = 0;
                    koeficijent = 0;
                    OsvjeziDGVRacun();
                    report.ShowDialog();
                } 
            }
            else 
            {
                MessageBox.Show("Nema proizvoda u kosarici!");
            }
        }

        private void NovaTransakcijaForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            proizvodi = DBRepository.DohvatiProizvode();
            ukupno = 0;
            koeficijent = 0;
            OsvjeziDGVProizvodi();
            OsvjeziDGVRacun();
            SakrijPodatke(dataGridViewRacun);
            SakrijPodatke(dataGridViewProizvodi);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData) 
            {
                case Keys.F1: buttonDodajJedinicu.PerformClick();break;
                case Keys.F2: buttonDodajVise.PerformClick();break;
                case Keys.F5: buttonObrisiJedinicu.PerformClick();break;
                case Keys.F6: buttonObrisiVise.PerformClick(); break;
                case Keys.F8: buttonIzvrsiTransakciju.PerformClick();break;
                default: break;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
