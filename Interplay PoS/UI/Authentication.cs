using io.cloudloom.interplay.pos.Proxy.Contracts;
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
            string username = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text;

            string error = this.authenticate(username, password);

            if(!string.IsNullOrEmpty(error))
            {
                lblError.Text = error;
            }

            else
            {
                interplayMainForm posForm = new interplayMainForm();
                posForm.Show();
            }
        }

        private string authenticate(string userName, string password)
        {
            return AuthenticationUtility.Authenticate(
                new Credential
                {
                    UserName = userName,
                    Password = password
                });
        }
    }
}
