using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemri.Forme
{
    public partial class UnesiKolicinuForm : Form
    {
        public int kolicina;
        public UnesiKolicinuForm(int max)
        {
            InitializeComponent();
            kolicina = max;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxPopust.Text) <= kolicina)
                {
                    this.kolicina = int.Parse(textBoxPopust.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nedostupna kolicina proizvoda!");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
