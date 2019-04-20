using io.cloudloom.interplay.pos.Proxy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CustomControls;
using UI.Storage;
using Proxy.Contracts;

namespace UI
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
           // AlignUI();
            PrepareUserSelectionview();
        }

        private void AlignUI()
        {
            this.Height = 600;
            this.Width = 600;
        }

        private void PrepareUserSelectionview()
        {
            List<io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User> userDetails = this.GetUserDetail();
            this.CreateUserSelectionButtons(userDetails);
        }
        private List<io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User> GetUserDetail()
        {
            List<io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User> allUsers = InterplayStorage.GetAllUsers();

            return allUsers;
        }

        private void CreateUserSelectionButtons(List<io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User> userDetails)
        {
            foreach(io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User detail in userDetails)
            {
                InterplayPOSUserSelectionButton button = new InterplayPOSUserSelectionButton();
                button.Text = detail.username;
                button.userDetail = detail;
                button.Click += User_Button_Click;
                button.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutPanelUserSelection.Controls.Add(button);
            }
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers.User user = ((InterplayPOSUserSelectionButton)sender).userDetail;
            InterplayStorage.SelectedUser = user;
            Authentication authForm = new Authentication();
            authForm.Show();
            authForm.Focus();
            authForm.FormClosed += AuthForm_FormClosed;
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
