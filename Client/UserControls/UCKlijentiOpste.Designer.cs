namespace Client.UserControls
{
    partial class UCKlijentiOpste
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKlijenti = new DataGridView();
            lblPretraziKlienta = new Label();
            lblImePrezime = new Label();
            lblMesto = new Label();
            tbImePrezime = new TextBox();
            cmbMesto = new ComboBox();
            btnDodajKlijenta = new Button();
            btnPromeniKlijenta = new Button();
            btnObrisiKlijenta = new Button();
            lblDodajImePrezime = new Label();
            lblDodajKontakt = new Label();
            lblDodajTipKlijenta = new Label();
            lblDodajPol = new Label();
            lblDodajMesto = new Label();
            lblDodajPromeniKlijenta = new Label();
            gbDodajPromeniKlijenta = new GroupBox();
            btnKrajUnosaKlijenta = new Button();
            tbDodajKontakt = new TextBox();
            tbDodajImePrezime = new TextBox();
            cmbDodajTipKlijenta = new ComboBox();
            cmbDodajPol = new ComboBox();
            cmbDodajMesto = new ComboBox();
            groupBox1 = new GroupBox();
            rbImePrezime = new RadioButton();
            rbMesto = new RadioButton();
            btnPretrazi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).BeginInit();
            gbDodajPromeniKlijenta.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKlijenti
            // 
            dgvKlijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijenti.Location = new Point(4, 5);
            dgvKlijenti.Margin = new Padding(4, 5, 4, 5);
            dgvKlijenti.Name = "dgvKlijenti";
            dgvKlijenti.ReadOnly = true;
            dgvKlijenti.RowHeadersWidth = 62;
            dgvKlijenti.RowTemplate.Height = 25;
            dgvKlijenti.Size = new Size(656, 775);
            dgvKlijenti.TabIndex = 0;
            // 
            // lblPretraziKlienta
            // 
            lblPretraziKlienta.AutoSize = true;
            lblPretraziKlienta.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblPretraziKlienta.Location = new Point(827, 25);
            lblPretraziKlienta.Margin = new Padding(4, 0, 4, 0);
            lblPretraziKlienta.Name = "lblPretraziKlienta";
            lblPretraziKlienta.Size = new Size(249, 46);
            lblPretraziKlienta.TabIndex = 1;
            lblPretraziKlienta.Text = "Pretrazi klijenta";
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Location = new Point(730, 113);
            lblImePrezime.Margin = new Padding(4, 0, 4, 0);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(119, 25);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Ime i prezime";
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(730, 195);
            lblMesto.Margin = new Padding(4, 0, 4, 0);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(62, 25);
            lblMesto.TabIndex = 3;
            lblMesto.Text = "Mesto";
            // 
            // tbImePrezime
            // 
            tbImePrezime.Enabled = false;
            tbImePrezime.Location = new Point(863, 111);
            tbImePrezime.Margin = new Padding(4, 5, 4, 5);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(270, 31);
            tbImePrezime.TabIndex = 4;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // cmbMesto
            // 
            cmbMesto.Enabled = false;
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(863, 190);
            cmbMesto.Margin = new Padding(4, 5, 4, 5);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(270, 33);
            cmbMesto.TabIndex = 5;
            cmbMesto.SelectionChangeCommitted += cmbMesto_SelectionChangeCommitted;
            // 
            // btnDodajKlijenta
            // 
            btnDodajKlijenta.Location = new Point(729, 245);
            btnDodajKlijenta.Margin = new Padding(4, 5, 4, 5);
            btnDodajKlijenta.Name = "btnDodajKlijenta";
            btnDodajKlijenta.Size = new Size(151, 58);
            btnDodajKlijenta.TabIndex = 6;
            btnDodajKlijenta.Text = "Dodaj klijenta";
            btnDodajKlijenta.UseVisualStyleBackColor = true;
            btnDodajKlijenta.Click += btnDodajKlijenta_Click;
            // 
            // btnPromeniKlijenta
            // 
            btnPromeniKlijenta.Location = new Point(730, 313);
            btnPromeniKlijenta.Margin = new Padding(4, 5, 4, 5);
            btnPromeniKlijenta.Name = "btnPromeniKlijenta";
            btnPromeniKlijenta.Size = new Size(150, 58);
            btnPromeniKlijenta.TabIndex = 7;
            btnPromeniKlijenta.Text = "Promeni klijenta";
            btnPromeniKlijenta.UseVisualStyleBackColor = true;
            btnPromeniKlijenta.Click += btnPromeniKlijenta_Click;
            // 
            // btnObrisiKlijenta
            // 
            btnObrisiKlijenta.Location = new Point(982, 313);
            btnObrisiKlijenta.Margin = new Padding(4, 5, 4, 5);
            btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            btnObrisiKlijenta.Size = new Size(151, 58);
            btnObrisiKlijenta.TabIndex = 8;
            btnObrisiKlijenta.Text = "Obrisi klijenta";
            btnObrisiKlijenta.UseVisualStyleBackColor = true;
            btnObrisiKlijenta.Click += btnObrisiKlijenta_Click;
            // 
            // lblDodajImePrezime
            // 
            lblDodajImePrezime.AutoSize = true;
            lblDodajImePrezime.Location = new Point(7, 101);
            lblDodajImePrezime.Margin = new Padding(4, 0, 4, 0);
            lblDodajImePrezime.Name = "lblDodajImePrezime";
            lblDodajImePrezime.Size = new Size(119, 25);
            lblDodajImePrezime.TabIndex = 9;
            lblDodajImePrezime.Text = "Ime i prezime";
            // 
            // lblDodajKontakt
            // 
            lblDodajKontakt.AutoSize = true;
            lblDodajKontakt.Location = new Point(7, 148);
            lblDodajKontakt.Margin = new Padding(4, 0, 4, 0);
            lblDodajKontakt.Name = "lblDodajKontakt";
            lblDodajKontakt.Size = new Size(73, 25);
            lblDodajKontakt.TabIndex = 10;
            lblDodajKontakt.Text = "Kontakt";
            // 
            // lblDodajTipKlijenta
            // 
            lblDodajTipKlijenta.AutoSize = true;
            lblDodajTipKlijenta.Location = new Point(7, 198);
            lblDodajTipKlijenta.Margin = new Padding(4, 0, 4, 0);
            lblDodajTipKlijenta.Name = "lblDodajTipKlijenta";
            lblDodajTipKlijenta.Size = new Size(96, 25);
            lblDodajTipKlijenta.TabIndex = 11;
            lblDodajTipKlijenta.Text = "Tip klijenta";
            // 
            // lblDodajPol
            // 
            lblDodajPol.AutoSize = true;
            lblDodajPol.Location = new Point(7, 246);
            lblDodajPol.Margin = new Padding(4, 0, 4, 0);
            lblDodajPol.Name = "lblDodajPol";
            lblDodajPol.Size = new Size(36, 25);
            lblDodajPol.TabIndex = 12;
            lblDodajPol.Text = "Pol";
            // 
            // lblDodajMesto
            // 
            lblDodajMesto.AutoSize = true;
            lblDodajMesto.Location = new Point(7, 295);
            lblDodajMesto.Margin = new Padding(4, 0, 4, 0);
            lblDodajMesto.Name = "lblDodajMesto";
            lblDodajMesto.Size = new Size(62, 25);
            lblDodajMesto.TabIndex = 13;
            lblDodajMesto.Text = "Mesto";
            // 
            // lblDodajPromeniKlijenta
            // 
            lblDodajPromeniKlijenta.AutoSize = true;
            lblDodajPromeniKlijenta.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblDodajPromeniKlijenta.Location = new Point(111, 29);
            lblDodajPromeniKlijenta.Margin = new Padding(4, 0, 4, 0);
            lblDodajPromeniKlijenta.Name = "lblDodajPromeniKlijenta";
            lblDodajPromeniKlijenta.Size = new Size(225, 46);
            lblDodajPromeniKlijenta.TabIndex = 14;
            lblDodajPromeniKlijenta.Text = "Dodaj klijenta";
            // 
            // gbDodajPromeniKlijenta
            // 
            gbDodajPromeniKlijenta.Controls.Add(btnKrajUnosaKlijenta);
            gbDodajPromeniKlijenta.Controls.Add(tbDodajKontakt);
            gbDodajPromeniKlijenta.Controls.Add(tbDodajImePrezime);
            gbDodajPromeniKlijenta.Controls.Add(cmbDodajTipKlijenta);
            gbDodajPromeniKlijenta.Controls.Add(cmbDodajPol);
            gbDodajPromeniKlijenta.Controls.Add(cmbDodajMesto);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajPromeniKlijenta);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajMesto);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajPol);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajImePrezime);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajTipKlijenta);
            gbDodajPromeniKlijenta.Controls.Add(lblDodajKontakt);
            gbDodajPromeniKlijenta.Location = new Point(730, 373);
            gbDodajPromeniKlijenta.Margin = new Padding(4, 5, 4, 5);
            gbDodajPromeniKlijenta.Name = "gbDodajPromeniKlijenta";
            gbDodajPromeniKlijenta.Padding = new Padding(4, 5, 4, 5);
            gbDodajPromeniKlijenta.Size = new Size(413, 407);
            gbDodajPromeniKlijenta.TabIndex = 15;
            gbDodajPromeniKlijenta.TabStop = false;
            // 
            // btnKrajUnosaKlijenta
            // 
            btnKrajUnosaKlijenta.Location = new Point(149, 333);
            btnKrajUnosaKlijenta.Margin = new Padding(4, 5, 4, 5);
            btnKrajUnosaKlijenta.Name = "btnKrajUnosaKlijenta";
            btnKrajUnosaKlijenta.Size = new Size(140, 73);
            btnKrajUnosaKlijenta.TabIndex = 21;
            btnKrajUnosaKlijenta.Text = "Kraj unosa";
            btnKrajUnosaKlijenta.UseVisualStyleBackColor = true;
            btnKrajUnosaKlijenta.Click += btnKrajUnosaKlijenta_Click;
            // 
            // tbDodajKontakt
            // 
            tbDodajKontakt.Location = new Point(133, 145);
            tbDodajKontakt.Margin = new Padding(4, 5, 4, 5);
            tbDodajKontakt.Name = "tbDodajKontakt";
            tbDodajKontakt.Size = new Size(270, 31);
            tbDodajKontakt.TabIndex = 20;
            // 
            // tbDodajImePrezime
            // 
            tbDodajImePrezime.Location = new Point(133, 96);
            tbDodajImePrezime.Margin = new Padding(4, 5, 4, 5);
            tbDodajImePrezime.Name = "tbDodajImePrezime";
            tbDodajImePrezime.Size = new Size(270, 31);
            tbDodajImePrezime.TabIndex = 19;
            // 
            // cmbDodajTipKlijenta
            // 
            cmbDodajTipKlijenta.FormattingEnabled = true;
            cmbDodajTipKlijenta.Location = new Point(133, 193);
            cmbDodajTipKlijenta.Margin = new Padding(4, 5, 4, 5);
            cmbDodajTipKlijenta.Name = "cmbDodajTipKlijenta";
            cmbDodajTipKlijenta.Size = new Size(270, 33);
            cmbDodajTipKlijenta.TabIndex = 18;
            // 
            // cmbDodajPol
            // 
            cmbDodajPol.FormattingEnabled = true;
            cmbDodajPol.Location = new Point(133, 241);
            cmbDodajPol.Margin = new Padding(4, 5, 4, 5);
            cmbDodajPol.Name = "cmbDodajPol";
            cmbDodajPol.Size = new Size(270, 33);
            cmbDodajPol.TabIndex = 17;
            // 
            // cmbDodajMesto
            // 
            cmbDodajMesto.FormattingEnabled = true;
            cmbDodajMesto.Location = new Point(133, 290);
            cmbDodajMesto.Margin = new Padding(4, 5, 4, 5);
            cmbDodajMesto.Name = "cmbDodajMesto";
            cmbDodajMesto.Size = new Size(270, 33);
            cmbDodajMesto.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbImePrezime);
            groupBox1.Controls.Add(rbMesto);
            groupBox1.Location = new Point(682, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(41, 148);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // rbImePrezime
            // 
            rbImePrezime.AutoSize = true;
            rbImePrezime.Location = new Point(6, 27);
            rbImePrezime.Name = "rbImePrezime";
            rbImePrezime.Size = new Size(21, 20);
            rbImePrezime.TabIndex = 13;
            rbImePrezime.TabStop = true;
            rbImePrezime.UseVisualStyleBackColor = true;
            rbImePrezime.CheckedChanged += rbImePrezime_CheckedChanged;
            // 
            // rbMesto
            // 
            rbMesto.AutoSize = true;
            rbMesto.Location = new Point(6, 109);
            rbMesto.Name = "rbMesto";
            rbMesto.Size = new Size(21, 20);
            rbMesto.TabIndex = 12;
            rbMesto.TabStop = true;
            rbMesto.UseVisualStyleBackColor = true;
            rbMesto.CheckedChanged += rbMesto_CheckedChanged;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(982, 245);
            btnPretrazi.Margin = new Padding(4, 5, 4, 5);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(151, 58);
            btnPretrazi.TabIndex = 18;
            btnPretrazi.Text = "Pretrazi klijenta";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // UCKlijentiOpste
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPretrazi);
            Controls.Add(groupBox1);
            Controls.Add(gbDodajPromeniKlijenta);
            Controls.Add(btnObrisiKlijenta);
            Controls.Add(btnPromeniKlijenta);
            Controls.Add(btnDodajKlijenta);
            Controls.Add(cmbMesto);
            Controls.Add(tbImePrezime);
            Controls.Add(lblMesto);
            Controls.Add(lblImePrezime);
            Controls.Add(lblPretraziKlienta);
            Controls.Add(dgvKlijenti);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCKlijentiOpste";
            Size = new Size(1173, 785);
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).EndInit();
            gbDodajPromeniKlijenta.ResumeLayout(false);
            gbDodajPromeniKlijenta.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKlijenti;
        private Label lblPretraziKlienta;
        private Label lblImePrezime;
        private Label lblMesto;
        private TextBox tbImePrezime;
        private ComboBox cmbMesto;
        private Button btnDodajKlijenta;
        private Button btnPromeniKlijenta;
        private Button btnObrisiKlijenta;
        private Label lblDodajImePrezime;
        private Label lblDodajKontakt;
        private Label lblDodajTipKlijenta;
        private Label lblDodajPol;
        private Label lblDodajMesto;
        private Label lblDodajPromeniKlijenta;
        private GroupBox gbDodajPromeniKlijenta;
        private ComboBox cmbDodajTipKlijenta;
        private ComboBox cmbDodajPol;
        private ComboBox cmbDodajMesto;
        private Button btnKrajUnosaKlijenta;
        private TextBox tbDodajKontakt;
        private TextBox tbDodajImePrezime;
        private GroupBox groupBox1;
        private RadioButton rbImePrezime;
        private RadioButton rbMesto;
        private Button btnPretrazi;

        public DataGridView DgvKlijenti
        {
            get { return dgvKlijenti; }
        }
        public ComboBox CmbMesto
        {
            get { return cmbMesto; }
        }
        public ComboBox CmbDodajMesto
        {
            get { return cmbDodajMesto; }
        }
        public ComboBox CmbDodajPol
        {
            get { return cmbDodajPol; }
        }
        public ComboBox CmbDodajTipKlijenta
        {
            get { return cmbDodajTipKlijenta; }
        }
        public Label LblDodajPromeniKlijenta
        {
            get { return lblDodajPromeniKlijenta; }
        }
        public Button BtnKrajUnosaKlijenta
        {
            get { return btnKrajUnosaKlijenta; }
        }
        public TextBox TbDodajImePrezime
        {
            get { return tbDodajImePrezime; }
        }
        public TextBox TbDodajKontakt
        {
            get { return tbDodajKontakt; }
        }
        public TextBox TbImePrezime
        {
            get { return tbImePrezime; }
        }
        public Button BtnDodajKlijenta
        {
            get { return btnDodajKlijenta; }
        }
        public Button BtnObrisiKlijenta
        {
            get { return btnObrisiKlijenta; }
        }
        public Button BtnPromeniKlijenta
        {
            get { return btnPromeniKlijenta; }
        }
        public Button BtnPretrazi
        {
            get { return btnPretrazi; }
        }
    }
}
