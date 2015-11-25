<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BroodstockWaterParameter2.aspx.cs" Inherits="Hatchery.Managers.BroodstockWaterParameter2" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="BatchNumber" DataValueField="BatchNumber" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Select A Batch!</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
            <SelectParameters>
                <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <telerik:ReportViewer ID="BroodstockReportViewer" runat="server" Width="612px"></telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
