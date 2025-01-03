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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMIracun, TSMIklijent, TSMIkvalifikacija });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMIracun
            // 
            TSMIracun.Name = "TSMIracun";
            TSMIracun.Size = new Size(52, 20);
            TSMIracun.Text = "Racun";
            TSMIracun.Click += TSMIracun_Click;
            // 
            // TSMIklijent
            // 
            TSMIklijent.Name = "TSMIklijent";
            TSMIklijent.Size = new Size(52, 20);
            TSMIklijent.Text = "Klijent";
            // 
            // TSMIkvalifikacija
            // 
            TSMIkvalifikacija.Name = "TSMIkvalifikacija";
            TSMIkvalifikacija.Size = new Size(81, 20);
            TSMIkvalifikacija.Text = "Kvalifikacija";
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(0, 27);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 424);
            pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Frizerski salon";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMIracun;
        private ToolStripMenuItem TSMIklijent;
        private ToolStripMenuItem TSMIkvalifikacija;
        private Panel pnlMain;

        public Panel PnlMain
        {
            get { return pnlMain; }
        }
    }
}