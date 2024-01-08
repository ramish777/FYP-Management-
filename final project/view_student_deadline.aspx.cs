using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class view_student_deadline : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("SELECT D_id,D_description,end_date,end_time from deadline_1 INNER JOIN group_fyp ON group_fyp.GF_id = deadline_1.GF_id INNER JOIN student ON student.GF_id = group_fyp.GF_id where St_id =" + Session["ID"] + ";", con);
        SqlDataReader reader = com.ExecuteReader();
        GridView4.DataSource = reader;
        GridView4.DataBind();
        con.Close();
        reader.Close();
        con.Close();

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("student1.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}