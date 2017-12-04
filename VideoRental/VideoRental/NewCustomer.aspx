<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="VideoRental.NewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 138px;
        }
        .auto-style3 {
            width: 258px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">First name :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbFName" runat="server" Width="115px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CVFname" runat="server" ControlToValidate="tbFName" ErrorMessage="Enter your first name" ForeColor="#CC0000" Operator="DataTypeCheck">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbLName" runat="server" Width="115px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CVLastname" runat="server" ControlToValidate="tbLName" ErrorMessage="Enter your last name" ForeColor="#CC0000" Operator="DataTypeCheck">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbAddress" runat="server" Width="115px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CVFname0" runat="server" ControlToValidate="tbAddress" ErrorMessage="Enter your address" ForeColor="#CC0000" Operator="DataTypeCheck">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone number</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbPhone" runat="server" Width="115px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CVPhone" runat="server" ControlToValidate="tbPhone" ErrorMessage="Enter your Phone" ForeColor="#CC0000" Operator="DataTypeCheck">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="97px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <br />
        </div>
    </form>
</body>
</html>
