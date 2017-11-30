<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="Assignment1.CheckOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 44%;
            height: 158px;
        }
        .auto-style2 {
            width: 127px;
        }
        .auto-style3 {
            width: 293px;
        }
        .auto-style4 {
            width: 127px;
            height: 26px;
        }
        .auto-style5 {
            width: 293px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            margin-left: 160px;
        }
        .auto-style8 {
            width: 44%;
            height: 175px;
        }
        .auto-style9 {
            width: 44%;
            height: 203px;
        }
        .auto-style10 {
            width: 44%;
        }
        .auto-style11 {
            width: 127px;
            height: 34px;
        }
        .auto-style12 {
            width: 293px;
            height: 34px;
        }
        .auto-style13 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Check Out Page<br />
            <br />
            <br />
            <br />
            Contact Information<br />
            <table class="auto-style9">
                <tr>
                    <td class="auto-style11">Email Address :</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="tbEmail" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:RegularExpressionValidator ID="REVEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Enter a valid Email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email Re-entry :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbEmail2" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CVEmail" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbEmail2" ErrorMessage="Must match with first email" ForeColor="#CC0000"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">First Name :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbFname" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbLname" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone Number</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbPhone" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="REVPhone" runat="server" ControlToValidate="tbPhone" ErrorMessage="Use this format : XXX-XXX-XXXX" ForeColor="#CC0000"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            Billing Address<br />
            <table class="auto-style8">
                <tr>
                    <td class="auto-style2">&nbsp;Adress:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbAddress" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ControlToValidate="tbAddress" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City&nbsp; :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbCity" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVAddress0" runat="server" ControlToValidate="tbCity" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">State :</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem>NY</asp:ListItem>
                            <asp:ListItem>CA</asp:ListItem>
                            <asp:ListItem>MA</asp:ListItem>
                            <asp:ListItem>OR</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVAddress1" runat="server" ControlToValidate="ddlState" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Zip Code :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbZip" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVAddress2" runat="server" ControlToValidate="tbAddress" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            Shipping Address</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="cbAddress" runat="server" Text="Same as Billing Address" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Adress:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbSAddress" runat="server" Width="265px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">City&nbsp; :</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbSCity" runat="server" Width="265px"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style4">State :</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlSState" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">Zip Code :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbSZip" runat="server" Width="265px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p class="auto-style7">
            <asp:Button ID="btCheckOut" runat="server" OnClick="btCheckOut_Click" Text="Check Out" Width="241px" />
        </p>
        <br />
        <table class="auto-style10">
            <tr>
                <td>Contact :</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbName" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbPhone" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbEmail" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Billing to :</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbAddress" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbCity" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbState" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbZip" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Shipping to :</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSAddress" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSCity" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSState" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbSZip" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
