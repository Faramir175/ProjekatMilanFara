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
        private TestBroker broker;
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
            try
            {
                broker = new TestBroker();
                broker.Open();
                Communication.Instance.Connect();
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

                List<Frizer> users = new List<Frizer>();

                using(SqlCommand command = broker.GetConnection().CreateCommand()) {

                    command.CommandText = "select * from Frizer";
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Frizer user = new Frizer();
                            user.IdFrizer = reader.GetInt32(0);
                            user.ImePrezime = (string)reader["imePrezime"];
                            user.Kontakt = (string)reader["kontakt"];
                            user.KorisnickoIme = (string)reader["korisnickoIme"];
                            user.Sifra = (string)reader["sifra"];
                            users.Add(user); 
                        }
                    }
                }

                foreach (Frizer user in users)
                {
                    if (username == user.KorisnickoIme && password == user.Sifra)
                    {
                        MessageBox.Show("Uspesno ste se ulogovali");
                        MainGuiController.Instance.logedUser = user;
                        MainGuiController.Instance.ShowFrmMain(frmLogIn);
                        return;
                    }
                }
                MessageBox.Show("Pogresni kredencijali");
            }
            finally
            {
                broker.Close();
            }
        }
    }
}
