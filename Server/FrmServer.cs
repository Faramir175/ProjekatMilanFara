namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnServerStop.Enabled = false;
        }

        private void btnServerStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnServerStop.Enabled = false;
            btnServerStart.Enabled = true;
            server.Listen();
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();
            btnServerStop.Enabled=true;
            btnServerStart.Enabled=false;
        }
    }
}
