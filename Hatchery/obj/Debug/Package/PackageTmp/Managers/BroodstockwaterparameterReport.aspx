<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BroodstockwaterparameterReport.aspx.cs" Inherits="Hatchery.Managers.BroodstockwaterparameterReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p style="font-weight: 700">
        <br />
        Broodstock Water Parameter Reports
    </p>
    <form id="form1" runat="server">
        <p style="font-weight: 700">
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true" AutoPostBack="True" DataSourceID="BatchDataSource" DataTextField="BatchNumber" DataValueField="BatchNumber" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select A Batch Number</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="BatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
     
        <telerik:ReportViewer ID="ReportViewer2" runat="server" Height="388px" Width="886px">
<typereportsource typename="HatcheryReportLibrary.BroodstockWaterParameter, HatcheryReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
</telerik:ReportViewer>
    </form>
</body>
</html>
