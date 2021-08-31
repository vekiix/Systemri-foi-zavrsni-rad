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
    public partial class UpravljanjePodruznicamaForm : Form
    {
        public event EventHandler PromijenjenaPodruznica;
        public UpravljanjePodruznicamaForm()
        {
            InitializeComponent();
            OsvjeziDGV(DBRepository.DohvatiPodruznice());
        }

        private void OsvjeziDGV(List<Podruznica> podruznice) 
        {
            dataGridViewPodruznice.DataSource = podruznice;
            dataGridViewPodruznice.Columns[0].HeaderText = "ID podruznice";
            dataGridViewPodruznice.Columns[2].HeaderText = "Adresa podruznice";
            dataGridViewPodruznice.Columns[2].HeaderText = "Naziv poduzeca";
            dataGridViewPodruznice.Columns[3].Visible = false;
            dataGridViewPodruznice.Columns[4].Visible = false;
            dataGridViewPodruznice.Columns[5].Visible = false;
            dataGridViewPodruznice.Columns[6].Visible = false;
            dataGridViewPodruznice.Columns[7].Visible = false;
        }

        private void textBoxPretrazivanje_Enter(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "Pretrazite podruznice po ulici...") 
            {
                textBoxPretrazivanje.Text = "";
            }
        }

        private void textBoxPretrazivanje_Leave(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "")
            {
                textBoxPretrazivanje.Text = "Pretrazite podruznice po ulici...";
            }
        }

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text != "Pretrazite podruznice po ulici...") 
            {
               OsvjeziDGV(DBRepository.DohvatiPretrazenePodruznice(textBoxPretrazivanje.Text)); 
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewPodruznice.Columns != null) 
            {
                Podruznica podruznica = dataGridViewPodruznice.CurrentRow.DataBoundItem as Podruznica;
                if (podruznica.ID_podruznica != PrijavljeniKorisnik.VratiIDPodruznice())
                {
                    DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati podruznicu s ID-em: " + podruznica.ID_podruznica + "?", "Upozorenje o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezultat == DialogResult.Yes)
                    {
                        DBRepository.ObrisiPodruznicu(podruznica);
                        OsvjeziDGV(DBRepository.DohvatiPodruznice());
                    }
                }
                else 
                {
                    MessageBox.Show("Trenutno se nalazite na podruznici koju zelite obrisat!");
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajPodruznicuForm dodajPodruznicu = new DodajPodruznicuForm();
            dodajPodruznicu.ShowDialog();
            OsvjeziDGV(DBRepository.DohvatiPodruznice());
        }

        private void dataGridViewPodruznice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                e.FormattingApplied = true;
                e.Value = DBRepository.DohvatiImePoduzeca();
            }
        }

        private void buttonPrebaci_Click(object sender, EventArgs e)
        {
            if (dataGridViewPodruznice.CurrentCell != null) 
            {
                Podruznica izabranaPodruznica = dataGridViewPodruznice.CurrentRow.DataBoundItem as Podruznica;
                if (izabranaPodruznica.ID_podruznica != PrijavljeniKorisnik.VratiIDPodruznice())
                {
                    DialogResult rezultat = MessageBox.Show("Jeste li sigurni da se želite prebaciti na podružnicu s ID-em: " + izabranaPodruznica.ID_podruznica + "?", "Upozorenje o prebacivanju na drugu podruznicu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezultat == DialogResult.Yes) 
                    {
                        PrijavljeniKorisnik.PromijeniIDPodruznice(izabranaPodruznica.ID_podruznica); 
                        EventHandler handler = PromijenjenaPodruznica;
                        if (handler != null) 
                        {
                            handler(this, e);
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Nalazite se na odabranoj podruznici!");
                }
            }
        }
    }
}
