<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductionCycle.aspx.cs" Inherits="Hatchery.WebForm5" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 241px;
        }
        .auto-style3 {
            height: 23px;
            width: 241px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Modules</td>
            <td>
                <asp:DropDownList ID="ModuleDropDownList" runat="server" DataSourceID="ModuleDatasource" DataTextField="ModuleName" DataValueField="ModuleName">
                </asp:DropDownList>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Start Date</td>
            <td class="auto-style1">
                <telerik:RadDatePicker ID="StartDateDatePicker" Runat="server">
                </telerik:RadDatePicker>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style2">Nauplii</td>
            <td>
                <telerik:RadNumericTextBox ID="NaupliiTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Batch Number</td>
            <td>
                <asp:DropDownList ID="BatchNumberDropdown" runat="server" DataSourceID="BatchDatasource" DataTextField="BatchNumber" DataValueField="BatchNumber">
                </asp:DropDownList>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">User ID</td>
            <td>
                <asp:Label ID="UserIDLabel" runat="server" Text="Label"></asp:Label>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
                
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:SqlDataSource ID="ModuleDatasource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT DISTINCT [ModuleName], [ModuleID] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="BatchDatasource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
<br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" DeleteCommand="DELETE FROM [ProductionCycle] WHERE [ProductionCycleID] = @ProductionCycleID" InsertCommand="INSERT INTO [ProductionCycle] ([ModuleName], [StartDate], [Nauplii], [Batch], [isInProduction], [EndDate], [UserID]) VALUES (@ModuleName, @StartDate, @Nauplii, @Batch, @isInProduction, @EndDate, @UserID)" SelectCommand="SELECT * FROM [ProductionCycle]" UpdateCommand="UPDATE [ProductionCycle] SET [ModuleName] = @ModuleName, [StartDate] = @StartDate, [Nauplii] = @Nauplii, [Batch] = @Batch, [isInProduction] = @isInProduction, [EndDate] = @EndDate, [UserID] = @UserID WHERE [ProductionCycleID] = @ProductionCycleID">
    <DeleteParameters>
        <asp:Parameter Name="ProductionCycleID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ModuleName" Type="String" />
        <asp:Parameter DbType="Date" Name="StartDate" />
        <asp:Parameter Name="Nauplii" Type="Double" />
        <asp:Parameter Name="Batch" Type="Int32" />
        <asp:Parameter Name="isInProduction" Type="Boolean" />
        <asp:Parameter DbType="Date" Name="EndDate" />
        <asp:Parameter Name="UserID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ModuleName" Type="String" />
        <asp:Parameter DbType="Date" Name="StartDate" />
        <asp:Parameter Name="Nauplii" Type="Double" />
        <asp:Parameter Name="Batch" Type="Int32" />
        <asp:Parameter Name="isInProduction" Type="Boolean" />
        <asp:Parameter DbType="Date" Name="EndDate" />
        <asp:Parameter Name="UserID" Type="String" />
        <asp:Parameter Name="ProductionCycleID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
