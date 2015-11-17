<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WaterParameterForm.aspx.cs" Inherits="Hatchery.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
    <asp:Panel ID="PnlPrimaryKey" runat="server">
        <tr>
            <td>Water Parameter ID:</td>
            <td></td>
            <td colspan="2">
                <asp:TextBox ID="TxtWaterParameterID" runat="server" />
            </td>
        </tr>
    </asp:Panel>
    <tr>
        <td>Module Name:</td>
        <td></td>
        <td colspan="2">
            <asp:DropDownList ID="ModuleDropDownList" runat="server" AutoPostBack="True" DataSourceID="ModuleDataSource" DataTextField="ModuleName" DataValueField="ModuleName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="ModuleDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ModuleName] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td>Production Cycle ID:</td>
        <td></td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ProductionCycleDataSource" DataTextField="ProductionCycleID" DataValueField="ProductionCycleID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="ProductionCycleDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ProductionCycleID] FROM [ProductionCycle] WHERE (([ModuleName] = @ModuleName) AND ([isInProduction] = @isInProduction))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ModuleDropDownList" Name="ModuleName" PropertyName="SelectedValue" Type="String" />
                    <asp:Parameter DefaultValue="True" Name="isInProduction" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Date:</td>
        <td></td>
        <td>
            <telerik:RadDateTimePicker ID="WaterParameterDatePicker" Runat="server">
            </telerik:RadDateTimePicker>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Alkalinty:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtAlkalinty" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvAlkalinty" runat="server" ControlToValidate="TxtAlkalinty" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Temperature:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtTemperature" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvTemperature" runat="server" ControlToValidate="TxtTemperature" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Ph:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtPh" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvPh" runat="server" ControlToValidate="TxtPh" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Nh3:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtNh3" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvNh3" runat="server" ControlToValidate="TxtNh3" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Salinity:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtSalinity" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvSalinity" runat="server" ControlToValidate="TxtSalinity" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Do:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtDo" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="CompvDo" runat="server" ControlToValidate="TxtDo" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" />
        </td>
    </tr>
    <tr>
        <td>Remark:</td>
        <td></td>
        <td colspan="2">
            <asp:TextBox ID="TxtRemark" runat="server" Rows="7" TextMode="MultiLine" />
        </td>
    </tr>
    <tr>
        <td>User ID:</td>
        <td></td>
        <td colspan="2">
            <asp:TextBox ID="TxtUserID" runat="server" MaxLength="0" />
        </td>
    </tr>
    <tr>
        <td colspan="2"></td>
        <td colspan="2">
            <asp:Button ID="BtnAddRecord" runat="server" OnClick="BtnAddRecord_Click" Text="Add Record" />
            <asp:Button ID="BtnUpdateRecord" runat="server" OnClick="BtnUpdateRecord_Click" Text="Update Record" Visible="false" />
            &nbsp;<input id="inpCancel" onclick="window.location = 'default.htm'; return false;" type="button" value="Cancel" /> </td>
    </tr>
</table>
</asp:Content>
