using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeshExpressPortal
{
    public partial class HomeUI : System.Web.UI.Page
    {
        Utlities u = new Utlities();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "Imperial";
        }

        private void UserCheck()
        {
            if (u.GetIntValue("select isnull(count(*),0) from appuser where username='" + HttpContext.Current.User.Identity.Name + "'") < 1)
            {
                LoginStatus_LoggedOut(null, null);
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