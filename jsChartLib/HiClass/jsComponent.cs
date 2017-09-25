using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;

namespace jsTools
{
    [Serializable]
    public class jsComponent
    {
        public override string ToString()
        {
            string r = "{";

            var ff = this.GetType().GetFields(BindingFlags.NonPublic |
                                              BindingFlags.Instance).ToList();

            ff.AddRange(this.GetType().GetFields());

            foreach (var d in ff)
            {
                var v = d.GetValue(this);

                if (v == null)
                    continue;

                r += d.Name.TrimStart('_') + " : " + MyToStr(v) + " ,\n";
            }

            r = r.Trim('\n');
            r = r.Trim(',');

            r += "} ";
            return r;

        }

        string MyToStr(object o)
        {
            if (o is string)
                return "'" + o + "'";

            if (o is double)
                return ((double)o).ToString(CultureInfo.CreateSpecificCulture("en-US"));

            if (o is Color)
                return "'" + HexConverter((Color)o) + "'" ;

            if (o is bool)
                return o.ToString().ToLower();

            if (o is IEnumerable)
            {
                string r = "[";

                foreach (var ob in (IEnumerable) o)
                {
                    r += MyToStr(ob) + ",";
                }

                r = r.Trim(',');

                return r + "]";
            }

            return o.ToString();
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }
    }
}