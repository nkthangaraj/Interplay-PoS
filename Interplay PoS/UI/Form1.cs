using io.cloudloom.interplay.pos.Proxy.Services;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace io.cloudloom.interplay.pos.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                //UserService ser = new UserService();
                //string str =  ser.GetProfile();
                CatalogueService service = new CatalogueService();
                string str = service.GetCatalogue();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
