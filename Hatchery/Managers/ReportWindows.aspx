<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportWindows.aspx.cs" Inherits="Hatchery.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
    

    <table style="width: 100%;">
        <tr>
            <td>
                 <telerik:RadMenu ID="RadMenu2" Runat="server">
                    <Items>
                        <telerik:RadMenuItem runat="server" Text="Broodstocks Reports">
                            <Items>
                                <telerik:RadMenuItem runat="server" Text="Nauplii Efficiency" NavigateUrl="~/Managers/NaupliiEfficiencyReport.aspx" Target="FrameReport">
                                </telerik:RadMenuItem>
                                <telerik:RadMenuItem runat="server" Text="Broodstock Water Parameter" NavigateUrl="~/Managers/BroodstockwaterparameterReport.aspx" Target="FrameReport">
                                </telerik:RadMenuItem>
                                <telerik:RadMenuItem runat="server" NavigateUrl="~/Managers/BroodstockWaterParameter2.aspx" Target="FrameReport" Text="Broodstock Water Parameter 2">
                                </telerik:RadMenuItem>
                                <telerik:RadMenuItem runat="server" NavigateUrl="~/Managers/CompleteBroodstockReportWindow.aspx" Target="FrameReport" Text="Complete Broodstock Report">
                                </telerik:RadMenuItem>
                            </Items>
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" Text="PL Reports">
                            <Items>
                                <telerik:RadMenuItem runat="server" Text="Module Reports">
                                </telerik:RadMenuItem>
                            </Items>
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenu>
                <br />
                <br />

            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><iframe name="FrameReport" height ="600" style="width: 898px" ></iframe></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
