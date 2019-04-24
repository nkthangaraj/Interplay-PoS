using BL;
using io.cloudloom.interplay.pos.ui;
using Proxy.Contracts;
using System;
using System.Linq;
using System.Windows.Forms;
using UI.Storage;

namespace UI
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private bool authenticate(string userName, string password)
        {
            UserBL userBL = new UserBL(
                new Credential { UserName = "admin", Password = "admin" });

            return userBL.Authenticate(
                new Credential
                {
                    UserName = userName,
                    Password = password
                });
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Count() == 5)
            {
                string password = this.txtPassword.Text;

                if (!this.authenticate(InterplayStorage.SelectedUser.UserName, password))
                {
                    lblInvalidUserMessage.Text = "Invalid PIN";
                }

                else
                {
                    InterplayStorage.SelectedUser.Password = password;
                    interplayMainForm posForm = new interplayMainForm();
                    posForm.Show();
                    this.Close();
                }
            }
        }
    }
}
