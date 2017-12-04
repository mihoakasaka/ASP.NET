<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="VideoRental.NewMedia" %>

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
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Title :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbTitle" runat="server" Width="115px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Type</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbType" runat="server" Width="115px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Producted Year</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbYear" runat="server" Width="115px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CVYear" runat="server" ControlToValidate="tbYear" ErrorMessage="Producted year is invalid" ForeColor="#CC0000" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="97px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
