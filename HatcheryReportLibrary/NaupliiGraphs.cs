namespace HatcheryReportLibrary
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for NaupliiGraphs.
    /// </summary>
    public partial class NaupliiGraphs : Telerik.Reporting.Report
    {
        public NaupliiGraphs()
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