<%@ Page 
    Language="C#"
  
    AutoEventWireup="true"
    CodeBehind="Home.aspx.cs"
    Inherits="UsersInformation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 108px;
        }
        .auto-style3 {
            width: 154px;
        }
        .auto-style4 {
            height: 192px;
        }
        .auto-style5 {
            margin-top: 0px;
        }
        .auto-style6 {
            width: 108px;
            height: 26px;
        }
        .auto-style7 {
            width: 154px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="tbName">
         
        <input type="hidden" id="hiddenCountt" value="0" runat="server"/>
        <div class="auto-style4">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">Name</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="RFVName" runat="server" ErrorMessage="Name is a required field." ForeColor="#FF0066" ControlToValidate="tbName" EnableClientScript="False">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CVName" runat="server" ControlToValidate="tbName" ErrorMessage="Name can be only letters." ForeColor="#CC0066" Operator="DataTypeCheck">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of Birth</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbDoB" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVDoB" runat="server" ErrorMessage="Date of Birth is a required field." ForeColor="#FF0066" ControlToValidate="tbDoB">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CVDoB" runat="server" ControlToValidate="tbDoB" ErrorMessage="Invalid Date" ForeColor="#CC0066" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="Email is a required field." ForeColor="#FF0066" ControlToValidate="tbEmail">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REVEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="This is not a valid email." ForeColor="#CC0066" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Province</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlProvince" runat="server" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged">
                            <asp:ListItem Value="">Select one</asp:ListItem>
                         
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>Alberta</asp:ListItem>
                               <asp:ListItem>Other</asp:ListItem>
                            
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RFVProvince" runat="server" ErrorMessage="Province is a required field." ForeColor="#FF0066" ControlToValidate="ddlProvince" EnableClientScript="False">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlCity" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
            </table>
            Result&nbsp;
            <asp:Label ID="lbResult" runat="server"></asp:Label>
            <br />
            <br />
            
            Count&nbsp;
            <asp:Label ID="lbCount" Value="0" runat="server"></asp:Label>
              <br />
            <br />
            <asp:Button ID="btSubmit" runat="server" BackColor="#00CC99" BorderColor="#006600" ForeColor="#003300" Text="Submit" CssClass="auto-style5" OnClick="btSubmit_Click" />
            <br />
            <asp:ListBox ID="lstUsers" runat="server" Width="478px"></asp:ListBox>
            <br />
        </div>
    </form>
</body>
</html>
