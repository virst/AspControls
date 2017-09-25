using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using jsChartLib.HiClass.Enums;

namespace jsTools.Highcharts
{

    /// <summary>
    /// Highcharts is a charting library written in pure JavaScript, offering an easy way of 
    /// adding doubleeractive charts to your web site or web application. Highcharts currently 
    /// supports line, spline, area, areaspline, column, bar, pie, scatter, angular gauges, 
    /// arearange, areasplinerange, columnrange, bubble, box plot, error bars, funnel, 
    /// waterfall and polar chart types.
    /// (http://api.highcharts.com/highcharts/accessibility)
    /// </summary>
    [Serializable]
    public class Highcharts : jsComponent
    {
        protected Accessibility _accessibility = null; public Accessibility accessibility { set { _accessibility = value; } get { if (_accessibility == null) _accessibility = new Accessibility(); return _accessibility; } }
        protected Chart _chart = null; public Chart chart { set { _chart = value; } get { if (_chart == null) _chart = new Chart(); return _chart; } }
        protected List<Color> _colors = null; public List<Color> colors { set { _colors = value; } get { if (_colors == null) _colors = new List<Color>(); return _colors; } }
        // public Color color;
        protected Credits _credits = null; public Credits credits { set { _credits = value; } get { if (_credits == null) _credits = new Credits(); return _credits; } }
        protected Data _data = null; public Data data { set { _data = value; } get { if (_data == null) _data = new Data(); return _data; } }
        public string defs = null;
        protected Drilldown _drilldown = null; public Drilldown drilldown { set { _drilldown = value; } get { if (_drilldown == null) _drilldown = new Drilldown(); return _drilldown; } }
        protected Exporting _exporting = null; public Exporting exporting { set { _exporting = value; } get { if (_exporting == null) _exporting = new Exporting(); return _exporting; } }
        protected Labels _labels = null; public Labels labels { set { _labels = value; } get { if (_labels == null) _labels = new Labels(); return _labels; } }
        protected Legend _legend = null; public Legend legend { set { _legend = value; } get { if (_legend == null) _legend = new Legend(); return _legend; } }
        protected Loading _loading = null; public Loading loading { set { _loading = value; } get { if (_loading == null) _loading = new Loading(); return _loading; } }
        protected Navigation _navigation = null; public Navigation navigation { set { _navigation = value; } get { if (_navigation == null) _navigation = new Navigation(); return _navigation; } }
        protected Nodata _noData = null; public Nodata noData { set { _noData = value; } get { if (_noData == null) _noData = new Nodata(); return _noData; } }
        protected Pane _pane = null; public Pane pane { set { _pane = value; } get { if (_pane == null) _pane = new Pane(); return _pane; } }
        protected Plotoptions _plotOptions = null; public Plotoptions plotOptions { set { _plotOptions = value; } get { if (_plotOptions == null) _plotOptions = new Plotoptions(); return _plotOptions; } }
        protected Responsive _responsive = null; public Responsive responsive { set { _responsive = value; } get { if (_responsive == null) _responsive = new Responsive(); return _responsive; } }
        protected List<Series> _series = null; public List<Series> series { set { _series = value; } get { if (_series == null) _series = new List<Series>(); return _series; } }
        protected Title _subtitle = null; public Title subtitle { set { _subtitle = value; } get { if (_subtitle == null) _subtitle = new Title(); return _subtitle; } }
        protected Title _title = null; public Title title { set { _title = value; } get { if (_title == null) _title = new Title(); return _title; } }
        protected Tooltip _tooltip = null; public Tooltip tooltip { set { _tooltip = value; } get { if (_tooltip == null) _tooltip = new Tooltip(); return _tooltip; } }
        protected List<Axis> _xAxis = null;

        public List<Axis> xAxis
        {
            set { _xAxis = value; }
            get { if (_xAxis == null) _xAxis = new List<Axis>(); return _xAxis; }
        }
        protected List<Axis> _yAxis = null; public List<Axis> yAxis { set { _yAxis = value; } get { if (_yAxis == null) _yAxis = new List<Axis>(); return _yAxis; } }
        protected Axis _zAxis = null; public Axis zAxis { set { _zAxis = value; } get { if (_zAxis == null) _zAxis = new Axis(); return _zAxis; } }

    }

