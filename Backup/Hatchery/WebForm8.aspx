<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Hatchery.WebForm8" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=9.0.15.225, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Welcome Managers</p>
<p>
    <telerik:RadHtmlChart ID="RadHtmlChart1" runat="server" DataSourceID="PopulationDataSource">
        <PlotArea>
            <Series>
                <telerik:LineSeries DataFieldY="Population" Name="Population">
                </telerik:LineSeries>

            </Series>
            <XAxis DataLabelsField ="Date">
                <TitleAppearance Text ="Date" />
            </XAxis>
        </PlotArea>
    </telerik:RadHtmlChart>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ProductionCycleID" DataTextField="ProductionCycleID" DataValueField="ProductionCycleID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="ProductionCycleID" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ProductionCycleID] FROM [ProductionCycle] WHERE ([isInProduction] = @isInProduction)">
        <SelectParameters>
            <asp:Parameter DefaultValue="True" Name="isInProduction" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="PopulationDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [Date], [Population] FROM [DailyMonitoringPostLarva] WHERE ([ProductionCycleID] = @ProductionCycleID)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="ProductionCycleID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </p>
</asp:Content>
