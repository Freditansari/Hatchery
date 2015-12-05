using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Hatchery
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BroodstockLogDateDatePicker.SelectedDate = DateTime.Now;    
            }
            
            UserIDLabel.Text = User.Identity.Name.ToString();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
       
            Page.Validate();
            if (Page.IsValid)
            {
               // string cs = ConfigurationManager.ConnectionStrings["HatcheryConnectionString"].ConnectionString;

               // System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(cs);

               // //string selecteddate = BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0, 10);

               // System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
               // cmd.CommandType = System.Data.CommandType.Text;
               // cmd.CommandText = "INSERT INTO [BroodStockMonitoring] ([Batch], [Date], [Male], [Female], [DeadMale], [DeadFemale], [Salinity], [MatTemp], [HatcTemp], [DO], [PH], [PolychaeteIn], [PolychaeteUsed], [PolychaeteBalance], [SquidIn], [SquidUsed], [SquidiBalance], [FR], [EDTA], [Formaldehyde], [Treflan], [Iodine], [Vitamin], [Matured], [Mated], [Spawned], [Egg], [NaupliiBruto], [NaupliiNetto], [Flush], [Distribution], [Remark], [userID]) VALUES  (" + BatchDropDownList.Text + ", '" +  BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0,10) + "', '" + MaleTextBox.Text + "', '" + FemaleTextBox.Text + "', '" + DeadMaleTextBox.Text + "', '" + DeadFemaleTextbox.Text + "', '" + SalinityTextBox.Text + "', '" + MaturationTempTextBox.Text + "', '" + HatchingTempTextbox.Text + "', '" + DOTextBOx.Text + "', '" + PHTextBox.Text + "', '" + PolycheateINTextBox.Text + "', '" + PolycheateUsedTextbox.Text + "', '" + PolycheateBalanceTextbox.Text + "', '" + SquidInTextBox.Text + "', '" + squidUsedTextBox.Text + "', '" + SquidBalanceTextbox.Text + "', '" + FRTextBox.Text + "', '" + EDTATextBox.Text + "', '" + FormalDehydeTextbox.Text + "', '" + treflantexbox.Text + "', '" + IodineTextBox.Text + "', '" + VitaminTextbox.Text + "', '" + MaturationTempTextBox.Text + "', '" + matedTextbox.Text + "', '" + SpawnTextbox.Text + "', '" + eggTextbox.Text + "', '" + NaupliiTextbox.Text + "', '" + NaupliiTextbox.Text + "', '" + FlushTextbox.Text + "', '" + DistributionTextbox.Text + "', '" + RemarkTextBOx.Text + "', '" + UserIDLabel.Text + "')";
               //// cmd.CommandText = "INSERT INTO [BroodStockMonitoring] ([Batch], [Date], [Male]) VALUES  (" + BatchDropDownList.Text + ", '" + BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0, 10) + "', '"+MaleTextBox.Text+"' )";
               // outputLabel.Text = cmd.CommandText.ToString();
               // cmd.Connection = sqlConnection1;

               // sqlConnection1.Open();
               // cmd.ExecuteNonQuery();
               // sqlConnection1.Close();
                try
                {
                    HatcheryEntities db = new HatcheryEntities();


                    BroodStockMonitoring newBroodStockMonitor = new BroodStockMonitoring();

                    newBroodStockMonitor.Batch = Convert.ToInt32(BatchDropDownList.SelectedValue);
                    newBroodStockMonitor.Date = BroodstockLogDateDatePicker.SelectedDate;
                    newBroodStockMonitor.Male = Convert.ToInt32(MaleTextBox.Text);
                    newBroodStockMonitor.DeadMale = Convert.ToInt32(DeadMaleTextBox.Text);
                    newBroodStockMonitor.Female = Convert.ToInt32(FemaleTextBox.Text);
                    newBroodStockMonitor.DeadFemale = Convert.ToInt32(DeadFemaleTextbox.Text);
                    newBroodStockMonitor.Salinity = Convert.ToDouble(SalinityTextBox.Text);
                    newBroodStockMonitor.MatTemp = Convert.ToDouble(MaturationTempTextBox.Text);
                    newBroodStockMonitor.HatcTemp = Convert.ToDouble(HatchingTempTextbox.Text);
                    newBroodStockMonitor.DO = Convert.ToDouble(DOTextBOx.Text);
                    newBroodStockMonitor.PH = Convert.ToDouble(PHTextBox.Text);
                    newBroodStockMonitor.PolychaeteIn = Convert.ToDouble(PolycheateINTextBox.Text);
                    newBroodStockMonitor.PolychaeteUsed = Convert.ToDouble(PolycheateUsedTextbox.Text);
                    newBroodStockMonitor.PolychaeteBalance = Convert.ToDouble(PolycheateBalanceTextbox.Text);
                    newBroodStockMonitor.SquidIn = Convert.ToDouble(SquidInTextBox.Text);
                    newBroodStockMonitor.SquidUsed = Convert.ToDouble(squidUsedTextBox.Text);
                    newBroodStockMonitor.SquidiBalance = Convert.ToDouble(SquidBalanceTextbox.Text);
                    newBroodStockMonitor.FR = Convert.ToDouble(FRTextBox.Text);
                    newBroodStockMonitor.EDTA = Convert.ToDouble(EDTATextBox.Text);
                    newBroodStockMonitor.Iodine = Convert.ToDouble(IodineTextBox.Text);
                    newBroodStockMonitor.Treflan = Convert.ToDouble(treflantexbox.Text);
                    newBroodStockMonitor.Formaldehyde = Convert.ToDouble(FormalDehydeTextbox.Text);
                    newBroodStockMonitor.Vitamin = Convert.ToDouble(VitaminTextbox.Text);
                    newBroodStockMonitor.Matured = Convert.ToInt32(maturedTextBox.Text);
                    newBroodStockMonitor.Mated = Convert.ToInt32(matedTextbox.Text);
                    newBroodStockMonitor.Spawned = Convert.ToInt32(SpawnTextbox.Text);
                    newBroodStockMonitor.Egg = Convert.ToDouble(eggTextbox.Text);
                    newBroodStockMonitor.NaupliiBruto = Convert.ToDouble(NaupliiTextbox.Text);
                    newBroodStockMonitor.NaupliiNetto = Convert.ToDouble(naupliiNettoTextBox.Text);
                    newBroodStockMonitor.Flush = Convert.ToDouble(FlushTextbox.Text);
                    newBroodStockMonitor.Distribution = DistributionTextbox.Text;
                    newBroodStockMonitor.Remark = RemarkTextBOx.Text;
                    newBroodStockMonitor.userID = UserIDLabel.Text;

                    db.BroodStockMonitorings.Add(newBroodStockMonitor);
                    db.SaveChanges();
                }
                catch (Exception g)
                {
                    errorLabel.Text = g.Message.ToString();
                }






               
			
               
			
            }

        }
    }
}