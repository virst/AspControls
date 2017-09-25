using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ViControlsLib
{
    public class DateTimeTextBox : Panel
    {
        Table Table1;
        Label Label1;
        DateTextBox DateTextBox;
        DropDownList ddlH;
        DropDownList ddlM;
        


        public DateTimeTextBox()
        {
            Table1 = new Table();
            Table1.Rows.Add(new TableRow());
            for (int i = 0; i < 5; i++)
                Table1.Rows[0].Cells.Add(new TableCell());

            Label1 = new Label();
            Label1.ID = "Label1";
            Label1.Text = "";
            Table1.Rows[0].Cells[0].Controls.Add(Label1);

            DateTextBox = new DateTextBox();
            DateTextBox.ID = "DateTextBox";
            Table1.Rows[0].Cells[1].Controls.Add(DateTextBox);

            ddlH = new DropDownList();
            ddlH.ID = "ddlH";
            ddlH.Width = new Unit("45px");
            Table1.Rows[0].Cells[2].Controls.Add(ddlH);

            ddlM = new DropDownList();
            ddlM.ID = "ddlM";
            ddlM.Width = new Unit("45px");
            Table1.Rows[0].Cells[4].Controls.Add(ddlM);

            Table1.Rows[0].Cells[3].Text = ":";

            ddlH.Items.Clear();
            for (int i = 0; i < 24; i++)
                ddlH.Items.Add(i.ToString("D2"));

            ddlM.Items.Clear();
            for (int i = 0; i < 60; i += 5)
                ddlM.Items.Add(i.ToString("D2"));

            Table1.Height = new Unit("100%");
            Table1.Width = new Unit("100%");

            this.Width = new Unit("250px");

            this.Controls.Add(Table1);
        }

        public bool AutoPostBack
        {
            get { return DateTextBox.AutoPostBack; }
            set { DateTextBox.AutoPostBack = value; }
        }

        public string LabelText
        {
            get { return Label1.Text; }
            set
            {
                Label1.Text = value;
                Table1.Rows[0].Cells[0].Visible = Label1.Text != "";
            }
        }
        public string Text
        {
            get { return DateTextBox.Text + " " + ddlH.SelectedValue + ":" + ddlM.SelectedValue; }
            set
            {
                try
                {
                    var ss = value.Split(' ');
                    DateTextBox.Text = ss[0];
                    ss = ss[1].Split(':');
                    ddlH.SelectedValue = ss[0].PadLeft(2, '0');
                    var s = ss[1].PadLeft(2, '0');
                    if (s[1] != '0' && s[1] != '5')
                        s = s[0] + "0";
                    ddlM.SelectedValue = s; //ss[1].PadLeft(2, '0');
                }
                catch (Exception)
                {
                    date = DateTime.Now;
                }
            }
        }

        public DateTime date
        {
            get { return Convert.ToDateTime(Text); }
            set { Text = value.ToString("dd.MM.yyyy HH:mm:ss"); }
        }
    }
}
