using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Task2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            //Value of Textbox1 and TectBox2 is assigin on the ViewState
            ViewState["name"] = textBox1.Text;
            ViewState["password"] = textBox2.Text;

            //after clicking on Button TextBox value Will be Cleared  
            textBox1.Text = textBox2.Text = string.Empty;
        }
        protected void viewState(object sender, EventArgs e)
        {
            //If ViewState Value is not Null then Value of View State is Assign to TextBox  
            if (ViewState["name"] != null)
            {
                textBox1.Text = ViewState["name"].ToString();
            }

            if (ViewState["password"] != null)
            {
                textBox2.Text = ViewState["password"].ToString();
            }
        }

        protected void hiddenFields(object sender, EventArgs e)
        {
            textBox1.Text = hiddenField1.Value.ToString();
            textBox2.Text = hiddenField2.Value.ToString();
            
        }
    }
}