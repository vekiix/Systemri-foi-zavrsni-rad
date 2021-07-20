
namespace Systemri
{
    partial class UpravljanjeKorisnicimaForm
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
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Upravljanje korisnicima";
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(580, 66);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(427, 20);
            this.textBoxPretrazivanje.TabIndex = 16;
            this.textBoxPretrazivanje.Text = "Pretrazite korisnika po imenu...";
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(26, 111);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(981, 457);
            this.dataGridViewKorisnici.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(195, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Izmijeni korisnika";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(26, 593);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisi.TabIndex = 19;
            this.buttonObrisi.Text = "Obriši korisnika";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(695, 593);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(312, 37);
            this.buttonDodaj.TabIndex = 21;
            this.buttonDodaj.Text = "Dodaj novog korisnika";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            // 
            // UpravljanjeKorisnicimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjeKorisnicimaForm";
            this.Text = "UpravljanjeKorisnicimaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonDodaj;
    }
}