using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jsChartLib.HiClass.Enums;
using jsTools.Highcharts;

namespace AspControls.Charts
{
    public partial class ChartTest4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            jsChart1.highcharts.chart = new Chart();
            jsChart1.highcharts.chart.type = enumPlotOptions.column;

            jsChart1.highcharts.title = new Title { text = "Заголовк 1" };

            jsChart1.highcharts.subtitle = new Title { text = "Заголовок 2" };

            jsChart1.highcharts.xAxis.Add(null);
            jsChart1.highcharts.xAxis[0] = new Axis
            {
                type = "category",
                labels = new ALabel { rotation = -45 }
            };
            // jsChart1.highcharts.xAxis[0].labels.st

            jsChart1.highcharts.yAxis.Add(null);
            jsChart1.highcharts.yAxis[0] = new Axis
            {
                min = 0,
                title = new ATitle { text = "Проишествия(шт)" }
            };

            jsChart1.highcharts.legend = new Legend { enabled = false };

            jsChart1.highcharts.tooltip = new Tooltip { podoubleFormat = "Проишествия за период : <b>{point.y:.1f} </b>" };

            jsChart1.highcharts.series.Add(null);
            jsChart1.highcharts.series[0] = new Series
            {
                name = "Что то ",
                dataLabels = new DataLabels
                {
                    enabled = true,
                    rotation = 0,
                    Color = Color.White,
                    align = "right",
                    format = "{point.y}",
                    y = 20
                }
            };

            object[][] objs = new object[7][];

            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                objs[i] = new object[2];
                objs[i][0] = "НГДУ_" + i;
                objs[i][1] = rnd.Next(2, 7);
            }

            jsChart1.highcharts.series[0].data = objs;
        }
    }
}