using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Task_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Value of Textbox1 and TectBox2 is assigin on the ViewState
            ViewState["name"] = Textbox3.Value;
            ViewState["password"] = Textbox4.Value;
            
            //Hiddenfield1.Value = Textbox3.Value;
            //Hiddenfield2.Value = Textbox4.Value;

            //after clicking on Button TextBox value Will be Cleared  
            Textbox3.Value = Textbox4.Value = string.Empty;
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //Value of Textbox1 and TectBox2 is assigin on the ViewState
        //    ViewState["name"] = TextBox1.Text;
        //    ViewState["password"] = TextBox2.Text;

        //    Hiddenfield1.Value = TextBox1.Text;
        //    Hiddenfield2.Value = TextBox2.Text;

        //    //after clicking on Button TextBox value Will be Cleared  
        //    TextBox1.Text = TextBox2.Text = string.Empty;
        //}
        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    //If ViewState Value is not Null then Value of View State is Assign to TextBox  
        //    if (ViewState["name"] != null)
        //    {
        //        TextBox1.Text = ViewState["name"].ToString();
        //    }

        //    if (ViewState["password"] != null)
        //    {
        //        TextBox2.Text = ViewState["password"].ToString();
        //    }
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            //If ViewState Value is not Null then Value of View State is Assign to TextBox  
            if (ViewState["name"] != null)
            {
                Textbox3.Value = ViewState["name"].ToString();
            }

            if (ViewState["password"] != null)
            {
                Textbox4.Value = ViewState["password"].ToString();
            }
        }
        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    if (Hiddenfield1.Value != null)
        //    {
        //        TextBox1.Text = Hiddenfield1.Value;
        //    }

        //    if (Hiddenfield2.Value != null)
        //    {
        //        TextBox2.Text = Hiddenfield2.Value;
        //    }
        //}
    }
}