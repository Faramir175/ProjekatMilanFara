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
            InitCmbKvalifikacija(ucKvalifikacijeView);
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

        private void InitCmbKvalifikacija(UCUnosKvalifikacije uc)
        {
            List<Kvalifikacija> kvalifikacijas = Communication.Instance.VratiListuSviKvalifikacija();
            kvalifikacije = new BindingList<Kvalifikacija>();
            foreach (Kvalifikacija k in kvalifikacijas)
            {
                kvalifikacije.Add(k);
            }
            uc.CmbKvalifikacija.DataSource = kvalifikacije;
        }

        internal void UnosNoveKvalifikacije(UCUnosKvalifikacije uc)
        {
            try
            {
                Kvalifikacija novaKvalifikacija = new Kvalifikacija();
                novaKvalifikacija.NazivKvalifikacije = uc.TbNazivKvalifikacije.Text;
                Communication.Instance.UbaciKvalifikacija(novaKvalifikacija);
                MessageBox.Show("Систем је запамтио квалификацију");
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да запамти квалификацију");
            }

            InitCmbKvalifikacija(uc);
        }

        internal void UnosPromenjeneKvalifikacije(UCUnosKvalifikacije uc)
        {
            try
            {
                Kvalifikacija kvalifikacijaZaPromenu = (Kvalifikacija)uc.CmbKvalifikacija.SelectedItem;
                kvalifikacijaZaPromenu.NazivKvalifikacije = uc.TbNazivKvalifikacije.Text;
                Communication.Instance.PromeniKvalifikacija(kvalifikacijaZaPromenu);
                MessageBox.Show("Систем је запамтио квалификацију");
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да запамти квалификацију");
            }
            InitCmbKvalifikacija(uc);
        }
    }
}
