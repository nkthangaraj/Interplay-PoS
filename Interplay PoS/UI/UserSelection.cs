using Proxy.Contracts;
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

namespace UI
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
            AlignUI();
            PrepareUserSelectionview();
        }

        private void AlignUI()
        {
            this.Height = 600;
            this.Width = 600;
        }

        private void PrepareUserSelectionview()
        {
            List<UserDetail> userDetails = this.GetUserDetail();
            this.CreateUserSelectionButtons(userDetails);
        }
        private List<UserDetail> GetUserDetail()
        {
            List<UserDetail> userDetails = new List<UserDetail>()
            {
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
                new UserDetail{UserName = "admin", Password = "admin"},
            };

            return userDetails;
        }

        private void CreateUserSelectionButtons(List<UserDetail> userDetails)
        {
            foreach(UserDetail detail in userDetails)
            {
                InterplayPOSUserSelectionButton button = new InterplayPOSUserSelectionButton();
                button.Text = detail.UserName;
                button.userDetail = detail;
                button.Click += User_Button_Click;
                button.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutPanelUserSelection.Controls.Add(button);
            }
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            UserDetail user = ((InterplayPOSUserSelectionButton)sender).userDetail;
            InterplayStorage.SelectedUser = user;
            Authentication authForm = new Authentication();
            authForm.Show();
            authForm.Focus();
            this.Hide();
        }
    }
}
