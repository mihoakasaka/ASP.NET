<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPagePostingDemo.aspx.cs" Inherits="WebApplicationLifeDemo.CrossPagePostingDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to the 1 Million Page (cross back)" PostBackUrl="~/1MillionPrize.aspx" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Go to 1 Million (Shortcut)" Width="324px" />
            <br />
        </div>
    </form>
</body>
</html>
