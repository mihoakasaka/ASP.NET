<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionVariables.aspx.cs" Inherits="WebApplicationLifeDemo.SessionVariables" %>

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
        </div>
    </form>
</body>
</html>
