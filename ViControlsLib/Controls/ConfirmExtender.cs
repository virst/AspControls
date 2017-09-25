using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI;
using AjaxControlToolkit;
using System.Drawing;
using System.ComponentModel;

namespace ViControlsLib
{

    [TargetControlType(typeof(Button))]
    [ClientScriptResource("Sys.Extended.UI.Button", "ViControlsLib.jsResources.no.js")]
    public class ConfirmExtender : ExtenderControlBase
    {
        public ConfirmExtender()
        {
            this.Load += new EventHandler(Page_Load);
                      
        }     

        string _MessageText = "Are you sure?";

        public string MessageText { get { return _MessageText; } set { _MessageText = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            var bt = this.TargetControl as Button;
            bt.OnClientClick = "return confirm('" + MessageText + "' )";
        }
    }
}
