<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PLMonitor.aspx.cs" Inherits="Hatchery.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 28px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <table>
	      <%--  <asp:Panel ID="PnlPrimaryKey" runat="server">
	        <tr>
		        <td>Mid:</td>
                <td></td>
		        <td colspan="2"><asp:TextBox ID="TxtMid" runat="server" /></td>
	        </tr>
	        </asp:Panel>--%>
	        <tr>
		        <td class="auto-style1">Module Name:</td>
                <td class="auto-style1"></td>
		        <td colspan="2" class="auto-style1"><asp:DropDownList ID="DdlModuleName" runat="server" DataSourceID="ModuleSqlDataSource" DataTextField="ModuleName" DataValueField="ModuleName" AutoPostBack="True" OnSelectedIndexChanged="DdlModuleName_SelectedIndexChanged"><asp:ListItem Value="">Select One</asp:ListItem></asp:DropDownList>
                </td>
	        </tr>
	        <tr>
		        <td>Production Cycle ID:</td>
                <td></td>
		        <td colspan="2"><asp:DropDownList ID="DdlProductionCycleID" runat="server" DataSourceID="ProductionCycleDataSource" DataTextField="ProductionCycleID" DataValueField="ProductionCycleID" AutoPostBack="True" OnSelectedIndexChanged="DdlProductionCycleID_SelectedIndexChanged"><asp:ListItem Value="">Select One</asp:ListItem></asp:DropDownList>
                    <asp:DropDownList ID="StartDateDDL" runat="server" AutoPostBack="True" DataSourceID="ProductionCycleDataSource" DataTextField="StartDate" DataValueField="StartDate" OnDataBound="StartDateDDL_DataBound" OnSelectedIndexChanged="StartDateDDL_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="ProductionCycleDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT * FROM [ProductionCycle] WHERE (([ModuleName] = @ModuleName) AND ([isInProduction] = @isInProduction))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DdlModuleName" Name="ModuleName" PropertyName="SelectedValue" Type="String" />
                            <asp:Parameter DefaultValue="True" Name="isInProduction" Type="Boolean" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
	        </tr>
	        <tr>
		        <td>Date:</td>
                <td></td>
		        <td>
                    <telerik:RadDatePicker ID="DatePicker" Runat="server" AutoPostBack="True" Culture="en-US" OnSelectedDateChanged="DatePicker_SelectedDateChanged">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;"></Calendar>

<DateInput DisplayDateFormat="M/d/yyyy" DateFormat="M/d/yyyy" LabelWidth="40%" AutoPostBack="True">
<EmptyMessageStyle Resize="None"></EmptyMessageStyle>

<ReadOnlyStyle Resize="None"></ReadOnlyStyle>

<FocusedStyle Resize="None"></FocusedStyle>

<DisabledStyle Resize="None"></DisabledStyle>

<InvalidStyle Resize="None"></InvalidStyle>

<HoveredStyle Resize="None"></HoveredStyle>

