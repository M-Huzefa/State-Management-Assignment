using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Task3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // check Session state if it is not null redirect it to greeting

            if (Session["username"] != null && Session["password"] != null)
            {
                Response.Redirect("Greeting.aspx");
            }
        }
        protected void LogIn(object sender, EventArgs e)
        {
            Session["username"] = textBox1.Text;
            Session["password"] = textBox2.Text;

            
            Response.Redirect("Greeting.aspx");
        }
    }
}