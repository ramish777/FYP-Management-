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

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        string s2 = DropDownList1.Text;
        if (s2 == "Students")
        {
            String str = "select g.GF_id as 'Project ID',s.St_id as 'Student ID',s.s_name as 'Student Name' from group_fyp as g,student as s,Panel as p,panel_member_1 as pm  where g.GF_id=s.GF_id and p.Fyp_id=g.GF_id and pm.P_id=p.P_id and pm.Pm_id=" + Session["Fyp"] + ";";
            cm = new SqlCommand(str, con);
            SqlDataReader reader = cm.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
            con.Close();
        }
        if (s2 == "Fyps")
        {
            String str = "select Fyp_id as 'FYP ID',g.proj_name as 'Project Name',proj_descrip as 'Project description', grade as 'Grade' from group_fyp as g,Panel as p,panel_member_1 as pm where g.GF_id=p.Fyp_id and p.P_id=pm.P_id and pm.Pm_id=" + Session["Fyp"] + ";";
            cm = new SqlCommand(str, con);
            SqlDataReader reader = cm.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
            con.Close();
        }
        if (s2 == "Evaluations")
        {
            String str = "select* from evaluation_2 where pm_id = " + Session["Fyp"] + ";";
            cm = new SqlCommand(str, con);
            SqlDataReader reader = cm.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("Default3.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}