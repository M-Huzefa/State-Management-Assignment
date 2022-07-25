using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Task_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 1;
            }
        }
        
        protected void Button(object sender, EventArgs e)
        {
            textbox.Text = ViewState["count"].ToString();
            int count = Convert.ToInt32(ViewState["count"]);
            count++;
            ViewState["count"] = count;
        }

       
    }
}