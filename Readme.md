<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545167/11.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3462)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [GenerateDocument.aspx](./CS/WebSite/GenerateDocument.aspx) (VB: [GenerateDocument.aspx](./VB/WebSite/GenerateDocument.aspx))
* [GenerateDocument.aspx.cs](./CS/WebSite/GenerateDocument.aspx.cs) (VB: [GenerateDocument.aspx.vb](./VB/WebSite/GenerateDocument.aspx.vb))
<!-- default file list end -->
# How to set a body background color for ASPxHtmlEditor and editing an Html document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3462/)**
<!-- run online end -->


<p>Currently, ASPxHtmlEditor does not allow editing the entire HTML document. It operates only on the <body> content. </p><br />
<p>At the same time, you may wish to define a body background color of an editing Html document. As the <style> tag cannot be used inside the <body> content, utilize the following solution:</p><br />
<p>- Put ASPxColorEdit on a page to allow end-users to choose a desired color;</p><p>- Handle the ASPxColorEdit.ValueChanged event to set the HtmlEditor's DesignViewArea and PreviewArea background color. So, end-users may see the exact appearance of an editing Html document;</p><p>- Set the chosen color for the generated document.</p>

<br/>


