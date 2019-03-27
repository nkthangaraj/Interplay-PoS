using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;

namespace UI.CustomControls
{
   public class InterPlayPOSButton:Button
    {
        protected void RePaint()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 25, 25, 180, 90);
            graphicpath.AddLine(25, 0, this.Width - 25, 0);
            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);
            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
        }
    }

    public class InterPlayPOSCatalogueButton: Button
    {
        public Catalog catalogue { get; set; }
    }

    public class InterPlayPOSProductEntryButton: Button
    {
        public ProductEntry productEntry { get; set; }
    }

    public class InterplayPOSArticleButton: Button
    {
        public SimpleArticle simpleArticle { get; set; }
    }
}
