using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace ViControlsLib
{
    public class Class1
    {
        public void GetStr(Page p )
        {
            
            p.ClientScript.RegisterClientScriptInclude("FunkyJavaScript",
               p.ClientScript.GetWebResourceUrl(this.GetType(),
                                           "ViControlsLib.jsResources.jquery-1.11.3.js"));

            
        }


    }
}
