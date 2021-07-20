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
        public NovaTransakcijaForm()
        {
            InitializeComponent();
            panelStavke.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(Color.FromArgb(46, 51, 73), -0.1);
        }
    }
}
