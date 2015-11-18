<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="broodstockMonitoring.aspx.cs" Inherits="Hatchery.WebForm4" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 105px;
        }
        .auto-style3 {
            width: 105px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 321px;
        }
        .auto-style5 {
            width: 321px;
            margin-left: 320px;
        }
        .auto-style6 {
            width: 105px;
            height: 47px;
        }
        .auto-style7 {
            width: 321px;
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; margin-left: 40px;">
       
        <tr>
            <td class="auto-style2">Batch</td>
            <td class="auto-style5">
                <asp:DropDownList ID="BatchDropDownList" runat="server" DataSourceID="BatchDataSource" DataTextField="BatchNumber" DataValueField="BatchNumber">
                </asp:DropDownList>
            </td>
            <td>
                UserID: <asp:Label ID="UserIDLabel" runat="server" Text="ExpUser"></asp:Label>

            </td>
          
        </tr>
        <tr>
            <td class="auto-style2">Date</td>
            <td class="auto-style5">
                <telerik:RadDatePicker ID="BroodstockLogDateDatePicker" Runat="server" Culture="en-US"  DateInput-DateFormat="MM/dd/yyyy" FocusedDate="2015-11-10" MinDate="2000-11-10">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;"></Calendar>

<DateInput DisplayDateFormat="M/d/yyyy"  DateFormat="M/d/yyyy" LabelWidth="40%" displaytext="11/10/2015" value="11/10/2015">
<EmptyMessageStyle Resize="None"></EmptyMessageStyle>

<ReadOnlyStyle Resize="None"></ReadOnlyStyle>

<FocusedStyle Resize="None"></FocusedStyle>

<DisabledStyle Resize="None"></DisabledStyle>

<InvalidStyle Resize="None"></InvalidStyle>

<HoveredStyle Resize="None"></HoveredStyle>

<EnabledStyle Resize="None"></EnabledStyle>
</DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                </telerik:RadDatePicker>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style3">Male</td>
            <td class="auto-style4">
                <telerik:RadNumericTextBox ID="MaleTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px" MinValue="0">
                </telerik:RadNumericTextBox>
            </td>
                  <td class="auto-style2">Dead Male</td>
            <td>
                <telerik:RadNumericTextBox ID="DeadMaleTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px" MinValue="0">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">Female</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="FemaleTextBox" Runat="server" AutoPostBack="True" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px" MinValue="0">
                </telerik:RadNumericTextBox>
            </td>
                <td class="auto-style2">Dead Female</td>
            <td>
                <telerik:RadNumericTextBox ID="DeadFemaleTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px" MinValue="0">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
      <%--      <td class="auto-style2">Dead Male</td>
            <td>
                <telerik:RadNumericTextBox ID="DeadMaleTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>--%>
            
        </tr>
        <tr>
        <%--    <td class="auto-style2">Dead Female</td>
            <td>
                <telerik:RadNumericTextBox ID="DeadFemaleTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Value="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>--%>
            
        </tr>
        <tr>
            <td class="auto-style6">Salinity</td>
            <td class="auto-style7">
                <telerik:RadNumericTextBox ID="SalinityTextBox" Runat="server" AutoPostBack="True" Culture="en-US" DbValueFactor="1" LabelWidth="64px" Width="160px" MaxValue="100" MinValue="0">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">Maturation Temp(°C)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="MaturationTempTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="100" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>

                    <td class="auto-style2">Hatching Temp(°C)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="HatchingTempTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="100" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style3">DO</td>
            <td class="auto-style4">
                <telerik:RadNumericTextBox ID="DOTextBOx" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="10" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                pH</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="PHTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="14" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Polycheate in
                
            </td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="PolycheateINTextBox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

               <td class="auto-style2">
                
                Squid in</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="SquidInTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="99999999" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Polycheate Used</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="PolycheateUsedTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

              <td class="auto-style2">
                
                Squid Used</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="squidUsedTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="999999999" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Polycheate Balance</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="PolycheateBalanceTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                Squid Balance</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="SquidBalanceTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MaxValue="999999999" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                FR (%)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="FRTextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                <strong>Chemicals</strong></td>
            <td class="auto-style5">
                &nbsp;</td>

             <td class="auto-style2">
                
                 &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                EDTA(g)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="EDTATextBox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MinValue="0" Value="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 Formaldehyde (ml)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="FormalDehydeTextbox" Runat="server" Culture="en-US" DbValueFactor="1" LabelWidth="64px" MinValue="0" Width="160px">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Iodine</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="IodineTextBox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 Vitamins</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="VitaminTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>
          
            
        </tr>
        <tr>

            <td class="auto-style2">
                
                 Treflans</td>
            <td class="auto-style5">
                 <telerik:RadNumericTextBox ID="treflantexbox" Runat="server">
                </telerik:RadNumericTextBox>
            <td>
                 &nbsp;</td>
            <td>

            </td>
          
        </tr>

        <tr>
            <td class="auto-style2">
                
                <strong>Productions</strong></td>
            <td class="auto-style5">
                &nbsp;</td>

             <td class="auto-style2">
                
                 &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Mated(pcs)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="matedTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 MK(pcs)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="mkTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Spawn(pcs)</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="SpawnTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 Egg</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="eggTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                Nauplii Bruto</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="NaupliiTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 Nauplii Netto</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server">
                </telerik:RadNumericTextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                flush</td>
            <td class="auto-style5">
                <telerik:RadNumericTextBox ID="FlushTextbox" Runat="server">
                </telerik:RadNumericTextBox>
            </td>

             <td class="auto-style2">
                
                 Distribution</td>
            <td class="auto-style5">
                <asp:TextBox ID="DistributionTextbox" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                remark</td>
            <td class="auto-style5">
                <asp:TextBox ID="RemarkTextBOx" runat="server"></asp:TextBox>
            </td>

             <td class="auto-style2">
                
                 &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
                <asp:Label ID="outputLabel" runat="server" Text="Label"></asp:Label>
            </td>

             <td class="auto-style2">
                
                 &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            
        </tr>
        </table>
    <br />

    <asp:SqlDataSource ID="BatchDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" SelectCommand="SELECT * FROM [MasterBatch] WHERE ([IsTerminated] = @IsTerminated)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="False" Name="IsTerminated" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp; 
    <asp:SqlDataSource ID="BatchMonitoringDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:HatcheryConnectionString %>" DeleteCommand="DELETE FROM [BroodStockMonitoring] WHERE [BSMID] = @BSMID" InsertCommand="INSERT INTO [BroodStockMonitoring] ([Batch], [Date], [Male], [Female], [DeadMale], [DeadFemale], [Salinity], [MatTemp], [HatcTemp], [DO], [PH], [PolychaeteIn], [PolychaeteUsed], [PolychaeteBalance], [SquidIn], [SquidUsed], [SquidiBalance], [FR], [EDTA], [Formaldehyde], [Treflan], [Iodine], [Vitamin], [Matured], [Mated], [Spawned], [Egg], [NaupliiBruto], [NaupliiNetto], [Flush], [Distribution], [Remark], [userID]) VALUES (@Batch, @Date, @Male, @Female, @DeadMale, @DeadFemale, @Salinity, @MatTemp, @HatcTemp, @DO, @PH, @PolychaeteIn, @PolychaeteUsed, @PolychaeteBalance, @SquidIn, @SquidUsed, @SquidiBalance, @FR, @EDTA, @Formaldehyde, @Treflan, @Iodine, @Vitamin, @Matured, @Mated, @Spawned, @Egg, @NaupliiBruto, @NaupliiNetto, @Flush, @Distribution, @Remark, @userID)" SelectCommand="SELECT * FROM [BroodStockMonitoring]" UpdateCommand="UPDATE [BroodStockMonitoring] SET [Batch] = @Batch, [Date] = @Date, [Male] = @Male, [Female] = @Female, [DeadMale] = @DeadMale, [DeadFemale] = @DeadFemale, [Salinity] = @Salinity, [MatTemp] = @MatTemp, [HatcTemp] = @HatcTemp, [DO] = @DO, [PH] = @PH, [PolychaeteIn] = @PolychaeteIn, [PolychaeteUsed] = @PolychaeteUsed, [PolychaeteBalance] = @PolychaeteBalance, [SquidIn] = @SquidIn, [SquidUsed] = @SquidUsed, [SquidiBalance] = @SquidiBalance, [FR] = @FR, [EDTA] = @EDTA, [Formaldehyde] = @Formaldehyde, [Treflan] = @Treflan, [Iodine] = @Iodine, [Vitamin] = @Vitamin, [Matured] = @Matured, [Mated] = @Mated, [Spawned] = @Spawned, [Egg] = @Egg, [NaupliiBruto] = @NaupliiBruto, [NaupliiNetto] = @NaupliiNetto, [Flush] = @Flush, [Distribution] = @Distribution, [Remark] = @Remark, [userID] = @userID WHERE [BSMID] = @BSMID">
        <DeleteParameters>
            <asp:Parameter Name="BSMID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Batch" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Date" />
            <asp:Parameter Name="Male" Type="Int32" />
            <asp:Parameter Name="Female" Type="Int32" />
            <asp:Parameter Name="DeadMale" Type="Int32" />
            <asp:Parameter Name="DeadFemale" Type="Int32" />
            <asp:Parameter Name="Salinity" Type="Double" />
            <asp:Parameter Name="MatTemp" Type="Double" />
            <asp:Parameter Name="HatcTemp" Type="Double" />
            <asp:Parameter Name="DO" Type="Double" />
            <asp:Parameter Name="PH" Type="Double" />
            <asp:Parameter Name="PolychaeteIn" Type="Double" />
            <asp:Parameter Name="PolychaeteUsed" Type="Double" />
            <asp:Parameter Name="PolychaeteBalance" Type="Double" />
            <asp:Parameter Name="SquidIn" Type="Double" />
            <asp:Parameter Name="SquidUsed" Type="Double" />
            <asp:Parameter Name="SquidiBalance" Type="Double" />
            <asp:Parameter Name="FR" Type="Double" />
            <asp:Parameter Name="EDTA" Type="Double" />
            <asp:Parameter Name="Formaldehyde" Type="Double" />
            <asp:Parameter Name="Treflan" Type="Double" />
            <asp:Parameter Name="Iodine" Type="Double" />
            <asp:Parameter Name="Vitamin" Type="Double" />
            <asp:Parameter Name="Matured" Type="Int32" />
            <asp:Parameter Name="Mated" Type="Int32" />
            <asp:Parameter Name="Spawned" Type="Int32" />
            <asp:Parameter Name="Egg" Type="Double" />
            <asp:Parameter Name="NaupliiBruto" Type="Double" />
            <asp:Parameter Name="NaupliiNetto" Type="Double" />
            <asp:Parameter Name="Flush" Type="Double" />
            <asp:Parameter Name="Distribution" Type="String" />
            <asp:Parameter Name="Remark" Type="String" />
            <asp:Parameter Name="userID" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Batch" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Date" />
            <asp:Parameter Name="Male" Type="Int32" />
            <asp:Parameter Name="Female" Type="Int32" />
            <asp:Parameter Name="DeadMale" Type="Int32" />
            <asp:Parameter Name="DeadFemale" Type="Int32" />
            <asp:Parameter Name="Salinity" Type="Double" />
            <asp:Parameter Name="MatTemp" Type="Double" />
            <asp:Parameter Name="HatcTemp" Type="Double" />
            <asp:Parameter Name="DO" Type="Double" />
            <asp:Parameter Name="PH" Type="Double" />
            <asp:Parameter Name="PolychaeteIn" Type="Double" />
            <asp:Parameter Name="PolychaeteUsed" Type="Double" />
            <asp:Parameter Name="PolychaeteBalance" Type="Double" />
            <asp:Parameter Name="SquidIn" Type="Double" />
            <asp:Parameter Name="SquidUsed" Type="Double" />
            <asp:Parameter Name="SquidiBalance" Type="Double" />
            <asp:Parameter Name="FR" Type="Double" />
            <asp:Parameter Name="EDTA" Type="Double" />
            <asp:Parameter Name="Formaldehyde" Type="Double" />
            <asp:Parameter Name="Treflan" Type="Double" />
            <asp:Parameter Name="Iodine" Type="Double" />
            <asp:Parameter Name="Vitamin" Type="Double" />
            <asp:Parameter Name="Matured" Type="Int32" />
            <asp:Parameter Name="Mated" Type="Int32" />
            <asp:Parameter Name="Spawned" Type="Int32" />
            <asp:Parameter Name="Egg" Type="Double" />
            <asp:Parameter Name="NaupliiBruto" Type="Double" />
            <asp:Parameter Name="NaupliiNetto" Type="Double" />
            <asp:Parameter Name="Flush" Type="Double" />
            <asp:Parameter Name="Distribution" Type="String" />
            <asp:Parameter Name="Remark" Type="String" />
            <asp:Parameter Name="userID" Type="String" />
            <asp:Parameter Name="BSMID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
