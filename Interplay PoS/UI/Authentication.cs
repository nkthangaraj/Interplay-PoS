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
using UI.Storage;

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

            string error = this.authenticate(InterplayStorage.SelectedUser.UserName, password);

            if(!string.IsNullOrEmpty(error))
            {
                labelError.Text = error;
            }

            else
            {
                interplayMainForm posForm = new interplayMainForm();
                posForm.Show();
                this.Close();
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
