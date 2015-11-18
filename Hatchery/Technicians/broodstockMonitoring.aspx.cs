using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//todo get login user name at submit
namespace Hatchery
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BroodstockLogDateDatePicker.SelectedDate = DateTime.Now;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
       
            Page.Validate();
            if (Page.IsValid)
            {
                string cs = ConfigurationManager.ConnectionStrings["HatcheryConnectionString"].ConnectionString;

                System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(cs);

                //string selecteddate = BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0, 10);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [BroodStockMonitoring] ([Batch], [Date], [Male], [Female], [DeadMale], [DeadFemale], [Salinity], [MatTemp], [HatcTemp], [DO], [PH], [PolychaeteIn], [PolychaeteUsed], [PolychaeteBalance], [SquidIn], [SquidUsed], [SquidiBalance], [FR], [EDTA], [Formaldehyde], [Treflan], [Iodine], [Vitamin], [Matured], [Mated], [Spawned], [Egg], [NaupliiBruto], [NaupliiNetto], [Flush], [Distribution], [Remark], [userID]) VALUES  (" + BatchDropDownList.Text + ", '" +  BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0,10) + "', '" + MaleTextBox.Text + "', '" + FemaleTextBox.Text + "', '" + DeadMaleTextBox.Text + "', '" + DeadFemaleTextbox.Text + "', '" + SalinityTextBox.Text + "', '" + MaturationTempTextBox.Text + "', '" + HatchingTempTextbox.Text + "', '" + DOTextBOx.Text + "', '" + PHTextBox.Text + "', '" + PolycheateINTextBox.Text + "', '" + PolycheateUsedTextbox.Text + "', '" + PolycheateBalanceTextbox.Text + "', '" + SquidInTextBox.Text + "', '" + squidUsedTextBox.Text + "', '" + SquidBalanceTextbox.Text + "', '" + FRTextBox.Text + "', '" + EDTATextBox.Text + "', '" + FormalDehydeTextbox.Text + "', '" + treflantexbox.Text + "', '" + IodineTextBox.Text + "', '" + VitaminTextbox.Text + "', '" + MaturationTempTextBox.Text + "', '" + matedTextbox.Text + "', '" + SpawnTextbox.Text + "', '" + eggTextbox.Text + "', '" + NaupliiTextbox.Text + "', '" + NaupliiTextbox.Text + "', '" + FlushTextbox.Text + "', '" + DistributionTextbox.Text + "', '" + RemarkTextBOx.Text + "', '" + UserIDLabel.Text + "')";
               // cmd.CommandText = "INSERT INTO [BroodStockMonitoring] ([Batch], [Date], [Male]) VALUES  (" + BatchDropDownList.Text + ", '" + BroodstockLogDateDatePicker.SelectedDate.ToString().Substring(0, 10) + "', '"+MaleTextBox.Text+"' )";
                outputLabel.Text = cmd.CommandText.ToString();
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

               
			
               
			
            }

        }
    }
}