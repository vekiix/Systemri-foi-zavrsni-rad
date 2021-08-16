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
    public partial class SkladisteForm : Form        
    {
        public SkladisteForm()
        {
            InitializeComponent();
            OsvjeziDGV(DBRepository.DohvatiProizvode());
            NapuniComboBoxove();
        }

        private void NapuniComboBoxove() 
        {
            foreach (Kategorija_Proizvoda kategorija in DBRepository.DohvatiKategorijeProizvoda()) 
            {
                comboBoxKategorija.Items.Add(kategorija.ToString());
            }

            comboBoxSortiranje.Items.Add("Uzlazno po nazivu");
            comboBoxSortiranje.Items.Add("Silazno po nazivu");
            comboBoxSortiranje.Items.Add("Uzlazno po cijeni");
            comboBoxSortiranje.Items.Add("Silazno po cijeni");
            comboBoxSortiranje.Items.Add("Uzlazno po kolicini");
            comboBoxSortiranje.Items.Add("Silazno po kolicini");
        }

        private void OsvjeziDGV(List<Proizvod> proizvods) 
        {
            if (comboBoxSortiranje.SelectedItem != default) 
            {
                switch (comboBoxSortiranje.SelectedItem.ToString())
                {
                    case "Uzlazno po nazivu": proizvods = (List<Proizvod>)proizvods.OrderBy(p => p.Naziv_proizvoda).ToList(); break;
                    case "Silazno po nazivu": proizvods = (List<Proizvod>)proizvods.OrderByDescending(p => p.Naziv_proizvoda).ToList(); break;
                    case "Uzlazno po cijeni": proizvods = (List<Proizvod>)proizvods.OrderBy(p => p.Cijena_proizvoda).ToList(); break;
                    case "Silazno po cijeni": proizvods = (List<Proizvod>)proizvods.OrderByDescending(p => p.Cijena_proizvoda).ToList(); break;
                    case "Uzlazno po kolicini": proizvods = (List<Proizvod>)proizvods.OrderBy(p => p.Kolicina_proizvoda).ToList(); break;
                    case "Silazno po kolicini": proizvods = (List<Proizvod>)proizvods.OrderByDescending(p => p.Kolicina_proizvoda).ToList(); break;
                    default: break;
                }
            }

            dataGridViewProizvodi.DataSource = proizvods;
            
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

        private List<Proizvod> ProvjeriCheckBoxove() 
        {
            if (checkBoxPrikaz.Checked == false && checkBoxPopust.Checked == false)
            {
                return DBRepository.DohvatiProizvode();
            }
            else if (checkBoxPrikaz.Checked == true && checkBoxPopust.Checked == false)
            {
                return DBRepository.DohvatiProizvodeSaSmanjenomZalihom();
            }
            else if (checkBoxPrikaz.Checked == true && checkBoxPopust.Checked == true)
            {
                return DBRepository.DohvatiProizvodeSaSmanjenomZalihomINaPopustu();
            }
            else return DBRepository.DohvatiProizvodeNaPopustu();
        }

        private void checkBoxPrikaz_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziDGV(ProvjeriCheckBoxove());
            if (comboBoxKategorija.SelectedItem != default)
            {
                comboBoxKategorija.SelectedItem = default;
                comboBoxKategorija.Text = "Odaberite kategoriju...";
            }
        }
        private void checkBoxPopust_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziDGV(ProvjeriCheckBoxove());
            if (comboBoxKategorija.SelectedItem != default)
            {
                comboBoxKategorija.SelectedItem = default;
                comboBoxKategorija.Text = "Odaberite kategoriju...";
            }
        }

        private void textBoxPretrazivanje_Enter(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "Pretrazite proizvod po imenu...")
            {
                textBoxPretrazivanje.Text = "";
            }
        }

        private void textBoxPretrazivanje_Leave(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text == "") 
            {
                textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            }
        }
        

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretrazivanje.Text != "Pretrazite proizvod po imenu...") 
            {
                checkBoxPopust.Checked = false;
                checkBoxPrikaz.Checked = false;
                comboBoxKategorija.SelectedItem = default;
                comboBoxKategorija.Text = "Odaberite kategoriju...";
                OsvjeziDGV(DBRepository.DohvatiPretrazeneProizvode(textBoxPretrazivanje.Text));
            }    
        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKategorija.SelectedItem != default) 
            {
                OsvjeziDGV(UpravljanjePodacima.FiltrirajProizvodePoKategoriji(comboBoxKategorija.Text, ProvjeriCheckBoxove()));
                textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            }
            
        }

        private void comboBoxSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKategorija.Text == "Odaberite kategoriju..." && checkBoxPopust.Checked == false 
                && checkBoxPrikaz.Checked == false && textBoxPretrazivanje.Text == "Pretrazite proizvod po imenu...") 
            {
                OsvjeziDGV(DBRepository.DohvatiProizvode());
            }
        }

        private void labelPoduzece_Click(object sender, EventArgs e)
        {
            if (comboBoxKategorija.SelectedItem != default)
            {
                comboBoxKategorija.SelectedItem = default;
                comboBoxKategorija.Text = "Odaberite kategoriju...";   
            }
            checkBoxPopust.Checked = false;
            checkBoxPrikaz.Checked = false;
            OsvjeziDGV(DBRepository.DohvatiProizvode());
        }

        private void dataGridViewProizvodi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                e.FormattingApplied = true;
                string temp = dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (temp)
                {
                    case "0":
                        e.Value = "Nije na popustu";
                        e.CellStyle.BackColor = Color.PaleVioletRed;
                        break;
                    case "1":
                        e.Value = "Na popustu";
                        e.CellStyle.BackColor = Color.LimeGreen;
                        break;
                    default:
                        e.Value = "Greska";
                        break;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                e.FormattingApplied = true;
                float id = float.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = (id * 100).ToString() + " %";
            }
            else if (e.ColumnIndex == 6)
            {
                e.FormattingApplied = true;
                int id = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = DBRepository.DohvatiImeKategorije(id);
            }
            else if (e.ColumnIndex == 7) 
            {
                e.FormattingApplied = true;
                int id = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = DBRepository.DohvatiImeDobavljaca(id);
            }
            else if (e.ColumnIndex == 8)
            {
                e.FormattingApplied = true;
                int id = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                e.Value = DBRepository.DohvatiImeProizvodaca(id);
            }
            else if (e.ColumnIndex == 9)
            {
                e.FormattingApplied = true;
                string id = dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                e.Value = DBRepository.DohvatiImeMjerneJedinice(id);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            Proizvod proizvod = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
            if (proizvod != null)
            {
                DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati proizvod " + proizvod.Naziv_proizvoda + "?","Upozorenje o brisanju" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes) 
                {
                    DBRepository.ObrisiProizvod(proizvod);
                }
                OsvjeziDGV(DBRepository.DohvatiProizvode());
            }
            else 
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
        }
    }
}
