
namespace Systemri
{
    partial class SkladisteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladisteForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxSortiranje = new System.Windows.Forms.ComboBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmijeniProizvod = new System.Windows.Forms.Button();
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.checkBoxPrikaz = new System.Windows.Forms.CheckBox();
            this.checkBoxPopust = new System.Windows.Forms.CheckBox();
            this.labelUkloniFiltere = new System.Windows.Forms.Label();
            this.buttonPopust = new System.Windows.Forms.Button();
            this.dataGridViewProizvodi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBoxKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategorija.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(30, 187);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(353, 23);
            this.comboBoxKategorija.TabIndex = 3;
            this.comboBoxKategorija.Text = "Odaberite kategoriju...";
            this.comboBoxKategorija.SelectedValueChanged += new System.EventHandler(this.comboBoxKategorija_SelectedValueChanged);
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBoxSortiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortiranje.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortiranje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Location = new System.Drawing.Point(31, 268);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(353, 23);
            this.comboBoxSortiranje.TabIndex = 4;
            this.comboBoxSortiranje.Text = "Odaberite nacin sortiranja...";
            this.comboBoxSortiranje.SelectedValueChanged += new System.EventHandler(this.comboBoxSortiranje_SelectedValueChanged);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(699, 173);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisi.TabIndex = 10;
            this.buttonObrisi.Text = "Obriši proizvod";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonDodaj.Image")));
            this.buttonDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodaj.Location = new System.Drawing.Point(699, 75);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(312, 50);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj novi proizvod";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmijeniProizvod
            // 
            this.buttonIzmijeniProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzmijeniProizvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonIzmijeniProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzmijeniProizvod.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmijeniProizvod.ForeColor = System.Drawing.Color.White;
            this.buttonIzmijeniProizvod.Location = new System.Drawing.Point(867, 173);
            this.buttonIzmijeniProizvod.Name = "buttonIzmijeniProizvod";
            this.buttonIzmijeniProizvod.Size = new System.Drawing.Size(144, 37);
            this.buttonIzmijeniProizvod.TabIndex = 11;
            this.buttonIzmijeniProizvod.Text = "Izmijeni proizvod";
            this.buttonIzmijeniProizvod.UseVisualStyleBackColor = false;
            this.buttonIzmijeniProizvod.Click += new System.EventHandler(this.buttonIzmijeniProizvod_Click);
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(658, 335);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(353, 20);
            this.textBoxPretrazivanje.TabIndex = 12;
            this.textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            this.textBoxPretrazivanje.TextChanged += new System.EventHandler(this.textBoxPretrazivanje_TextChanged);
            this.textBoxPretrazivanje.Enter += new System.EventHandler(this.textBoxPretrazivanje_Enter);
            this.textBoxPretrazivanje.Leave += new System.EventHandler(this.textBoxPretrazivanje_Leave);
            // 
            // checkBoxPrikaz
            // 
            this.checkBoxPrikaz.AutoSize = true;
            this.checkBoxPrikaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.checkBoxPrikaz.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrikaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxPrikaz.Location = new System.Drawing.Point(30, 75);
            this.checkBoxPrikaz.Name = "checkBoxPrikaz";
            this.checkBoxPrikaz.Size = new System.Drawing.Size(354, 25);
            this.checkBoxPrikaz.TabIndex = 13;
            this.checkBoxPrikaz.Text = "Prikazi samo proizvode sa smanjenom zalihom";
            this.checkBoxPrikaz.UseVisualStyleBackColor = false;
            this.checkBoxPrikaz.CheckedChanged += new System.EventHandler(this.checkBoxPrikaz_CheckedChanged);
            // 
            // checkBoxPopust
            // 
            this.checkBoxPopust.AutoSize = true;
            this.checkBoxPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.checkBoxPopust.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPopust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxPopust.Location = new System.Drawing.Point(30, 129);
            this.checkBoxPopust.Name = "checkBoxPopust";
            this.checkBoxPopust.Size = new System.Drawing.Size(272, 25);
            this.checkBoxPopust.TabIndex = 14;
            this.checkBoxPopust.Text = "Prikazi samo proizvode na popustu";
            this.checkBoxPopust.UseVisualStyleBackColor = false;
            this.checkBoxPopust.CheckedChanged += new System.EventHandler(this.checkBoxPopust_CheckedChanged);
            // 
            // labelUkloniFiltere
            // 
            this.labelUkloniFiltere.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkloniFiltere.ForeColor = System.Drawing.Color.White;
            this.labelUkloniFiltere.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUkloniFiltere.Location = new System.Drawing.Point(28, 340);
            this.labelUkloniFiltere.Name = "labelUkloniFiltere";
            this.labelUkloniFiltere.Size = new System.Drawing.Size(220, 15);
            this.labelUkloniFiltere.TabIndex = 15;
            this.labelUkloniFiltere.Text = "Ukloni filtere";
            this.labelUkloniFiltere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUkloniFiltere.Click += new System.EventHandler(this.labelPoduzece_Click);
            // 
            // buttonPopust
            // 
            this.buttonPopust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonPopust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPopust.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPopust.ForeColor = System.Drawing.Color.White;
            this.buttonPopust.Image = ((System.Drawing.Image)(resources.GetObject("buttonPopust.Image")));
            this.buttonPopust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPopust.Location = new System.Drawing.Point(699, 254);
            this.buttonPopust.Name = "buttonPopust";
            this.buttonPopust.Size = new System.Drawing.Size(312, 37);
            this.buttonPopust.TabIndex = 16;
            this.buttonPopust.Text = "Dodaj/Ukloni popust";
            this.buttonPopust.UseVisualStyleBackColor = false;
            this.buttonPopust.Click += new System.EventHandler(this.buttonPopust_Click);
            // 
            // dataGridViewProizvodi
            // 
            this.dataGridViewProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProizvodi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewProizvodi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProizvodi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProizvodi.ColumnHeadersHeight = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProizvodi.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProizvodi.EnableHeadersVisualStyles = false;
            this.dataGridViewProizvodi.Location = new System.Drawing.Point(31, 361);
            this.dataGridViewProizvodi.Name = "dataGridViewProizvodi";
            this.dataGridViewProizvodi.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProizvodi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewProizvodi.RowTemplate.Height = 45;
            this.dataGridViewProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProizvodi.Size = new System.Drawing.Size(981, 269);
            this.dataGridViewProizvodi.TabIndex = 28;
            this.dataGridViewProizvodi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProizvodi_CellFormatting);
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.dataGridViewProizvodi);
            this.Controls.Add(this.buttonPopust);
            this.Controls.Add(this.labelUkloniFiltere);
            this.Controls.Add(this.checkBoxPopust);
            this.Controls.Add(this.checkBoxPrikaz);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.buttonIzmijeniProizvod);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.label1);
            this.Name = "SkladisteForm";
            this.Text = "SkladisteForm";
            this.Load += new System.EventHandler(this.SkladisteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxSortiranje;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmijeniProizvod;
        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.CheckBox checkBoxPrikaz;
        private System.Windows.Forms.CheckBox checkBoxPopust;
        private System.Windows.Forms.Label labelUkloniFiltere;
        private System.Windows.Forms.Button buttonPopust;
        private System.Windows.Forms.DataGridView dataGridViewProizvodi;
    }
}