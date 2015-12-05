<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PLWaterParameterReport.aspx.cs" Inherits="Hatchery.Managers.PLWaterParameterReport" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ModuleDDL" AppendDataBoundItems="True" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ModuleName" DataValueField="ModuleName" OnSelectedIndexChanged="ModuleDDL_SelectedIndexChanged">
            <asp:ListItem>Select a Module!</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [ModuleName] FROM [MasterModule] ORDER BY [ModuleID]"></asp:SqlDataSource>
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="875px"></telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
