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
    public class FixedHeaderGridExtender : ExtenderControlBase
    {

        Panel Panel1 = new Panel();

        private int hrn = 0;
        private int rn = 0;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.InitComplete += new EventHandler(Page_InitComplete);
            this.Page.PreRender += new EventHandler(Page_PreRender);

            GridView GridView1 = this.TargetControl as GridView;

            GridView1.RowDataBound += new GridViewRowEventHandler(GridView1_RowDataBound);
        }

        void Page_PreRender(object sender, EventArgs e)
        {
            GridView GridView1 = this.TargetControl as GridView;
            if (!this.Page.IsPostBack)

            {
                //  GridView GridView1 = this.TargetControl as GridView;
                int n = GridView1.Parent.Controls.IndexOf(GridView1);
                GridView1.Parent.Controls.AddAt(n, Panel1);

                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
                GridView1.HeaderRow.ID = "trz";
                GridView1.HeaderRow.ClientIDMode = ClientIDMode.AutoID;
                GridView1.BorderWidth = 0;
            }

            var Src = "";


            if (GridView1.Rows.Count == 0)
                return;

            Src = "$( document ).ready(function() { \n";

            for (int i = 0; i < GridView1.HeaderRow.Cells.Count; i++)
            {
                Src += String.Format("   $('#{0}').width( $('#{1}').width() ); \n", GridView1.HeaderRow.Cells[i].ClientID, GridView1.Rows[0].Cells[i].ClientID);

                Src += String.Format("   $('#{1}').width( $('#{0}').width() ); \n", GridView1.HeaderRow.Cells[i].ClientID, GridView1.Rows[0].Cells[i].ClientID);
            }

            Src += String.Format(" var o2 = $('#{0}').offset(); \n", GridView1.ClientID);
            Src += String.Format(" var o1 = $('#{0}').offset(); \n", GridView1.HeaderRow.ClientID);

            Src += String.Format(" $('#{0}').parent().css('left', o2.left); \n", GridView1.HeaderRow.ClientID);

            Src += String.Format(" $('#{0}').height( $('#{1}').height() + 2 );  \n ", Panel1.ClientID,
        GridView1.HeaderRow.ClientID);


            Src += String.Format(" $('#{0}').parent().css('position', 'fixed'); \n", GridView1.HeaderRow.ClientID);
            Src += String.Format(" $('#{0}').parent().css('background-color', 'white'); \n", GridView1.HeaderRow.ClientID);
            Src += String.Format(" $('#{0}').parent().css('top', o1.top ); \n", GridView1.HeaderRow.ClientID);

            Src += "});";

            ScriptManager.RegisterClientScriptBlock(this.Page, typeof(string), "tableH_JS" + GridView1.ID, Src, true);

            //Label1.Text = string.Format("<script> {0}  </script> ", Src);
        }

        void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                hrn++;
                for (int i = 0; i < e.Row.Cells.Count; i++)
                    e.Row.Cells[i].ID = "h_" + hrn + "_" + i;
            }

            if (e.Row.RowType == DataControlRowType.DataRow && rn == 0)
            {
                rn++;
                for (int i = 0; i < e.Row.Cells.Count; i++)
                    e.Row.Cells[i].ID = "r_" + i;
            }

            e.Row.Style["border-width"] = "1px";
            e.Row.Style["border-style"] = "solid";

            for (int i = 0; i < e.Row.Cells.Count; i++)
            {

                e.Row.Cells[i].Style["border-width"] = "1px";
                e.Row.Cells[i].Style["border-style"] = "solid";
            }
        }

        void Page_InitComplete(object sender, EventArgs e)
        {

        }

    }
}
