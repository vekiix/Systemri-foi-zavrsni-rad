
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPrikaz = new System.Windows.Forms.RadioButton();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
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
            // radioButtonPrikaz
            // 
            this.radioButtonPrikaz.AutoSize = true;
            this.radioButtonPrikaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.radioButtonPrikaz.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrikaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radioButtonPrikaz.Location = new System.Drawing.Point(30, 75);
            this.radioButtonPrikaz.Name = "radioButtonPrikaz";
            this.radioButtonPrikaz.Size = new System.Drawing.Size(353, 25);
            this.radioButtonPrikaz.TabIndex = 2;
            this.radioButtonPrikaz.TabStop = true;
            this.radioButtonPrikaz.Text = "Prikaži samo proizvode sa smanjenom zalihom";
            this.radioButtonPrikaz.UseVisualStyleBackColor = false;
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBoxKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategorija.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(30, 123);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(353, 23);
            this.comboBoxKategorija.TabIndex = 3;
            this.comboBoxKategorija.Text = "Odaberite kategoriju...";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Odaberite način sortiranja...";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(699, 161);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisi.TabIndex = 10;
            this.buttonObrisi.Text = "Obriši proizvod";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(699, 75);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(312, 50);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj novi proizvod";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(867, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Izmijeni proizvod";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(30, 224);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(353, 20);
            this.textBoxPretrazivanje.TabIndex = 12;
            this.textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            this.textBoxPretrazivanje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxPretrazivanje_MouseDown);
            // 
            // dataGridViewProizvodi
            // 
            this.dataGridViewProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvodi.Location = new System.Drawing.Point(30, 276);
            this.dataGridViewProizvodi.Name = "dataGridViewProizvodi";
            this.dataGridViewProizvodi.Size = new System.Drawing.Size(981, 354);
            this.dataGridViewProizvodi.TabIndex = 5;
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewProizvodi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.radioButtonPrikaz);
            this.Controls.Add(this.label1);
            this.Name = "SkladisteForm";
            this.Text = "SkladisteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPrikaz;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.DataGridView dataGridViewProizvodi;
    }
}