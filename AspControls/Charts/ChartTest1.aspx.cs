using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jsChartLib.HiClass.Enums;
using jsTools.Highcharts;

namespace AspControls.Charts
{
    public partial class ChartTest1 : System.Web.UI.Page
    {
        static double R(double v, double min, double max)
        {
            double r = max - min;
            r = r * v;
            r = min + r;
            r = Math.Round(r, 1);
            return r;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //  Highcharts highcharts = new Highcharts();

            jsChart1.highcharts.title = new jsTools.Highcharts.Title();
            jsChart1.highcharts.title.text = "Monthly Average Temperature";
            jsChart1.highcharts.title.x = -20;

            jsChart1.highcharts.credits = new Credits();
            jsChart1.highcharts.credits.enabled = false;

            jsChart1.highcharts.subtitle = new jsTools.Highcharts.Title();
            jsChart1.highcharts.subtitle.text = "Source: WorldClimate.com";
            jsChart1.highcharts.subtitle.x = -20;

            jsChart1.highcharts.xAxis.Add(null);
            jsChart1.highcharts.xAxis[0] = new Axis();
            jsChart1.highcharts.xAxis[0].categories = new List<string>(new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" });

            jsChart1.highcharts.yAxis.Add(null);
            jsChart1.highcharts.yAxis[0] = new Axis();
            jsChart1.highcharts.yAxis[0].title = new ATitle();
            jsChart1.highcharts.yAxis[0].title.text = "Temperature (°C)";
            jsChart1.highcharts.yAxis[0].plotLines.Add(null);
            jsChart1.highcharts.yAxis[0].plotLines[0] = new Plot();
            jsChart1.highcharts.yAxis[0].plotLines[0].value = 0;
            jsChart1.highcharts.yAxis[0].plotLines[0].width = 1;
            jsChart1.highcharts.yAxis[0].plotLines[0].Color = System.Drawing.ColorTranslator.FromHtml("#808080");

            jsChart1.highcharts.tooltip = new Tooltip();
            jsChart1.highcharts.tooltip.valueSuffix = "°C";

            jsChart1.highcharts.legend = new Legend();
            jsChart1.highcharts.legend.layout = jsLayout.vertical;
            jsChart1.highcharts.legend.align = jsAling.right;
            jsChart1.highcharts.legend.verticalAlign = jsVerticalAlign.middle;
            jsChart1.highcharts.legend.borderWidth = 0;

            Random rnd = new Random();

            jsChart1.highcharts.series.Add(null);
            jsChart1.highcharts.series.Add(null);
            jsChart1.highcharts.series.Add(null);
            jsChart1.highcharts.series.Add(null);

            for (int i = 0; i < jsChart1.highcharts.series.Count; i++)
            {
                jsChart1.highcharts.series[i] = new SeriesLine();
                jsChart1.highcharts.series[i].name = "City_" + i;
                jsChart1.highcharts.series[i].data = new double[12];

                for (int j = 0; j < jsChart1.highcharts.series[i].data.Length; j++)
                    ((double[])jsChart1.highcharts.series[i].data)[j] = R(rnd.NextDouble(), 5, 25);
            }
        }
    }
}