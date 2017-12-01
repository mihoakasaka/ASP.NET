<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResponseRedirectDemo.aspx.cs" Inherits="WebApplicationLifeDemo.ResponseRedirectDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go to Second Form" />
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value ="">Select One</asp:ListItem>
                <asp:ListItem>HyperLinkASP</asp:ListItem>
                <asp:ListItem>StateVariable</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Name
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Add" />
            <br />
            <br />
            List of Name (you need to enter 5 name to go to our 1 million dollar page)<br />
            <asp:ListBox ID="lboxNames" runat="server"></asp:ListBox>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to the 1 Million Page" PostBackUrl="~/1MillionPrize.aspx" />
            <br />
        </div>
    </form>
</body>
</html>
