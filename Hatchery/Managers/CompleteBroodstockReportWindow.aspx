<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompleteBroodstockReportWindow.aspx.cs" Inherits="Hatchery.Managers.CompleteBroodstockReport" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700">
        Complete Broodstock Report<br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="BatchDataSource" DataTextField="BatchNumber" DataValueField="BatchNumber" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="BatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
            <SelectParameters>
                <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="391px" Width="1054px">
<typereportsource typename="HatcheryReportLibrary.CompleteBroodstockReport, HatcheryReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
</telerik:ReportViewer>
    </div>
    </form>
</body>
</html>
