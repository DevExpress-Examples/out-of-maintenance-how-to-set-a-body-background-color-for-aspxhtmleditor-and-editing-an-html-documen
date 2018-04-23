using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void ASPxColorEdit1_ValueChanged(object sender, EventArgs e) {
        ASPxHtmlEditor1.Styles.DesignViewArea.BackColor = ASPxColorEdit1.Color;
        ASPxHtmlEditor1.Styles.PreviewArea.BackColor = ASPxHtmlEditor1.Styles.DesignViewArea.BackColor;
    }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        preview.Visible = true;
        preview.Attributes["src"] = "GenerateDocument.aspx";
        Session["color"] = ColorTranslator.ToHtml(ASPxHtmlEditor1.Styles.DesignViewArea.BackColor);       
        Session["html"] = ASPxHtmlEditor1.Html;
    }
}