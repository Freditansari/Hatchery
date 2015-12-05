using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WaterParameterDatePicker.SelectedDate = DateTime.Now;
            TxtUserID.Text = User.Identity.Name.ToString();
        }

        protected void BtnAddRecord_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                BtnAddRecord.Enabled = false;
                HatcheryEntities db = new HatcheryEntities();
                WaterParameterPostLarva newWaterParameter = new WaterParameterPostLarva();
                newWaterParameter.ModuleName = ModuleDropDownList.SelectedValue;
                newWaterParameter.ProductionCycleID = Convert.ToInt32(ProductionCycleIDDDL.SelectedValue);
                newWaterParameter.Date = WaterParameterDatePicker.SelectedDate;
                newWaterParameter.Alkalinty = Convert.ToDouble(TxtAlkalinty.Text);
                newWaterParameter.Temperature = Convert.ToDouble(TxtTemperature.Text);
                newWaterParameter.PH = Convert.ToDouble(TxtPh.Text);
                newWaterParameter.NH3 = Convert.ToDouble(TxtNh3.Text);
                newWaterParameter.N = Convert.ToDouble(NTxt.Text);
                newWaterParameter.Salinity = Convert.ToDouble(TxtSalinity.Text);
                newWaterParameter.DO = Convert.ToDouble(TxtDo.Text);
                newWaterParameter.Remark = TxtRemark.Text;
                newWaterParameter.Algae = AlgaeTXT.Text;
                newWaterParameter.userID = TxtUserID.Text;

                db.WaterParameterPostLarvas.Add(newWaterParameter);
                db.SaveChanges();

                BtnAddRecord.Enabled = true;

            }

        }

        protected void BtnUpdateRecord_Click(object sender, EventArgs e)
        {

        }
    }
}