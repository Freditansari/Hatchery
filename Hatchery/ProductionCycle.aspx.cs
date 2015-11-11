using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    //todo change label user name 
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StartDateDatePicker.SelectedDate = DateTime.Now;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {


            Page.Validate();
            if (Page.IsValid)
            {
                string cs = ConfigurationManager.ConnectionStrings["HatcheryConnectionString"].ConnectionString;

               
                
                System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(cs);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [ProductionCycle] ([ModuleName], [StartDate], [Nauplii], [Batch], [isInProduction],  [UserID]) VALUES ('"+ModuleDropDownList.SelectedValue+"', '"+StartDateDatePicker.SelectedDate.ToString().Substring(0,10)+"', '"+NaupliiTextbox.Text+"', '"+BatchNumberDropdown.SelectedValue+"', 'True', '"+UserIDLabel.Text+"')";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
			
        }
    }
}