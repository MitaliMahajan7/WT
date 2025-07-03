Assignment No .: 12
Assignment Name - Write a program in ASP.net using drop down list.
ASP code-
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>DropDownList Example</title>
</head>
<body>
<form id="form1" runat="server">
<div style="margin: 30px;">
<h2>Select a Country:</h2>
<asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
<asp:ListItem Text="--Select Country--" Value="" />
<asp:ListItem Text="India" Value="India" />
<asp:ListItem Text="USA" Value="USA" />
<asp:ListItem Text="Canada" Value="Canada" />
<asp:ListItem Text="Australia" Value="Australia" />
</asp:DropDownList>

<br /><br />

<asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Blue" />
</div>
</form>
</body>
</html>

C# code -
using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // No need to add anything here for this example
    }

    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedCountry = ddlCountry.SelectedValue;

        if (!string.IsNullOrEmpty(selectedCountry))
        {
            lblMessage.Text = "You selected: " + selectedCountry;
        }
        else
        {
            lblMessage.Text = "Please select a country.";
        }
    }
}