<EnabledStyle Resize="None"></EnabledStyle>
</DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
		        <td style="width: 156px">&nbsp;</td>
	        </tr>
	        <tr>
		        <td>Doc:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtDoc" runat="server" /></td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvDoc" ControlToValidate="TxtDoc" ErrorMessage="Invalid integer!" Display="Dynamic" Operator="DataTypeCheck" Type="Integer" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Stage:</td>
                <td></td>
		        <td colspan="2">
                    <asp:DropDownList ID="StageDDL" runat="server" DataSourceID="MasterStagesDataSource" DataTextField="Stage" DataValueField="Stage">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="MasterStagesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [Stage] FROM [MasterStages]"></asp:SqlDataSource>
                </td>
	        </tr>
	        <tr>
		        <td>Population:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtPopulation" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvPopulation" ControlToValidate="TxtPopulation" ErrorMessage="Invalid integer!" Display="Dynamic" Operator="DataTypeCheck" Type="Integer" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Bios Z:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtBiosZ" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvBiosZ" ControlToValidate="TxtBiosZ" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Bios M:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtBiosM" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvBiosM" ControlToValidate="TxtBiosM" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Bios100:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtBios100" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvBios100" ControlToValidate="TxtBios100" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Bios150:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtBios150" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvBios150" ControlToValidate="TxtBios150" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Lanzy PL:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtLanzyPL" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvLanzyPL" ControlToValidate="TxtLanzyPL" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Lanzy MP L:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtLanzyMPL" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvLanzyMPL" ControlToValidate="TxtLanzyMPL" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Lanzy ZM:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtLanzyZM" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvLanzyZM" ControlToValidate="TxtLanzyZM" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mpz:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtMpz" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMpz" ControlToValidate="TxtMpz" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mp1:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtMp1" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMp1" ControlToValidate="TxtMp1" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mp2:</td>
    
                <td></td>
		        <td><asp:TextBox ID="TxtMp2" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMp2" ControlToValidate="TxtMp2" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mp3:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtMp3" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMp3" ControlToValidate="TxtMp3" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mpl:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtMpl" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMpl" ControlToValidate="TxtMpl" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Spirulina:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtSpirulina" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvSpirulina" ControlToValidate="TxtSpirulina" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Lhf:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtLhf" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvLhf" ControlToValidate="TxtLhf" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Roysf100 200:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtRoySF100_200" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvRoySF100_200" ControlToValidate="TxtRoySF100_200" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Roysf200 300:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtRoySF200_300" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvRoySF200_300" ControlToValidate="TxtRoySF200_300" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Tzu Feng:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtTzuFeng" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvTzuFeng" ControlToValidate="TxtTzuFeng" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Artemia:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtArtemia" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvArtemia" ControlToValidate="TxtArtemia" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Artemia EZ1:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtArtemiaEZ1" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvArtemiaEZ1" ControlToValidate="TxtArtemiaEZ1" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Artemia EZ2:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtArtemiaEZ2" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvArtemiaEZ2" ControlToValidate="TxtArtemiaEZ2" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Activity:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtActivity" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvActivity" ControlToValidate="TxtActivity" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Length:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtLength" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvLength" ControlToValidate="TxtLength" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Stdev:     <td></td>
		        <td><asp:TextBox ID="TxtStdev" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvStdev" ControlToValidate="TxtStdev" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Fgc:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtFgc" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvFgc" ControlToValidate="TxtFgc" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Necrosis:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtNecrosis" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvNecrosis" ControlToValidate="TxtNecrosis" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Fouling:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtFouling" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvFouling" ControlToValidate="TxtFouling" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Parasite:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtParasite" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvParasite" ControlToValidate="TxtParasite" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Mgr:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtMgr" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvMgr" ControlToValidate="TxtMgr" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	       
	        <tr>
		        <td>Treflan:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtTreflan" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvTreflan" ControlToValidate="TxtTreflan" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Probiotik:</td>
                <td></td>
		        <td><asp:TextBox ID="TxtProbiotik" runat="server" >0</asp:TextBox>
                </td>
		        <td style="width: 156px"><asp:CompareValidator ID="CompvProbiotik" ControlToValidate="TxtProbiotik" ErrorMessage="Invalid number!" Display="Dynamic" Operator="DataTypeCheck" Type="Double" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>Remark:</td>
                <td></td>
		        <td colspan="2"><asp:TextBox ID="TxtRemark" TextMode="MultiLine" Rows="7" runat="server" /></td>
	        </tr>
	        <tr>
		        <td>User ID:</td>
                <td></td>
		        <td colspan="2"><asp:TextBox ID="TxtUserID" MaxLength="0" runat="server" ReadOnly="True" /></td>
	        </tr>
	        <tr>
		        <td colspan="2"></td>
		        <td colspan="2">
                    <asp:Button ID="BtnAddRecord" Text="Add Record" runat="server" OnClick="BtnAddRecord_Click" />
                    <asp:Button ID="BtnUpdateRecord" Text="Update Record" runat="server" Visible="false" OnClick="BtnUpdateRecord_Click" />
                    &nbsp;<input id="inpCancel" type="button" value="Clear" onclick="window.location = 'default.htm'; return false;" />
                </td>
	        </tr>
	        <tr>
		        <td colspan="2">
                    <asp:SqlDataSource ID="ModuleSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ModuleName] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
                </td>
		        <td colspan="2">
                    &nbsp;</td>
	        </tr>
        </table> 
</asp:Content>
