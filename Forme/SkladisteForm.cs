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
        private List<Dobavljac> dobavljaci;
        private List<Proizvodac> proizvodaci;
        private List<Mjerna_Jedinica> mjerneJedinice;
        private List<Kategorija_Proizvoda> kategorije;

        public SkladisteForm()
        {
            InitializeComponent();
            DohvatiListeZaFormatiranje();
        }

        private void DohvatiListeZaFormatiranje() 
        {
            if(dobavljaci != null)dobavljaci.Clear();
            dobavljaci = DBRepository.DohvatiDobavljace();
            if(proizvodaci != null) proizvodaci.Clear();
            proizvodaci = DBRepository.DohvatiProizvodace();
            if (mjerneJedinice != null) mjerneJedinice.Clear();
            mjerneJedinice = DBRepository.DohvatiMjerneJedinice();
            if(kategorije != null) kategorije.Clear();
            kategorije = DBRepository.DohvatiKategorijeProizvoda();
        }

        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            ((ISupportInitialize)dataGridViewProizvodi).BeginInit();
            NapuniComboBoxove();
            OsvjeziDGV(DBRepository.DohvatiProizvode());
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
            ((ISupportInitialize)dataGridViewProizvodi).EndInit();
        }

        private void NapuniComboBoxove() 
        {
            if (comboBoxKategorija.Items != null) comboBoxKategorija.Items.Clear();
            foreach (Kategorija_Proizvoda kategorija in DBRepository.DohvatiKategorijeProizvoda()) 
            {
                comboBoxKategorija.Items.Add(kategorija);
            }

            if (comboBoxSortiranje.Items != null) 
            {
                comboBoxSortiranje.Items.Add("Uzlazno po nazivu");
                comboBoxSortiranje.Items.Add("Silazno po nazivu");
                comboBoxSortiranje.Items.Add("Uzlazno po cijeni");
                comboBoxSortiranje.Items.Add("Silazno po cijeni");
                comboBoxSortiranje.Items.Add("Uzlazno po kolicini");
                comboBoxSortiranje.Items.Add("Silazno po kolicini");
            }   
        }

        private void OcistiFiltere() 
        {
            if (checkBoxPopust.Checked == true) 
            {
                checkBoxPopust.Checked = false;
            }
            if (checkBoxPrikaz.Checked == true) 
            {
                checkBoxPrikaz.Checked = false;
            }
            if (textBoxPretrazivanje.Text != "") textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            if (comboBoxKategorija.SelectedItem != default) 
            {
                comboBoxKategorija.SelectedItem = default;
                comboBoxKategorija.Text = "Odaberite kategoriju...";
            } 
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
            else if (checkBoxPrikaz.Checked == false && checkBoxPopust.Checked == true)
            {
                return DBRepository.DohvatiProizvodeNaPopustu();
            }
            else if (checkBoxPrikaz.Checked == true && checkBoxPopust.Checked == true)
            {
                return DBRepository.DohvatiProizvodeSaSmanjenomZalihomINaPopustu();
            }
            else 
            {
                MessageBox.Show("HAHAHAHAHA");
                return DBRepository.DohvatiProizvode();
            }
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
                OcistiFiltere();
                OsvjeziDGV(DBRepository.DohvatiPretrazeneProizvode(textBoxPretrazivanje.Text));
            }    
        }


        private void labelPoduzece_Click(object sender, EventArgs e)
        {
            OcistiFiltere();
            OsvjeziDGV(DBRepository.DohvatiProizvode());
        }

        private void dataGridViewProizvodi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex) 
            {
                case 4:
                    e.FormattingApplied = true;
                    if (dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
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
                    }break;
                case 5:
                    e.FormattingApplied = true;
                    if (dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        float id = float.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                        e.Value = (id * 100).ToString() + " %";
                    }break;
                case 6:
                    e.FormattingApplied = true;
                    int id2 = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    e.Value = kategorije.FirstOrDefault(x => x.ID_kategorije_proizvoda == id2).Naziv_kategorije_proizvoda;
                    break;
                case 7:
                    e.FormattingApplied = true;
                    int id3 = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    e.Value = dobavljaci.FirstOrDefault(x => x.ID_dobavljaca == id3).Naziv_dobavljaca;
                    break;
                case 8:
                    e.FormattingApplied = true;
                    int id4 = int.Parse(dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    e.Value = proizvodaci.FirstOrDefault(x => x.ID_proizvodaca == id4).Naziv_proizvodaca;
                    break;
                case 9:
                    e.FormattingApplied = true;
                    string id5 = dataGridViewProizvodi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    e.Value = mjerneJedinice.FirstOrDefault(x => x.ID_mjerne_jedinice == id5).Naziv_mjerne_jedinice;
                    break;

            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod != null)
            {
                Proizvod proizvod = dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod;
                DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati proizvod " + proizvod.Naziv_proizvoda + "?","Upozorenje o brisanju" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (rezultat == DialogResult.Yes) 
                {
                    try
                    {
                        DBRepository.ObrisiProizvod(proizvod);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                OsvjeziDGV(DBRepository.DohvatiProizvode());
                OcistiFiltere();
            }
            else 
            {
                MessageBox.Show("Niste odabrali proizvod!");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajProizvodForm proizvodForm = new DodajProizvodForm();
            proizvodForm.ShowDialog();
            DohvatiListeZaFormatiranje();
            OsvjeziDGV(DBRepository.DohvatiProizvode());
            OcistiFiltere();
            NapuniComboBoxove();
        }

        private void buttonIzmijeniProizvod_Click(object sender, EventArgs e)
        {
            DodajProizvodForm form = new DodajProizvodForm(dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod);
            form.ShowDialog();
            DohvatiListeZaFormatiranje();
            OsvjeziDGV(DBRepository.DohvatiProizvode());
            OcistiFiltere();
        }

        private void comboBoxKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxKategorija.SelectedItem as Kategorija_Proizvoda != null)
            {
                OsvjeziDGV(UpravljanjePodacima.FiltrirajProizvodePoKategoriji(comboBoxKategorija.SelectedItem as Kategorija_Proizvoda, ProvjeriCheckBoxove()));
            }
        }

        private void buttonPopust_Click(object sender, EventArgs e)
        {
            if (dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod != null)
            {
                if ((dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod).Popust == 0)
                {
                    Forme.DodajPopustForm form = new Forme.DodajPopustForm(dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod);
                    form.ShowDialog();                 
                }
                else
                {
                    DialogResult rezultat = MessageBox.Show("Jeste li sigurni da zelite maknuti akciju sa proizvoda " + (dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod).Naziv_proizvoda, "Popust", MessageBoxButtons.YesNo);
                    if (rezultat == DialogResult.Yes)
                    {
                        DBRepository.MakniPopust(dataGridViewProizvodi.CurrentRow.DataBoundItem as Proizvod);                        
                    }
                }
                OsvjeziDGV(DBRepository.DohvatiProizvode());
                OcistiFiltere();
            }
            else 
            {
                MessageBox.Show("Morate odabrati proizvod!");
            }
        }

        private void comboBoxSortiranje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxKategorija.Text == "Odaberite kategoriju..." && checkBoxPopust.Checked == false
                && checkBoxPrikaz.Checked == false && textBoxPretrazivanje.Text == "Pretrazite proizvod po imenu...")
            {
                OsvjeziDGV(DBRepository.DohvatiProizvode());
                OcistiFiltere();
            }
            else if (comboBoxKategorija.SelectedItem as Kategorija_Proizvoda != null)
            {
                OsvjeziDGV(UpravljanjePodacima.FiltrirajProizvodePoKategoriji(comboBoxKategorija.SelectedItem as Kategorija_Proizvoda, ProvjeriCheckBoxove()));
            }
        }
    }
}
