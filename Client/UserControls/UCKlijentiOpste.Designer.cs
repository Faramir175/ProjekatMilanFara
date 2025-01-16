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
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).BeginInit();
            gbDodajPromeniKlijenta.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKlijenti
            // 
            dgvKlijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijenti.Location = new Point(3, 3);
            dgvKlijenti.Name = "dgvKlijenti";
            dgvKlijenti.ReadOnly = true;
            dgvKlijenti.RowTemplate.Height = 25;
            dgvKlijenti.Size = new Size(470, 465);
            dgvKlijenti.TabIndex = 0;
            // 
            // lblPretraziKlienta
            // 
            lblPretraziKlienta.AutoSize = true;
            lblPretraziKlienta.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblPretraziKlienta.Location = new Point(579, 15);
            lblPretraziKlienta.Name = "lblPretraziKlienta";
            lblPretraziKlienta.Size = new Size(171, 31);
            lblPretraziKlienta.TabIndex = 1;
            lblPretraziKlienta.Text = "Pretrazi klijenta";
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Location = new Point(511, 68);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(78, 15);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Ime i prezime";
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(511, 117);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(40, 15);
            lblMesto.TabIndex = 3;
            lblMesto.Text = "Mesto";
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(604, 60);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(190, 23);
            tbImePrezime.TabIndex = 4;
            // 
            // cmbMesto
            // 
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(604, 114);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(190, 23);
            cmbMesto.TabIndex = 5;
            // 
            // btnDodajKlijenta
            // 
            btnDodajKlijenta.Location = new Point(511, 155);
            btnDodajKlijenta.Name = "btnDodajKlijenta";
            btnDodajKlijenta.Size = new Size(87, 44);
            btnDodajKlijenta.TabIndex = 6;
            btnDodajKlijenta.Text = "Dodaj klijenta";
            btnDodajKlijenta.UseVisualStyleBackColor = true;
            // 
            // btnPromeniKlijenta
            // 
            btnPromeniKlijenta.Location = new Point(604, 155);
            btnPromeniKlijenta.Name = "btnPromeniKlijenta";
            btnPromeniKlijenta.Size = new Size(98, 44);
            btnPromeniKlijenta.TabIndex = 7;
            btnPromeniKlijenta.Text = "Promeni klijenta";
            btnPromeniKlijenta.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKlijenta
            // 
            btnObrisiKlijenta.Location = new Point(708, 155);
            btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            btnObrisiKlijenta.Size = new Size(92, 44);
            btnObrisiKlijenta.TabIndex = 8;
            btnObrisiKlijenta.Text = "Obrisi klijenta";
            btnObrisiKlijenta.UseVisualStyleBackColor = true;
            // 
            // lblDodajImePrezime
            // 
            lblDodajImePrezime.AutoSize = true;
            lblDodajImePrezime.Location = new Point(5, 68);
            lblDodajImePrezime.Name = "lblDodajImePrezime";
            lblDodajImePrezime.Size = new Size(78, 15);
            lblDodajImePrezime.TabIndex = 9;
            lblDodajImePrezime.Text = "Ime i prezime";
            // 
            // lblDodajKontakt
            // 
            lblDodajKontakt.AutoSize = true;
            lblDodajKontakt.Location = new Point(5, 96);
            lblDodajKontakt.Name = "lblDodajKontakt";
            lblDodajKontakt.Size = new Size(48, 15);
            lblDodajKontakt.TabIndex = 10;
            lblDodajKontakt.Text = "Kontakt";
            // 
            // lblDodajTipKlijenta
            // 
            lblDodajTipKlijenta.AutoSize = true;
            lblDodajTipKlijenta.Location = new Point(5, 126);
            lblDodajTipKlijenta.Name = "lblDodajTipKlijenta";
            lblDodajTipKlijenta.Size = new Size(65, 15);
            lblDodajTipKlijenta.TabIndex = 11;
            lblDodajTipKlijenta.Text = "Tip klijenta";
            // 
            // lblDodajPol
            // 
            lblDodajPol.AutoSize = true;
            lblDodajPol.Location = new Point(5, 155);
            lblDodajPol.Name = "lblDodajPol";
            lblDodajPol.Size = new Size(24, 15);
            lblDodajPol.TabIndex = 12;
            lblDodajPol.Text = "Pol";
            // 
            // lblDodajMesto
            // 
            lblDodajMesto.AutoSize = true;
            lblDodajMesto.Location = new Point(5, 184);
            lblDodajMesto.Name = "lblDodajMesto";
            lblDodajMesto.Size = new Size(40, 15);
            lblDodajMesto.TabIndex = 13;
            lblDodajMesto.Text = "Mesto";
            // 
            // lblDodajPromeniKlijenta
            // 
            lblDodajPromeniKlijenta.AutoSize = true;
            lblDodajPromeniKlijenta.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblDodajPromeniKlijenta.Location = new Point(80, 19);
            lblDodajPromeniKlijenta.Name = "lblDodajPromeniKlijenta";
            lblDodajPromeniKlijenta.Size = new Size(155, 31);
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
            gbDodajPromeniKlijenta.Location = new Point(511, 205);
            gbDodajPromeniKlijenta.Name = "gbDodajPromeniKlijenta";
            gbDodajPromeniKlijenta.Size = new Size(289, 263);
            gbDodajPromeniKlijenta.TabIndex = 15;
            gbDodajPromeniKlijenta.TabStop = false;
            // 
            // btnKrajUnosaKlijenta
            // 
            btnKrajUnosaKlijenta.Location = new Point(105, 219);
            btnKrajUnosaKlijenta.Name = "btnKrajUnosaKlijenta";
            btnKrajUnosaKlijenta.Size = new Size(98, 44);
            btnKrajUnosaKlijenta.TabIndex = 21;
            btnKrajUnosaKlijenta.Text = "Kraj unosa";
            btnKrajUnosaKlijenta.UseVisualStyleBackColor = true;
            // 
            // tbDodajKontakt
            // 
            tbDodajKontakt.Location = new Point(93, 94);
            tbDodajKontakt.Name = "tbDodajKontakt";
            tbDodajKontakt.Size = new Size(190, 23);
            tbDodajKontakt.TabIndex = 20;
            // 
            // tbDodajImePrezime
            // 
            tbDodajImePrezime.Location = new Point(93, 65);
            tbDodajImePrezime.Name = "tbDodajImePrezime";
            tbDodajImePrezime.Size = new Size(190, 23);
            tbDodajImePrezime.TabIndex = 19;
            // 
            // cmbDodajTipKlijenta
            // 
            cmbDodajTipKlijenta.FormattingEnabled = true;
            cmbDodajTipKlijenta.Location = new Point(93, 123);
            cmbDodajTipKlijenta.Name = "cmbDodajTipKlijenta";
            cmbDodajTipKlijenta.Size = new Size(190, 23);
            cmbDodajTipKlijenta.TabIndex = 18;
            // 
            // cmbDodajPol
            // 
            cmbDodajPol.FormattingEnabled = true;
            cmbDodajPol.Location = new Point(93, 152);
            cmbDodajPol.Name = "cmbDodajPol";
            cmbDodajPol.Size = new Size(190, 23);
            cmbDodajPol.TabIndex = 17;
            // 
            // cmbDodajMesto
            // 
            cmbDodajMesto.FormattingEnabled = true;
            cmbDodajMesto.Location = new Point(93, 181);
            cmbDodajMesto.Name = "cmbDodajMesto";
            cmbDodajMesto.Size = new Size(190, 23);
            cmbDodajMesto.TabIndex = 16;
            // 
            // UCKlijentiOpste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "UCKlijentiOpste";
            Size = new Size(821, 471);
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).EndInit();
            gbDodajPromeniKlijenta.ResumeLayout(false);
            gbDodajPromeniKlijenta.PerformLayout();
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
    }
}
