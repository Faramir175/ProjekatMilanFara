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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(127, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 4;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 321);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
    }
}