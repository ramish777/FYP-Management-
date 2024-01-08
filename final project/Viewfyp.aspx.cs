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

public partial class Viewfyp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select g.GF_id as 'Project ID',g.proj_name as 'Project Name',g.proj_descrip as 'Description',g.grade as 'Grade' from group_fyp as g,Panel as p, panel_member_1 as pm,Emp_2 as e ,supervisor_1 as s  where g.GF_id=p.Fyp_id and pm.P_id=p.P_id and pm.E_id=e.E_id and sup_id=s.S_id  and Email='" + Session["New"] + "';", con);
            SqlDataReader reader = com.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();

            com = new SqlCommand("select GF_id as 'Project ID',sup_id as 'Supervisor ID',e.Ename as 'Supervisor Name' from group_fyp as g,Panel as p, panel_member_1 as pm,Emp_2 as e ,supervisor_1 as s  where g.GF_id=p.Fyp_id and pm.P_id=p.P_id and sup_id=s.S_id and pm.Pm_id="+Session["Fyp"]+" and e.E_id=s.E_id;", con);
            reader = com.ExecuteReader();
            GridView2.DataSource = reader;
            GridView2.DataBind();
            reader.Close();

            com = new SqlCommand("select g.GF_id as 'Project ID',s.St_id as 'Student ID',s.s_name as 'Student Name' from group_fyp as g,student as s,Panel as p,panel_member_1 as pm  where g.GF_id=s.GF_id and p.Fyp_id=g.GF_id and pm.P_id=p.P_id and pm.Pm_id=" + Session["Fyp"] + ";", con);
            reader = com.ExecuteReader();
            GridView3.DataSource = reader;
            GridView3.DataBind();
            con.Close();
            reader.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("Default3.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}