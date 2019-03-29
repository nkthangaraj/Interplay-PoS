using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.CustomControls
{
    public class InterPlayPOSButton : Button
    {
        public InterPlayPOSButton()
        {
            Height = 60;
            Width = 80;
            BackColor = Color.LimeGreen;
            ForeColor = Color.White;
            Margin = new Padding(0);
            Padding = new Padding(0);
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
        }
    }
}
