using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController
{
    internal class StavkeRacunaGuiController
    {
        private static StavkeRacunaGuiController instance;
        public static StavkeRacunaGuiController Instance {
            get 
            { 
                if (instance == null) instance = new StavkeRacunaGuiController();
                return instance; 
            } 
        }

        internal void PromeniFormu(FrmStavkeRacuna frmStavkeRacuna)
        {
            frmStavkeRacuna = new FrmStavkeRacuna();
            frmStavkeRacuna.AutoSize = true;
            frmStavkeRacuna.ShowDialog();
        }
    }
}
