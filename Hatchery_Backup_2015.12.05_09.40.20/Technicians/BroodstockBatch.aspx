<%@ Page Title="Broodstock Batch Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BroodstockBatch.aspx.cs" Inherits="Hatchery.WebForm2" %><%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="MasterBatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT * FROM [MasterBatch]" DeleteCommand="DELETE FROM [MasterBatch] WHERE [BatchNumber] = @BatchNumber" InsertCommand="INSERT INTO [MasterBatch] ([BatchNumber], [IsTerminated], [ReceivedDate], [TerminationDate], [Note]) VALUES (@BatchNumber, @IsTerminated, @ReceivedDate, @TerminationDate, @Note)" UpdateCommand="UPDATE [MasterBatch] SET [IsTerminated] = @IsTerminated, [ReceivedDate] = @ReceivedDate, [TerminationDate] = @TerminationDate, [Note] = @Note WHERE [BatchNumber] = @BatchNumber">
    <DeleteParameters>
        <asp:Parameter Name="BatchNumber" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="BatchNumber" Type="Int32" />
        <asp:Parameter Name="IsTerminated" Type="Boolean" />
        <asp:Parameter DbType="Date" Name="ReceivedDate" />
        <asp:Parameter DbType="Date" Name="TerminationDate" />
        <asp:Parameter Name="Note" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="IsTerminated" Type="Boolean" />
        <asp:Parameter DbType="Date" Name="ReceivedDate" />
        <asp:Parameter DbType="Date" Name="TerminationDate" />
        <asp:Parameter Name="Note" Type="String" />
        <asp:Parameter Name="BatchNumber" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="BatchNumber" DataSourceID="MasterBatchDataSource" AllowSorting="True" CellPadding="4" GridLines="None" ForeColor="#333333" HorizontalAlign="Justify">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="BatchNumber" HeaderText="BatchNumber" ReadOnly="True" SortExpression="BatchNumber" />
            <asp:CheckBoxField DataField="IsTerminated" HeaderText="IsTerminated" SortExpression="IsTerminated" />
<asp:BoundField DataField="ReceivedDate" HeaderText="ReceivedDate" SortExpression="ReceivedDate"></asp:BoundField>
            <asp:BoundField DataField="TerminationDate" HeaderText="TerminationDate" SortExpression="TerminationDate" />
            <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" />
            <asp:BoundField DataField="userID" HeaderText="userID" SortExpression="userID" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderWidth="1pt" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br />

    <asp:DetailsView ID="DetailsView1" GridLines ="None" HorizontalAlign ="Justify" runat="server" DataSourceID="MasterBatchDataSource" Height="50px" Width="125px" CellPadding="4" ForeColor="#333333" AutoGenerateRows="False" DataKeyNames="BatchNumber">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
        <EditRowStyle BackColor="#2461BF" />
        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
        <Fields>
            <asp:TemplateField HeaderText="BatchNumber" SortExpression="BatchNumber">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("BatchNumber") %>'></asp:Label>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("BatchNumber") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="red" runat="server" ControlToValidate ="TextBox3" ErrorMessage="Batch number required"/>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("BatchNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CheckBoxField DataField="IsTerminated" HeaderText="IsTerminated" SortExpression="IsTerminated" />
            <asp:TemplateField HeaderText="ReceivedDate" SortExpression="ReceivedDate">
                <EditItemTemplate>
                    <%--<asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ReceivedDate") %>'></asp:TextBox>--%>
                    <telerik:RadDatePicker ID="RadDatePicker2" SelectedDate='<%# Bind("ReceivedDate") %>' runat="server"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="red" runat="server" ControlToValidate ="RadDatePicker2" Text="*" ErrorMessage="Received Date Required required"/>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <%--<asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ReceivedDate") %>'></asp:TextBox>--%>
                    <telerik:RadDatePicker ID="RadDatePicker2" SelectedDate='<%# Bind("ReceivedDate") %>' runat="server"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="red" runat="server" ControlToValidate ="RadDatePicker2" Text="*" ErrorMessage="Received Date Required required"/>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ReceivedDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TerminationDate" SortExpression="TerminationDate">
                <EditItemTemplate>
                   <%-- <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TerminationDate") %>'></asp:TextBox>--%>
                    <telerik:RadDatePicker ID="RadDatePicker1" SelectedDate='<%# Bind("TerminationDate") %>' runat="server"/>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <%--<asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TerminationDate") %>'></asp:TextBox>--%>
                    <telerik:RadDatePicker ID="RadDatePicker1" SelectedDate='<%# Bind("TerminationDate") %>' runat="server"/>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TerminationDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" />
            <asp:BoundField DataField="userID" HeaderText="userID" SortExpression="userID" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
    </asp:DetailsView>
    <br />
    <br />

</asp:Content>
