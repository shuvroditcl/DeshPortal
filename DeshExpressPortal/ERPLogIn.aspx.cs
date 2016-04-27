using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeshExpressPortal
{
    public partial class ERPLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                Utlities u = new Utlities();
                List<string[]> parameters = new List<string[]>();
                parameters.Add(new string[] { "user", txtusername.Text });
                parameters.Add(new string[] { "pass", txtuserpass.Text });
                DataTable DTOU = u.ReturnTableWithParameter("select [UserName],[Password],'Admin' as TypeName from AppUser where [UserName]=@user And [Password]=@pass", parameters);



                if (DTOU.Rows.Count > 0)
                {
                    if (DTOU.Rows[0]["UserName"].ToString() == txtusername.Text && DTOU.Rows[0]["Password"].ToString() == txtuserpass.Text)
                    {
                        var EXPIRETIMELIMIT = Convert.ToDouble(ConfigurationManager.AppSettings["EXPIRETIMELIMIT"]);

                        FormsAuthentication.Initialize();
                        FormsAuthentication.HashPasswordForStoringInConfigFile(txtuserpass.Text.ToString(), "md5");
                        string ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                        if (string.IsNullOrEmpty(ip))
                        {
                            ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                        }
                        var roles = new StringBuilder();

                        //string logip = u.SaveLogin(txtusername.Text, ip, DTOU.Rows[0]["TypeName"].ToString());
                        //if (logip != "")
                        //{
                        //    string message = "Already Login " + txtusername.Text + " From " + logip;
                        //    var page = HttpContext.Current.Handler as Page;
                        //    if (page != null)
                        //    {
                        //        message = message.Replace("'", "\'");
                        //        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg",
                        //            "alert('" + message + "');", true);
                        //    }
                        //    return;
                        //}
                        //for (var i = 0; i < DTOU.Rows.Count; i++)
                        //{
                        //    roles.Append(DTOU.Rows[i]["RoleName"].ToString());
                        //}

                        var ticket = new FormsAuthenticationTicket(1, txtusername.Text.ToString(), DateTime.Now,
                            DateTime.Now.AddMinutes(EXPIRETIMELIMIT), true, roles.ToString(),
                            FormsAuthentication.FormsCookiePath);

                        var hash = FormsAuthentication.Encrypt(ticket);
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
                        /*We have to set the cookie expire time manually,its not working which we set in the parameter  of the FormsAuthenticationTicket's constructor .*/
                        cookie.Expires = DateTime.Now.AddMinutes(EXPIRETIMELIMIT);

                        if (ticket.IsPersistent)
                            cookie.Expires = ticket.Expiration;

                        Response.Cookies.Add(cookie);

                        //                        DateTime bdate = new DateTime();
                        //                        if (DTOU.Rows[0]["Emp_Job_Type"].ToString() == "Emp")
                        //                        {
                        //                            bdate = Convert.ToDateTime(u.GetStringValue(@"select  dob from  PayEmployeesBasicInfoes
                        //                         a join PayEmployeeJobDetails b on  a.EmpId=b.EmpId where b.UserName='" + txtusername.Text + "'"));
                        //                        }
                        //                        else
                        //                        {
                        //                            bdate =
                        //                                Convert.ToDateTime(
                        //                                    u.GetStringValue(@"select  dob from  AgentBasicInfo a join AgentJobDetails b on 
                        //                                a.AgentId=b.AgentId where b.UserName='" + txtusername.Text + "'"));
                        //                        }
                        //                        if (DTOU.Rows[0]["Emp_Job_Type"].ToString() != "SE")
                        //                        {
                        //                            if (bdate.Day == DateTime.Now.Day && bdate.Month == DateTime.Now.Month)
                        //                            {
                        //                                Response.Redirect("WelcomeWish.aspx");
                        //                            }
                        //                            else
                        //                            {
                        //                                Response.Redirect("HomeUI.aspx");
                        //                            }
                        //                        }
                        //                        else
                        //                        {
                        Response.Redirect("HomeUI.aspx");
                        //}

                    }

                }
                else
                {
                    string message = "Username or Password Incorrect.";
                    var page = HttpContext.Current.Handler as Page;
                    if (page != null)
                    {
                        message = message.Replace("'", "\'");
                        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg",
                            "alert('" + message + "');", true);
                    }
                }
            }
            catch (Exception ex)
            {

                Response.Write(ex.ToString());
                Response.Write("\n  " + ex.Message);
            }
        }
    }
}