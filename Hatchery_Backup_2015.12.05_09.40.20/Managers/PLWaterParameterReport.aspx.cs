using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery.Managers
{
    public partial class PLWaterParameterReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ModuleDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductionCycle SelectedProdID = new ProductionCycle();
            try
            {
                HatcheryEntities db = new HatcheryEntities();
                var ProdCycleQuery = from ProdCycle in db.ProductionCycles where ProdCycle.ModuleName == ModuleDDL.SelectedValue && ProdCycle.isInProduction == true select ProdCycle;

                SelectedProdID = ProdCycleQuery.SingleOrDefault();
            }
            catch (Exception)
            {
            }

            try
            {

                var report = new Telerik.Reporting.InstanceReportSource();
                report.ReportDocument = new HatcheryReportLibrary.PLWaterParameter();
                report.Parameters.Add("ProductionCycleIDParameter", SelectedProdID.ProductionCycleID);
                this.ReportViewer1.ReportSource = report;


            }
            catch (Exception)
            {


            }
        }
    }
}