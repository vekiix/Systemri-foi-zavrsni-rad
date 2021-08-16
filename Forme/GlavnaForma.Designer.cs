
namespace Systemri
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.panelNavigacija = new System.Windows.Forms.Panel();
            this.labelPodruznica = new System.Windows.Forms.Label();
            this.labelPoduzece = new System.Windows.Forms.Label();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.buttonUpravljanjeKorisnicima = new System.Windows.Forms.Button();
            this.buttonNovaTransakcija = new System.Windows.Forms.Button();
            this.buttonSkladiste = new System.Windows.Forms.Button();
            this.buttonPocetnaStranica = new System.Windows.Forms.Button();
            this.panelKorisnik = new System.Windows.Forms.Panel();
            this.labelVrstaKorisnika = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForma = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNavigacija.SuspendLayout();
            this.panelKorisnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigacija
            // 
            this.panelNavigacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNavigacija.Controls.Add(this.panel1);
            this.panelNavigacija.Controls.Add(this.buttonOdjava);
            this.panelNavigacija.Controls.Add(this.buttonUpravljanjeKorisnicima);
            this.panelNavigacija.Controls.Add(this.buttonNovaTransakcija);
            this.panelNavigacija.Controls.Add(this.buttonSkladiste);
            this.panelNavigacija.Controls.Add(this.buttonPocetnaStranica);
            this.panelNavigacija.Controls.Add(this.panelKorisnik);
            this.panelNavigacija.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigacija.Location = new System.Drawing.Point(0, 0);
            this.panelNavigacija.Name = "panelNavigacija";
            this.panelNavigacija.Size = new System.Drawing.Size(220, 681);
            this.panelNavigacija.TabIndex = 0;
            // 
            // labelPodruznica
            // 
            this.labelPodruznica.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPodruznica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPodruznica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPodruznica.Location = new System.Drawing.Point(0, 30);
            this.labelPodruznica.Name = "labelPodruznica";
            this.labelPodruznica.Size = new System.Drawing.Size(220, 12);
            this.labelPodruznica.TabIndex = 7;
            this.labelPodruznica.Text = ".";
            this.labelPodruznica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoduzece
            // 
            this.labelPoduzece.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoduzece.ForeColor = System.Drawing.Color.White;
            this.labelPoduzece.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPoduzece.Location = new System.Drawing.Point(0, 10);
            this.labelPoduzece.Name = "labelPoduzece";
            this.labelPoduzece.Size = new System.Drawing.Size(220, 15);
            this.labelPoduzece.TabIndex = 6;
            this.labelPoduzece.Text = ".";
            this.labelPoduzece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOdjava.FlatAppearance.BorderSize = 0;
            this.buttonOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOdjava.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdjava.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOdjava.Image = ((System.Drawing.Image)(resources.GetObject("buttonOdjava.Image")));
            this.buttonOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOdjava.Location = new System.Drawing.Point(0, 621);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonOdjava.Size = new System.Drawing.Size(220, 60);
            this.buttonOdjava.TabIndex = 5;
            this.buttonOdjava.Text = "      Odjava";
            this.buttonOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // buttonUpravljanjeKorisnicima
            // 
            this.buttonUpravljanjeKorisnicima.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpravljanjeKorisnicima.FlatAppearance.BorderSize = 0;
            this.buttonUpravljanjeKorisnicima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpravljanjeKorisnicima.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpravljanjeKorisnicima.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpravljanjeKorisnicima.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpravljanjeKorisnicima.Image")));
            this.buttonUpravljanjeKorisnicima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpravljanjeKorisnicima.Location = new System.Drawing.Point(0, 314);
            this.buttonUpravljanjeKorisnicima.Name = "buttonUpravljanjeKorisnicima";
            this.buttonUpravljanjeKorisnicima.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonUpravljanjeKorisnicima.Size = new System.Drawing.Size(220, 60);
            this.buttonUpravljanjeKorisnicima.TabIndex = 4;
            this.buttonUpravljanjeKorisnicima.Text = "      Upravljanje korisnicima";
            this.buttonUpravljanjeKorisnicima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpravljanjeKorisnicima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpravljanjeKorisnicima.UseVisualStyleBackColor = true;
            this.buttonUpravljanjeKorisnicima.Click += new System.EventHandler(this.buttonUpravljanjeKorisnicima_Click);
            // 
            // buttonNovaTransakcija
            // 
            this.buttonNovaTransakcija.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNovaTransakcija.FlatAppearance.BorderSize = 0;
            this.buttonNovaTransakcija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaTransakcija.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaTransakcija.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNovaTransakcija.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovaTransakcija.Image")));
            this.buttonNovaTransakcija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovaTransakcija.Location = new System.Drawing.Point(0, 254);
            this.buttonNovaTransakcija.Name = "buttonNovaTransakcija";
            this.buttonNovaTransakcija.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonNovaTransakcija.Size = new System.Drawing.Size(220, 60);
            this.buttonNovaTransakcija.TabIndex = 3;
            this.buttonNovaTransakcija.Text = "      Nova transakcija";
            this.buttonNovaTransakcija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovaTransakcija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovaTransakcija.UseVisualStyleBackColor = true;
            this.buttonNovaTransakcija.Click += new System.EventHandler(this.buttonNovaTransakcija_Click);
            // 
            // buttonSkladiste
            // 
            this.buttonSkladiste.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSkladiste.FlatAppearance.BorderSize = 0;
            this.buttonSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkladiste.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkladiste.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSkladiste.Image = ((System.Drawing.Image)(resources.GetObject("buttonSkladiste.Image")));
            this.buttonSkladiste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSkladiste.Location = new System.Drawing.Point(0, 194);
            this.buttonSkladiste.Name = "buttonSkladiste";
            this.buttonSkladiste.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonSkladiste.Size = new System.Drawing.Size(220, 60);
            this.buttonSkladiste.TabIndex = 2;
            this.buttonSkladiste.Text = "      Skladište";
            this.buttonSkladiste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSkladiste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSkladiste.UseVisualStyleBackColor = true;
            this.buttonSkladiste.Click += new System.EventHandler(this.buttonSkladiste_Click);
            // 
            // buttonPocetnaStranica
            // 
            this.buttonPocetnaStranica.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPocetnaStranica.FlatAppearance.BorderSize = 0;
            this.buttonPocetnaStranica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPocetnaStranica.Font = new System.Drawing.Font("Times New Roman", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPocetnaStranica.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPocetnaStranica.Image = ((System.Drawing.Image)(resources.GetObject("buttonPocetnaStranica.Image")));
            this.buttonPocetnaStranica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPocetnaStranica.Location = new System.Drawing.Point(0, 134);
            this.buttonPocetnaStranica.Name = "buttonPocetnaStranica";
            this.buttonPocetnaStranica.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonPocetnaStranica.Size = new System.Drawing.Size(220, 60);
            this.buttonPocetnaStranica.TabIndex = 1;
            this.buttonPocetnaStranica.Text = "      Početna stranica";
            this.buttonPocetnaStranica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPocetnaStranica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPocetnaStranica.UseVisualStyleBackColor = true;
            this.buttonPocetnaStranica.Click += new System.EventHandler(this.buttonPocetnaStranica_Click);
            // 
            // panelKorisnik
            // 
            this.panelKorisnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelKorisnik.Controls.Add(this.labelVrstaKorisnika);
            this.panelKorisnik.Controls.Add(this.labelUsername);
            this.panelKorisnik.Controls.Add(this.pictureBox1);
            this.panelKorisnik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKorisnik.Location = new System.Drawing.Point(0, 0);
            this.panelKorisnik.Name = "panelKorisnik";
            this.panelKorisnik.Size = new System.Drawing.Size(220, 134);
            this.panelKorisnik.TabIndex = 0;
            // 
            // labelVrstaKorisnika
            // 
            this.labelVrstaKorisnika.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrstaKorisnika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelVrstaKorisnika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVrstaKorisnika.Location = new System.Drawing.Point(0, 108);
            this.labelVrstaKorisnika.Name = "labelVrstaKorisnika";
            this.labelVrstaKorisnika.Size = new System.Drawing.Size(220, 12);
            this.labelVrstaKorisnika.TabIndex = 2;
            this.labelVrstaKorisnika.Text = ".";
            this.labelVrstaKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUsername.Location = new System.Drawing.Point(0, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(220, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = ".";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForma
            // 
            this.panelForma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForma.Location = new System.Drawing.Point(220, 0);
            this.panelForma.Name = "panelForma";
            this.panelForma.Size = new System.Drawing.Size(1044, 681);
            this.panelForma.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.labelPodruznica);
            this.panel1.Controls.Add(this.labelPoduzece);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 54);
            this.panel1.TabIndex = 8;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelForma);
            this.Controls.Add(this.panelNavigacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlavnaForma";
            this.Text = "Systemri";
            this.panelNavigacija.ResumeLayout(false);
            this.panelKorisnik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigacija;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Button buttonUpravljanjeKorisnicima;
        private System.Windows.Forms.Button buttonNovaTransakcija;
        private System.Windows.Forms.Button buttonSkladiste;
        private System.Windows.Forms.Button buttonPocetnaStranica;
        private System.Windows.Forms.Panel panelKorisnik;
        private System.Windows.Forms.Panel panelForma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVrstaKorisnika;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPodruznica;
        private System.Windows.Forms.Label labelPoduzece;
        private System.Windows.Forms.Panel panel1;
    }
}

