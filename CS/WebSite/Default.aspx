<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        BackgroundColor:
        <dx:ASPxColorEdit ID="ASPxColorEdit1" runat="server" ClientInstanceName="ce" AutoPostBack="true"
            OnValueChanged="ASPxColorEdit1_ValueChanged">
        </dx:ASPxColorEdit>
        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server" ClientInstanceName="he">
            <SettingsImageUpload>
                <ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png">
                </ValidationSettings>
            </SettingsImageUpload>
            <SettingsImageSelector>
                <CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
            </SettingsImageSelector>
            <SettingsDocumentSelector>
                <CommonSettings AllowedFileExtensions=".rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp">
                </CommonSettings>
            </SettingsDocumentSelector>
        </dx:ASPxHtmlEditor>
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Generate and Preview Document"
            OnClick="ASPxButton1_Click">
        </dx:ASPxButton>
        <iframe runat="server" id="preview" visible="false" />
    </div>
    </form>
</body>
</html>
