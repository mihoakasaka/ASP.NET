<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PriceQuotation.aspx.cs" Inherits="PriceQuotation.PriceQuotation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 336px">
            <h3>Price quotation</h3>
            <asp:Label ID="Label1" runat="server" Text="Sales price " Width="120"></asp:Label>
            <asp:TextBox ID="tbPrice" runat="server" Width="120" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Discount (%)"  Width="120"></asp:Label>
            <asp:TextBox ID="tbDiscount" runat="server" Width="120"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Discount amount"  Width="120"></asp:Label>
            <asp:Label ID="lbDiscount" runat="server" Width="120"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Total price"  Width="120"></asp:Label>
            <asp:Label ID="lbTotal" runat="server" Width="120"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btCalculate" runat="server" Text="Calculate" OnClick="btCalculate_Click" />
            <br />
            <asp:RangeValidator ID="RVprice" runat="server" ControlToValidate="tbPrice" ErrorMessage="Price must be more than 0" ForeColor="#CC0000" MaximumValue="1000000000000" MinimumValue="0.01" Type="Double"></asp:RangeValidator>
            <br />
            <asp:RangeValidator ID="RVdiscount" runat="server" ControlToValidate="tbDiscount" ErrorMessage="Discount rate must be more than 0 and less than 100" ForeColor="#CC0000" MaximumValue="100" MinimumValue="0" Type="Double"></asp:RangeValidator>
        </div>
    </form>
</body>
</html>
