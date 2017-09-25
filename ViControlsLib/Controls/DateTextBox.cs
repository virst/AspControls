using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace ViControlsLib
{
    public class DateTextBox : TextBox
    {
        MaskedEditExtender m;
        CalendarExtender c;

        public DateTextBox()
        {
            m = new MaskedEditExtender();           

            m.Mask = "99/99/9999";
            m.MaskType = MaskedEditType.Date;
            m.CultureAMPMPlaceholder = "";
            m.CultureCurrencySymbolPlaceholder = "";
            m.CultureDateFormat = "";
            m.CultureDatePlaceholder = "";
            m.CultureDecimalPlaceholder = "";
            m.CultureThousandsPlaceholder = "";
            m.CultureTimePlaceholder = "";
            m.Enabled = true;

            c = new CalendarExtender();
            c.Enabled = true;
            c.Animated = true;
            c.FirstDayOfWeek = FirstDayOfWeek.Monday;
            c.Format = "dd.MM.yyyy";
            

            this.Width = new Unit("100%");         

        }   

         

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.InitComplete += new EventHandler(Page_InitComplete);

           
        }

        void Page_InitComplete(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack)
                return;

            m.ID = this.ID + "meeFiltDate";
            m.TargetControlID = this.ID;
            this.Parent.Controls.Add(m);

            c.ID = this.ID + "CalendarExtender1";
            c.TargetControlID = this.ID;
            this.Parent.Controls.Add(c);
        }

        public DateTime? date
        {
            get
            {
                if (this.Text == "")
                    return null;
                return Convert.ToDateTime(this.Text);
            }
        }
    }
}
