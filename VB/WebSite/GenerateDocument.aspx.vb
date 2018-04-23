Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class GenerateDocument
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Session("color") IsNot Nothing Then
			body1.Style.Add(HtmlTextWriterStyle.BackgroundColor, Session("color").ToString())
			body1.InnerHtml = Session("html").ToString()
		End If
	End Sub
End Class