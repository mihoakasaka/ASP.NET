<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationLifeDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnURL" runat="server" OnClick="btnURL_Click" Text="Server Transfer" Width="171px" />
            <br />
            <br />
            <asp:Button ID="btnURL0" runat="server" OnClick="btnURL0_Click" Text="External Link (Tranfer)" Width="171px" />
            <br />
            <br />
            <asp:Button ID="btnExecute" runat="server" OnClick="btnExecute_Click" Text="Server Execute" Width="171px" />
            <br />
            <br />
            <asp:Label ID="lbOutcome" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
