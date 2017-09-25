using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jsChartLib.HiClass.Enums
{
    public enum enumPlotOptions
    {
        area = -13, // не спрашивай просто так лучше 
        arearange,
        areaspline,
        areasplinerange,
        bar,
        boxplot,
        bubble,
        column,
        columnrange,
        errorbar,
        funnel,
        gauge,
        heatmap,
        line,
        pie,
        polygon,
        pyramid,
        scatter,
        series,
        solidgauge,
        spline,
        treemap,
        waterfall
    };

    public enum jsAling
    {
        left, center, right
    }

    public enum jsLayout
    {
        horizontal, vertical
    }

    public enum jsVerticalAlign
    {
        top, middle, bottom
    }

    public enum HiShape
    {
        solid, arc
    }

    public enum DashStyles
    {
        Solid,
        ShortDash,
        ShortDot,
        ShortDashDot,
        ShortDashDotDot,
        Dot,
        Dash,
        LongDash,
        DashDot,
        LongDashDot,
        LongDashDotDot
    }
}
