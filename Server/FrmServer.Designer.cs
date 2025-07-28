namespace Server
{
    partial class FrmServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnServerStop = new Button();
            btnServerStart = new Button();
            lblServer = new Label();
            SuspendLayout();
            // 
            // btnServerStop
            // 
            btnServerStop.Location = new Point(384, 106);
            btnServerStop.Margin = new Padding(4, 5, 4, 5);
            btnServerStop.Name = "btnServerStop";
            btnServerStop.Size = new Size(198, 124);
            btnServerStop.TabIndex = 0;
            btnServerStop.Text = "Zaustavi server";
            btnServerStop.UseVisualStyleBackColor = true;
            btnServerStop.Click += btnServerStop_Click;
            // 
            // btnServerStart
            // 
            btnServerStart.Location = new Point(64, 106);
            btnServerStart.Margin = new Padding(4, 5, 4, 5);
            btnServerStart.Name = "btnServerStart";
            btnServerStart.Size = new Size(198, 124);
            btnServerStart.TabIndex = 1;
            btnServerStart.Text = "Pokreni server";
            btnServerStart.UseVisualStyleBackColor = true;
            btnServerStart.Click += btnServerStart_Click;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(240, 293);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(170, 25);
            lblServer.TabIndex = 2;
            lblServer.Text = "Server nije pokrenut";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 411);
            Controls.Add(lblServer);
            Controls.Add(btnServerStart);
            Controls.Add(btnServerStop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmServer";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServerStop;
        private Button btnServerStart;
        private Label lblServer;
    }
}
