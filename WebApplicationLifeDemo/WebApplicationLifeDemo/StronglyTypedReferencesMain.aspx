<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronglyTypedReferencesMain.aspx.cs" Inherits="WebApplicationLifeDemo.StronglyTypedReferencesMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Name:
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnURL" runat="server" OnClick="btnURL_Click" Text="Server Transfer" Width="171px" />
            </p>
        <div>
        </div>
    </form>
</body>
</html>