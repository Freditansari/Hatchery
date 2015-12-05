using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery.Managers
{
    public partial class CompletePLReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProductionCycleDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void ProductionCycleDDL_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    var report = new Telerik.Reporting.InstanceReportSource();
            //    report.ReportDocument = new HatcheryReportLibrary.CompletePLReport();
            //    report.Parameters.Add("ProductionCycleIDParameter", Convert.ToInt32(ProductionCycleDDL.SelectedValue));
            //    this.ReportViewer1.ReportSource = report;


            //}
            //catch (Exception)
            //{


            //}
        }

        protected void ModuleNameDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductionCycle SelectedProdID = new ProductionCycle();
            try
            {
                HatcheryEntities db = new HatcheryEntities();
                var ProdCycleQuery = from ProdCycle in db.ProductionCycles where ProdCycle.ModuleName == ModuleNameDDL.SelectedValue && ProdCycle.isInProduction == true select ProdCycle;

                SelectedProdID = ProdCycleQuery.SingleOrDefault();
            }
            catch (Exception)
            {
            }

            try
            {

                var report = new Telerik.Reporting.InstanceReportSource();
                report.ReportDocument = new HatcheryReportLibrary.CompletePLReport();
                report.Parameters.Add("ProductionCycleIDParameter", SelectedProdID.ProductionCycleID);
                this.ReportViewer1.ReportSource = report;


            }
            catch (Exception)
            {


            }


        }
    }
}