<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exam1.WebForm1" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="Header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 66%;
            height: 458px;
        }
        .auto-style2 {
            width: 406px;
        }
        .auto-style4 {
            width: 600px;
        }
        .auto-style5 {
            width: 406px;
            height: 42px;
        }
        .auto-style7 {
            width: 600px;
            height: 42px;
        }
        .auto-style8 {
            width: 406px;
            height: 36px;
        }
        .auto-style10 {
            width: 600px;
            height: 36px;
        }
        .auto-style11 {
            width: 523px;
        }
        .auto-style12 {
            width: 523px;
            height: 36px;
        }
        .auto-style13 {
            width: 523px;
            height: 42px;
        }
        .auto-style14 {
            width: 751px;
            height: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>  
            <uc1:Header ID="Header1" runat="server" />
            <br />
            <br />
        </div>
        <table class="auto-style14">
            <tr>
                <td class="auto-style2">Student Name</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbName" runat="server" Width="118px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVName" runat="server" ErrorMessage="Student Name is required" ControlToValidate="tbName" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ErrorMessage="Email is required" ControlToValidate="tbEmail" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REVEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Invalid Email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Email</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbEmail2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVEmail2" runat="server" ErrorMessage="Confirm Email is required" ControlToValidate="tbEmail2" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CVemail" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbEmail2" ErrorMessage="Confirm email must match with first Email" ForeColor="#CC0000">*</asp:CompareValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Date of birth</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbDoB" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVDoB" runat="server" ErrorMessage="Date of birth is required" ControlToValidate="tbDoB" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CVDoB" runat="server" ControlToValidate="tbDoB" ErrorMessage="Invalid Date" ForeColor="#CC0000" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Class</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlClass" runat="server" AppendDataBoundItems="True" Height="17px" Width="129px">
                        <asp:ListItem Value="" Text="Select class"></asp:ListItem>
                        <asp:ListItem>Freshman</asp:ListItem>
                        <asp:ListItem>Sophomore</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RFVClass" runat="server" ErrorMessage="Class is required" ControlToValidate="ddlClass" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Final Grade</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbGrade" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVGrade" runat="server" ErrorMessage="Final grade is required" ControlToValidate="tbGrade" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RVGrade" runat="server" ControlToValidate="tbGrade" ErrorMessage="Grade must be between 0 and 100" ForeColor="#CC0000" MaximumValue="100" MinimumValue="0" Type="Double">*</asp:RangeValidator>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Alerts</td>
                <td class="auto-style11">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">Student Information</td>
                <td class="auto-style4">Grade</td>
            </tr>
            <tr>
                <td class="auto-style2">Student Details</td>
                <td class="auto-style11">
                    <asp:ListBox ID="lstStudents" runat="server" Width="376px"></asp:ListBox>
                </td>
                <td class="auto-style4">
                    <asp:ListBox ID="lstGrades" runat="server" Width="114px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style12">
                    <asp:Button ID="btAdd" runat="server" OnClick="btAdd_Click" Text="Add Student &amp; Calculate Average" Width="206px" />
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style5">Class Average</td>
                <td class="auto-style13">
                    <asp:Label ID="lbAverage" runat="server"></asp:Label>
                </td>
                <td class="auto-style7"></td>
            </tr>
        </table>
    </form>
</body>
</html>
