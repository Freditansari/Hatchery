<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Broodstock.aspx.cs" Inherits="Hatchery.WebForm1" %><%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <%--<asp:SqlDataSource ID="BroodStockDataSource" runat="server"></asp:SqlDataSource>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:DropDownList ID="BatchDropDownList" runat="server" AutoPostBack="True" DataSourceID="BatchDataSource" DataTextField="BatchNumber" DataValueField="BatchNumber">
</asp:DropDownList>
<asp:SqlDataSource ID="BatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
    </SelectParameters>
    </asp:SqlDataSource>
    &nbsp;<br />
    <telerik:RadGrid ID="PopulationRadGrid" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="BroodstockPopulationDataSource" GroupPanelPosition="Top">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
        <MasterTableView AutoGenerateColumns="False" DataSourceID="BroodstockPopulationDataSource">
            <Columns>
                <telerik:GridBoundColumn DataField="Date" DataType="System.DateTime" FilterControlAltText="Filter Date column" HeaderText="Date" SortExpression="Date" UniqueName="Date">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Male" DataType="System.Int32" FilterControlAltText="Filter Male column" HeaderText="Male" SortExpression="Male" UniqueName="Male">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Female" DataType="System.Int32" FilterControlAltText="Filter Female column" HeaderText="Female" SortExpression="Female" UniqueName="Female">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="DeadMale" DataType="System.Int32" FilterControlAltText="Filter DeadMale column" HeaderText="DeadMale" SortExpression="DeadMale" UniqueName="DeadMale">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="DeadFemale" DataType="System.Int32" FilterControlAltText="Filter DeadFemale column" HeaderText="DeadFemale" SortExpression="DeadFemale" UniqueName="DeadFemale">
                </telerik:GridBoundColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <br />
    <br />
    <asp:SqlDataSource ID="BroodstockPopulationDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [Date], [Male], [Female], [DeadMale], [DeadFemale] FROM [BroodStockMonitoring] WHERE ([Batch] = @Batch)">
        <SelectParameters>
            <asp:ControlParameter ControlID="BatchDropDownList" Name="Batch" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <telerik:RadGrid ID="WaterParameterRadGrid" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="WaterMonitoringDataSource" GroupPanelPosition="Top">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
        <MasterTableView AutoGenerateColumns="False" DataSourceID="WaterMonitoringDataSource">
            <Columns>
                <telerik:GridBoundColumn DataField="Date" DataType="System.DateTime" FilterControlAltText="Filter Date column" HeaderText="Date" SortExpression="Date" UniqueName="Date">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Salinity" DataType="System.Double" FilterControlAltText="Filter Salinity column" HeaderText="Salinity" SortExpression="Salinity" UniqueName="Salinity">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="MatTemp" DataType="System.Double" FilterControlAltText="Filter MatTemp column" HeaderText="MatTemp" SortExpression="MatTemp" UniqueName="MatTemp">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="HatcTemp" DataType="System.Double" FilterControlAltText="Filter HatcTemp column" HeaderText="HatcTemp" SortExpression="HatcTemp" UniqueName="HatcTemp">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="DO" DataType="System.Double" FilterControlAltText="Filter DO column" HeaderText="DO" SortExpression="DO" UniqueName="DO">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="PH" DataType="System.Double" FilterControlAltText="Filter PH column" HeaderText="PH" SortExpression="PH" UniqueName="PH">
                </telerik:GridBoundColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <asp:SqlDataSource ID="WaterMonitoringDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [Date], [Salinity], [MatTemp], [HatcTemp], [DO], [PH] FROM [BroodStockMonitoring] WHERE ([Batch] = @Batch)">
        <SelectParameters>
            <asp:ControlParameter ControlID="BatchDropDownList" Name="Batch" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
       
</asp:Content>
