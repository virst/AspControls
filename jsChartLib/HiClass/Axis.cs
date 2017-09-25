using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using jsChartLib.HiClass.Enums;


namespace jsTools.Highcharts
{

    [Serializable]
    public class Break : jsComponent
    {
        public double? breakSize = null;
        public double? from = null;
        public double? repeat = null;
        public double? to = null;
    }

    [Serializable]
    public class Crosshair : jsComponent
    {
        public string className = null;
        public Color? Color = null;
        public DashStyles dashStyle;
        public bool? snap = null;
        public double? width = null;
        public double? zIndex = null;
    }

    [Serializable]
    public class Evetnts : jsComponent
    {
        public string afterBreaks = null;
        public string afterSetExtremes = null;
        public string podoubleBreak = null;
        public string podoubleInBreak = null;
        public string setExtremes = null;
    }

    [Serializable]
    public class ALabel : jsComponent
    {
        public jsAling align;
        public string autoRotation = null;
        public double? autoRotationLimit = null;
        public double? distance = null;
        public bool? enabled = null;
        public string format = null;
        public string formatter = null;
        public double? maxStaggerLines = null;
        public string overflow = null;
        public double? padding = null;
        public bool? reserveSpace = null;
        public double? rotation = null;
        public string staggerLines = null;
        public string step = null;
        public string style = null;
        public bool? useHTML = null;
        public double? x = null;
        public double? y = null;
        public double? zIndex = null;
    }

    [Serializable]
    public class Axis : jsComponent
    {
        public bool? allowDecimals = null;
        public string alternateGridColor = null;
        protected List<Break> _breaks = null; public List<Break> breaks { set { _breaks = value; } get { if (_breaks == null) _breaks = new List<Break>(); return _breaks; } }
        protected List<string> _categories = null; public List<string> categories { set { _categories = value; } get { if (_categories == null) _categories = new List<string>(); return _categories; } }
        public string ceiling = null;
        public string className = null;
        protected Crosshair _crosshair = null; public Crosshair crosshair { set { _crosshair = value; } get { if (_crosshair == null) _crosshair = new Crosshair(); return _crosshair; } }
        public string dateTimeLabelFormats = null;
        public string description = null;
        public bool? endOnTick = null;
        protected Evetnts _events = null; public Evetnts events { set { _events = value; } get { if (_events == null) _events = new Evetnts(); return _events; } }
        public string floor = null;
        public Color? gridLineColor = null;
        public string gridLineDashStyle = null;
        public double? gridLineWidth = null;
        public double? gridZIndex = null;
        public string id = null;
        protected ALabel _labels = null; public ALabel labels { set { _labels = value; } get { if (_labels == null) _labels = new ALabel(); return _labels; } }
        public Color? lineColor = null;
        public double? lineWidth = null;
        public double? linkedTo = null;
        public double? max = null;
        public double? maxPadding = null;
        public double? maxZoom = null;
        public double? min = null;
        public double? minPadding = null;
        public double? minRange = null;
        public double? mdoubleickdoubleerval = null;
        public Color? minorGridLineColor = null;
        public string minorGridLineDashStyle = null;
        public double? minorGridLineWidth = null;
        public Color? minorTickColor = null;
        public double? minorTickdoubleerval = null;
        public double? minorTickLength = null;
        public string minorTickPosition = null;
        public double? minorTickWidth = null;
        public bool? nameToX = null;
        public double? offset = null;
        public bool? opposite = null;
        protected List<Plot> _plotBands = null; public List<Plot> plotBands { set { _plotBands = value; } get { if (_plotBands == null) _plotBands = new List<Plot>(); return _plotBands; } }
        protected List<Plot> _plotLines = null; public List<Plot> plotLines { set { _plotLines = value; } get { if (_plotLines == null) _plotLines = new List<Plot>(); return _plotLines; } }
        public bool? reversed = null;
        public bool? showEmpty = null;
        public bool? showFirstLabel = null;
        public bool? showLastLabel = null;
        public double? startOfWeek = null;
        public bool? startOnTick = null;
        public double? tickAmount = null;
        public Color? tickColor = null;
        public double? tickdoubleerval = null;
        public double? tickLength = null;
        public double? tickPixeldoubleerval = null;
        public string tickPosition = null;
        public string tickPositioner = null;
        public string tickPositions = null;
        public double? tickWidth = null;
        public string tickmarkPlacement = null;
        protected ATitle _title = null; public ATitle title { set { _title = value; } get { if (_title == null) _title = new ATitle(); return _title; } }
        public string type = null;
        public string units = null;
        public bool? visible = null;
    }

    [Serializable]
    public class ATitle : jsComponent
    {
        public jsAling align;
        public string enabled = null;
        public string margin = null;
        public string offset = null;
        public double? rotation = null;
        public string style = null;
        public string text = null;
        public double? x = null;
        public double? y = null;
    }

    [Serializable]
    public class Plot : jsComponent
    {
        public string className = null;
        public Color? Color = null;
        public DashStyles dashStyle;
        public string events = null;
        public string id = null;
        protected PLabel _label = null; public PLabel label { set { _label = value; } get { if (_label == null) _label = new PLabel(); return _label; } }
        public double? value = null;
        public double? width = null;
        public double? zIndex = null;
    }

    [Serializable]
    public class PLabel : jsComponent
    {
        public jsAling align;
        public string rotation = null;
        public string style = null;
        public string text = null;
        public string textAlign = null;
        public bool? useHTML = null;
        public string verticalAlign = null;
        public double? x = null;
        public double? y;
    }


}
