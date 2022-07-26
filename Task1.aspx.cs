using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Task1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if Page is PostBack then it prevent taking value

            if (!IsPostBack)
            {
                ViewState["count"] = 0;
                textbox.Text = ViewState["count"].ToString();

            }
        }

        protected void Button(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(ViewState["count"]);
            count++;
            ViewState["count"] = count;
            textbox.Text = ViewState["count"].ToString();

        }
    }
}