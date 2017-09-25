using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ViControlsLib
{
    public class PanelSplitter : Panel
    {
        #region Templates

        [TemplateContainer(typeof(MyTemplateContainer))]
        [TemplateInstance(TemplateInstance.Single)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ITemplate ContentTemplate1 { get; set; }

        [TemplateContainer(typeof(MyTemplateContainer))]
        [TemplateInstance(TemplateInstance.Single)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ITemplate ContentTemplate2 { get; set; }
        #endregion

        private Panel p1, p2;

        public Unit Size_P1 { get; set; }

        public Unit Size_P2 { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            //  base.OnInit(e);

            #region init_Components

            this.Page.InitComplete += Page_InitComplete;

            p1 = new Panel();
            p1.ClientIDMode = ClientIDMode.AutoID;
            p1.ID = this.ID + "_p1";


            if (this.ContentTemplate1 != null)
            {
                var container = new MyTemplateContainer();

                this.ContentTemplate1.InstantiateIn(container);
                p1.Controls.Add(container);
            }

            p2 = new Panel();
            p2.ID = this.ID + "_p1";
            p2.ClientIDMode = ClientIDMode.AutoID;

            if (this.ContentTemplate2 != null)
            {
                var container = new MyTemplateContainer();

                this.ContentTemplate2.InstantiateIn(container);
                p2.Controls.Add(container);
            }
            #endregion

            #region Registr Head


            var p = this.Page;

            p.ClientScript.RegisterClientScriptInclude("jquery-1_11_3",
                p.ClientScript.GetWebResourceUrl(this.GetType(),
                    "ViControlsLib.jsResources.jquery-1.11.3.js"));


            if (this.Page.Header != null)
            {
                if (!this.Page.ClientScript.IsClientScriptBlockRegistered("jqx_base_css"))
                {
                    var link = new HtmlLink();

                    link.Href = this.Page.ClientScript.GetWebResourceUrl(
                        this.GetType(),
                        "ViControlsLib.cssResources.jqx.base.css"
                    );
                    link.Attributes.Add("rel", "stylesheet");
                    link.Attributes.Add("type", "text/css");

                    this.Page.Header.Controls.Add(link);
                    this.Page.ClientScript.RegisterClientScriptBlock(
                        typeof(Page),
                        "jqx_base_css",
                        string.Empty
                    );
                }
            }

            #endregion


        }

        private void Page_InitComplete(object sender, EventArgs e)
        {
            Page.Controls.Add(p1);
            Page.Controls.Add(p2);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            ScriptManager.RegisterClientScriptBlock(this.Page, typeof(string), "Rdf_" + this.ID, GetJScod(), true);
        }

        private string GetJScod()
        {
            Panel MySplitter = this;

            string str = "<script type=\"text/javascript\">\n" +
            "    $(document).ready(function () {\n" +
            "        $('#" + MySplitter.ClientID + "').jqxSplitter({ width: '" + MySplitter.Width.ToString() + "', height: '" + MySplitter.Height.ToString() + "',\n" +
            "            panels: [{ size: '" + Size_P1.ToString() + "' },\n" +
            "                { size: '" + Size_P2.ToString() + "'}]\n" +
            "        });\n" +
            "    });\n" +
            "</script>";


            return str;
        }
    }

    internal class MyTemplateContainer : Control, INamingContainer { }
}
