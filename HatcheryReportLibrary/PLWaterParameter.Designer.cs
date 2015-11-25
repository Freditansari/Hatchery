namespace HatcheryReportLibrary
{
    partial class PLWaterParameter
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLWaterParameter));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.temperatureCaptionTextBox = new Telerik.Reporting.TextBox();
            this.salinityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nH3CaptionTextBox = new Telerik.Reporting.TextBox();
            this.alkalintyCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pHCaptionTextBox = new Telerik.Reporting.TextBox();
            this.algaeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.remarkCaptionTextBox = new Telerik.Reporting.TextBox();
            this.userIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.temperatureSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.salinitySumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.dOSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.nSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.nH3SumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.alkalintySumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.pHSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.temperatureDataTextBox = new Telerik.Reporting.TextBox();
            this.salinityDataTextBox = new Telerik.Reporting.TextBox();
            this.dODataTextBox = new Telerik.Reporting.TextBox();
            this.nDataTextBox = new Telerik.Reporting.TextBox();
            this.nH3DataTextBox = new Telerik.Reporting.TextBox();
            this.alkalintyDataTextBox = new Telerik.Reporting.TextBox();
            this.pHDataTextBox = new Telerik.Reporting.TextBox();
            this.algaeDataTextBox = new Telerik.Reporting.TextBox();
            this.remarkDataTextBox = new Telerik.Reporting.TextBox();
            this.userIDDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "HatcheryReportLibrary.Properties.Settings.Hatchery";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ProductionCycleIDParameter", System.Data.DbType.Int32, "= Parameters.ProductionCycleIDParameter.Value")});
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dateCaptionTextBox,
            this.temperatureCaptionTextBox,
            this.salinityCaptionTextBox,
            this.dOCaptionTextBox,
            this.nCaptionTextBox,
            this.nH3CaptionTextBox,
            this.alkalintyCaptionTextBox,
            this.pHCaptionTextBox,
            this.algaeCaptionTextBox,
            this.remarkCaptionTextBox,
            this.userIDCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // temperatureCaptionTextBox
            // 
            this.temperatureCaptionTextBox.CanGrow = true;
            this.temperatureCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.99725604057312012D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.temperatureCaptionTextBox.Name = "temperatureCaptionTextBox";
            this.temperatureCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.temperatureCaptionTextBox.StyleName = "Caption";
            this.temperatureCaptionTextBox.Value = "Temperature";
            // 
            // salinityCaptionTextBox
            // 
            this.salinityCaptionTextBox.CanGrow = true;
            this.salinityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9736787080764771D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.salinityCaptionTextBox.Name = "salinityCaptionTextBox";
            this.salinityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.salinityCaptionTextBox.StyleName = "Caption";
            this.salinityCaptionTextBox.Value = "Salinity";
            // 
            // dOCaptionTextBox
            // 
            this.dOCaptionTextBox.CanGrow = true;
            this.dOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.950101375579834D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dOCaptionTextBox.Name = "dOCaptionTextBox";
            this.dOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dOCaptionTextBox.StyleName = "Caption";
            this.dOCaptionTextBox.Value = "DO";
            // 
            // nCaptionTextBox
            // 
            this.nCaptionTextBox.CanGrow = true;
            this.nCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9265241622924805D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nCaptionTextBox.Name = "nCaptionTextBox";
            this.nCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nCaptionTextBox.StyleName = "Caption";
            this.nCaptionTextBox.Value = "N";
            // 
            // nH3CaptionTextBox
            // 
            this.nH3CaptionTextBox.CanGrow = true;
            this.nH3CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.902946949005127D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nH3CaptionTextBox.Name = "nH3CaptionTextBox";
            this.nH3CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nH3CaptionTextBox.StyleName = "Caption";
            this.nH3CaptionTextBox.Value = "NH3";
            // 
            // alkalintyCaptionTextBox
            // 
            this.alkalintyCaptionTextBox.CanGrow = true;
            this.alkalintyCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8793692588806152D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.alkalintyCaptionTextBox.Name = "alkalintyCaptionTextBox";
            this.alkalintyCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.alkalintyCaptionTextBox.StyleName = "Caption";
            this.alkalintyCaptionTextBox.Value = "Alkalinty";
            // 
            // pHCaptionTextBox
            // 
            this.pHCaptionTextBox.CanGrow = true;
            this.pHCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.8557920455932617D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pHCaptionTextBox.Name = "pHCaptionTextBox";
            this.pHCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pHCaptionTextBox.StyleName = "Caption";
            this.pHCaptionTextBox.Value = "PH";
            // 
            // algaeCaptionTextBox
            // 
            this.algaeCaptionTextBox.CanGrow = true;
            this.algaeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8322148323059082D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.algaeCaptionTextBox.Name = "algaeCaptionTextBox";
            this.algaeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.algaeCaptionTextBox.StyleName = "Caption";
            this.algaeCaptionTextBox.Value = "Algae";
            // 
            // remarkCaptionTextBox
            // 
            this.remarkCaptionTextBox.CanGrow = true;
            this.remarkCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8086376190185547D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.remarkCaptionTextBox.Name = "remarkCaptionTextBox";
            this.remarkCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.remarkCaptionTextBox.StyleName = "Caption";
            this.remarkCaptionTextBox.Value = "Remark";
            // 
            // userIDCaptionTextBox
            // 
            this.userIDCaptionTextBox.CanGrow = true;
            this.userIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.785059928894043D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.userIDCaptionTextBox.Name = "userIDCaptionTextBox";
            this.userIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.userIDCaptionTextBox.StyleName = "Caption";
            this.userIDCaptionTextBox.Value = "user ID";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.temperatureSumFunctionTextBox,
            this.salinitySumFunctionTextBox,
            this.dOSumFunctionTextBox,
            this.nSumFunctionTextBox,
            this.nH3SumFunctionTextBox,
            this.alkalintySumFunctionTextBox,
            this.pHSumFunctionTextBox});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Grand total:";
            // 
            // temperatureSumFunctionTextBox
            // 
            this.temperatureSumFunctionTextBox.CanGrow = true;
            this.temperatureSumFunctionTextBox.Format = "{0:N0}";
            this.temperatureSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.99725604057312012D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.temperatureSumFunctionTextBox.Name = "temperatureSumFunctionTextBox";
            this.temperatureSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.temperatureSumFunctionTextBox.StyleName = "Data";
            this.temperatureSumFunctionTextBox.Value = "= AVG(Fields.Temperature)";
            // 
            // salinitySumFunctionTextBox
            // 
            this.salinitySumFunctionTextBox.CanGrow = true;
            this.salinitySumFunctionTextBox.Format = "{0:N0}";
            this.salinitySumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9736787080764771D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.salinitySumFunctionTextBox.Name = "salinitySumFunctionTextBox";
            this.salinitySumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.salinitySumFunctionTextBox.StyleName = "Data";
            this.salinitySumFunctionTextBox.Value = "= AVG(Fields.Salinity)";
            // 
            // dOSumFunctionTextBox
            // 
            this.dOSumFunctionTextBox.CanGrow = true;
            this.dOSumFunctionTextBox.Format = "{0:N0}";
            this.dOSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.950101375579834D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dOSumFunctionTextBox.Name = "dOSumFunctionTextBox";
            this.dOSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dOSumFunctionTextBox.StyleName = "Data";
            this.dOSumFunctionTextBox.Value = "= AVG(Fields.DO)";
            // 
            // nSumFunctionTextBox
            // 
            this.nSumFunctionTextBox.CanGrow = true;
            this.nSumFunctionTextBox.Format = "{0:N0}";
            this.nSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9265241622924805D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nSumFunctionTextBox.Name = "nSumFunctionTextBox";
            this.nSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nSumFunctionTextBox.StyleName = "Data";
            this.nSumFunctionTextBox.Value = "= AVG(Fields.N)";
            // 
            // nH3SumFunctionTextBox
            // 
            this.nH3SumFunctionTextBox.CanGrow = true;
            this.nH3SumFunctionTextBox.Format = "{0:N0}";
            this.nH3SumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.902946949005127D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nH3SumFunctionTextBox.Name = "nH3SumFunctionTextBox";
            this.nH3SumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nH3SumFunctionTextBox.StyleName = "Data";
            this.nH3SumFunctionTextBox.Value = "= AVG(Fields.NH3)";
            // 
            // alkalintySumFunctionTextBox
            // 
            this.alkalintySumFunctionTextBox.CanGrow = true;
            this.alkalintySumFunctionTextBox.Format = "{0:N0}";
            this.alkalintySumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8793692588806152D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.alkalintySumFunctionTextBox.Name = "alkalintySumFunctionTextBox";
            this.alkalintySumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.alkalintySumFunctionTextBox.StyleName = "Data";
            this.alkalintySumFunctionTextBox.Value = "= AVG(Fields.Alkalinty)";
            // 
            // pHSumFunctionTextBox
            // 
            this.pHSumFunctionTextBox.CanGrow = true;
            this.pHSumFunctionTextBox.Format = "{0:N0}";
            this.pHSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.8557920455932617D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pHSumFunctionTextBox.Name = "pHSumFunctionTextBox";
            this.pHSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pHSumFunctionTextBox.StyleName = "Data";
            this.pHSumFunctionTextBox.Value = "= AVG(Fields.PH)";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3494915962219238D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3911581039428711D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3494915962219238D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.761483192443848D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Water Parameter PL";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dateDataTextBox,
            this.temperatureDataTextBox,
            this.salinityDataTextBox,
            this.dODataTextBox,
            this.nDataTextBox,
            this.nH3DataTextBox,
            this.alkalintyDataTextBox,
            this.pHDataTextBox,
            this.algaeDataTextBox,
            this.remarkDataTextBox,
            this.userIDDataTextBox});
            this.detail.Name = "detail";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "= Fields.Date";
            // 
            // temperatureDataTextBox
            // 
            this.temperatureDataTextBox.CanGrow = true;
            this.temperatureDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.99725604057312012D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.temperatureDataTextBox.Name = "temperatureDataTextBox";
            this.temperatureDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.temperatureDataTextBox.StyleName = "Data";
            this.temperatureDataTextBox.Value = "= Fields.Temperature";
            // 
            // salinityDataTextBox
            // 
            this.salinityDataTextBox.CanGrow = true;
            this.salinityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9736787080764771D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.salinityDataTextBox.Name = "salinityDataTextBox";
            this.salinityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.salinityDataTextBox.StyleName = "Data";
            this.salinityDataTextBox.Value = "= Fields.Salinity";
            // 
            // dODataTextBox
            // 
            this.dODataTextBox.CanGrow = true;
            this.dODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.950101375579834D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dODataTextBox.Name = "dODataTextBox";
            this.dODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dODataTextBox.StyleName = "Data";
            this.dODataTextBox.Value = "= Fields.DO";
            // 
            // nDataTextBox
            // 
            this.nDataTextBox.CanGrow = true;
            this.nDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9265241622924805D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nDataTextBox.Name = "nDataTextBox";
            this.nDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nDataTextBox.StyleName = "Data";
            this.nDataTextBox.Value = "= Fields.N";
            // 
            // nH3DataTextBox
            // 
            this.nH3DataTextBox.CanGrow = true;
            this.nH3DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.902946949005127D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nH3DataTextBox.Name = "nH3DataTextBox";
            this.nH3DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nH3DataTextBox.StyleName = "Data";
            this.nH3DataTextBox.Value = "= Fields.NH3";
            // 
            // alkalintyDataTextBox
            // 
            this.alkalintyDataTextBox.CanGrow = true;
            this.alkalintyDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8793692588806152D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.alkalintyDataTextBox.Name = "alkalintyDataTextBox";
            this.alkalintyDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.alkalintyDataTextBox.StyleName = "Data";
            this.alkalintyDataTextBox.Value = "= Fields.Alkalinty";
            // 
            // pHDataTextBox
            // 
            this.pHDataTextBox.CanGrow = true;
            this.pHDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.8557920455932617D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pHDataTextBox.Name = "pHDataTextBox";
            this.pHDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pHDataTextBox.StyleName = "Data";
            this.pHDataTextBox.Value = "= Fields.PH";
            // 
            // algaeDataTextBox
            // 
            this.algaeDataTextBox.CanGrow = true;
            this.algaeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8322148323059082D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.algaeDataTextBox.Name = "algaeDataTextBox";
            this.algaeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.algaeDataTextBox.StyleName = "Data";
            this.algaeDataTextBox.Value = "= Fields.Algae";
            // 
            // remarkDataTextBox
            // 
            this.remarkDataTextBox.CanGrow = true;
            this.remarkDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8086376190185547D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.remarkDataTextBox.Name = "remarkDataTextBox";
            this.remarkDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.remarkDataTextBox.StyleName = "Data";
            this.remarkDataTextBox.Value = "= Fields.Remark";
            // 
            // userIDDataTextBox
            // 
            this.userIDDataTextBox.CanGrow = true;
            this.userIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.785059928894043D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.userIDDataTextBox.Name = "userIDDataTextBox";
            this.userIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.95558935403823853D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.userIDDataTextBox.StyleName = "Data";
            this.userIDDataTextBox.Value = "= Fields.userID";
            // 
            // PLWaterParameter
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.reportFooter,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "PLWaterParameter";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.25D), Telerik.Reporting.Drawing.Unit.Cm(0.25D), Telerik.Reporting.Drawing.Unit.Cm(0.25D), Telerik.Reporting.Drawing.Unit.Cm(0.25D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "ProductionCycleIDParameter";
            reportParameter1.Text = "ProductionCycleIDParameter";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule2.Style.Font.Name = "Calibri";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            styleRule3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule3.Style.Font.Name = "Calibri";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule4.Style.Font.Name = "Calibri";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule5.Style.Font.Name = "Calibri";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(10.761483192443848D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox temperatureCaptionTextBox;
        private Telerik.Reporting.TextBox salinityCaptionTextBox;
        private Telerik.Reporting.TextBox dOCaptionTextBox;
        private Telerik.Reporting.TextBox nCaptionTextBox;
        private Telerik.Reporting.TextBox nH3CaptionTextBox;
        private Telerik.Reporting.TextBox alkalintyCaptionTextBox;
        private Telerik.Reporting.TextBox pHCaptionTextBox;
        private Telerik.Reporting.TextBox algaeCaptionTextBox;
        private Telerik.Reporting.TextBox remarkCaptionTextBox;
        private Telerik.Reporting.TextBox userIDCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox temperatureSumFunctionTextBox;
        private Telerik.Reporting.TextBox salinitySumFunctionTextBox;
        private Telerik.Reporting.TextBox dOSumFunctionTextBox;
        private Telerik.Reporting.TextBox nSumFunctionTextBox;
        private Telerik.Reporting.TextBox nH3SumFunctionTextBox;
        private Telerik.Reporting.TextBox alkalintySumFunctionTextBox;
        private Telerik.Reporting.TextBox pHSumFunctionTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.TextBox temperatureDataTextBox;
        private Telerik.Reporting.TextBox salinityDataTextBox;
        private Telerik.Reporting.TextBox dODataTextBox;
        private Telerik.Reporting.TextBox nDataTextBox;
        private Telerik.Reporting.TextBox nH3DataTextBox;
        private Telerik.Reporting.TextBox alkalintyDataTextBox;
        private Telerik.Reporting.TextBox pHDataTextBox;
        private Telerik.Reporting.TextBox algaeDataTextBox;
        private Telerik.Reporting.TextBox remarkDataTextBox;
        private Telerik.Reporting.TextBox userIDDataTextBox;

    }
}