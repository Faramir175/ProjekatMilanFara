﻿using Client.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCUnosKvalifikacije : UserControl
    {
        public UCUnosKvalifikacije()
        {
            InitializeComponent();
        }

        private void cbPromenaKvalifikacije_CheckedChanged(object sender, EventArgs e)
        {
            KvalifikacijaGuiController.Instance.PromenaCheck(this);
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if(this.cbPromenaKvalifikacije.Checked)
            {
                KvalifikacijaGuiController.Instance.UnosPromenjeneKvalifikacije(this);
            }
            else
            {
                KvalifikacijaGuiController.Instance.UnosNoveKvalifikacije(this);
            }
        }
    }
}
