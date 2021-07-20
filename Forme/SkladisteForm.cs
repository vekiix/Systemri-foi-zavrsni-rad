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
        }

        private void textBoxPretrazivanje_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPretrazivanje.Text = "";
        }
    }
}
