﻿<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeBehind="indexWithMaster.aspx.cs" Inherits="TimeTracker._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPH" runat="server">
    <div>
        <a href="indexWithMaster.aspx?Print=true">Printable Version</a>
            Welcome<br />
            <asp:GridView ID="gvEmployees" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="EmployeeObjDS">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                    <asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:ObjectDataSource ID="EmployeeObjDS" runat="server" SelectMethod="getAllEmployees" TypeName="TimeTracker.Models.TimeTrackerRepository"></asp:ObjectDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="timecardObjDS">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="submissionDate" HeaderText="submissionDate" SortExpression="submissionDate" />
                    <asp:BoundField DataField="MondayHours" HeaderText="MondayHours" SortExpression="MondayHours" />
                    <asp:BoundField DataField="TuesdayHours" HeaderText="TuesdayHours" SortExpression="TuesdayHours" />
                    <asp:BoundField DataField="WednesdayHours" HeaderText="WednesdayHours" SortExpression="WednesdayHours" />
                    <asp:BoundField DataField="ThursdayHours" HeaderText="ThursdayHours" SortExpression="ThursdayHours" />
                    <asp:BoundField DataField="FridayHours" HeaderText="FridayHours" SortExpression="FridayHours" />
                    <asp:BoundField DataField="SaturdayHours" HeaderText="SaturdayHours" SortExpression="SaturdayHours" />
                    <asp:BoundField DataField="SundayHours" HeaderText="SundayHours" SortExpression="SundayHours" />
                    <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" SortExpression="EmployeeId" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="timecardObjDS" runat="server" SelectMethod="getTimeCardsById" TypeName="TimeTracker.Models.TimeTrackerRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gvEmployees" DefaultValue="" Name="empId" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
        </div>
</asp:Content>
