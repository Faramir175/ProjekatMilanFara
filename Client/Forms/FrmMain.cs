using Client.GuiController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void TSMIracun_Click(object sender, EventArgs e)
        {
            MainGuiController.Instance.PanelRacun(this);
        }

        private void TSMIkvalifikacija_Click(object sender, EventArgs e)
        {
            MainGuiController.Instance.PanelKvalifikacija(this);
        }

        private void TSMIklijent_Click(object sender, EventArgs e)
        {
            MainGuiController.Instance.PanelKlijent(this);
        }
    }
}
