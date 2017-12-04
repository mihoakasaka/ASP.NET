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
            <asp:GridView ID="lstResult" runat="server" AutoGenerateColumns="False" DataSourceID="MediasObjDS">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                    <asp:BoundField DataField="ProducedYear" HeaderText="ProducedYear" SortExpression="ProducedYear" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="MediasObjDS" runat="server" SelectMethod="GetMediaByTitle" TypeName="VideoRental.Models.VideoRentalRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tbSearch" Name="title" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
