<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HarvestForm.aspx.cs" Inherits="Hatchery.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <asp:Panel ID="PnlPrimaryKey" runat="server">
            
         <%--   <tr>
                <td>Harvest ID:</td>
                <td></td>
                <td colspan="2">
                    <asp:TextBox ID="TxtHarvestID" runat="server" />
                </td>
            </tr>--%>
        </asp:Panel>
        <tr>
                <td>Module</td>
                <td />
                <td colspan="2">
                    <asp:DropDownList ID="ModulesDDL" runat="server" AutoPostBack="True" DataSourceID="ModulesDataSource" DataTextField="ModuleName" DataValueField="ModuleName"></asp:DropDownList>
                    <asp:SqlDataSource ID="ModulesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ModuleName] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
                </td>
            </tr>
        <tr>
            <td>Production Cycle ID:</td>
            <td></td>
            <td colspan="2">
                
                <asp:DropDownList ID="ProductionCycleDDl" runat="server" DataSourceID="ProductionCycleIDDS" DataTextField="ProductionCycleID" DataValueField="ProductionCycleID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="ProductionCycleIDDS" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ProductionCycleID] FROM [ProductionCycle] WHERE (([ModuleName] = @ModuleName) AND ([isInProduction] = @isInProduction))">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ModulesDDL" Name="ModuleName" PropertyName="SelectedValue" Type="String" />
                        <asp:Parameter DefaultValue="true" Name="isInProduction" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Doc:</td>
            <td></td>
            <td>
                <asp:TextBox ID="TxtDoc" runat="server" />
            </td>
            <td>
                <asp:CompareValidator ID="CompvDoc" runat="server" ControlToValidate="TxtDoc" Display="Dynamic" ErrorMessage="Invalid integer!" Operator="DataTypeCheck" Type="Integer" />
            </td>
        </tr>
        <tr>
            <td>Stage:</td>
            <td></td>
            <td colspan="2">
                <asp:DropDownList ID="StagesDDL" runat="server" DataSourceID="MasterStagesDS" DataTextField="Stage" DataValueField="Stage">
                </asp:DropDownList>
                <asp:SqlDataSource ID="MasterStagesDS" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [Stage] FROM [MasterStages]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Harvested Population:</td>
            <td></td>
            <td>
                <asp:TextBox ID="TxtHarvestedPopulation" runat="server" />
            </td>
            <td>
                <asp:CompareValidator ID="CompvHarvestedPopulation" runat="server" ControlToValidate="TxtHarvestedPopulation" Display="Dynamic" ErrorMessage="Invalid integer!" Operator="DataTypeCheck" Type="Integer" />
            </td>
        </tr>
        <tr>
            <td>Date:</td>
            <td></td>
            <td>
                <asp:TextBox ID="TxtDate" runat="server" />
            </td>
            <td>
                <asp:CompareValidator ID="CompvDate" runat="server" ControlToValidate="TxtDate" Display="Dynamic" ErrorMessage="Invalid date!" Operator="DataTypeCheck" Type="Date" />
            </td>
        </tr>
        <tr>
            <td>Time:</td>
            <td></td>
            <td colspan="2">
                <asp:TextBox ID="TxtTime" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Userid:</td>
            <td></td>
            <td colspan="2">
                <asp:TextBox ID="TxtUserid" runat="server" MaxLength="0" ReadOnly="True" />
            </td>
        </tr>
        <tr>
            <td colspan="2"></td>
            <td colspan="2">
                <asp:Button ID="BtnAddRecord" runat="server" OnClick="BtnAddRecord_Click" Text="Add Record" />
                &nbsp; </td>
        </tr>
    </table>
</asp:Content>
