<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLinkASP.aspx.cs" Inherits="WebApplicationLifeDemo.HyperLinkASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="myHL" NavigateUrl="~/SecondWebForm.aspx" runat="server">Go to HyperLinkASP2</asp:HyperLink>
        </div>
        <asp:Button ID="btnChangeURL" runat="server" OnClick="btnChangeURL_Click" Text="Change my URL" Width="139px" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ApplicationVariables.aspx">My Second Link</asp:HyperLink>
        <br />
    </form>
</body>
</html>
