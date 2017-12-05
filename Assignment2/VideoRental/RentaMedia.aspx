<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaMedia.aspx.cs" Inherits="VideoRental.RentaMedia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" />
            <br />
            <br />
            <asp:ObjectDataSource ID="MediasObjDS" runat="server" SelectMethod="GetMediaByTitle" TypeName="VideoRental.Models.VideoRentalRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tbSearch" Name="title" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="MediasObjDS" DataTextField="Title" DataValueField="ID">
        </asp:CheckBoxList>
    </form>
</body>
</html>
