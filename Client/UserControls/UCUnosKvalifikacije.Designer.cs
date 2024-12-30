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
            SuspendLayout();
            // 
            // btnUnesi
            // 
            btnUnesi.Location = new Point(160, 189);
            btnUnesi.Name = "btnUnesi";
            btnUnesi.Size = new Size(143, 35);
            btnUnesi.TabIndex = 0;
            btnUnesi.Text = "Unesi";
            btnUnesi.UseVisualStyleBackColor = true;
            // 
            // lblUnosKvalifikacije
            // 
            lblUnosKvalifikacije.AutoSize = true;
            lblUnosKvalifikacije.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnosKvalifikacije.Location = new Point(69, 28);
            lblUnosKvalifikacije.Name = "lblUnosKvalifikacije";
            lblUnosKvalifikacije.Size = new Size(189, 31);
            lblUnosKvalifikacije.TabIndex = 1;
            lblUnosKvalifikacije.Text = "Unos kvalifikacije";
            // 
            // lblNazivKvalifikacije
            // 
            lblNazivKvalifikacije.AutoSize = true;
            lblNazivKvalifikacije.Location = new Point(26, 116);
            lblNazivKvalifikacije.Name = "lblNazivKvalifikacije";
            lblNazivKvalifikacije.Size = new Size(100, 15);
            lblNazivKvalifikacije.TabIndex = 2;
            lblNazivKvalifikacije.Text = "Naziv kvalifikacije";
            // 
            // tbNazivKvalifikacije
            // 
            tbNazivKvalifikacije.Location = new Point(160, 108);
            tbNazivKvalifikacije.Name = "tbNazivKvalifikacije";
            tbNazivKvalifikacije.Size = new Size(143, 23);
            tbNazivKvalifikacije.TabIndex = 3;
            // 
            // UCUnosKvalifikacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbNazivKvalifikacije);
            Controls.Add(lblNazivKvalifikacije);
            Controls.Add(lblUnosKvalifikacije);
            Controls.Add(btnUnesi);
            Name = "UCUnosKvalifikacije";
            Size = new Size(356, 263);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnesi;
        private Label lblUnosKvalifikacije;
        private Label lblNazivKvalifikacije;
        private TextBox tbNazivKvalifikacije;
    }
}
