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
    public partial class NovaTransakcijaForm : Form
    {
        private List<Proizvod> racun = new List<Proizvod>();
        public NovaTransakcijaForm()
        {
            InitializeComponent();
            OsvjeziDGVProizvodi();
            panelStavke.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(Color.FromArgb(46, 51, 73), -0.1);
        }

        private void textBoxPretrazivanje_Leave(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "")
            {
                textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            }
        }

        private void textBoxPretrazivanje_Enter(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "Pretrazite proizvod po imenu...") 
            {
                textBoxPretrazivanje.Text = "";
            }
        }

        private void OsvjeziDGVProizvodi() 
        {
            dataGridViewProizvodi.DataSource = DBRepository.DohvatiProizvode();
            dataGridViewProizvodi.Columns[0].Visible = false;
            dataGridViewProizvodi.Columns[1].HeaderText = "Naziv";
            dataGridViewProizvodi.Columns[2].HeaderText = "Cijena";
            dataGridViewProizvodi.Columns[3].HeaderText = "Količina";
            dataGridViewProizvodi.Columns[4].HeaderText = "Popust";
            dataGridViewProizvodi.Columns[5].HeaderText = "Iznos popusta";
            dataGridViewProizvodi.Columns[6].HeaderText = "Kategorija proizvoda";
            dataGridViewProizvodi.Columns[7].HeaderText = "Dobavljač";
            dataGridViewProizvodi.Columns[8].HeaderText = "Proizvođač";
            dataGridViewProizvodi.Columns[9].HeaderText = "Mjerna jedinica";
            dataGridViewProizvodi.Columns[10].Visible = false;
            dataGridViewProizvodi.Columns[11].Visible = false;
            dataGridViewProizvodi.Columns[12].Visible = false;
            dataGridViewProizvodi.Columns[13].Visible = false;
            dataGridViewProizvodi.Columns[14].Visible = false;
            dataGridViewProizvodi.Columns[15].Visible = false;
            dataGridViewProizvodi.Columns[16].Visible = false;
        }
    }
}
