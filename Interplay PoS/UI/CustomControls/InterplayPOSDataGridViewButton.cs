using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model;

namespace UI.CustomControls
{
    public class InterplayPOSDataGridViewButton : DataGridViewButtonColumn
    {
        public Item item { get; set; }
    }
}
