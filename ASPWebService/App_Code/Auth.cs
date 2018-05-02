using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Auth
/// </summary>
public class Auth : System.Web.Services.Protocols.SoapHeader
{
    public string userName { get; set; }
    public string userPassword { get; set; }
    public bool isValid()
    {
        string conStr = "Server=DESKTOP-J5PKAGQ\\BUNEYMISYA;Database=Students;User ID=sa;Password=Kemal33";

        using (SqlConnection conn = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand("select * from ASPServicesUsers where userName =@userNa and userPassword=@userPass", conn);
            cmd.Parameters.AddWithValue("@userNa", userName);
            cmd.Parameters.AddWithValue("@userPass", userPassword);
            cmd.Connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if (count == 0)
                return false;
            else
                return true;
        }
    }
}