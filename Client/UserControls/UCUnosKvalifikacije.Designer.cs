namespace Client.UserControls
{
    partial class UCUnosKvalifikacije
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
            btnUnesi = new Button();
            lblUnosKvalifikacije = new Label();
            lblNazivKvalifikacije = new Label();
            tbNazivKvalifikacije = new TextBox();
            lblPromenaKvalifikacija = new Label();
            cmbKvalifikacija = new ComboBox();
            cbPromenaKvalifikacije = new CheckBox();
            SuspendLayout();
            // 
            // btnUnesi
            // 
            btnUnesi.Location = new Point(209, 217);
            btnUnesi.Name = "btnUnesi";
            btnUnesi.Size = new Size(143, 35);
            btnUnesi.TabIndex = 0;
            btnUnesi.Text = "Unesi";
            btnUnesi.UseVisualStyleBackColor = true;
            btnUnesi.Click += btnUnesi_Click;
            // 
            // lblUnosKvalifikacije
            // 
            lblUnosKvalifikacije.AutoSize = true;
            lblUnosKvalifikacije.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnosKvalifikacije.Location = new Point(67, 30);
            lblUnosKvalifikacije.Name = "lblUnosKvalifikacije";
            lblUnosKvalifikacije.Size = new Size(244, 31);
            lblUnosKvalifikacije.TabIndex = 1;
            lblUnosKvalifikacije.Text = "Unos nove kvalifikacije";
            // 
            // lblNazivKvalifikacije
            // 
            lblNazivKvalifikacije.AutoSize = true;
            lblNazivKvalifikacije.Location = new Point(67, 99);
            lblNazivKvalifikacije.Name = "lblNazivKvalifikacije";
            lblNazivKvalifikacije.Size = new Size(100, 15);
            lblNazivKvalifikacije.TabIndex = 2;
            lblNazivKvalifikacije.Text = "Naziv kvalifikacije";
            // 
            // tbNazivKvalifikacije
            // 
            tbNazivKvalifikacije.Location = new Point(201, 91);
            tbNazivKvalifikacije.Name = "tbNazivKvalifikacije";
            tbNazivKvalifikacije.Size = new Size(151, 23);
            tbNazivKvalifikacije.TabIndex = 3;
            // 
            // lblPromenaKvalifikacija
            // 
            lblPromenaKvalifikacija.AutoSize = true;
            lblPromenaKvalifikacija.Location = new Point(35, 157);
            lblPromenaKvalifikacija.Name = "lblPromenaKvalifikacija";
            lblPromenaKvalifikacija.Size = new Size(135, 15);
            lblPromenaKvalifikacija.TabIndex = 4;
            lblPromenaKvalifikacija.Text = "Kvalifikacija za promenu";
            // 
            // cmbKvalifikacija
            // 
            cmbKvalifikacija.FormattingEnabled = true;
            cmbKvalifikacija.Location = new Point(201, 154);
            cmbKvalifikacija.Name = "cmbKvalifikacija";
            cmbKvalifikacija.Size = new Size(151, 23);
            cmbKvalifikacija.TabIndex = 5;
            // 
            // cbPromenaKvalifikacije
            // 
            cbPromenaKvalifikacije.AutoSize = true;
            cbPromenaKvalifikacije.Location = new Point(38, 226);
            cbPromenaKvalifikacije.Name = "cbPromenaKvalifikacije";
            cbPromenaKvalifikacije.Size = new Size(136, 19);
            cbPromenaKvalifikacije.TabIndex = 6;
            cbPromenaKvalifikacije.Text = "Promeni kvalifikaciju";
            cbPromenaKvalifikacije.UseVisualStyleBackColor = true;
            cbPromenaKvalifikacije.CheckedChanged += cbPromenaKvalifikacije_CheckedChanged;
            // 
            // UCUnosKvalifikacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbPromenaKvalifikacije);
            Controls.Add(cmbKvalifikacija);
            Controls.Add(lblPromenaKvalifikacija);
            Controls.Add(tbNazivKvalifikacije);
            Controls.Add(lblNazivKvalifikacije);
            Controls.Add(lblUnosKvalifikacije);
            Controls.Add(btnUnesi);
            Name = "UCUnosKvalifikacije";
            Size = new Size(403, 316);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnesi;
        private Label lblUnosKvalifikacije;
        private Label lblNazivKvalifikacije;
        private TextBox tbNazivKvalifikacije;
        private Label lblPromenaKvalifikacija;
        private ComboBox cmbKvalifikacija;
        private CheckBox cbPromenaKvalifikacije;

        public CheckBox CbPromenaKvalifikacije { get { return cbPromenaKvalifikacije;  }  }
        public ComboBox CmbKvalifikacija { get { return cmbKvalifikacija; } }
        public TextBox TbNazivKvalifikacije { get { return tbNazivKvalifikacije; } }
        public Button BtnUnesi { get { return btnUnesi; } }
        public Label LblUnosKvalifikacije { get { return lblUnosKvalifikacije; } }
    }
}
