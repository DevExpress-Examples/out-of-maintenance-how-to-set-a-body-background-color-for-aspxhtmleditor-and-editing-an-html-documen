Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Drawing

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxColorEdit1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxHtmlEditor1.Styles.DesignViewArea.BackColor = ASPxColorEdit1.Color
		ASPxHtmlEditor1.Styles.PreviewArea.BackColor = ASPxHtmlEditor1.Styles.DesignViewArea.BackColor
	End Sub
	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		preview.Visible = True
		preview.Attributes("src") = "GenerateDocument.aspx"
		Session("color") = ColorTranslator.ToHtml(ASPxHtmlEditor1.Styles.DesignViewArea.BackColor)
		Session("html") = ASPxHtmlEditor1.Html
	End Sub
End Class