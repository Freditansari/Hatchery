namespace HatcheryReportLibrary
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for BroodstockPopulationGraph.
    /// </summary>
    public partial class BroodstockPopulationGraph : Telerik.Reporting.Report
    {
        public BroodstockPopulationGraph()
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