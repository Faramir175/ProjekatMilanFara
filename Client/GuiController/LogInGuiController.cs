using Broker;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Identity.Client;
using Client.ServerCommunication;

namespace Client.GuiController
{
    class LogInGuiController
    {
        private static LogInGuiController instance;
        private FrmLogIn frmLogIn;

        public static LogInGuiController Instance
        {
            get
            {
                if (instance == null)
                    instance = new LogInGuiController();
                return instance;
            }
        }

        public void LogInUser(FrmLogIn frmLogIn)
        {
            Communication.Instance.Connect();

            this.frmLogIn = frmLogIn;

            string username = frmLogIn.TbUsername.Text.Trim();
            string password = frmLogIn.TbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(username))
                {
                    frmLogIn.TbUsername.BackColor = Color.Salmon;
                }
                if (string.IsNullOrEmpty(password))
                {
                    frmLogIn.TbPassword.BackColor = Color.Salmon;
                }
                MessageBox.Show("Some field is empthy!");
                return;
            }

            List<Frizer> users = Communication.Instance.LoginUser(username, password);
            if(users.Count == 1 && users.First<Frizer>().KorisnickoIme != null)
            {
                MessageBox.Show("Корисничко име и шифра су исправни");
                MainGuiController.Instance.logedUser = users.First<Frizer>();
                try
                {
                    MainGuiController.Instance.ShowFrmMain(frmLogIn);
                }
                catch (Exception)
                {
                    MessageBox.Show("Не може да се отвори главна форма и мени");
                }
            }
            else
            {
                MessageBox.Show("Не може да се отвори главна форма и мени");

            }
        }
    }
}
