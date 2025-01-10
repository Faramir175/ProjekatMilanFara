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
            SuspendLayout();
            // 
            // btnServerStop
            // 
            btnServerStop.Location = new Point(510, 156);
            btnServerStop.Name = "btnServerStop";
            btnServerStop.Size = new Size(139, 106);
            btnServerStop.TabIndex = 0;
            btnServerStop.Text = "Zaustavi server";
            btnServerStop.UseVisualStyleBackColor = true;
            btnServerStop.Click += btnServerStop_Click;
            // 
            // btnServerStart
            // 
            btnServerStart.Location = new Point(171, 156);
            btnServerStart.Name = "btnServerStart";
            btnServerStart.Size = new Size(139, 106);
            btnServerStart.TabIndex = 1;
            btnServerStart.Text = "Pokreni server";
            btnServerStart.UseVisualStyleBackColor = true;
            btnServerStart.Click += btnServerStart_Click;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServerStart);
            Controls.Add(btnServerStop);
            Name = "FrmServer";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private Button btnServerStop;
        private Button btnServerStart;
    }
}
