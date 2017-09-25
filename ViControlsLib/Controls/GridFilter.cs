using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AjaxControlToolkit;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Globalization;


namespace ViControlsLib
{

    public class GridFilter : Panel
    {
        HiddenField HiddenField1;
        Label Label1;
        RadComboBox RadComboBox1;

        public GridFilter()
        {
            HiddenField HiddenField1 = new HiddenField();
            HiddenField1.ID = "HiddenField1";
            Label Label1 = new Label();
            Label1.ID = "Label1";
            RadComboBox RadComboBox1 = new RadComboBox();
            RadComboBox1.ID = "RadComboBox1";

            RadComboBox1.RenderMode = RenderMode.Lightweight;
            RadComboBox1.CheckBoxes = true;
            RadComboBox1.EnableCheckAllItemsCheckBox = true;
            RadComboBox1.Culture = new CultureInfo("ru-RU");

            RadComboBox1.Localization.CheckAllString = "Все";
            RadComboBox1.Localization.AllItemsCheckedString = "Все выбрано";
            RadComboBox1.Localization.ItemsCheckedString = "Выбрано";


            Table tb = new Table();
            this.Controls.Add(tb);

            tb.Width = new Unit("100%");
            RadComboBox1.Width = new Unit("100%");

            this.Width = new Unit("150px");

            tb.Rows.Add(new TableRow());
            tb.Rows[0].Cells.Add(new TableCell());
            tb.Rows[0].Cells[0].Controls.Add(HiddenField1);
            tb.Rows[0].Cells[0].Controls.Add(Label1);

            tb.Rows.Add(new TableRow());
            tb.Rows[1].Cells.Add(new TableCell());
            tb.Rows[1].Cells[0].Controls.Add(RadComboBox1);
        }


        public bool AutoPostBack
        {
            get { return RadComboBox1.AutoPostBack; }
            set { RadComboBox1.AutoPostBack = value; }
        }

        public string FieldName { get; set; }

        public string Label
        {
            get { return Label1.Text; }
            set { Label1.Text = value; }
        }

        public string GridViewID { get; set; }

        private GridView gv;

        private int rn
        {
            get { return HiddenField1.Value.ConvertItTo<int>(); }
            set { HiddenField1.Value = value.ToString(); }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            gv.DataBound += Gr_DataBound;

            this.Page.Load += new EventHandler(Page_Load);
            this.Page.PreRender += new EventHandler(Page_PreRender);

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (gv != null)
            {
                foreach (GridViewRow r in gv.Rows)
                {
                    r.Visible = true;
                }

            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var ss = new List<string>();

            foreach (RadComboBoxItem i in RadComboBox1.Items)
            {
                if (i.Checked)
                    ss.Add(i.Text);
            }


            foreach (GridViewRow r in gv.Rows)
            {
                if (r.Visible)
                    r.Visible = r.Cells[rn].Text.In(ss.ToArray());
            }
        }


        private void Gr_DataBound(object sender, EventArgs e)
        {


            for (int index = 0; index < gv.Columns.Count; index++)
            {
                BoundField o = gv.Columns[index] as BoundField;
                if (o != null && string.Equals(o.DataField, FieldName, StringComparison.CurrentCultureIgnoreCase))
                    rn = index;

            }

            var ss = (from GridViewRow o in gv.Rows select o.Cells[rn].Text).ToList();
            ss = ss.Distinct().ToList();

            List<RadComboBoxItem> remList = new List<RadComboBoxItem>();

            foreach (RadComboBoxItem o in RadComboBox1.Items)
            {
                if (!o.Text.In(ss.ToArray()))
                    remList.Add(o);// RadComboBox1.Items.Remove(o);
                else
                    ss.Remove(o.Text);
            }

            foreach (RadComboBoxItem o in remList)
            {
                RadComboBox1.Items.Remove(o);
            }

            foreach (string s in ss)
            {
                RadComboBoxItem r = new RadComboBoxItem { Text = s, Checked = true };
                RadComboBox1.Items.Add(r);
            }
        }
    }
}
