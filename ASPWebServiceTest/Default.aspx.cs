using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        Response.Cookies["username"].Value = UsernameTextBox.Text;
        Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(1);
        Response.Cookies["pass"].Value = PassTextBox.Text;
        Response.Cookies["pass"].Expires = DateTime.Now.AddSeconds(1);
        ServiceReference1.TestServiceClient tsc = new ServiceReference1.TestServiceClient();
        bool test = tsc.check(new ServiceReference1.Auth() { userName = Request.Cookies["username"].Value, userPassword = Request.Cookies["pass"].Value });
        if (test)
        {
            if (Response.IsClientConnected)
            {
                Response.Redirect("AddEvent.aspx", false);
            }
            else
            {
                Response.End();
            }
        }
        else
        {
            if (Response.IsClientConnected)
            {
                Response.Redirect("Calendar.aspx", false);
            }
            else
            {
                Response.End();
            }
            }
    }
}