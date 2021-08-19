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
    public partial class DodajPopustForm : Form
    {
        private Proizvod proizvod { get; set; }
        public DodajPopustForm(Proizvod uneseniProizvod)
        {
            InitializeComponent();
            proizvod = uneseniProizvod;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int br = int.Parse(textBoxPopust.Text);
                DBRepository.DodijeliPopust(br, proizvod);
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
