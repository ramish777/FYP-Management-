using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        string username = TextBox1.Text;
        string password = TextBox2.Text;
        string Query = "SELECT count(*) FROM master.sys.sql_logins where name = '" + username + "' and PWDCOMPARE('" + password + "',password_hash)= 1; ";
        cm = new SqlCommand(Query, con);
        int temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
        if (temp == 1)
        {
            string checkrole1 = "SELECT count(*) FROM sys.database_role_members rm JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id  where m.name = '" + username + "' ";
            cm = new SqlCommand(checkrole1, con);
            temp = Convert.ToInt32(cm.ExecuteScalar().ToString());
            if (temp == 1)
            {
                checkrole1 = "SELECT r.name role_principal_name FROM sys.database_role_members rm JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id JOIN sys.database_principals m  ON rm.member_principal_id = m.principal_id  where m.name = '" + username + "'; ";
                cm = new SqlCommand(checkrole1, con);
                string x = Convert.ToString(cm.ExecuteScalar());
                Session["New"]= TextBox1.Text;
                if (x == "committee_member")
                {
                    Response.Redirect("Default2.aspx");
                }
                if (x == "supervisor")
                {
                    Response.Redirect("supervisor.aspx");
                }
                if (x == "panel_member")
                {
                    Response.Redirect("Default3.aspx");
                }
                if (x == "student")
                {
                    Response.Redirect("student1.aspx");
                }
            }
            if(temp==2)
            {
                Session["New"] = TextBox1.Text;
                //user is a supervisor and panel member
                Response.Redirect("Default6.aspx");
            }
        }
        else
        {
            Response.Write("Username or passowrd is incorrect");
        }
        con.Close();
        cm.Dispose();
    }
}