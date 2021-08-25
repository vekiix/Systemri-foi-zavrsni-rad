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
    public partial class UpravljanjeKorisnicimaForm : Form
    {
        public UpravljanjeKorisnicimaForm()
        {
            InitializeComponent();
            OsvjeziDGV(DBRepository.DohvatiKorisnike());
            dataGridViewKorisnici.Columns[0].HeaderText = "ID";
            dataGridViewKorisnici.Columns[3].HeaderText = "Korisnicko ime";
            dataGridViewKorisnici.Columns[4].Visible = false;
            dataGridViewKorisnici.Columns[5].HeaderText = "Mjesto stanovanja";
            dataGridViewKorisnici.Columns[9].HeaderText = "Datum rodenja";
            dataGridViewKorisnici.Columns[10].HeaderText = "Pocetak ugovora";
            dataGridViewKorisnici.Columns[11].HeaderText = "Kraj ugovora";
            dataGridViewKorisnici.Columns[12].HeaderText = "Uloga";
            dataGridViewKorisnici.Columns[13].HeaderText = "ID podruznice";
            dataGridViewKorisnici.Columns[14].Visible = false;
            dataGridViewKorisnici.Columns[15].Visible = false;
            dataGridViewKorisnici.Columns[16].Visible = false;
        }

        private void textBoxPretrazivanje_Enter(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "Pretrazite korisnika po imenu...") 
            {
                textBoxPretrazivanje.Text = "";
            }
        }

        private void textBoxPretrazivanje_Leave(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "")
            {
                textBoxPretrazivanje.Text = "Pretrazite korisnika po imenu...";
            }
        }

        private void OsvjeziDGV(List<Korisnik> korisnici) 
        {
            dataGridViewKorisnici.DataSource = korisnici;
            
        }

        private void dataGridViewKorisnici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                e.FormattingApplied = true;
                int temp = int.Parse(dataGridViewKorisnici.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = UpravljanjePodacima.VratiUlogu(temp);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewKorisnici.CurrentRow != null)
            {
                Korisnik korisnik = dataGridViewKorisnici.CurrentRow.DataBoundItem as Korisnik;
                DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati korisnika '" + korisnik.Ime + " " + korisnik.Prezime+ "'?", "Upozorenje o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rezultat == DialogResult.Yes)
                {
                    DBRepository.ObrisiKorisnika(korisnik);
                }
                OsvjeziDGV(DBRepository.DohvatiKorisnike());
            }
            else 
            {
                MessageBox.Show("Niste odabrali korisnika!");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajKorisnikaForm form = new DodajKorisnikaForm();
            form.ShowDialog();
            OsvjeziDGV(DBRepository.DohvatiKorisnike());
        }

        private void buttonIzmijeni_Click(object sender, EventArgs e)
        {
            if (dataGridViewKorisnici.CurrentRow != null)
            {
                DodajKorisnikaForm form = new DodajKorisnikaForm(dataGridViewKorisnici.CurrentRow.DataBoundItem as Korisnik);
                form.ShowDialog();
                OsvjeziDGV(DBRepository.DohvatiKorisnike());
            }
            else 
            {
                MessageBox.Show("Niste odabrali korisnika!");
            }
        }

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text != "Pretrazite korisnika po imenu...") 
            {
                OsvjeziDGV(DBRepository.DohvatiPretrazeneKorisnike(textBoxPretrazivanje.Text));
            }
        }
    }
}



