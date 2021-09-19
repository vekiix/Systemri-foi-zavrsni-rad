
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodajJedinicu = new System.Windows.Forms.Button();
            this.buttonDodajVise = new System.Windows.Forms.Button();
            this.buttonObrisiJedinicu = new System.Windows.Forms.Button();
            this.buttonObrisiVise = new System.Windows.Forms.Button();
            this.buttonIzvrsiTransakciju = new System.Windows.Forms.Button();
            this.panelStavke = new System.Windows.Forms.Panel();
            this.dataGridViewRacun = new System.Windows.Forms.DataGridView();
            this.labelUkupno = new System.Windows.Forms.Label();
            this.dataGridViewProizvodi = new System.Windows.Forms.DataGridView();
            this.panelStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazivanje.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazivanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(474, 74);
            this.textBoxPretrazivanje.Multiline = true;
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(353, 20);
            this.textBoxPretrazivanje.TabIndex = 13;
            this.textBoxPretrazivanje.Text = "Pretrazite proizvod po imenu...";
            this.textBoxPretrazivanje.TextChanged += new System.EventHandler(this.textBoxPretrazivanje_TextChanged);
            this.textBoxPretrazivanje.Enter += new System.EventHandler(this.textBoxPretrazivanje_Enter);
            this.textBoxPretrazivanje.Leave += new System.EventHandler(this.textBoxPretrazivanje_Leave);
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
            // buttonDodajJedinicu
            // 
            this.buttonDodajJedinicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajJedinicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodajJedinicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajJedinicu.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajJedinicu.ForeColor = System.Drawing.Color.White;
            this.buttonDodajJedinicu.Location = new System.Drawing.Point(861, 100);
            this.buttonDodajJedinicu.Name = "buttonDodajJedinicu";
            this.buttonDodajJedinicu.Size = new System.Drawing.Size(144, 37);
            this.buttonDodajJedinicu.TabIndex = 17;
            this.buttonDodajJedinicu.Text = "[F1] Dodaj 1 proizvod na račun";
            this.buttonDodajJedinicu.UseVisualStyleBackColor = false;
            this.buttonDodajJedinicu.Click += new System.EventHandler(this.buttonDodajJedinicu_Click);
            // 
            // buttonDodajVise
            // 
            this.buttonDodajVise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodajVise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajVise.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajVise.ForeColor = System.Drawing.Color.White;
            this.buttonDodajVise.Location = new System.Drawing.Point(861, 160);
            this.buttonDodajVise.Name = "buttonDodajVise";
            this.buttonDodajVise.Size = new System.Drawing.Size(144, 37);
            this.buttonDodajVise.TabIndex = 18;
            this.buttonDodajVise.Text = "[F2] Dodaj više proizvoda na račun";
            this.buttonDodajVise.UseVisualStyleBackColor = false;
            this.buttonDodajVise.Click += new System.EventHandler(this.buttonDodajVise_Click);
            // 
            // buttonObrisiJedinicu
            // 
            this.buttonObrisiJedinicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisiJedinicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisiJedinicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisiJedinicu.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiJedinicu.ForeColor = System.Drawing.Color.White;
            this.buttonObrisiJedinicu.Location = new System.Drawing.Point(861, 55);
            this.buttonObrisiJedinicu.Name = "buttonObrisiJedinicu";
            this.buttonObrisiJedinicu.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisiJedinicu.TabIndex = 18;
            this.buttonObrisiJedinicu.Text = "[F3] Obriši jedinicu proizvoda";
            this.buttonObrisiJedinicu.UseVisualStyleBackColor = false;
            this.buttonObrisiJedinicu.Click += new System.EventHandler(this.buttonObrisiJedinicu_Click);
            // 
            // buttonObrisiVise
            // 
            this.buttonObrisiVise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisiVise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonObrisiVise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisiVise.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiVise.ForeColor = System.Drawing.Color.White;
            this.buttonObrisiVise.Location = new System.Drawing.Point(861, 111);
            this.buttonObrisiVise.Name = "buttonObrisiVise";
            this.buttonObrisiVise.Size = new System.Drawing.Size(144, 37);
            this.buttonObrisiVise.TabIndex = 19;
            this.buttonObrisiVise.Text = "[F4] Obriši stavku";
            this.buttonObrisiVise.UseVisualStyleBackColor = false;
            this.buttonObrisiVise.Click += new System.EventHandler(this.buttonObrisiVise_Click);
            // 
            // buttonIzvrsiTransakciju
            // 
            this.buttonIzvrsiTransakciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzvrsiTransakciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonIzvrsiTransakciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzvrsiTransakciju.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzvrsiTransakciju.ForeColor = System.Drawing.Color.White;
            this.buttonIzvrsiTransakciju.Location = new System.Drawing.Point(861, 212);
            this.buttonIzvrsiTransakciju.Name = "buttonIzvrsiTransakciju";
            this.buttonIzvrsiTransakciju.Size = new System.Drawing.Size(144, 53);
            this.buttonIzvrsiTransakciju.TabIndex = 20;
            this.buttonIzvrsiTransakciju.Text = "[F5] Izvrši transakciju";
            this.buttonIzvrsiTransakciju.UseVisualStyleBackColor = false;
            this.buttonIzvrsiTransakciju.Click += new System.EventHandler(this.buttonIzvrsiTransakciju_Click);
            // 
            // panelStavke
            // 
            this.panelStavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStavke.Controls.Add(this.dataGridViewRacun);
            this.panelStavke.Controls.Add(this.labelUkupno);
            this.panelStavke.Controls.Add(this.buttonIzvrsiTransakciju);
            this.panelStavke.Controls.Add(this.buttonObrisiVise);
            this.panelStavke.Controls.Add(this.buttonObrisiJedinicu);
            this.panelStavke.Location = new System.Drawing.Point(0, 353);
            this.panelStavke.Name = "panelStavke";
            this.panelStavke.Size = new System.Drawing.Size(1044, 289);
            this.panelStavke.TabIndex = 16;
            // 
            // dataGridViewRacun
            // 
            this.dataGridViewRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRacun.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRacun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewRacun.ColumnHeadersHeight = 50;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRacun.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewRacun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRacun.EnableHeadersVisualStyles = false;
            this.dataGridViewRacun.Location = new System.Drawing.Point(26, 55);
            this.dataGridViewRacun.Name = "dataGridViewRacun";
            this.dataGridViewRacun.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRacun.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewRacun.RowTemplate.Height = 30;
            this.dataGridViewRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRacun.Size = new System.Drawing.Size(801, 210);
            this.dataGridViewRacun.TabIndex = 24;
            this.dataGridViewRacun.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewRacun_CellFormatting);
            // 
            // labelUkupno
            // 
            this.labelUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkupno.ForeColor = System.Drawing.Color.White;
            this.labelUkupno.Location = new System.Drawing.Point(26, 20);
            this.labelUkupno.Name = "labelUkupno";
            this.labelUkupno.Size = new System.Drawing.Size(801, 32);
            this.labelUkupno.TabIndex = 23;
            this.labelUkupno.Text = "0kn";
            // 
            // dataGridViewProizvodi
            // 
            this.dataGridViewProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProizvodi.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewProizvodi.ColumnHeadersHeight = 50;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProizvodi.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewProizvodi.EnableHeadersVisualStyles = false;
            this.dataGridViewProizvodi.Location = new System.Drawing.Point(26, 100);
            this.dataGridViewProizvodi.Name = "dataGridViewProizvodi";
            this.dataGridViewProizvodi.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProizvodi.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewProizvodi.RowTemplate.Height = 30;
            this.dataGridViewProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProizvodi.Size = new System.Drawing.Size(801, 247);
            this.dataGridViewProizvodi.TabIndex = 15;
            this.dataGridViewProizvodi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProizvodi_CellFormatting);
            // 
            // NovaTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1044, 642);
            this.Controls.Add(this.buttonDodajVise);
            this.Controls.Add(this.buttonDodajJedinicu);
            this.Controls.Add(this.panelStavke);
            this.Controls.Add(this.dataGridViewProizvodi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Name = "NovaTransakcijaForm";
            this.Text = "TransakcijaForm";
            this.Load += new System.EventHandler(this.NovaTransakcijaForm_Load);
            this.panelStavke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajJedinicu;
        private System.Windows.Forms.Button buttonDodajVise;
        private System.Windows.Forms.Button buttonObrisiJedinicu;
        private System.Windows.Forms.Button buttonObrisiVise;
        private System.Windows.Forms.Button buttonIzvrsiTransakciju;
        private System.Windows.Forms.Panel panelStavke;
        private System.Windows.Forms.DataGridView dataGridViewProizvodi;
        private System.Windows.Forms.Label labelUkupno;
        private System.Windows.Forms.DataGridView dataGridViewRacun;
    }
}