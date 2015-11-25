<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoleManagement.aspx.cs" Inherits="Hatchery.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 258px;
    }
    .auto-style2 {
        width: 356px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style1">Users:</td>
        <td class="auto-style2">Roles:</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:DropDownList ID="AllUserDDL" runat="server" AppendDataBoundItems="true" Height="17px" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="AllUserDDL_SelectedIndexChanged">
                <asp:ListItem>Select A User!</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style2">
            <asp:DropDownList ID="RolesDDL" runat="server" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="RolesDDL_SelectedIndexChanged">
                <asp:ListItem>Select A Role!</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="AddUserToRole" runat="server" OnClick="AddUserToRole_Click" Text="Add to Role" />
            <asp:Label ID="errorLabel" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="removeRole" runat="server" OnClick="removeRole_Click" Text="Remove from Role" />
        </td>
    </tr>
</table>
</asp:Content>
