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

public partial class review_eval : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("SELECT pm.Pm_id as 'ID', Ename as 'Name',Department,Contact_no,Email,v.review,g.GF_id as 'Project ID' FROM GROUP_FYP as g,evaluation_2 as v ,Panel as p,panel_member_1 as pm,Emp_2 as e where sup_id="+Session["ID"]+" and p.Fyp_id=g.GF_id and pm.P_id=p.P_id and e.E_id=pm.E_id and v.pm_id=pm.Pm_id;", con);
        SqlDataReader reader = com.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        reader.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("supervisor.aspx");
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}