<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateVariable.aspx.cs" Inherits="WebApplicationLifeDemo.StateVariable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1">My Counter:</span>
            <asp:TextBox ID="tbCounter" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncerment" runat="server" OnClick="btnIncerment_Click" Text="Icrement Value" />
            <br />
            <br />
            <br />
            My HTML counter
            <input id="Text1" type="text" /><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Test Post back" />
        </div>
    </form>
</body>
</html>
