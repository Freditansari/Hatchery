namespace HatcheryReportLibrary
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for BroodstockWaterParameter2.
    /// </summary>
    public partial class BroodstockWaterParameter2 : Telerik.Reporting.Report
    {
        public BroodstockWaterParameter2()
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