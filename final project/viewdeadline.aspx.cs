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

public partial class viewdeadline : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("select d.D_description as 'Deadline',end_date,end_time,d.GF_id as 'Fyp ID' from deadline_1 as d , group_fyp as g where g.GF_id=d.GF_id and sup_id="+Session["ID"]+";", con);
        SqlDataReader reader = com.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        reader.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("supervisor.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}