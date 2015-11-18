using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hatchery
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatePicker.SelectedDate = DateTime.Now;
            TxtUserID.Text = User.Identity.Name.ToString();
         
        }

   

        protected void BtnAddRecord_Click(object sender, EventArgs e)
        {
            //todo insert to database
            Page.Validate();
            if (Page.IsValid)
            {
                HatcheryEntities db = new HatcheryEntities();
                DailyMonitoringPostLarva newMonitor = new DailyMonitoringPostLarva();
                newMonitor.ModuleName = DdlModuleName.SelectedValue;
                newMonitor.ProductionCycleID = Convert.ToInt32( DdlProductionCycleID.SelectedValue);
                newMonitor.Date = DatePicker.SelectedDate;
                newMonitor.DOC = Convert.ToInt32( TxtDoc.Text);
                newMonitor.Stage = StageDDL.SelectedValue;
                newMonitor.Population = Convert.ToInt32(TxtPopulation.Text);
                newMonitor.BiosZ = Convert.ToDouble(TxtBiosZ.Text);
                newMonitor.BiosM = Convert.ToDouble(TxtBiosM.Text);
                newMonitor.Bios100 = Convert.ToDouble(TxtBios100.Text);
                newMonitor.Bios150 = Convert.ToDouble(TxtBios150.Text);
                newMonitor.LanzyPL = Convert.ToDouble(TxtLanzyPL.Text);
                newMonitor.LanzyMPL = Convert.ToDouble(TxtLanzyMPL.Text);
                newMonitor.LanzyZM = Convert.ToDouble(TxtLanzyZM.Text);
                newMonitor.MPZ = Convert.ToDouble(TxtMpz.Text);
                newMonitor.MP1 = Convert.ToDouble(TxtMp1.Text);
                newMonitor.MP2 = Convert.ToDouble(TxtMp2.Text);
                newMonitor.MP3 = Convert.ToDouble(TxtMp3.Text);
                newMonitor.MPL = Convert.ToDouble(TxtMpl.Text);
                newMonitor.Spirulina = Convert.ToDouble(TxtSpirulina.Text);
                newMonitor.LHF = Convert.ToDouble(TxtLhf.Text);
                newMonitor.RoySF100_200 = Convert.ToDouble(TxtRoySF100_200.Text);
                newMonitor.RoySF200_300 = Convert.ToDouble(TxtRoySF200_300.Text);
                newMonitor.TzuFeng = Convert.ToDouble(TxtTzuFeng.Text);
                newMonitor.Artemia = Convert.ToDouble(TxtArtemia.Text);
                newMonitor.ArtemiaEZ1 = Convert.ToDouble(TxtArtemiaEZ1.Text);
                newMonitor.ArtemiaEZ2 = Convert.ToDouble(TxtArtemiaEZ2.Text);
                newMonitor.Activity = Convert.ToDouble(TxtActivity.Text);
                newMonitor.Length = Convert.ToDouble(TxtLength.Text);
                newMonitor.STDEV = Convert.ToDouble(TxtStdev.Text);
                newMonitor.FGC = Convert.ToDouble(TxtFgc.Text);
                newMonitor.Necrosis = Convert.ToDouble(TxtNecrosis.Text);
                newMonitor.Fouling = Convert.ToDouble(TxtFouling.Text);
                newMonitor.Parasite = Convert.ToDouble(TxtParasite.Text);
                newMonitor.MGR = Convert.ToDouble(TxtMgr.Text);
                newMonitor.Treflan = Convert.ToDouble(TxtTreflan.Text);
                newMonitor.Probiotik = Convert.ToDouble(TxtProbiotik.Text);
                newMonitor.Remark = TxtRemark.Text;
                newMonitor.userID = TxtUserID.Text;

                db.DailyMonitoringPostLarvas.Add(newMonitor);
                db.SaveChanges();



            }


        }

        protected void BtnUpdateRecord_Click(object sender, EventArgs e)
        {

        }

        protected void DdlProductionCycleID_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void DdlModuleName_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  calculateDOC();
        }

        protected void DatePicker_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
        {

            calculateDOC();
        
        }

        protected void calculateDOC()
        {
            TimeSpan DOC = DateTime.Parse(DatePicker.SelectedDate.ToString()) - DateTime.Parse(StartDateDDL.SelectedValue);
            TxtDoc.Text = DOC.TotalDays.ToString();
        }

        protected void StartDateDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDOC();
        }

        protected void StartDateDDL_DataBound(object sender, EventArgs e)
        {
            try
            {
                calculateDOC();
            }
            catch (Exception)
            {


            }
        }
    }
}