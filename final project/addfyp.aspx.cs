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

public partial class addfyp : System.Web.UI.Page
{
    int s1;
    string str3;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            String str = "select max(GF_id) from group_fyp ";
            SqlCommand com = new SqlCommand(str, con);
            s1 = Convert.ToInt32(Convert.ToString(com.ExecuteScalar())) + 1;
            Label2.Text = Convert.ToString(s1);
            Label1.Text = "N";
            str3 = Label1.Text;
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        string str1 = TextBox2.Text;
        string str2 = TextBox6.Text;
        String str = "select max(GF_id) from group_fyp ";
        SqlCommand com = new SqlCommand(str, con);
        int z = Convert.ToInt32(Convert.ToString(com.ExecuteScalar())) + 1;
        string str4 = "N";
        String query = ("insert into group_fyp values(" + z + ",'" + str1 + "','" + str2 + "','" + str4 + "',NULL);");
        cm = new SqlCommand(query, con);
        cm.ExecuteNonQuery();
        Response.Write("Record Saved !!!");
        Response.Redirect("addfyp.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}