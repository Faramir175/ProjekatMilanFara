namespace Client
{
    partial class FrmStavkeRacuna
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
            dgvStavkeRacuna = new DataGridView();
            btnKrajUnosa = new Button();
            tbKolicina = new TextBox();
            lblIznos = new Label();
            lblCenaName = new Label();
            lblKolicina = new Label();
            lblIznosName = new Label();
            cmbUsluga = new ComboBox();
            lblUsluga = new Label();
            btnDodaj = new Button();
            lblNaslov = new Label();
            lblCena = new Label();
            btnIzbaci = new Button();
            btnKrajUnosaStavki = new Button();
            lblUnosRacuna = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            lblPopust = new Label();
            lblUkupanIznosName = new Label();
            lblPopustName = new Label();
            lblUkupanIznos = new Label();
            lblKlijent = new Label();
            cmbKlijent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRacuna).BeginInit();
            SuspendLayout();
            // 
            // dgvStavkeRacuna
            // 
            dgvStavkeRacuna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavkeRacuna.Location = new Point(12, 12);
            dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            dgvStavkeRacuna.RowTemplate.Height = 25;
            dgvStavkeRacuna.Size = new Size(502, 454);
            dgvStavkeRacuna.TabIndex = 0;
            // 
            // btnKrajUnosa
            // 
            btnKrajUnosa.Location = new Point(876, 371);
            btnKrajUnosa.Name = "btnKrajUnosa";
            btnKrajUnosa.Size = new Size(121, 37);
            btnKrajUnosa.TabIndex = 1;
            btnKrajUnosa.Text = "Kraj unosa";
            btnKrajUnosa.UseVisualStyleBackColor = true;
            // 
            // tbKolicina
            // 
            tbKolicina.Location = new Point(641, 157);
            tbKolicina.Name = "tbKolicina";
            tbKolicina.Size = new Size(121, 23);
            tbKolicina.TabIndex = 3;
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(641, 254);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(0, 15);
            lblIznos.TabIndex = 4;
            // 
            // lblCenaName
            // 
            lblCenaName.AutoSize = true;
            lblCenaName.Location = new Point(552, 207);
            lblCenaName.Name = "lblCenaName";
            lblCenaName.Size = new Size(34, 15);
            lblCenaName.TabIndex = 5;
            lblCenaName.Text = "Cena";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(552, 160);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(49, 15);
            lblKolicina.TabIndex = 6;
            lblKolicina.Text = "Kolicina";
            // 
            // lblIznosName
            // 
            lblIznosName.AutoSize = true;
            lblIznosName.Location = new Point(552, 254);
            lblIznosName.Name = "lblIznosName";
            lblIznosName.Size = new Size(34, 15);
            lblIznosName.TabIndex = 7;
            lblIznosName.Text = "Iznos";
            // 
            // cmbUsluga
            // 
            cmbUsluga.FormattingEnabled = true;
            cmbUsluga.Location = new Point(641, 110);
            cmbUsluga.Name = "cmbUsluga";
            cmbUsluga.Size = new Size(121, 23);
            cmbUsluga.TabIndex = 8;
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(552, 113);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(43, 15);
            lblUsluga.TabIndex = 9;
            lblUsluga.Text = "Usluga";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(552, 309);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(86, 37);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj stavku";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNaslov.Location = new Point(552, 43);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(181, 28);
            lblNaslov.TabIndex = 11;
            lblNaslov.Text = "Unos stavki u racun";
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(641, 207);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(0, 15);
            lblCena.TabIndex = 12;
            // 
            // btnIzbaci
            // 
            btnIzbaci.Location = new Point(676, 309);
            btnIzbaci.Name = "btnIzbaci";
            btnIzbaci.Size = new Size(86, 37);
            btnIzbaci.TabIndex = 13;
            btnIzbaci.Text = "Izbaci stavku";
            btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // btnKrajUnosaStavki
            // 
            btnKrajUnosaStavki.Location = new Point(615, 367);
            btnKrajUnosaStavki.Name = "btnKrajUnosaStavki";
            btnKrajUnosaStavki.Size = new Size(86, 41);
            btnKrajUnosaStavki.TabIndex = 14;
            btnKrajUnosaStavki.Text = "Kraj unosa stavki";
            btnKrajUnosaStavki.UseVisualStyleBackColor = true;
            // 
            // lblUnosRacuna
            // 
            lblUnosRacuna.AutoSize = true;
            lblUnosRacuna.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnosRacuna.Location = new Point(876, 43);
            lblUnosRacuna.Name = "lblUnosRacuna";
            lblUnosRacuna.Size = new Size(120, 28);
            lblUnosRacuna.TabIndex = 15;
            lblUnosRacuna.Text = "Unos racuna";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(889, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(806, 113);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(43, 15);
            lblDatum.TabIndex = 17;
            lblDatum.Text = "Datum";
            // 
            // lblPopust
            // 
            lblPopust.AutoSize = true;
            lblPopust.Location = new Point(895, 207);
            lblPopust.Name = "lblPopust";
            lblPopust.Size = new Size(0, 15);
            lblPopust.TabIndex = 21;
            // 
            // lblUkupanIznosName
            // 
            lblUkupanIznosName.AutoSize = true;
            lblUkupanIznosName.Location = new Point(806, 254);
            lblUkupanIznosName.Name = "lblUkupanIznosName";
            lblUkupanIznosName.Size = new Size(78, 15);
            lblUkupanIznosName.TabIndex = 20;
            lblUkupanIznosName.Text = "Ukupan iznos";
            // 
            // lblPopustName
            // 
            lblPopustName.AutoSize = true;
            lblPopustName.Location = new Point(806, 207);
            lblPopustName.Name = "lblPopustName";
            lblPopustName.Size = new Size(44, 15);
            lblPopustName.TabIndex = 19;
            lblPopustName.Text = "Popust";
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.AutoSize = true;
            lblUkupanIznos.Location = new Point(895, 254);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(0, 15);
            lblUkupanIznos.TabIndex = 18;
            // 
            // lblKlijent
            // 
            lblKlijent.AutoSize = true;
            lblKlijent.Location = new Point(806, 160);
            lblKlijent.Name = "lblKlijent";
            lblKlijent.Size = new Size(40, 15);
            lblKlijent.TabIndex = 23;
            lblKlijent.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            cmbKlijent.FormattingEnabled = true;
            cmbKlijent.Location = new Point(889, 157);
            cmbKlijent.Name = "cmbKlijent";
            cmbKlijent.Size = new Size(200, 23);
            cmbKlijent.TabIndex = 22;
            // 
            // FrmStavkeRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 476);
            Controls.Add(lblKlijent);
            Controls.Add(cmbKlijent);
            Controls.Add(lblPopust);
            Controls.Add(lblUkupanIznosName);
            Controls.Add(lblPopustName);
            Controls.Add(lblUkupanIznos);
            Controls.Add(lblDatum);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblUnosRacuna);
            Controls.Add(btnKrajUnosaStavki);
            Controls.Add(btnIzbaci);
            Controls.Add(lblCena);
            Controls.Add(lblNaslov);
            Controls.Add(btnDodaj);
            Controls.Add(lblUsluga);
            Controls.Add(cmbUsluga);
            Controls.Add(lblIznosName);
            Controls.Add(lblKolicina);
            Controls.Add(lblCenaName);
            Controls.Add(lblIznos);
            Controls.Add(tbKolicina);
            Controls.Add(btnKrajUnosa);
            Controls.Add(dgvStavkeRacuna);
            Name = "FrmStavkeRacuna";
            Text = "Racun";
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRacuna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStavkeRacuna;
        private Button btnKrajUnosa;
        private TextBox tbCena;
        private TextBox tbKolicina;
        private Label lblIznos;
        private Label lblCenaName;
        private Label lblKolicina;
        private Label lblIznosName;
        private ComboBox cmbUsluga;
        private Label lblUsluga;
        private Button btnDodaj;
        private Label lblNaslov;
        private Label lblCena;
        private Button btnIzbaci;
        private Button btnKrajUnosaStavki;
        private Label lblUnosRacuna;
        private DateTimePicker dateTimePicker1;
        private Label lblDatum;
        private Label lblPopust;
        private Label lblUkupanIznosName;
        private Label lblPopustName;
        private Label lblUkupanIznos;
        private Label lblKlijent;
        private ComboBox cmbKlijent;
    }
}