    [Serializable]
    public class Accessibility : jsComponent
    {
        public bool? describeSingleSeries = null;
        public bool? enabled = null;
        protected KeyboardNavigation _keyboardNavigation = null; public KeyboardNavigation keyboardNavigation { set { _keyboardNavigation = value; } get { if (_keyboardNavigation == null) _keyboardNavigation = new KeyboardNavigation(); return _keyboardNavigation; } }
        public string onTableAnchorClick = null;
        public string podoubleDateFormat = null;
        public string podoubleDateFormatter = null;
        public string podoubleDescriptionFormatter = null;
        protected boolDouble _podoubleDescriptionThreshold = null; public boolDouble podoubleDescriptionThreshold { set { _podoubleDescriptionThreshold = value; } get { if (_podoubleDescriptionThreshold == null) _podoubleDescriptionThreshold = 0; return _podoubleDescriptionThreshold; } }
        public string screenReaderSectionFormatter = null;
        public string seriesDescriptionFormatter = null;
    }

    [Serializable]
    public class KeyboardNavigation : jsComponent
    {
        public bool? enabled = null;
        public bool? skipNullPodoubles = null;
    }

    [Serializable]
    public class boolDouble : jsComponent
    {
        object val = null;
        public boolDouble(double? v)
        {
            val = null;
        }

        public boolDouble(bool? v)
        {
            val = null;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        //  User-defined conversion from double to Digit
        public static implicit operator boolDouble(double d)
        {
            return new boolDouble(d);
        }

        public static implicit operator boolDouble(bool d)
        {
            return new boolDouble(d);
        }
    }

    [Serializable]
    public class Chart : jsComponent
    {
        public bool? booldouble = null;
        public bool? animation = null;
        public Color? backgroundColor = null;
        public Color? borderColor = null;
        public double? borderRadius = null;
        public double? borderWidth = null;
        public string className = null;
        public double? colorCount = null;
        public string defaultSeriesType = null;
        public string description = null;
        protected Events _events = null; public Events events { set { _events = value; } get { if (_events == null) _events = new Events(); return _events; } }
        public double? height = null;
        public bool? ignoreHiddenSeries = null;
        public bool? inverted = null;
        public string margin = null;
        public double? marginBottom = null;
        public double? marginLeft = null;
        public double? marginRight = null;
        public double? margdoubleop = null;
        protected Options3d _options3d = null; public Options3d options3d { set { _options3d = value; } get { if (_options3d == null) _options3d = new Options3d(); return _options3d; } }
        public string panKey = null;
        public bool? panning = null;
        public string pinchType = null;
        public Color? plotBackgroundColor = null;
        public string plotBackgroundImage = null;
        public Color? plotBorderColor = null;
        public double? plotBorderWidth = null;
        public bool? plotShadow = null;
        public bool? polar = null;
        public bool? reflow = null;
        public string renderTo = null;
        protected ResetZoomButton _resetZoomButton = null; public ResetZoomButton resetZoomButton { set { _resetZoomButton = value; } get { if (_resetZoomButton == null) _resetZoomButton = new ResetZoomButton(); return _resetZoomButton; } }
        public Color? selectionMarkerFill = null;
        public bool? shadow = null;
        public bool? showAxes = null;
        protected List<double> _spacing = null; public List<double> spacing { set { _spacing = value; } get { if (_spacing == null) _spacing = new List<double>(); return _spacing; } }
        public double? spacingBottom = null;
        public double? spacingLeft = null;
        public double? spacingRight = null;
        public double? spacingTop = null;
        public string style = null;
        public enumPlotOptions type;
        public string typeDescription = null;
        public double? width = null;
        public string zoomType = null;



    }

    [Serializable]
    public class ResetZoomButton : jsComponent
    {
        public string position = null;
        public string relativeTo = null;
        public string theme = null;
    }

    [Serializable]
    public class Options3d : jsComponent
    {
        public double? alpha = null;
        public double? beta = null;
        public double? depth = null;
        public bool? enabled = null;
        public bool? fitToPlot = null;
        protected Frame _frame = null; public Frame frame { set { _frame = value; } get { if (_frame == null) _frame = new Frame(); return _frame; } }
        public double? viewDistance = null;

    }

    [Serializable]
    public class Frame : jsComponent
    {
        public Bnt back;
        public Bnt bottom;
        public Bnt side;
    }

    [Serializable]
    public class Bnt : jsComponent
    {
        public Color? Color = null;
        public double? size = null;
    }

    [Serializable]
    public class Events : jsComponent
    {
        public string addSeries = null;
        public string afterPrdouble = null;
        public string beforePrdouble = null;
        public string click = null;
        public string drilldown = null;
        public string drillup = null;
        public string drillupall = null;
        public string load = null;
        public string redraw = null;
        public string selection = null;

    }

    [Serializable]
    public class Credits : jsComponent
    {
        public bool? enabled = null;
        public string href = null;
        public string position = null;
        public string style = null;
        public string text = null;
    }

