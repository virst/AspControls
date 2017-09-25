using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AjaxControlToolkit;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViControlsLib
{
    [TargetControlType(typeof(GridView))]
    [ClientScriptResource("Sys.Extended.UI.GridView", "ViControlsLib.jsResources.jquery-1.11.3.js")]
    public class GridRowClickExtender : ExtenderControlBase
    {
    

        public string ToolTip { get; set; }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            var gv = this.TargetControl as GridView;
            gv.RowDataBound += Gv_RowDataBound;

        }

        private void Gv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow) // && !e.Row.RowState.HasFlag(DataControlRowState.Selected))
            {
                //каждой строке даём отрибут onclick, чтобы выбрать запись
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(sender as Control, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = this.ToolTip;
            }
        }
    }
}
