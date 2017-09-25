using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using jsTools.Highcharts;
using System.Web.UI;

namespace jsChartLib
{
    public class jsChart : Panel
    {
        public jsChart()
        {
            this.Width = new Unit("100%");
            this.Height = new Unit("100%");
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            var p = this.Page;

            p.ClientScript.RegisterClientScriptInclude("jquery-1_8_3",
             p.ClientScript.GetWebResourceUrl(this.GetType(),
                                         "jsChartLib.JS.jquery-1.8.3.js"));

            p.ClientScript.RegisterClientScriptInclude("highcharts",
             p.ClientScript.GetWebResourceUrl(this.GetType(),
                                         "jsChartLib.JS.highcharts.js"));
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            ScriptManager.RegisterClientScriptBlock(this.Page, typeof(string), "dfn_" + ID, GetJScod(), true);
        }

        // public Highcharts highcharts { get; set; }

        public Highcharts highcharts
        {
            get
            {
                var rz = ViewState["highcharts"] as Highcharts;
                if (rz == null)
                {
                    rz=new Highcharts();
                    ViewState["highcharts"] = rz;
                }
                return rz;
            }
            set { ViewState["highcharts"] = value; }
        }

        public string GetJScod()
        {
            return @"  
        $(document).ready(function() {
            $('#" + this.ClientID + "').highcharts(" + highcharts.ToString() + @");
        }
		);
   ";
        }
    }
}
