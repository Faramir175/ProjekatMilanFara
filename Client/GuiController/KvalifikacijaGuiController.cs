using Client.ServerCommunication;
using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController
{
    public class KvalifikacijaGuiController
    {
        UCUnosKvalifikacije ucKvalifikacijeView;
        private BindingList<Kvalifikacija> kvalifikacije;
        private static KvalifikacijaGuiController instance;
        public static KvalifikacijaGuiController Instance {  get { if (instance == null) instance = new KvalifikacijaGuiController(); return instance; } }

        public UserControl CreateUCUnosKvalifikacije()
        {
            ucKvalifikacijeView = new UCUnosKvalifikacije();
            InitCmbKvalifikacija();
            PromenaCheck(ucKvalifikacijeView);

            return ucKvalifikacijeView;
        }

        public void PromenaCheck(UCUnosKvalifikacije uc)
        {
            bool uslov = uc.CbPromenaKvalifikacije.Checked;
            if (uslov)
            {
                uc.LblUnosKvalifikacije.Text = "Promena kvalifikacije";
            }else uc.LblUnosKvalifikacije.Text = "Unos nove kvalifikacije";
            uc.CmbKvalifikacija.Enabled = uslov;
        }

        private void InitCmbKvalifikacija()
        {
            List<Kvalifikacija> kvalifikacijas = Communication.Instance.VratiListuSviKvalifikacija();
            kvalifikacije = new BindingList<Kvalifikacija>();
            foreach (Kvalifikacija k in kvalifikacijas)
            {
                kvalifikacije.Add(k);
            }
            ucKvalifikacijeView.CmbKvalifikacija.DataSource = kvalifikacije;
        }
    }
}
