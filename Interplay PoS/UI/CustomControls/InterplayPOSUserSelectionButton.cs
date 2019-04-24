using BL.Contracts.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.CustomControls
{
    public class InterplayPOSUserSelectionButton : InterPlayPOSButton
    {
        public InterplayPOSUserSelectionButton()
        {
            Height = 100;
            Width = 204;
            BackColor = Color.LimeGreen;
            ForeColor = Color.White;
            Margin = new Padding(0);
            Padding = new Padding(0);
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
        }
        public User userDetail { get; set; }
    }
}
