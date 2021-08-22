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
        public NovaTransakcijaForm()
        {
            InitializeComponent();
            proizvodi = DBRepository.DohvatiProizvode();
            OsvjeziDGVProizvodi();
            OsvjeziDGVRacun();
            panelStavke.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(Color.FromArgb(46, 51, 73), -0.1);
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
            SakrijPodatke(dataGridViewRacun);
        }

        private void buttonDodajJedinicu_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvodi.CurrentRow != null)
            {
                Proizvod odabrani = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
                try
                {
                    UpravljanjePodacima.DodajNaRacun(odabrani, proizvodi, racun, 1);
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
                float id = float.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = (id * 100).ToString() + " %";
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
                try
                {
                    using (var form = new Forme.UnesiKolicinuForm(odabrani.Kolicina_proizvoda)) 
                    {
                        var rez = form.ShowDialog();
                        if (rez == DialogResult.OK) 
                        {
                            UpravljanjePodacima.DodajNaRacun(odabrani, proizvodi, racun, form.kolicina);
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
                UpravljanjePodacima.DodajKolicinuProizodaNaProizvode(proizvodi, dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod);
                racun.Remove(dataGridViewRacun.CurrentRow.DataBoundItem as Proizvod);
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
                DBRepository.NapraviRacun(racun);
                racun.Clear();
                OsvjeziDGVRacun();
            }
        }
    }
}