    [Serializable]
    public class Data : jsComponent
    {
        protected List<string> _columns = null; public List<string> columns { set { _columns = value; } get { if (_columns == null) _columns = new List<string>(); return _columns; } }
        public string complete = null;
        public string csv = null;
        public string dateFormat = null;
        public string decimalPodouble = null;
        public double? endColumn = null;
        public double? endRow = null;
        public bool? firstRowAsNames = null;
        public string googleSpreadsheetKey = null;
        public string googleSpreadsheetWorksheet = null;
        public string itemDelimiter = null;
        public string lineDelimiter = null;
        public string parseDate = null;
        public string parsed = null;
        protected List<string> _rows = null; public List<string> rows { set { _rows = value; } get { if (_rows == null) _rows = new List<string>(); return _rows; } }
        protected List<string> _seriesMapping = null; public List<string> seriesMapping { set { _seriesMapping = value; } get { if (_seriesMapping == null) _seriesMapping = new List<string>(); return _seriesMapping; } }
        public double? startColumn = null;
        public double? startRow = null;
        public bool? switchRowsAndColumns = null;
        public string table = null;
    }

    [Serializable]
    public class Drilldown : jsComponent
    {
        public string activeAxisLabelStyle = null;
        public string activeDataLabelStyle = null;
        public bool? allowPodoubleDrilldown = null;
        public string animation = null;
        protected DrillUpButton _drillUpButton = null; public DrillUpButton drillUpButton { set { _drillUpButton = value; } get { if (_drillUpButton == null) _drillUpButton = new DrillUpButton(); return _drillUpButton; } }
        protected List<string> _series = null; public List<string> series { set { _series = value; } get { if (_series == null) _series = new List<string>(); return _series; } }
    }

    [Serializable]
    public class DrillUpButton : jsComponent
    {
        public string position = null;
        public string relativeTo = null;
        public string theme = null;
    }

    [Serializable]
    public class Exporting : jsComponent
    {
        public bool? allowHTML = null;
        protected Buttons _buttons = null; public Buttons buttons { set { _buttons = value; } get { if (_buttons == null) _buttons = new Buttons(); return _buttons; } }
        public string chartOptions = null;
        public bool? enabled = null;
        public string error = null;
        public bool? fallbackToExportServer = null;
        public string filename = null;
        public string formAttributes = null;
        public string libURL = null;
        public double? prdoubleMaxWidth = null;
        public double? scale = null;
        public double? sourceHeight = null;
        public double? sourceWidth = null;
        public string type = null;
        public string url = null;
        public double? width = null;
    }

    [Serializable]
    public class Buttons : jsComponent
    {
        protected ContextButton _contextButton = null; public ContextButton contextButton { set { _contextButton = value; } get { if (_contextButton == null) _contextButton = new ContextButton(); return _contextButton; } }
    }

    [Serializable]
    public class ContextButton : jsComponent
    {
        public jsAling align;
        public bool? enabled = null;
        public double? height = null;
        public string menuItems = null;
        public string onclick = null;
        public string symbol = null;
        public Color? symbolFill = null;
        public double? symbolSize = null;
        public Color? symbolStroke = null;
        public double? symbolStrokeWidth = null;
        public double? symbolX = null;
        public double? symbolY = null;
        public string text = null;
        public string theme = null;
        public jsVerticalAlign verticalAlign;
        public double? width = null;
        public double? x = null;
        public double? y = null;
    }

    [Serializable]
    public class Labels : jsComponent
    {
        protected List<Item> _items = null; public List<Item> items { set { _items = value; } get { if (_items == null) _items = new List<Item>(); return _items; } }
        public string style = null;
    }

    [Serializable]
    public class Item : jsComponent
    {
        public string html = null;
        public string style = null;
    }

    [Serializable]
    public class Legend : jsComponent
    {
        public jsAling align;
        public Color? backgroundColor = null;
        public Color? borderColor = null;
        public double? borderRadius = null;
        public double? borderWidth = null;
        public bool? enabled = null;
        public bool? floating = null;
        public double? itemDistance = null;
        public string itemHiddenStyle = null;
        public string itemHoverStyle = null;
        public double? itemMarginBottom = null;
        public double? itemMargdoubleop = null;
        public string itemStyle = null;
        public double? itemWidth = null;
        public string labelFormat = null;
        public string labelFormatter = null;
        public jsLayout layout;
        public double? lineHeight = null;
        public double? margin = null;
        public double? maxHeight = null;
        protected LNavigation _navigation = null; public LNavigation navigation { set { _navigation = value; } get { if (_navigation == null) _navigation = new LNavigation(); return _navigation; } }
        public double? padding = null;
        public bool? reversed = null;
        public bool? rtl = null;
        public bool? shadow = null;
        public string style = null;
        public double? symbolHeight = null;
        public double? symbolPadding = null;
        public double? symbolRadius = null;
        public double? symbolWidth = null;
        protected LTitle _title = null; public LTitle title { set { _title = value; } get { if (_title == null) _title = new LTitle(); return _title; } }
        public bool? useHTML = null;
        public jsVerticalAlign verticalAlign;
        public double? width;
        public double? x = null;
        public double? y = null;
    }

