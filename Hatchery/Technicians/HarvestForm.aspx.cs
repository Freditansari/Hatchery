using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtDate.Text = DateTime.Now.Date.ToString().Substring(0,10);
            TxtTime.Text = DateTime.Now.TimeOfDay.ToString();
            TxtUserid.Text = User.Identity.Name.ToString();
        }

        protected void BtnAddRecord_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                HatcheryEntities db = new HatcheryEntities();

                Harvest newHarvest = new Harvest();
                newHarvest.ProductionCycleID = Convert.ToInt32( ProductionCycleDDl.SelectedValue);
                newHarvest.DOC = Convert.ToInt32(TxtDoc.Text);
                newHarvest.Stage = StagesDDL.SelectedValue;
                newHarvest.HarvestedPopulation = Convert.ToInt32( TxtHarvestedPopulation.Text);
                newHarvest.Date = Convert.ToDateTime(TxtDate.Text);
                newHarvest.Time = TimeSpan.Parse(TxtTime.Text);
                newHarvest.userid = TxtUserid.Text;

                db.Harvests.Add(newHarvest);
                db.SaveChanges();

                var ProdCycleQuery = from ProdCycle in db.ProductionCycles where ProdCycle.ProductionCycleID == newHarvest.ProductionCycleID select ProdCycle;
                ProductionCycle selectedCycle = ProdCycleQuery.Single();

                selectedCycle.isInProduction = false;

                db.SaveChanges();
            }

        }
    }
}