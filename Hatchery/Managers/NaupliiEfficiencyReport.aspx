<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NaupliiEfficiencyReport.aspx.cs" Inherits="Hatchery.WebForm8" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700">
        Nauplii Efficiency Report<br />
        <br />
        Select a Batch Number:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="BatchDataSource" AppendDataBoundItems="true" DataTextField="BatchNumber" DataValueField="BatchNumber" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Select a batch!</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="BatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT [BatchNumber] FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
            <SelectParameters>
                <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height=" 500" Width ="100%">
<typereportsource typename="HatcheryReportLibrary.NaupliiGraphs, HatcheryReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
</telerik:ReportViewer>
    </div>
    </form>
</body>
</html>
