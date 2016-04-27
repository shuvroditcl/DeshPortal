using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeshExpressPortal
{
    public partial class SiteMasterEntrypage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    Set_Title();
            //this.Title = "Policy";
            MenuLoad();
        }

        public void MenuLoad()
        {
            var s = Request.QueryString["q"];
            if (s == "1")
            {
                this.Title = "DeshExpress";
                //Title = "SLICL: Policy";
                PnlPolicy.Visible = true;
            }
            else if (s == "2")
            {
                this.Title = "UnderWriting";
                //Title = "SLICL: UnderWriting";
                PnlUnderWriting.Visible = true;
            }
            else if (s == "3")
            {
               this.Title = "Accounts";
               // Title = "SLICL: Accounts";
                Pnlaccount.Visible = true;
                Response.Redirect("AccSiteMasterEntryPage.aspx");
            }
            else if (s == "4")
            {
                this.Title = "HRPayRoll";
                //Title = "SLICL: HRPayRoll";
                PnlHr.Visible = true;
            }
            else if (s == "5")
            {
                this.Title = "Agency";
                //Title = "SLICL: Agency";
                PnlAgencey.Visible = true;
            }
            else if (s == "6")
            {
                this.Title = "Payments";
                //Title = "SLICL: Payments";
                PnlPayments.Visible = true;
            }
            else if (s == "7")
            {
                this.Title = "AgentCom";
                //Title = "SLICL: AgentCom";
                PnlAgentCom.Visible = true;
            }
            else if (s == "8")
            {
                this.Title = "mis";
                //Title = "SLICL: mis";
                PnlMis.Visible = true;
            }
            else if (s == "9")
            {
                this.Title = "polServ";
                //Title = "SLICL: polServ";
                PnlPolServ.Visible = true;
            }
            else if (s == "10")
            {
                this.Title = "Utilities";
                //Title = "SLICL: utilities";
                PnlUtilities.Visible = true;
            }
            else if (s == "11")
            {
                this.Title = "claim";
                //Title = "SLICL: claim";
                PnlClaim.Visible = true;
            }
            else if (s == "12")
            {
                this.Title = "chat";
                //Title = "SLICL: chat";
                PnlChat.Visible = true;
            }
            else if (s == "13")
            {
                this.Title = "Approval";
                //Title = "SLICL: Approval";
                PnlApproval.Visible = true;
            }
            else if (s == "14")
            {
                this.Title = "AssetManagement";
                //Title = "SLICL: AssetManagement";
                PnlAssetManagement.Visible = true;
            }
            else if (s == "15")
            {
                this.Title = "Reinsurance";
                //Title = "SLICL: Reinsurance";
                PnlReInsurance.Visible = true;
            }
            else if (s == "16")
            {
                this.Title = "Expenses";
                //Title = "SLICL: Expenses";
                PnlExpenses.Visible = true;
            }
            else if (s == "17")
            {
                this.Title = "userActivity";
                //Title = "SLICL: userActivity";
                PnlUserActivity.Visible = true;
            }
            else if (s == "18")
            {
                this.Title = "groupPolicy";
                //Title = "SLICL: groupPolicy";
                PnlGrpPol.Visible = true;
            }
            else if (s == "19")
            {
                this.Title = "Investment";
                //Title = "SLICL: Investment";
                pnlInvestment.Visible = true;
            }
            else if (s == "20")
            {
                this.Title = "Attendance";
                //Title = "SLICL: Attendance";
                PnlCardMg.Visible = true;
            }
            else if (s == "21")
            {
                this.Title = "MaturityClaim";
                //Title = "SLICL: MaturityClaim";
                PnlMaturityClaim.Visible = true;
            }
            else if (s == "22")
            {
                this.Title = "PageAccess";
                //Title = "SLICL: PageAccess";
                PnlPageAccess.Visible = true;
            }
            else if (s == "23")
            {
                this.Title = "Training";
                //Title = "SLICL: Training";
                PnlTraning.Visible = true;
            }
            else if (s == "24")
            {
                this.Title = "Loan";
                PnlLoan.Visible = true;
            }

        }
        //protected void Set_Title()
        //{
        //    String s = Request.QueryString["q"];

        //    switch (int.Parse(s))
        //    {
        //        case 1:
        //            this.Title = "Policy";
        //            break;
        //        case 2:
        //            this.Title = "UnderWriting";
        //            break;
        //        case 3:
        //            this.Title = "Accounts";
        //            break;
        //        case 4:
        //            this.Title = "HR";
        //            break;
        //        case 5:
        //            this.Title = "Agency";
        //            break;
        //    }
        //}
    }
}