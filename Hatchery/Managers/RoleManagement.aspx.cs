using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AllUserDDL.DataSource = Membership.GetAllUsers();
                AllUserDDL.DataBind();


                RolesDDL.DataSource = Roles.GetAllRoles();
                RolesDDL.DataBind();
            }
        }

        protected void AddUserToRole_Click(object sender, EventArgs e)
        {
            string selectedUser = AllUserDDL.SelectedItem.ToString();
            string selectedRole = RolesDDL.SelectedValue.ToString();
            if (!Roles.IsUserInRole(selectedUser, selectedRole))
            {
                Roles.AddUserToRole(selectedUser, selectedRole);
                errorLabel.Text = "User has been assigned";
            }
            else
            {
                errorLabel.Text = "User already in the role";
            }

        }

        protected void removeRole_Click(object sender, EventArgs e)
        {
            string selectedUser;
            string selectedRole;

            selectedRole = RolesDDL.SelectedValue.ToString();
            selectedUser = AllUserDDL.SelectedValue.ToString();
            if (Roles.IsUserInRole(selectedUser, selectedRole))
            {
                Roles.RemoveUserFromRole(selectedUser, selectedRole);
                errorLabel.Text = "User has been removed";
            }
            else
            {
                errorLabel.Text = "User already not in the role";
            }
        }

        protected void AllUserDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
      

        protected void RolesDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}