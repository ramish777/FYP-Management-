using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class review_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("select review from evaluation_2 as e, panel_member_1 as pm,Panel as p,student as s where pm.Pm_id=e.pm_id and p.P_id=pm.P_id and s.GF_id=p.Fyp_id and st_id="+Session["ID"]+";", con);
        SqlDataReader reader = com.ExecuteReader();
        GridView4.DataSource = reader;
        GridView4.DataBind();
        con.Close();
        reader.Close();
        con.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("student1.aspx");

    }
}