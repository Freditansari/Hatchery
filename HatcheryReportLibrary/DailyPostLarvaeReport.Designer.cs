namespace HatcheryReportLibrary
{
    partial class DailyPostLarvaeReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group3 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.moduleNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.productionCycleIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.activityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.stageCaptionTextBox = new Telerik.Reporting.TextBox();
            this.populationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.survivalRateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.remarkCaptionTextBox = new Telerik.Reporting.TextBox();
            this.moduleNameGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.moduleNameGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.productionCycleIDGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.productionCycleIDGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.activityDataTextBox = new Telerik.Reporting.TextBox();
            this.stageDataTextBox = new Telerik.Reporting.TextBox();
            this.populationDataTextBox = new Telerik.Reporting.TextBox();
            this.survivalRateDataTextBox = new Telerik.Reporting.TextBox();
            this.remarkDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "HatcheryReportLibrary.Properties.Settings.Hatchery";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "SELECT        ModuleName, ProductionCycleID, Date, DOC, Stage, Population, Surviv" +
    "alRate, Activity, Length, Remark\r\nFROM            DailyPostLarvaeHealthReport";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.moduleNameCaptionTextBox,
            this.productionCycleIDCaptionTextBox,
            this.dateCaptionTextBox,
            this.activityCaptionTextBox,
            this.stageCaptionTextBox,
            this.populationCaptionTextBox,
            this.survivalRateCaptionTextBox,
            this.remarkCaptionTextBox,
            this.textBox3});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // moduleNameCaptionTextBox
            // 
            this.moduleNameCaptionTextBox.CanGrow = true;
            this.moduleNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.moduleNameCaptionTextBox.Name = "moduleNameCaptionTextBox";
            this.moduleNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.moduleNameCaptionTextBox.StyleName = "Caption";
            this.moduleNameCaptionTextBox.Value = "Module Name";
            // 
            // productionCycleIDCaptionTextBox
            // 
            this.productionCycleIDCaptionTextBox.CanGrow = true;
            this.productionCycleIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDCaptionTextBox.Name = "productionCycleIDCaptionTextBox";
            this.productionCycleIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.productionCycleIDCaptionTextBox.StyleName = "Caption";
            this.productionCycleIDCaptionTextBox.Value = "PID";
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0697917938232422D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // activityCaptionTextBox
            // 
            this.activityCaptionTextBox.CanGrow = true;
            this.activityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8000001907348633D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.activityCaptionTextBox.Name = "activityCaptionTextBox";
            this.activityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.activityCaptionTextBox.StyleName = "Caption";
            this.activityCaptionTextBox.Value = "Activity";
            // 
            // stageCaptionTextBox
            // 
            this.stageCaptionTextBox.CanGrow = true;
            this.stageCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.stageCaptionTextBox.Name = "stageCaptionTextBox";
            this.stageCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stageCaptionTextBox.StyleName = "Caption";
            this.stageCaptionTextBox.Value = "Stage";
            // 
            // populationCaptionTextBox
            // 
            this.populationCaptionTextBox.CanGrow = true;
            this.populationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9395833015441895D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.populationCaptionTextBox.Name = "populationCaptionTextBox";
            this.populationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.98385429382324219D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.populationCaptionTextBox.StyleName = "Caption";
            this.populationCaptionTextBox.Value = "Population";
            // 
            // survivalRateCaptionTextBox
            // 
            this.survivalRateCaptionTextBox.CanGrow = true;
            this.survivalRateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9427108764648438D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.survivalRateCaptionTextBox.Name = "survivalRateCaptionTextBox";
            this.survivalRateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.survivalRateCaptionTextBox.StyleName = "Caption";
            this.survivalRateCaptionTextBox.Value = "SR";
            // 
            // remarkCaptionTextBox
            // 
            this.remarkCaptionTextBox.CanGrow = true;
            this.remarkCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7729172706604D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.remarkCaptionTextBox.Name = "remarkCaptionTextBox";
            this.remarkCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9838536977767944D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.remarkCaptionTextBox.StyleName = "Caption";
            this.remarkCaptionTextBox.Value = "Remark";
            // 
            // moduleNameGroupHeaderSection
            // 
            this.moduleNameGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.moduleNameGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
            this.moduleNameGroupHeaderSection.Name = "moduleNameGroupHeaderSection";
            // 
            // moduleNameGroupFooterSection
            // 
            this.moduleNameGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.moduleNameGroupFooterSection.Name = "moduleNameGroupFooterSection";
            // 
            // productionCycleIDGroupHeaderSection
            // 
            this.productionCycleIDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.productionCycleIDGroupHeaderSection.Name = "productionCycleIDGroupHeaderSection";
            // 
            // productionCycleIDGroupFooterSection
            // 
            this.productionCycleIDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.productionCycleIDGroupFooterSection.Name = "productionCycleIDGroupFooterSection";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "= Fields.ModuleName";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.ProductionCycleID";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.pageHeader.Name = "pageHeader";
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
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7020440101623535D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.84791678190231323D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.34791666269302368D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "PL Reports";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dateDataTextBox,
            this.activityDataTextBox,
            this.stageDataTextBox,
            this.populationDataTextBox,
            this.survivalRateDataTextBox,
            this.remarkDataTextBox,
            this.textBox4});
            this.detail.Name = "detail";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Format = "{0:dd/MM/yy}";
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0697917938232422D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "= Fields.Date";
            // 
            // activityDataTextBox
            // 
            this.activityDataTextBox.CanGrow = true;
            this.activityDataTextBox.Format = "{0:N0}";
            this.activityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8000001907348633D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.activityDataTextBox.Name = "activityDataTextBox";
            this.activityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.activityDataTextBox.StyleName = "Data";
            this.activityDataTextBox.Value = "= Fields.Activity";
            // 
            // stageDataTextBox
            // 
            this.stageDataTextBox.CanGrow = true;
            this.stageDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.stageDataTextBox.Name = "stageDataTextBox";
            this.stageDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999967217445374D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stageDataTextBox.StyleName = "Data";
            this.stageDataTextBox.Value = "= Fields.Stage";
            // 
            // populationDataTextBox
            // 
            this.populationDataTextBox.CanGrow = true;
            this.populationDataTextBox.Format = "{0:N0}";
            this.populationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9395833015441895D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.populationDataTextBox.Name = "populationDataTextBox";
            this.populationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.98385429382324219D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.populationDataTextBox.StyleName = "Data";
            this.populationDataTextBox.Value = "= Fields.Population";
            // 
            // survivalRateDataTextBox
            // 
            this.survivalRateDataTextBox.CanGrow = true;
            this.survivalRateDataTextBox.Format = "{0:P0}";
            this.survivalRateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9427108764648438D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.survivalRateDataTextBox.Name = "survivalRateDataTextBox";
            this.survivalRateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.survivalRateDataTextBox.StyleName = "Data";
            this.survivalRateDataTextBox.Value = "= Fields.SurvivalRate";
            // 
            // remarkDataTextBox
            // 
            this.remarkDataTextBox.CanGrow = true;
            this.remarkDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7729172706604D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.remarkDataTextBox.Name = "remarkDataTextBox";
            this.remarkDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9838536977767944D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.remarkDataTextBox.StyleName = "Data";
            this.remarkDataTextBox.Value = "= Fields.Remark";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1156249046325684D), Telerik.Reporting.Drawing.Unit.Inch(0.023041406646370888D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80007904767990112D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.textBox3.Style.Font.Bold = false;
            this.textBox3.Style.Font.Name = "Tahoma";
            this.textBox3.Value = "Length";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1156253814697266D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80007904767990112D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.textBox4.Value = "= Fields.Length";
            // 
            // DailyPostLarvaeReport
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.moduleNameGroupFooterSection;
            group2.GroupHeader = this.moduleNameGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.ModuleName"));
            group2.Name = "moduleNameGroup";
            group3.GroupFooter = this.productionCycleIDGroupFooterSection;
            group3.GroupHeader = this.productionCycleIDGroupHeaderSection;
            group3.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.ProductionCycleID"));
            group3.Name = "productionCycleIDGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2,
            group3});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.moduleNameGroupHeaderSection,
            this.moduleNameGroupFooterSection,
            this.productionCycleIDGroupHeaderSection,
            this.productionCycleIDGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "DailyPostLarvaeReport";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Italic = false;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Style.Font.Strikeout = false;
            styleRule2.Style.Font.Underline = false;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(8.90000057220459D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox moduleNameCaptionTextBox;
        private Telerik.Reporting.TextBox productionCycleIDCaptionTextBox;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox activityCaptionTextBox;
        private Telerik.Reporting.TextBox stageCaptionTextBox;
        private Telerik.Reporting.TextBox populationCaptionTextBox;
        private Telerik.Reporting.TextBox survivalRateCaptionTextBox;
        private Telerik.Reporting.TextBox remarkCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection moduleNameGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection moduleNameGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection productionCycleIDGroupHeaderSection;
        private Telerik.Reporting.GroupFooterSection productionCycleIDGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.TextBox activityDataTextBox;
        private Telerik.Reporting.TextBox stageDataTextBox;
        private Telerik.Reporting.TextBox populationDataTextBox;
        private Telerik.Reporting.TextBox survivalRateDataTextBox;
        private Telerik.Reporting.TextBox remarkDataTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;

    }
}