using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Systemri
{
    public static class UpravljanjeGlavnomFormom
    {
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        public static void DeaktivirajTipku(Button proslaTipka) 
        {
            
                if (proslaTipka.GetType() == typeof(Button)) 
                {
                    proslaTipka.BackColor = Color.FromArgb(51, 51, 76);
                    proslaTipka.ForeColor = Color.Gainsboro;
                    proslaTipka.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }               
            
        }

        public static void AktivirajTipku(Button trenutnaTipka)
        {
            if (trenutnaTipka.GetType() == typeof(Button))
            {
                trenutnaTipka.BackColor = UpravljanjeGlavnomFormom.ChangeColorBrightness(trenutnaTipka.BackColor, 0.2);
                trenutnaTipka.ForeColor = Color.White;
                trenutnaTipka.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        public static void AktivirajFormu(Form childForm, Panel panel) 
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

