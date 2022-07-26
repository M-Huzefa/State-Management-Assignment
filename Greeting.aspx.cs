using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Greeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // check Session state if it is null redirect it to LogIn

            if (Session["username"] == null && Session["password"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                welcomeMsg.InnerText = "Hello " + Session["username"].ToString();
            }
        }
        
        protected void LogOut(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("LogIn.aspx");
        }


    }
}