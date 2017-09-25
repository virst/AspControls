using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspControls.Controls
{
    public partial class PanelSplitter : System.Web.UI.UserControl
    {
        public string innerPanel1 { get; set; }
        public string innerPanel2 { get; set; }



        public Unit Width
        {
            get { return MySplitter.Width; }
            set { MySplitter.Width = value; }
        }

        public Unit Height
        {
            get { return MySplitter.Height; }
            set { MySplitter.Height = value; }
        }

        public Unit Size_P1 { get; set; }

        public Unit Size_P2 { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            Page.PreLoad += Page_PreLoad;

        }

        private void Page_PreLoad(object sender, EventArgs e)
        {
            var c1 = Parent.FindControl(innerPanel1);
            var c2 = Parent.FindControl(innerPanel2);

            MySplitter.Controls.Add(c1);
            MySplitter.Controls.Add(c2);
        }
    }
}