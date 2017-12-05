<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VideoRental.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ImageButton ID="btCustomers" runat="server"  Width="132px" PostBackUrl="Customers.aspx" ImageUrl="~/Image/man.jfif"/>
            <asp:ImageButton ID="btMedia" runat="server" Text="Rent Media" Width="132px" PostBackUrl="RentaMedia.aspx" ImageUrl="~/Image/disc.png" />
            <br />
            <br />
            <asp:ImageButton ID="btAddCustomer" runat="server" Text="New Customer" Width="132px" PostBackUrl="NewCustomer.aspx" ImageUrl="~/Image/newCustomer.png"/>
            <asp:ImageButton ID="btAddMedia" runat="server" Text="New Media" Width="132px" PostBackUrl="NewMedia.aspx" ImageUrl="~/Image/newMeida.jfif" />
        </div>
    </form>
</body>
</html>
