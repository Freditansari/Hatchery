﻿using HatcheryReportLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery.Managers
{
    public partial class CompleteBroodstockReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var report = new Telerik.Reporting.InstanceReportSource();
                report.ReportDocument = new HatcheryReportLibrary.CompleteBroodstockReport();
                report.Parameters.Add("batchParameter", Convert.ToInt32(DropDownList1.SelectedValue));
                this.ReportViewer1.ReportSource = report;


            }
            catch (Exception)
            {


            }
        }
    }
}