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
            lblKorisnik = new Label();
            cmbKorisnik = new ComboBox();
            btnUnosNovogRacuna = new Button();
            btnPromeniRacun = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            SuspendLayout();
            // 
            // dgvRacuni
            // 
            dgvRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRacuni.Location = new Point(3, 3);
            dgvRacuni.Name = "dgvRacuni";
            dgvRacuni.RowTemplate.Height = 25;
            dgvRacuni.Size = new Size(514, 311);
            dgvRacuni.TabIndex = 0;
            // 
            // lblPretraziRacun
            // 
            lblPretraziRacun.AutoSize = true;
            lblPretraziRacun.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblPretraziRacun.Location = new Point(622, 29);
            lblPretraziRacun.Name = "lblPretraziRacun";
            lblPretraziRacun.Size = new Size(154, 31);
            lblPretraziRacun.TabIndex = 1;
            lblPretraziRacun.Text = "Pretrazi racun";
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Location = new Point(603, 91);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(49, 15);
            lblKorisnik.TabIndex = 2;
            lblKorisnik.Text = "Korisnik";
            // 
            // cmbKorisnik
            // 
            cmbKorisnik.FormattingEnabled = true;
            cmbKorisnik.Location = new Point(708, 86);
            cmbKorisnik.Name = "cmbKorisnik";
            cmbKorisnik.Size = new Size(121, 23);
            cmbKorisnik.TabIndex = 3;
            // 
            // btnUnosNovogRacuna
            // 
            btnUnosNovogRacuna.Location = new Point(586, 185);
            btnUnosNovogRacuna.Name = "btnUnosNovogRacuna";
            btnUnosNovogRacuna.Size = new Size(99, 47);
            btnUnosNovogRacuna.TabIndex = 4;
            btnUnosNovogRacuna.Text = "Unos novog racuna";
            btnUnosNovogRacuna.UseVisualStyleBackColor = true;
            // 
            // btnPromeniRacun
            // 
            btnPromeniRacun.Location = new Point(733, 186);
            btnPromeniRacun.Name = "btnPromeniRacun";
            btnPromeniRacun.Size = new Size(96, 46);
            btnPromeniRacun.TabIndex = 5;
            btnPromeniRacun.Text = "Promeni racun";
            btnPromeniRacun.UseVisualStyleBackColor = true;
            // 
            // UCRacunOpsta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPromeniRacun);
            Controls.Add(btnUnosNovogRacuna);
            Controls.Add(cmbKorisnik);
            Controls.Add(lblKorisnik);
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
        private Label lblKorisnik;
        private ComboBox cmbKorisnik;
        private Button btnUnosNovogRacuna;
        private Button btnPromeniRacun;
    }
}
