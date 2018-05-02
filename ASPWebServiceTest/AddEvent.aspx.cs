using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SaveButton_Click(object sender, EventArgs e)
    {
        ServiceReference1.TestServiceClient tsc = new ServiceReference1.TestServiceClient();
        ServiceReference1.Auth au;
        try
        {
            au = new ServiceReference1.Auth();
            au.userName = Request.Cookies["username"].Value;
            au.userPassword = Request.Cookies["pass"].Value;
        }
        catch(Exception ex)
        {
            au = null;
        }
        string test = tsc.AddEvent(au, ENameTextBox.Text, EDateTextBox.Text, EAccTextBox.Text, ETimeTextBox.Text);
    }
}