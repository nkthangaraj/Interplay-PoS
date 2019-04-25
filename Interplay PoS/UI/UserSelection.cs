
using BL;
using BL.Contracts.User;
using Proxy.Contracts;
using System;
using System.Collections.Generic;

using System.Windows.Forms;
using UI.CustomControls;
using UI.Storage;


namespace UI
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
            PrepareUserSelectionview();
        }

        private void AlignUI()
        {
            this.Height = 600;
            this.Width = 600;
        }

        private void PrepareUserSelectionview()
        {
            List<User> userDetails = this.GetUserDetail();
            this.CreateUserSelectionButtons(userDetails);
        }

        private List<User> GetUserDetail()
        {
            UserBL userBL = new UserBL(
                new Credential { UserName="admin", Password = "admin"});

            List<User> allUsers = userBL.GetAllUsers();
            return allUsers;
        }

        private void CreateUserSelectionButtons(List<User> userDetails)
        {
            foreach (User detail in userDetails)
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
            User user = ((InterplayPOSUserSelectionButton)sender).userDetail;
            InterplayStorage.SelectedUser = new Credential() { UserName = user.username };
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
