<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WaterParameterForm.aspx.cs" Inherits="Hatchery.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
  <%--  <asp:Panel ID="PnlPrimaryKey" runat="server">
        <tr>
            <td>Water Parameter ID:</td>
            <td></td>
            <td colspan="2">
                <asp:TextBox ID="TxtWaterParameterID" runat="server" />
            </td>
        </tr>
    </asp:Panel>--%>
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
            <asp:DropDownList ID="ProductionCycleIDDDL" runat="server" DataSourceID="ProductionCycleDataSource" DataTextField="ProductionCycleID" DataValueField="ProductionCycleID">
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
            <asp:TextBox ID="TxtAlkalinty" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtAlkalinty" ErrorMessage="Required">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompvAlkalinty" runat="server" ControlToValidate="TxtAlkalinty" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>Temperature:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtTemperature" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompvTemperature" runat="server" ControlToValidate="TxtTemperature" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtTemperature" ErrorMessage="Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Ph:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtPh" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompvPh" runat="server" ControlToValidate="TxtPh" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtPh" ErrorMessage="Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Nh3:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtNh3" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompvNh3" runat="server" ControlToValidate="TxtNh3" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtNh3" ErrorMessage="Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
         <tr>
        <td>N:</td>
        <td></td>
        <td>
            <asp:TextBox ID="NTxt" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="NTxt" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="NTxt" ErrorMessage="Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr>
        <td>Algae:</td>
        <td></td>
        <td>
            <asp:TextBox ID="AlgaeTXT" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <%--<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="AlgaeTXT" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="AlgaeTXT" ErrorMessage="Required">*</asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr>
        <td>Salinity:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtSalinity" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompvSalinity" runat="server" ControlToValidate="TxtSalinity" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtSalinity" ErrorMessage="Required">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Do:</td>
        <td></td>
        <td>
            <asp:TextBox ID="TxtDo" runat="server" >0</asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompvDo" runat="server" ControlToValidate="TxtDo" Display="Dynamic" ErrorMessage="Invalid number!" Operator="DataTypeCheck" Type="Double" >*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtDo" ErrorMessage="Required">*</asp:RequiredFieldValidator>
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
            <asp:TextBox ID="TxtUserID" runat="server" MaxLength="0" ReadOnly="True" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
        </td>
        <td colspan="2">
            <asp:Button ID="BtnAddRecord" runat="server" OnClick="BtnAddRecord_Click" Text="Add Record" />
            &nbsp; </td>
    </tr>
</table>
</asp:Content>
