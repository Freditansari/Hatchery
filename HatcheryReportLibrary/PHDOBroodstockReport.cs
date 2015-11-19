namespace HatcheryReportLibrary
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for PHDOBroodstockReport.
    /// </summary>
    public partial class PHDOBroodstockReport : Telerik.Reporting.Report
    {
        public PHDOBroodstockReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            graphAxis2.LabelAngle = -45;

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}