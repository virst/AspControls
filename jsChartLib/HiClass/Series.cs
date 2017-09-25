using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace jsTools.Highcharts
{
    [Serializable]
    public class Series : jsComponent
    {
        public string type = null;
        public double? animationLimit = null;
        public string className = null;
        public string cursor = null;
        public Array data = null;
        public DataLabels dataLabels = null;
        public string description = null;
        public bool? enableMouseTracking = null;
        public SEvent events = null;
        public bool? getExtremesFromAll = null;
        public string id;
        public double? index = null;
        public string keys = null;
        public double? legendIndex = null;
        public string name = null;
        public SEvent podouble = null;
        public bool? selected = null;
        public bool? stickyTracking = null;
        public Tooltip tooltip = null;
        public bool? visible = null;
        public double? zIndex = null;

    }

    [Serializable]
    public class SEvent : jsComponent
    {
        public string afterAnimate = null;
        public string checkboxClick = null;
        public string click = null;
        public string hide = null;
        public string legendItemClick = null;
        public string mouseOut = null;
        public string mouseOver = null;
        public string show = null;
    }

    [Serializable]
    public class SeriesLine : Series
    {
        public SeriesLine()
        {
            type = null;
        }

        public bool? allowPodoubleSelect = null;
        public bool? animation = null;
        public Color? Color = null;
        public bool? connectEnds = null;
        public bool? connectNulls = null;
        public double? cropThreshold = null;
        public string dashStyle = null;
        public DataLabels dataLabels = null;
        public double? lineWidth = null;
        public string linecap = null;
        public string linkedTo = null;
        public Marker marker = null;
        public Color? negativeColor = null;
        public double? podoubledoubleerval = null;
        public double? podoubledoubleervalUnit = null;
        public string podoublePlacement = null;
        public double? podoubleStart = null;
        public bool? shadow = null;
        public bool? showCheckbox = null;
        public bool? showInLegend = null;
        public bool? softThreshold = null;
        public string stack = null;
        public string stacking = null;
        public States states = null;
        public string step = null;
        public double? threshold = null;
        public double? turboThreshold = null;
        public double? xAxis = null;
        public double? yAxis = null;
        public string zoneAxis = null;
        public Zone[] zones = null;

    }

    [Serializable]
    public class DataLabels : jsComponent
    {
        public string align = null;
        public bool? allowOverlap = null;
        public Color? backgroundColor = null;
        public Color? borderColor = null;
        public string className = null;
        public double? borderRadius = null;
        public double? borderWidth = null;
        public Color? Color = null;
        public bool? crop = null;
        public bool? defer = null;
        public bool? enabled = null;
        public string format = null;
        public string formatter = null;
        public string inside = null;
        public string overflow = null;
        public string padding = null;
        public bool? reserveSpace = null;
        public double? rotation = null;
        public bool? shadow = null;
        public string shape = null;
        public string style = null;
        public bool? useHTML = null;
        public string verticalAlign = null;
        public double? x = null;
        public double? y = null;
        public double? zIndex = null;
    }

    [Serializable]
    public class Marker : jsComponent
    {
        public Hover hover = null;
        public Select select = null;
    }

    [Serializable]
    public class States : jsComponent
    {
        public Hover hover = null;
    }

    [Serializable]
    public class Select : jsComponent
    {
        public bool? enabled = null;
        public Color? fillColor = null;
        public Color? lineColor = null;
        public double? lineWidth = null;
        public double? radius = null;
    }

    [Serializable]
    public class Hover : jsComponent
    {
        public bool? enabled = null;
        public Halo halo = null;
        public Color? fillColor = null;
        public Color? lineColor = null;
        public double? lineWidth = null;
        public double? lineWidthPlus = null;
        public Marker marker = null;
        public double? radius = null;
        public double? radiusPlus = null;
    }

    [Serializable]
    public class Halo : jsComponent
    {
        public string attributes = null;
        public double? opacity = null;
        public double? size = null;
    }

    [Serializable]
    public class Zone : jsComponent
    {
        public string className = null;
        public Color? Color = null;
        public string dashStyle = null;
        public Color? fillColor = null;
        public double? value = null;
    }
}
