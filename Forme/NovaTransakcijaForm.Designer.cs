
namespace Systemri
{
    partial class NovaTransakcijaForm
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
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProizvodi = new System.Windows.Forms.DataGridView();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRacun = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelStavke = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).BeginInit();
            this.panelStavke.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(474, 58);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(353, 20);
            this.textBoxPretrazivanje.TabIndex = 13;
            this.textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nova transakcija";
            // 
            // dataGridViewProizvodi
            // 
            this.dataGridViewProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvodi.Location = new System.Drawing.Point(26, 100);
            this.dataGridViewProizvodi.Name = "dataGridViewProizvodi";
            this.dataGridViewProizvodi.Size = new System.Drawing.Size(801, 291);
            this.dataGridViewProizvodi.TabIndex = 15;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(861, 100);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisi.TabIndex = 17;
            this.buttonObrisi.Text = "[F1] Dodaj 1 proizvod na račun";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(861, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "[F2] Dodaj više proizvoda na račun";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRacun
            // 
            this.dataGridViewRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacun.Location = new System.Drawing.Point(26, 14);
            this.dataGridViewRacun.Name = "dataGridViewRacun";
            this.dataGridViewRacun.Size = new System.Drawing.Size(801, 189);
            this.dataGridViewRacun.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(861, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "[F3] Obriši jedinicu proizvoda";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(861, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "[F4] Obriši stavku";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(861, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 53);
            this.button4.TabIndex = 20;
            this.button4.Text = "[F5] Izvrši transakciju";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelStavke
            // 
            this.panelStavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStavke.Controls.Add(this.button4);
            this.panelStavke.Controls.Add(this.button3);
            this.panelStavke.Controls.Add(this.button2);
            this.panelStavke.Controls.Add(this.dataGridViewRacun);
            this.panelStavke.Location = new System.Drawing.Point(0, 415);
            this.panelStavke.Name = "panelStavke";
            this.panelStavke.Size = new System.Drawing.Size(1044, 227);
            this.panelStavke.TabIndex = 16;
            // 
            // NovaTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.panelStavke);
            this.Controls.Add(this.dataGridViewProizvodi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Name = "NovaTransakcijaForm";
            this.Text = "TransakcijaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).EndInit();
            this.panelStavke.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProizvodi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRacun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelStavke;
    }
}