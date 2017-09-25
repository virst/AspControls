using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jsChartLib.HiClass.Enums;
using jsTools.Highcharts;

namespace AspControls
{
    public partial class ChartTest3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                Button1_Click(null,null); 
        }

        static double R(double v, double min, double max)
        {
            double r = max - min;
            r = r * v;
            r = min + r;
            r = Math.Round(r, 1);
            return r;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            jsChart1.highcharts.credits.enabled = false;

            jsChart1.highcharts.xAxis.Add(new Axis());
            jsChart1.highcharts.series.Add(new Series());

            jsChart1.highcharts.series[0].data = new double[12];
        
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                jsChart1.highcharts.xAxis[0].categories.Add("M_" + i);

                ((double[]) jsChart1.highcharts.series[0].data)[i] = rnd.Next(10, 50);
            }
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            jsChart2.highcharts.credits.enabled = false;

            jsChart2.highcharts.xAxis.Add(new Axis());
            jsChart2.highcharts.series.Add(new Series());

            jsChart2.highcharts.series[0].data = new double[12];

            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                jsChart2.highcharts.xAxis[0].categories.Add("L_" + i);

                ((double[])jsChart2.highcharts.series[0].data)[i] = rnd.Next(150, 161);
            }
        }
    }
}