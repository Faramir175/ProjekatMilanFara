namespace Client.UserControls
{
    partial class UCRacunOpsta
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
            dgvRacuni = new DataGridView();
            lblPretraziRacun = new Label();
            lblKlijent = new Label();
            cmbKlijent = new ComboBox();
            btnUnosNovogRacuna = new Button();
            btnPromeniRacun = new Button();
            cmbFrizer = new ComboBox();
            lblFrizer = new Label();
            cmbUsluga = new ComboBox();
            lblUsluga = new Label();
            lblCenaRacun = new Label();
            tbCenaRacuna = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            SuspendLayout();
            // 
            // dgvRacuni
            // 
            dgvRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRacuni.Location = new Point(3, 3);
            dgvRacuni.Name = "dgvRacuni";
            dgvRacuni.ReadOnly = true;
            dgvRacuni.RowTemplate.Height = 25;
            dgvRacuni.Size = new Size(559, 311);
            dgvRacuni.TabIndex = 0;
            // 
            // lblPretraziRacun
            // 
            lblPretraziRacun.AutoSize = true;
            lblPretraziRacun.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblPretraziRacun.Location = new Point(644, 29);
            lblPretraziRacun.Name = "lblPretraziRacun";
            lblPretraziRacun.Size = new Size(154, 31);
            lblPretraziRacun.TabIndex = 1;
            lblPretraziRacun.Text = "Pretrazi racun";
            // 
            // lblKlijent
            // 
            lblKlijent.AutoSize = true;
            lblKlijent.Location = new Point(625, 91);
            lblKlijent.Name = "lblKlijent";
            lblKlijent.Size = new Size(40, 15);
            lblKlijent.TabIndex = 2;
            lblKlijent.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            cmbKlijent.FormattingEnabled = true;
            cmbKlijent.Location = new Point(730, 86);
            cmbKlijent.Name = "cmbKlijent";
            cmbKlijent.Size = new Size(121, 23);
            cmbKlijent.TabIndex = 3;
            cmbKlijent.SelectionChangeCommitted += cmbKlijent_SelectionChangeCommitted;
            // 
            // btnUnosNovogRacuna
            // 
            btnUnosNovogRacuna.Location = new Point(608, 229);
            btnUnosNovogRacuna.Name = "btnUnosNovogRacuna";
            btnUnosNovogRacuna.Size = new Size(99, 47);
            btnUnosNovogRacuna.TabIndex = 4;
            btnUnosNovogRacuna.Text = "Unos novog racuna";
            btnUnosNovogRacuna.UseVisualStyleBackColor = true;
            btnUnosNovogRacuna.Click += btnUnosNovogRacuna_Click;
            // 
            // btnPromeniRacun
            // 
            btnPromeniRacun.Location = new Point(755, 230);
            btnPromeniRacun.Name = "btnPromeniRacun";
            btnPromeniRacun.Size = new Size(96, 46);
            btnPromeniRacun.TabIndex = 5;
            btnPromeniRacun.Text = "Promeni racun";
            btnPromeniRacun.UseVisualStyleBackColor = true;
            btnPromeniRacun.Click += btnPromeniRacun_Click;
            // 
            // cmbFrizer
            // 
            cmbFrizer.FormattingEnabled = true;
            cmbFrizer.Location = new Point(730, 115);
            cmbFrizer.Name = "cmbFrizer";
            cmbFrizer.Size = new Size(121, 23);
            cmbFrizer.TabIndex = 7;
            cmbFrizer.SelectionChangeCommitted += cmbFrizer_SelectionChangeCommitted;
            // 
            // lblFrizer
            // 
            lblFrizer.AutoSize = true;
            lblFrizer.Location = new Point(625, 120);
            lblFrizer.Name = "lblFrizer";
            lblFrizer.Size = new Size(35, 15);
            lblFrizer.TabIndex = 6;
            lblFrizer.Text = "Frizer";
            // 
            // cmbUsluga
            // 
            cmbUsluga.FormattingEnabled = true;
            cmbUsluga.Location = new Point(730, 144);
            cmbUsluga.Name = "cmbUsluga";
            cmbUsluga.Size = new Size(121, 23);
            cmbUsluga.TabIndex = 9;
            cmbUsluga.SelectionChangeCommitted += cmbUsluga_SelectionChangeCommitted;
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(625, 149);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(43, 15);
            lblUsluga.TabIndex = 8;
            lblUsluga.Text = "Usluga";
            // 
            // lblCenaRacun
            // 
            lblCenaRacun.AutoSize = true;
            lblCenaRacun.Location = new Point(625, 184);
            lblCenaRacun.Name = "lblCenaRacun";
            lblCenaRacun.Size = new Size(73, 15);
            lblCenaRacun.TabIndex = 10;
            lblCenaRacun.Text = "Cena racuna";
            // 
            // tbCenaRacuna
            // 
            tbCenaRacuna.Location = new Point(730, 181);
            tbCenaRacuna.Name = "tbCenaRacuna";
            tbCenaRacuna.Size = new Size(121, 23);
            tbCenaRacuna.TabIndex = 11;
            tbCenaRacuna.TextChanged += tbCenaRacuna_TextChanged;
            // 
            // UCRacunOpsta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbCenaRacuna);
            Controls.Add(lblCenaRacun);
            Controls.Add(cmbUsluga);
            Controls.Add(lblUsluga);
            Controls.Add(cmbFrizer);
            Controls.Add(lblFrizer);
            Controls.Add(btnPromeniRacun);
            Controls.Add(btnUnosNovogRacuna);
            Controls.Add(cmbKlijent);
            Controls.Add(lblKlijent);
            Controls.Add(lblPretraziRacun);
            Controls.Add(dgvRacuni);
            Name = "UCRacunOpsta";
            Size = new Size(901, 317);
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRacuni;
        private Label lblPretraziRacun;
        private Label lblKlijent;
        private ComboBox cmbKlijent;
        private Button btnUnosNovogRacuna;
        private Button btnPromeniRacun;
        private ComboBox cmbFrizer;
        private Label lblFrizer;
        private ComboBox cmbUsluga;
        private Label lblUsluga;
        private Label lblCenaRacun;
        private TextBox tbCenaRacuna;

        public DataGridView DgvRacuni
        {
            get { return dgvRacuni;}
        }

        public ComboBox CmbKlijent
        {
            get { return cmbKlijent; }
        }

        public ComboBox CmbFrizer
        {
            get { return cmbFrizer; }
        }

        public ComboBox CmbUsluga
        {
            get { return cmbUsluga; }
        }

        public TextBox TbCenaRacuna
        {
            get { return tbCenaRacuna; }
        }
    }
}
