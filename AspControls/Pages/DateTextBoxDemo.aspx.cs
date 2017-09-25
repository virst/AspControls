using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspControls.Pages
{
    public partial class DateTextBoxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                DateTimeTextBox1.date = DateTime.Now;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          if(DateTextBox1.date != null)
            Label1.Text = "Date - " + DateTextBox1.date.Value.ToLongDateString();

          Label2.Text = "Date time -" + DateTimeTextBox1.date.ToLongDateString() + " " + DateTimeTextBox1.date.ToLongTimeString();
        }
    }
}