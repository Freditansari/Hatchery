﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    //todo change label user name 
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    String[] userRoles = Roles.GetRolesForUser();

            //    foreach (String role in userRoles)
            //    {
            //        if (role != "Managers")
            //        {
            //            throw new System.InvalidOperationException("User is not authorized");
            //        }
            //    }
            //}
            //catch (Exception)
            //{
                
            //    Response.Redirect("~/Account/Login.aspx", true);
            //}
            StartDateDatePicker.SelectedDate = DateTime.Now;
            UserIDLabel.Text = User.Identity.Name.ToString();
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