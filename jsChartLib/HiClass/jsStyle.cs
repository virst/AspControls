using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jsTools
{
    [Serializable]
    public class jsStyle : Dictionary<string, string>
    {
        public override string ToString()
        {
            string s = "";

            foreach (var o in this)
            {
                s += '"' + o.Key + '"' + ':' + '"' + o.Value + "'";
            }

            return s;
        }

        public jsStyle() : base()
        {

        }

        public jsStyle(string s) : base()
        {
            using (Panel p = new Panel())
            {
                p.Style.Value = s;

                foreach (string k in p.Style.Keys)
                {
                    Add(k, p.Style[k]);
                }
            }

        }
    }
}