    [Serializable]
    public class LNavigation : jsComponent
    {
        public Color? activeColor = null;
        public bool? animation = null;
        public double? arrowSize = null;
        public bool? enabled = null;
        public Color? inactiveColor = null;
        public string style = null;
    }

    [Serializable]
    public class LTitle : jsComponent
    {
        public string style = null;
        public string text = null;
    }

    [Serializable]
    public class Loading : jsComponent
    {
        public double? hideDuration = null;
        public string labelStyle = null;
        public double? showDuration = null;
        public string style = null;
    }

    [Serializable]
    public class Navigation : jsComponent
    {
        protected ButtonOptions _buttonOptions = null; public ButtonOptions buttonOptions { set { _buttonOptions = value; } get { if (_buttonOptions == null) _buttonOptions = new ButtonOptions(); return _buttonOptions; } }
        public string menuItemHoverStyle = null;
        public string menuItemStyle = null;
        public string menuStyle = null;
    }

    [Serializable]
    public class ButtonOptions : jsComponent
    {
        public jsAling align;
        public bool? enabled = null;
        public double? height = null;
        public Color? symbolFill = null;
        public double? symbolSize = null;
        public Color? symbolStroke = null;
        public double? symbolStrokeWidth = null;
        public double? symbolX = null;
        public double? symbolY = null;
        public string text = null;
        public string theme = null;
        public jsVerticalAlign verticalAlign;
        public double? width = null;
        public double? y = null;
    }

    [Serializable]
    public class Nodata : jsComponent
    {
        public string attr = null;
        public string position = null;
        public string style = null;
        public bool? useHTML = null;
    }

    [Serializable]
    public class Pane : jsComponent
    {
        protected Background _background = null; public Background background { set { _background = value; } get { if (_background == null) _background = new Background(); return _background; } }
        public string center = null;
        public string endAngle = null;
        public string size = null;
        public string startAngle = null;
    }

    [Serializable]
    public class Background : jsComponent
    {
        public Color? backgroundColor = null;
        public Color? borderColor = null;
        public double? borderWidth = null;
        public string className = null;
        public double? innerRadius = null;
        public string outerRadius = null;
        public HiShape shape;
    }

    [Serializable]
    public class Plotoptions : jsComponent
    {
        //!!!
    }

    [Serializable]
    public class Responsive : jsComponent
    {
        protected List<Rules> _rules = null; public List<Rules> rules { set { _rules = value; } get { if (_rules == null) _rules = new List<Rules>(); return _rules; } }
    }

    [Serializable]
    public class Rules : jsComponent
    {
        public string chartOptions = null;
        protected Condition _condition = null; public Condition condition { set { _condition = value; } get { if (_condition == null) _condition = new Condition(); return _condition; } }

    }

    [Serializable]
    public class Condition : jsComponent
    {
        public string callback = null;
        public double? maxHeight = null;
        public double? maxWidth = null;
        public double? minHeight = null;
        public double? minWidth = null;
    }


    [Serializable]
    public class Title : jsComponent
    {
        public jsAling align;
        public bool? floating = null;
        public string style = null;
        public string text = null;
        public bool? useHTML = null;
        public jsVerticalAlign verticalAlign;
        public double? widthAdjust = null;
        public double? x = null;
        public double? y = null;
    }

    [Serializable]
    public class Tooltip : jsComponent
    {
        public bool? animation = null;
        public Color? backgroundColor = null;
        public Color? borderColor = null;
        public double? borderRadius = null;
        public double? borderWidth = null;
        public string crosshairs = null;
        public string dateTimeLabelFormats = null;
        public bool? enabled = null;
        public bool? followPodoubleer = null;
        public bool? followTouchMove = null;
        public string footerFormat = null;
        public string formatter = null;
        public string headerFormat = null;
        public double? hideDelay = null;
        public double? padding = null;
        public string podoubleFormat = null;
        public string podoubleFormatter = null;
        public string positioner = null;
        public bool? shadow = null;
        public string shape = null;
        public bool? shared = null;
        public string snap = null;
        public bool? split = null;
        public string style = null;
        public bool? useHTML = null;
        public string valueDecimals = null;
        public string valuePrefix = null;
        public string valueSuffix = null;
        public string xDateFormat = null;
    }


}
