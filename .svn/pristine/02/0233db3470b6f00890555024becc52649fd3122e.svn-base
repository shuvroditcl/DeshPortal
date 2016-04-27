using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeshExpressPortal
{
    public partial class SitePopUp : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Utlities u = new Utlities();
            u.RefreshLogTemp(HttpContext.Current.User.Identity.Name);
//            string chat =
//                   u.GetStringValue("SELECT top 1 ChatText FROM [dbo].[ChatRoom] where ReadBy like '%" +
//                                 HttpContext.Current.User.Identity.Name + "%' order by Id desc");
//            if (chat.Length > 0)
//                lbchat.Text = @"<div id=""frameContainer"" style=""overflow: hidden; width: 280px; height: 45px;  margin-top: -40px;"">
//             <iframe src=""../Utilities/ChatContain.aspx"" scrolling=no style=""width: 280px; height: 60px;margin-left:0px; margin-top: -16px; padding-left: 0px;border-left-width: 0px; border-right-width: 0px;""></iframe>
//               </div>";
            //else
            //{
            //    lbchat.Text = "";
            //}
            // PageAccess();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }


        //public void PageAccess()
        //{
        //    Utlities u = new Utlities();
        //    //if (HttpContext.Current.Request.Url.AbsolutePath.Contains("AccSiteMasterEntryPage"))
        //    //    return;
        //    if (HttpContext.Current.Request.Url.AbsolutePath.Contains("SiteMasterEntrypage"))
        //        return;
        //    if (HttpContext.Current.Request.Url.AbsolutePath.Contains("EmpHier"))
        //        return;
        //    var empusername = HttpContext.Current.User.Identity.Name;

        //    var roleid = u.GetIntValue("select RoleId from AppUser where UserName='" + empusername + "'");

        //    DataTable loadPage =
        //        u.ReturnTable(
        //            "Select PagePath from HR_PayPageObjects a join HR_PayPageObjectRoles b on a.PageObjectId=b.PageObjectId where b.RoleId=" +
        //            roleid);
        //    var count = loadPage.Rows.Count;

        //    var matcheddata = 0;
        //    for (var i = 0; i < count; i++)
        //    {
        //        if (Request.Url.ToString().ToLower().Contains(loadPage.Rows[i]["PagePath"].ToString().Trim().ToLower()))
        //        {
        //            matcheddata = matcheddata + 1;
        //        }
        //    }
        //    if (matcheddata > 0)
        //    {
        //    }
        //    else
        //    {
        //        Show("You do not have access permission!!!");
        //        Response.Redirect("../HomeUI.aspx");
        //    }
        //}


        public static void Show(string message)
        {
            var page = HttpContext.Current.Handler as Page;
            if (page != null)
            {
                message = message.Replace("'", "\'");
                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + message + "');", true);
            }
        }

        protected void LoginStatus_LoggedOut(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            var ticket1 = new FormsAuthenticationTicket("", true, 0);
            var hash1 = FormsAuthentication.Encrypt(ticket1);
            var cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, hash1);
            cookie1.Expires = DateTime.Now.AddMinutes(0);

            if (ticket1.IsPersistent)
                cookie1.Expires = ticket1.Expiration;

            Response.Cookies.Add(cookie1);
            Utlities u = new Utlities();
            u.LogoutUser(HttpContext.Current.User.Identity.Name);
        }
    }
}