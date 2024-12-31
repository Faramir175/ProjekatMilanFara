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
        private static FrmMain instance;
        private FrmMain frmMain;
        public Frizer logedUser { get; set; }

        public static FrmMain Instance
        {
            get 
            { 
                if (instance == null) instance = new FrmMain();
                return instance; 
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        internal void ShowFrmMain(FrmLogIn frmLogIn)
        {
            frmMain = new FrmMain();
            frmLogIn.Visible = false;
            frmMain.Text = logedUser.ToString();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();

            frmLogIn.Visible = true;
        }
    }
}
