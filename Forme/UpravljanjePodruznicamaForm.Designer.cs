
namespace Systemri
{
    partial class UpravljanjePodruznicamaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjePodruznicamaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.dataGridViewPodruznice = new System.Windows.Forms.DataGridView();
            this.buttonPrebaci = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodruznice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upravljanje podruznicama";
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(580, 85);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(427, 20);
            this.textBoxPretrazivanje.TabIndex = 24;
            this.textBoxPretrazivanje.Text = "Pretrazite podruznice po ulici...";
            this.textBoxPretrazivanje.TextChanged += new System.EventHandler(this.textBoxPretrazivanje_TextChanged);
            this.textBoxPretrazivanje.Enter += new System.EventHandler(this.textBoxPretrazivanje_Enter);
            this.textBoxPretrazivanje.Leave += new System.EventHandler(this.textBoxPretrazivanje_Leave);
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
            this.buttonObrisi.TabIndex = 25;
            this.buttonObrisi.Text = "Obrisi podruznicu";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // dataGridViewPodruznice
            // 
            this.dataGridViewPodruznice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPodruznice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPodruznice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewPodruznice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPodruznice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPodruznice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPodruznice.ColumnHeadersHeight = 60;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPodruznice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPodruznice.EnableHeadersVisualStyles = false;
            this.dataGridViewPodruznice.Location = new System.Drawing.Point(26, 111);
            this.dataGridViewPodruznice.Name = "dataGridViewPodruznice";
            this.dataGridViewPodruznice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPodruznice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPodruznice.RowTemplate.Height = 45;
            this.dataGridViewPodruznice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPodruznice.Size = new System.Drawing.Size(981, 476);
            this.dataGridViewPodruznice.TabIndex = 27;
            this.dataGridViewPodruznice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPodruznice_CellFormatting);
            // 
            // buttonPrebaci
            // 
            this.buttonPrebaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonPrebaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrebaci.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrebaci.ForeColor = System.Drawing.Color.White;
            this.buttonPrebaci.Location = new System.Drawing.Point(26, 74);
            this.buttonPrebaci.Name = "buttonPrebaci";
            this.buttonPrebaci.Size = new System.Drawing.Size(327, 31);
            this.buttonPrebaci.TabIndex = 28;
            this.buttonPrebaci.Text = "Prebaci se na odabranu podruznicu";
            this.buttonPrebaci.UseVisualStyleBackColor = false;
            this.buttonPrebaci.Click += new System.EventHandler(this.buttonPrebaci_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonDodaj.Image")));
            this.buttonDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodaj.Location = new System.Drawing.Point(695, 593);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(312, 37);
            this.buttonDodaj.TabIndex = 26;
            this.buttonDodaj.Text = "Dodaj novu podruznicu";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // UpravljanjePodruznicamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.buttonPrebaci);
            this.Controls.Add(this.dataGridViewPodruznice);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjePodruznicamaForm";
            this.Text = "UpravljanjePodruznicamaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodruznice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.DataGridView dataGridViewPodruznice;
        private System.Windows.Forms.Button buttonPrebaci;
    }
}