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
    public partial class AdministratorPocetnaStranicaForm : Form
    {
        private List<Korisnik> korisnici;
        public AdministratorPocetnaStranicaForm()
        {
            korisnici = DBRepository.DohvatiSveKorisnike();
            InitializeComponent(); 
        }

        private void AdministratorPocetnaStranicaForm_Load(object sender, EventArgs e)
        {
            OsvjeziDGV();
            dataGridViewRacuni.Columns[3].HeaderText = "Korisnicko ime";
            dataGridViewRacuni.Columns[4].HeaderText = "Ukupan iznos";
            dataGridViewRacuni.Columns[5].Visible = false;
            dataGridViewRacuni.Columns[6].Visible = false;
        }

        private void OsvjeziDGV() 
        {
            dataGridViewRacuni.DataSource = DBRepository.DohvatiRacune();
            labelDnevniPromet.Text = DBRepository.IzracunajDnevniPromet().ToString() + " kn";
            labelMjesecniPromet.Text = DBRepository.IzracunajMjesecniPromet().ToString() + " kn";
            labelTjedniPromet.Text = DBRepository.IzracunajTjedniPromet().ToString() + " kn";
            labelBrojProizvodaSaSmanjenomZalihom.Text = (DBRepository.DohvatiProizvodeSaSmanjenomZalihom().Count).ToString();
        }

        private void buttonStorniraj_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacuni.CurrentRow != null)
            {
                DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite stornirati racun s ID-em: " + (dataGridViewRacuni.CurrentRow.DataBoundItem as Racun).ID_racuna + "?", "Upozorenje o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rezultat == DialogResult.Yes)
                {
                    DBRepository.ObrisiRacun(dataGridViewRacuni.CurrentRow.DataBoundItem as Racun);
                    OsvjeziDGV();
                }
                
            }
            else 
            {
                MessageBox.Show("Niste odabrali racun!");
            }
        }

        private void dataGridViewRacuni_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.FormattingApplied = true;
                int temp = int.Parse(dataGridViewRacuni.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = korisnici.FirstOrDefault(x=>x.ID_korisnik == temp).Korisnicko_ime;
            }
            if (e.ColumnIndex == 4) 
            {
                e.FormattingApplied = true;
                float temp = float.Parse(dataGridViewRacuni.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = (temp.ToString()) + " kn";
            }
        }
    }
}
