using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;

[WebService(Namespace = "tempuri.org")]
[WebServiceBinding(Name = "TestService", ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService
{
    public WebService() { }
    public Auth User;
    
    [WebMethod]
    [SoapDocumentMethod(Binding = "TestService")]
    [SoapHeader("User", Required = true)]
    public string AddEvent(string eventName, string eventDate, string eventAcc, string eventTime)
    {
        string conStr = "Server=DESKTOP-J5PKAGQ\\BUNEYMISYA;Database=Students;User ID=sa;Password=Kemal33";
        if (User != null)
        {
            if (User.isValid()) // adds event
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    string que = "INSERT INTO ASPServices (eventName, eventDate, eventAcc, eventTime, eventFromUser)" +
                        "values (@eventName, @eventDate, @eventAcc, @eventTime, @eventFromUser)";
                    using (SqlCommand cmd = new SqlCommand(que, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventName", eventName);
                        cmd.Parameters.AddWithValue("@eventDate", eventDate);
                        cmd.Parameters.AddWithValue("@eventAcc", eventAcc);
                        cmd.Parameters.AddWithValue("@eventTime", eventTime);
                        cmd.Parameters.AddWithValue("@eventFromUser", User.userName);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Added."; // ok
            }
            else // wrong id and pass

                //using (SqlConnection con = new SqlConnection(conStr))
                //{
                //    SqlCommand cmd = new SqlCommand("select * from ASPServices", con);
                //    using (SqlDataReader read = cmd.ExecuteReader())
                //    {
                //        DataTable dt = new DataTable();
                //        dt.Columns.Add("eventName");
                //        dt.Columns.Add("eventDate");
                //        dt.Columns.Add("eventAcc");
                //        dt.Columns.Add("eventTime");
                //        dt.Columns.Add("eventFromUser");
                //        while (read.Read())
                //        {
                //            DataRow dr = dt.NewRow();
                //            dr["eventName"] = read["eventName"];
                //            dr["eventDate"] = read["eventDate"];
                //            dr["eventAcc"] = read["eventAcc"];
                //            dr["eventTime"] = read["eventTime"];
                //            dr["eventFromUser"] = read["eventFromUser"];
                //        }
                //    }
                //}
            return "Showed.";
        }
        else // cant login
        {
            return "Invalid login.";
        }
    }
    [WebMethod]
    [SoapDocumentMethod(Binding = "TestService")]
    [SoapHeader("User", Required = true)]
    public bool check()
    {
        if (User != null)
        {
            if (User.isValid())
                return true;
            else
                return false;
        }
        else
            return false;
    }
}
