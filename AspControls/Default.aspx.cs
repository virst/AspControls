using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViControlsLib;

namespace AspControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            new Class1().GetStr(this);

         //   cs.RegisterClientScriptResource(rsType, "ViControlsLib.jquery-1.11.3.js");
        }
    }
}