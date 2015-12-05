<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompletePLReport.aspx.cs" Inherits="Hatchery.Managers.CompletePLReport" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ModuleNameDDL" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="moduleDataSource" DataTextField="ModuleName" DataValueField="ModuleName" OnSelectedIndexChanged="ModuleNameDDL_SelectedIndexChanged">
            <asp:ListItem>Select a Module!</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="moduleDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ModuleName] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="396px" Width="1083px">
<typereportsource typename="HatcheryReportLibrary.CompletePLReport, HatcheryReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
</telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
