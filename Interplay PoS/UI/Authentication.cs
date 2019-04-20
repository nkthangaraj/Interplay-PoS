using io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Utility;
using io.cloudloom.interplay.pos.ui;
using UI.Storage;
using io.cloudloom.interplay.pos.Proxy.Contracts;

namespace UI
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = this.txtPassword.Text;

            User user = this.authenticate(InterplayStorage.SelectedUser.username, password);

            if(user is null)
            {
                lblInvalidUserMessage.Text = "Invalid PIN";
            }

            else
            {
                interplayMainForm posForm = new interplayMainForm();
                posForm.Show();
                this.Close();
            }
        }

        private User authenticate(string userName, string password)
        {
            return AuthenticationUtility.Authenticate(
                new Credential
                {
                    UserName = userName,
                    Password = password
                });
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Count() == 6)
            {
                string password = this.txtPassword.Text;

                User user = this.authenticate(InterplayStorage.SelectedUser.username, password);

                if (user is null)
                {
                    lblInvalidUserMessage.Text = "Invalid PIN";
                }

                else
                {
                    interplayMainForm posForm = new interplayMainForm();
                    //posForm.MdiParent = true;
                    posForm.Show();
                    this.Close();                    
                }
            }
        }
    }
}
