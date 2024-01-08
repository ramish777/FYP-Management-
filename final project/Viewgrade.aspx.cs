using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Viewgrade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            String str = " select grade from group_fyp where GF_id = "+Session["ID2"]+"; "; 
            SqlCommand com = new SqlCommand(str, con);
            str = com.ExecuteScalar().ToString();
            if (str == "N")
            {
            Label1.Text = "Grade has not been uploaded. Please wait some time";
            }
            else
            {
            Label1.Text = "Your Grade :"+str;
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("student1.aspx");
    }
}