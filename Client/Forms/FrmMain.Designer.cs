namespace Client
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            TSMIracun = new ToolStripMenuItem();
            TSMIklijent = new ToolStripMenuItem();
            TSMIkvalifikacija = new ToolStripMenuItem();
            pnlMain = new Panel();
            lblPocetniMeni = new Label();
            menuStrip1.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMIracun, TSMIklijent, TSMIkvalifikacija });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMIracun
            // 
            TSMIracun.Name = "TSMIracun";
            TSMIracun.Size = new Size(76, 29);
            TSMIracun.Text = "Racun";
            TSMIracun.Click += TSMIracun_Click;
            // 
            // TSMIklijent
            // 
            TSMIklijent.Name = "TSMIklijent";
            TSMIklijent.Size = new Size(75, 29);
            TSMIklijent.Text = "Klijent";
            TSMIklijent.Click += TSMIklijent_Click;
            // 
            // TSMIkvalifikacija
            // 
            TSMIkvalifikacija.Name = "TSMIkvalifikacija";
            TSMIkvalifikacija.Size = new Size(116, 29);
            TSMIkvalifikacija.Text = "Kvalifikacija";
            TSMIkvalifikacija.Click += TSMIkvalifikacija_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblPocetniMeni);
            pnlMain.Location = new Point(0, 45);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1143, 707);
            pnlMain.TabIndex = 1;
            // 
            // lblPocetniMeni
            // 
            lblPocetniMeni.AutoSize = true;
            lblPocetniMeni.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPocetniMeni.Location = new Point(241, 289);
            lblPocetniMeni.Name = "lblPocetniMeni";
            lblPocetniMeni.Size = new Size(639, 67);
            lblPocetniMeni.TabIndex = 0;
            lblPocetniMeni.Text = "Dobrodosli na pocetni meni";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "Frizerski salon";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMIracun;
        private ToolStripMenuItem TSMIklijent;
        private ToolStripMenuItem TSMIkvalifikacija;
        private Panel pnlMain;
        private Label lblPocetniMeni;

        public Panel PnlMain
        {
            get { return pnlMain; }
        }
    }
}