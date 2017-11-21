<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvestmentCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 370px">
            <table>
                <tr>
                    <td> <asp:Label ID="Label1" runat="server" Text="Monthly investment"></asp:Label></td>
                    <td> <asp:DropDownList ID="ddlinvestment" runat="server" >
              
            </asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td>  <asp:Label ID="Label2" runat="server" Text="Annual interest rate"></asp:Label></td>
                    <td>  <asp:TextBox ID="tbRate" runat="server" Width="101px"></asp:TextBox></td>

                </tr>
                <tr>
                    <td> <asp:Label ID="Label3" runat="server" Text="Number of years"></asp:Label></td>
                    <td>  <asp:TextBox ID="tbYears" runat="server" Width="99px" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Future Value : "></asp:Label></td>
                    <td> <asp:Label ID="lbValue" runat="server"></asp:Label></td>

                </tr>
                 <tr>
                    <td><asp:Button ID="btCalculate" runat="server" OnClick="btCalculate_Click" Text="Calculate" /></td>
                    <td> <asp:Button ID="btReset" runat="server" OnClick="btReset_Click" Text="Reset" /></td>

                </tr>
           
                 
</table>
                
    
            <asp:RangeValidator ID="RVInterest" runat="server" ControlToValidate="tbRate" ErrorMessage="Interest rate must be between 1.0 and 20.0" ForeColor="#CC0000" Type="Double"></asp:RangeValidator>
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RFVInterest" runat="server" ControlToValidate="tbRate" ErrorMessage="Interest rate is required." ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
                
    
        </div>
    </form>
</body>
</html>
