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
            rbFrizer = new RadioButton();
            rbKlijent = new RadioButton();
            rbUsluga = new RadioButton();
            rbCenaRacuna = new RadioButton();
            groupBox1 = new GroupBox();
            btnDetalji = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRacuni
            // 
            dgvRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRacuni.Location = new Point(4, 5);
            dgvRacuni.Margin = new Padding(4, 5, 4, 5);
            dgvRacuni.Name = "dgvRacuni";
            dgvRacuni.ReadOnly = true;
            dgvRacuni.RowHeadersWidth = 62;
            dgvRacuni.RowTemplate.Height = 25;
            dgvRacuni.Size = new Size(799, 518);
            dgvRacuni.TabIndex = 0;
            // 
            // lblPretraziRacun
            // 
            lblPretraziRacun.AutoSize = true;
            lblPretraziRacun.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblPretraziRacun.Location = new Point(920, 48);
            lblPretraziRacun.Margin = new Padding(4, 0, 4, 0);
            lblPretraziRacun.Name = "lblPretraziRacun";
            lblPretraziRacun.Size = new Size(225, 46);
            lblPretraziRacun.TabIndex = 1;
            lblPretraziRacun.Text = "Pretrazi racun";
            // 
            // lblKlijent
            // 
            lblKlijent.AutoSize = true;
            lblKlijent.Location = new Point(893, 152);
            lblKlijent.Margin = new Padding(4, 0, 4, 0);
            lblKlijent.Name = "lblKlijent";
            lblKlijent.Size = new Size(59, 25);
            lblKlijent.TabIndex = 2;
            lblKlijent.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            cmbKlijent.Enabled = false;
            cmbKlijent.FormattingEnabled = true;
            cmbKlijent.Location = new Point(1043, 143);
            cmbKlijent.Margin = new Padding(4, 5, 4, 5);
            cmbKlijent.Name = "cmbKlijent";
            cmbKlijent.Size = new Size(171, 33);
            cmbKlijent.TabIndex = 3;
            cmbKlijent.SelectionChangeCommitted += cmbKlijent_SelectionChangeCommitted;
            // 
            // btnUnosNovogRacuna
            // 
            btnUnosNovogRacuna.Location = new Point(982, 383);
            btnUnosNovogRacuna.Margin = new Padding(4, 5, 4, 5);
            btnUnosNovogRacuna.Name = "btnUnosNovogRacuna";
            btnUnosNovogRacuna.Size = new Size(141, 92);
            btnUnosNovogRacuna.TabIndex = 4;
            btnUnosNovogRacuna.Text = "Unos novog racuna";
            btnUnosNovogRacuna.UseVisualStyleBackColor = true;
            btnUnosNovogRacuna.Click += btnUnosNovogRacuna_Click;
            // 
            // btnPromeniRacun
            // 
            btnPromeniRacun.Location = new Point(1131, 383);
            btnPromeniRacun.Margin = new Padding(4, 5, 4, 5);
            btnPromeniRacun.Name = "btnPromeniRacun";
            btnPromeniRacun.Size = new Size(137, 92);
            btnPromeniRacun.TabIndex = 5;
            btnPromeniRacun.Text = "Promeni racun";
            btnPromeniRacun.UseVisualStyleBackColor = true;
            btnPromeniRacun.Click += btnPromeniRacun_Click;
            // 
            // cmbFrizer
            // 
            cmbFrizer.Enabled = false;
            cmbFrizer.FormattingEnabled = true;
            cmbFrizer.Location = new Point(1043, 192);
            cmbFrizer.Margin = new Padding(4, 5, 4, 5);
            cmbFrizer.Name = "cmbFrizer";
            cmbFrizer.Size = new Size(171, 33);
            cmbFrizer.TabIndex = 7;
            cmbFrizer.SelectionChangeCommitted += cmbFrizer_SelectionChangeCommitted;
            // 
            // lblFrizer
            // 
            lblFrizer.AutoSize = true;
            lblFrizer.Location = new Point(893, 200);
            lblFrizer.Margin = new Padding(4, 0, 4, 0);
            lblFrizer.Name = "lblFrizer";
            lblFrizer.Size = new Size(54, 25);
            lblFrizer.TabIndex = 6;
            lblFrizer.Text = "Frizer";
            // 
            // cmbUsluga
            // 
            cmbUsluga.Enabled = false;
            cmbUsluga.FormattingEnabled = true;
            cmbUsluga.Location = new Point(1043, 240);
            cmbUsluga.Margin = new Padding(4, 5, 4, 5);
            cmbUsluga.Name = "cmbUsluga";
            cmbUsluga.Size = new Size(171, 33);
            cmbUsluga.TabIndex = 9;
            cmbUsluga.SelectionChangeCommitted += cmbUsluga_SelectionChangeCommitted;
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(893, 248);
            lblUsluga.Margin = new Padding(4, 0, 4, 0);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(66, 25);
            lblUsluga.TabIndex = 8;
            lblUsluga.Text = "Usluga";
            // 
            // lblCenaRacun
            // 
            lblCenaRacun.AutoSize = true;
            lblCenaRacun.Location = new Point(893, 307);
            lblCenaRacun.Margin = new Padding(4, 0, 4, 0);
            lblCenaRacun.Name = "lblCenaRacun";
            lblCenaRacun.Size = new Size(108, 25);
            lblCenaRacun.TabIndex = 10;
            lblCenaRacun.Text = "Cena racuna";
            // 
            // tbCenaRacuna
            // 
            tbCenaRacuna.Enabled = false;
            tbCenaRacuna.Location = new Point(1043, 302);
            tbCenaRacuna.Margin = new Padding(4, 5, 4, 5);
            tbCenaRacuna.Name = "tbCenaRacuna";
            tbCenaRacuna.Size = new Size(171, 31);
            tbCenaRacuna.TabIndex = 11;
            tbCenaRacuna.TextChanged += tbCenaRacuna_TextChanged;
            // 
            // rbFrizer
            // 
            rbFrizer.AutoSize = true;
            rbFrizer.Location = new Point(17, 63);
            rbFrizer.Name = "rbFrizer";
            rbFrizer.Size = new Size(21, 20);
            rbFrizer.TabIndex = 12;
            rbFrizer.TabStop = true;
            rbFrizer.UseVisualStyleBackColor = true;
            rbFrizer.CheckedChanged += rbFrizer_CheckedChanged;
            // 
            // rbKlijent
            // 
            rbKlijent.AutoSize = true;
            rbKlijent.Location = new Point(17, 21);
            rbKlijent.Name = "rbKlijent";
            rbKlijent.Size = new Size(21, 20);
            rbKlijent.TabIndex = 13;
            rbKlijent.TabStop = true;
            rbKlijent.UseVisualStyleBackColor = true;
            rbKlijent.CheckedChanged += rbKlijent_CheckedChanged;
            // 
            // rbUsluga
            // 
            rbUsluga.AutoSize = true;
            rbUsluga.Location = new Point(17, 111);
            rbUsluga.Name = "rbUsluga";
            rbUsluga.Size = new Size(21, 20);
            rbUsluga.TabIndex = 14;
            rbUsluga.TabStop = true;
            rbUsluga.UseVisualStyleBackColor = true;
            rbUsluga.CheckedChanged += rbUsluga_CheckedChanged;
            // 
            // rbCenaRacuna
            // 
            rbCenaRacuna.AutoSize = true;
            rbCenaRacuna.Location = new Point(17, 170);
            rbCenaRacuna.Name = "rbCenaRacuna";
            rbCenaRacuna.Size = new Size(21, 20);
            rbCenaRacuna.TabIndex = 15;
            rbCenaRacuna.TabStop = true;
            rbCenaRacuna.UseVisualStyleBackColor = true;
            rbCenaRacuna.CheckedChanged += rbCenaRacuna_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbKlijent);
            groupBox1.Controls.Add(rbCenaRacuna);
            groupBox1.Controls.Add(rbUsluga);
            groupBox1.Controls.Add(rbFrizer);
            groupBox1.Location = new Point(824, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(62, 207);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // btnDetalji
            // 
            btnDetalji.Location = new Point(833, 383);
            btnDetalji.Margin = new Padding(4, 5, 4, 5);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(141, 92);
            btnDetalji.TabIndex = 17;
            btnDetalji.Text = "Detalji racuna";
            btnDetalji.UseVisualStyleBackColor = true;
            btnDetalji.Click += btnDetalji_Click;
            // 
            // UCRacunOpsta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDetalji);
            Controls.Add(groupBox1);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCRacunOpsta";
            Size = new Size(1287, 528);
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private RadioButton rbFrizer;
        private RadioButton rbKlijent;
        private RadioButton rbUsluga;
        private RadioButton rbCenaRacuna;
        private GroupBox groupBox1;
        private Button btnDetalji;

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
