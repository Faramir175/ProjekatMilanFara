namespace Client
{
    partial class FrmLogIn
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
            btnPrijava = new Button();
            lblKorisnickoIme = new Label();
            lblSifra = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(127, 229);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(116, 50);
            btnPrijava.TabIndex = 0;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize = true;
            lblKorisnickoIme.Location = new Point(25, 74);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new Size(85, 15);
            lblKorisnickoIme.TabIndex = 1;
            lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // lblSifra
            // 
            lblSifra.AutoSize = true;
            lblSifra.Location = new Point(80, 164);
            lblSifra.Name = "lblSifra";
            lblSifra.Size = new Size(30, 15);
            lblSifra.TabIndex = 2;
            lblSifra.Text = "Sifra";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(127, 71);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(116, 23);
            tbUsername.TabIndex = 3;
            tbUsername.Text = "Zoki2015";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(127, 161);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(116, 23);
            tbPassword.TabIndex = 4;
            tbPassword.Text = "zoki2015!";
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 321);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblSifra);
            Controls.Add(lblKorisnickoIme);
            Controls.Add(btnPrijava);
            Name = "FrmLogIn";
            Text = "Prijava frizera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrijava;
        private Label lblKorisnickoIme;
        private Label lblSifra;
        private TextBox tbUsername;
        private TextBox tbPassword;
        public TextBox TbUsername { get => tbUsername; set => tbUsername = value; }
        public TextBox TbPassword { get => tbPassword; set => tbPassword = value; }
        public Button BtnPrijava { get => btnPrijava; set => btnPrijava = value; }
    }
}