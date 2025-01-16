using Common.Domain;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController
{
    public class MainGuiController
    {
        private static MainGuiController instance;
        private RacunGuiController racunGuiController;
        private KvalifikacijaGuiController kvalifikacijaGuiController;
        private KlijentGuiController klijentGuiController;
        private FrmMain frmMain;

        public Frizer logedUser { get; set; }

        public static MainGuiController Instance 
        {  
            get 
            {
                if (instance == null) instance = new MainGuiController();
                return instance;
            } 
        }

        public MainGuiController()
        {
            racunGuiController = new RacunGuiController();
            kvalifikacijaGuiController = new KvalifikacijaGuiController();
            klijentGuiController = new KlijentGuiController();
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

        internal void PanelRacun(FrmMain frmMain)
        {
            PromeniPanel(racunGuiController.CreateUCRacun(),frmMain.PnlMain);
            
        }

        private void PromeniPanel(UserControl uc,Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = true;
            pnl.AutoSize = true;

            uc.Width = pnl.Width;
        }

        internal void PanelKvalifikacija(FrmMain frmMain)
        {
            PromeniPanel(kvalifikacijaGuiController.CreateUCUnosKvalifikacije(), frmMain.PnlMain);
        }

        internal void PanelKlijent(FrmMain frmMain)
        {
            PromeniPanel(klijentGuiController.CreateUCKlijentiOpste(), frmMain.PnlMain);
        }
    }
}
