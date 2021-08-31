
namespace Systemri
{
    partial class DodajKorisnikaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMjestoStanovanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKontakt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUgovorDo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerUgovorOd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxUloga = new System.Windows.Forms.ComboBox();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Systemri.Properties.Resources.icons8_person_128;
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIme.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxIme.Location = new System.Drawing.Point(182, 88);
            this.textBoxIme.Multiline = true;
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(203, 22);
            this.textBoxIme.TabIndex = 18;
            this.textBoxIme.Text = "Unesite ime...";
            this.textBoxIme.Enter += new System.EventHandler(this.textBoxIme_Enter);
            this.textBoxIme.Leave += new System.EventHandler(this.textBoxIme_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrezime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxPrezime.Location = new System.Drawing.Point(182, 130);
            this.textBoxPrezime.Multiline = true;
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(203, 22);
            this.textBoxPrezime.TabIndex = 20;
            this.textBoxPrezime.Text = "Unesite prezime...";
            this.textBoxPrezime.Enter += new System.EventHandler(this.textBoxPrezime_Enter);
            this.textBoxPrezime.Leave += new System.EventHandler(this.textBoxPrezime_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prezime:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKorisnickoIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKorisnickoIme.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(592, 130);
            this.textBoxKorisnickoIme.Multiline = true;
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(174, 22);
            this.textBoxKorisnickoIme.TabIndex = 22;
            this.textBoxKorisnickoIme.Text = "Unesite korisnicko ime...";
            this.textBoxKorisnickoIme.Enter += new System.EventHandler(this.textBoxKorisnickoIme_Enter);
            this.textBoxKorisnickoIme.Leave += new System.EventHandler(this.textBoxKorisnickoIme_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(402, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Korisnicko ime:";
            // 
            // textBoxMjestoStanovanja
            // 
            this.textBoxMjestoStanovanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMjestoStanovanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxMjestoStanovanja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMjestoStanovanja.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMjestoStanovanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxMjestoStanovanja.Location = new System.Drawing.Point(27, 308);
            this.textBoxMjestoStanovanja.Multiline = true;
            this.textBoxMjestoStanovanja.Name = "textBoxMjestoStanovanja";
            this.textBoxMjestoStanovanja.Size = new System.Drawing.Size(354, 22);
            this.textBoxMjestoStanovanja.TabIndex = 24;
            this.textBoxMjestoStanovanja.Text = "Unesite mjesto stanovanja...";
            this.textBoxMjestoStanovanja.Enter += new System.EventHandler(this.textBoxMjestoStanovanja_Enter);
            this.textBoxMjestoStanovanja.Leave += new System.EventHandler(this.textBoxMjestoStanovanja_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(23, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mjesto stanovanja:";
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOIB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxOIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOIB.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxOIB.Location = new System.Drawing.Point(182, 356);
            this.textBoxOIB.Multiline = true;
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(203, 22);
            this.textBoxOIB.TabIndex = 26;
            this.textBoxOIB.Text = "Unesite OIB...";
            this.textBoxOIB.Enter += new System.EventHandler(this.textBoxOIB_Enter);
            this.textBoxOIB.Leave += new System.EventHandler(this.textBoxOIB_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(23, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "OIB:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxEmail.Location = new System.Drawing.Point(182, 401);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 22);
            this.textBoxEmail.TabIndex = 28;
            this.textBoxEmail.Text = "Unesite email...";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(23, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email:";
            // 
            // textBoxKontakt
            // 
            this.textBoxKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKontakt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxKontakt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKontakt.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKontakt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxKontakt.Location = new System.Drawing.Point(182, 226);
            this.textBoxKontakt.Multiline = true;
            this.textBoxKontakt.Name = "textBoxKontakt";
            this.textBoxKontakt.Size = new System.Drawing.Size(203, 22);
            this.textBoxKontakt.TabIndex = 30;
            this.textBoxKontakt.Text = "Unesite kontakt...";
            this.textBoxKontakt.Enter += new System.EventHandler(this.textBoxKontakt_Enter);
            this.textBoxKontakt.Leave += new System.EventHandler(this.textBoxKontakt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(23, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kontakt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(23, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Datum rodenja:";
            // 
            // dateTimePickerDatumRodenja
            // 
            this.dateTimePickerDatumRodenja.AllowDrop = true;
            this.dateTimePickerDatumRodenja.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerDatumRodenja.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePickerDatumRodenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dateTimePickerDatumRodenja.Location = new System.Drawing.Point(182, 178);
            this.dateTimePickerDatumRodenja.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDatumRodenja.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDatumRodenja.Name = "dateTimePickerDatumRodenja";
            this.dateTimePickerDatumRodenja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDatumRodenja.Size = new System.Drawing.Size(203, 21);
            this.dateTimePickerDatumRodenja.TabIndex = 32;
            // 
            // dateTimePickerUgovorDo
            // 
            this.dateTimePickerUgovorDo.AllowDrop = true;
            this.dateTimePickerUgovorDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dateTimePickerUgovorDo.Location = new System.Drawing.Point(564, 226);
            this.dateTimePickerUgovorDo.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerUgovorDo.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerUgovorDo.Name = "dateTimePickerUgovorDo";
            this.dateTimePickerUgovorDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerUgovorDo.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerUgovorDo.TabIndex = 34;
            this.dateTimePickerUgovorDo.ValueChanged += new System.EventHandler(this.dateTimePickerUgovorDo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label9.Location = new System.Drawing.Point(404, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ugovor od:";
            // 
            // dateTimePickerUgovorOd
            // 
            this.dateTimePickerUgovorOd.AllowDrop = true;
            this.dateTimePickerUgovorOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dateTimePickerUgovorOd.Location = new System.Drawing.Point(566, 178);
            this.dateTimePickerUgovorOd.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerUgovorOd.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerUgovorOd.Name = "dateTimePickerUgovorOd";
            this.dateTimePickerUgovorOd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerUgovorOd.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerUgovorOd.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label10.Location = new System.Drawing.Point(404, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ugovor do:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(402, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Uloga:";
            // 
            // comboBoxUloga
            // 
            this.comboBoxUloga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBoxUloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUloga.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUloga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxUloga.FormattingEnabled = true;
            this.comboBoxUloga.Location = new System.Drawing.Point(645, 84);
            this.comboBoxUloga.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxUloga.MaxDropDownItems = 4;
            this.comboBoxUloga.Name = "comboBoxUloga";
            this.comboBoxUloga.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUloga.TabIndex = 38;
            this.comboBoxUloga.Text = "Odaberite ulogu";
            // 
            // labelNaslov
            // 
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelNaslov.Location = new System.Drawing.Point(301, 12);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(499, 57);
            this.labelNaslov.TabIndex = 39;
            this.labelNaslov.Text = "Dodaj korisnika";
            this.labelNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOdustani.ForeColor = System.Drawing.Color.White;
            this.buttonOdustani.Location = new System.Drawing.Point(406, 401);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(358, 22);
            this.buttonOdustani.TabIndex = 43;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(406, 308);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(358, 72);
            this.buttonDodaj.TabIndex = 42;
            this.buttonDodaj.Text = "Dodaj korisnika";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label13.Location = new System.Drawing.Point(405, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "(neobavezno)";
            // 
            // DodajKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.comboBoxUloga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerUgovorOd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerUgovorDo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerDatumRodenja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKontakt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMjestoStanovanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DodajKorisnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMjestoStanovanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKontakt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodenja;
        private System.Windows.Forms.DateTimePicker dateTimePickerUgovorDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerUgovorOd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUloga;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label13;
    }
}