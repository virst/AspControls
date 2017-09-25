using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AjaxControlToolkit;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViControlsLib
{
    [TargetControlType(typeof(GridView))]
    [ClientScriptResource("Sys.Extended.UI.GridView", "ViControlsLib.jsResources.jquery-1.11.3.js")]
    class GridViewMultiHeaderExpander : ExtenderControlBase
    {
        private bool _upLevelMergeControl = true;
        public bool UpLevelMergeControl
        {
            get { return _upLevelMergeControl; }
            set { _upLevelMergeControl = value; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            var gr = this.TargetControl as GridView;
            gr.RowDataBound += grdViewProducts_RowDataBound;
            gr.RowCreated += grdViewProducts_RowCreated;

        }

        public string CssClass { get; set; }

        protected void grdViewProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                foreach (TableCell c in e.Row.Cells)
                {
                    c.Visible = false;
                }
            }
        }

        bool NrUp(string[] ss1, string[] ss2, int n, bool up = true)
        {
            if (up)
            {
                for (int i = n; i >= 0; i--)
                    if (ss1[i] != ss2[i])
                        return true;
                return false;
            }
            else
            {
                return ss1[n] != ss2[n];
            }
        }

        protected void grdViewProducts_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header) // If header created
            {
                GridView ProductGrid = (GridView)sender;

                // Creating a Row

                string[][] headerStrings = new string[ProductGrid.Columns.Count][];
                for (int i = 0; i < ProductGrid.Columns.Count; i++)
                {
                    headerStrings[i] = ProductGrid.Columns[i].HeaderText.Split('|');
                }

                int maxLevel = headerStrings.Select(s => s.Length).Concat(new[] { 0 }).Max();  // максимальная высота шапки 

                for (int i = maxLevel; i > 0; i--)
                {
                    var headerRow = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert)
                    {
                        TableSection = TableRowSection.TableHeader
                    };
                    foreach (string[] s in headerStrings)
                    {
                        int n = headerStrings.ToList().IndexOf(s);

                        // if (s.Length >= i && s == headerStrings.FirstOrDefault(t => t.Length >= i && t[i - 1] == s[i - 1]))
                        // if (s.Length >= i && (n == 0 || headerStrings[n - 1].Length < i || s[i - 1] != headerStrings[n - 1][i - 1]))  // только для тех кто являеться первыми в совей серии
                        if (s.Length >= i && (n == 0 || headerStrings[n - 1].Length < i || NrUp(s, headerStrings[n - 1], i - 1, _upLevelMergeControl)))  // только для тех кто являеться первыми в совей серии
                        {

                            int maxLen = s.Length; // максимальная высота текущего элимента
                            int k = 0;  // количество столбцов занимаемое текущим элиментом

                            for (int j = n; j < headerStrings.Length; j++)
                            {
                                //  if (headerStrings[j].Length >= i && headerStrings[j][i - 1] != s[i - 1])
                                //if (headerStrings[j].Length >= i && NrUp(headerStrings[j], s, i - 1, _upLevelMergeControl))
                                if (headerStrings[j].Length < i || NrUp(headerStrings[j], s, i - 1, _upLevelMergeControl))
                                    break;
                                if (maxLen < headerStrings[j].Length)
                                    maxLen = headerStrings[j].Length;
                                k++;
                            }

                            var HeaderCell = new TableCell();

                            HeaderCell.Text = s[i - 1];
                            HeaderCell.HorizontalAlign = HorizontalAlign.Center;
                            HeaderCell.RowSpan = maxLevel - /*s.Length*/ maxLen + 1;
                            HeaderCell.ColumnSpan = k;// headerStrings.Count(t => t.Length >= i && t[i - 1] == s[i - 1]);
                            HeaderCell.CssClass = this.CssClass;
                            HeaderCell.Font.Bold = true;
                            headerRow.Cells.Add(HeaderCell);

                        }
                    }
                    ProductGrid.Controls[0].Controls.AddAt(0, headerRow);
                }
            }
        }
    }
}
