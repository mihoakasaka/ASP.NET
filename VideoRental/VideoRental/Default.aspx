<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VideoRental.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btCustomers" runat="server" Text="Customers" Width="132px" />
            <asp:Button ID="btMedia" runat="server" Text="Rent Media" Width="132px" />
            <br />
            <br />
            <asp:Button ID="btAddCustomer" runat="server" Text="New Customer" Width="132px" />
            <asp:Button ID="btAddMedia" runat="server" Text="New Media" Width="132px" />
        </div>
    </form>
</body>
</html>
