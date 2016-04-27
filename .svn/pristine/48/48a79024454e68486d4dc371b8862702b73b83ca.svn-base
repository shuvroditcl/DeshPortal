using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeshExpressPortal.Utilities
{
    public partial class UserManagement : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Utilities : User Management";
            if (!IsPostBack)
            {
                loadRepeater();
            }
        }

        Utlities u = new Utlities();
        public static void Show(string message)
        {
            Page page = HttpContext.Current.Handler as Page;
            if (page != null)
            {
                message = message.Replace("'", "\'");
                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + message + "');", true);
            }
        }
        private void loadRepeater()
        {
            var proc = "Select Id,UserName,Password from AppUser ";

            var dt = new DataTable();
            dt = u.ReturnTable(proc);

            var objPds = new PagedDataSource();
            var objDataView = new DataView(dt);
            objPds.DataSource = objDataView;

            objPds.AllowPaging = true;
            objPds.PageSize = 10;
            int CurPage;
            if (Request.QueryString["Page"] != null)
                CurPage = Convert.ToInt32(Request.QueryString["Page"]);
            else
                CurPage = 1;

            objPds.CurrentPageIndex = CurPage - 1;
            lblCurrentPage.Text = "Page: " + CurPage.ToString();

            if (!objPds.IsFirstPage)
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath
                + "?Page=" + Convert.ToString(CurPage - 1);

            if (!objPds.IsLastPage)
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath
                + "?Page=" + Convert.ToString(CurPage + 1);

            RptData.DataSource = objPds;
            RptData.DataBind();
        }

        protected void btn_Create_Click(object sender, EventArgs e)
        {
            pnlCnSButton.Visible = false;
            pnlRepeater.Visible = false;
            pnlCreate.Visible = true;

            txtUserName.Text = "";
            txtPassword.Text = "";
           
        }
        protected void btnCancelNew_Click(object sender, EventArgs e)
        {
            pnlCreate.Visible = false;
            btnSave.Text = "Save";
            pnlRepeater.Visible = true;
            pnlCnSButton.Visible = true;

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                string query = @"DECLARE @dbccVal INT = (SELECT COUNT(*) FROM AppUser)
	IF (@dbccVal != 0) SET @dbccVal = (SELECT TOP 1 Id FROM AppUser ORDER BY Id DESC)
    Else SET @dbccVal =1
	DBCC CHECKIDENT('AppUser', RESEED, @dbccVal)
insert into AppUser ( UserName,Password,TypeName,ComFlag,UpdateCardBy,UpdateCardDate) VALUES ('" + txtUserName.Text + "','" + txtPassword.Text + "','Admin','','" + HttpContext.Current.User.Identity.Name + "',getdate())";
                if (u.CommonSqlExecutionBool(query))
                {
                    Show("Data inserted successfully");
                    loadRepeater();
                    btnCancelNew_Click(null, null);
                }
            }
            if (btnSave.Text == "Update")
            {
                string query = "Update AppUser set UserName='" + txtUserName.Text + "',Password='" + txtPassword.Text + "',UpdateCardBy='" + HttpContext.Current.User.Identity.Name + "',UpdateCardDate=getdate() where Id='" + ViewState["Id"] + "'";
                if (u.CommonSqlExecutionBool(query))
                {
                    Show("Data Update successfully");
                    loadRepeater();
                    btnCancelNew_Click(null, null);
                }
            }
        }
        protected void LinkButton_btndelete(object sender, CommandEventArgs e)
        {
            string sl = e.CommandArgument.ToString();

            if (u.CommonSqlExecutionBool("Delete AppUser Where Id='" + sl + "'"))
            {

                Show("Deleted successfully");
                loadRepeater();
            }

        }
        protected void LinkButton_Command_Basic(object sender, CommandEventArgs e)
        {
            string sl = e.CommandArgument.ToString();
            ViewState["Id"] = sl;
            pnlCnSButton.Visible = false;
            pnlRepeater.Visible = false;
            pnlCreate.Visible = true;
            btnSave.Text = "Update";

            DataTable dtedit =
                u.ReturnTable("Select UserName,Password,TypeName,ComFlag,UpdateCardBy,UpdateCardDate from AppUser Where Id='" + sl + "'");
            foreach (DataRow row in dtedit.Rows)
            {

                txtUserName.Text = row["UserName"].ToString();
                txtPassword.Text = row["Password"].ToString();
               
            }
        }
    }
}