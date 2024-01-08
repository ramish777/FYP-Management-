using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class stu_view_panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
        SqlCommand com = new SqlCommand("select panel_member_1.Pm_id as ' Panel Member ID',Panel.P_name as 'Panel Name',Emp_2.Ename as 'Name' from Emp_2 INNER JOIN Panel_member_1 ON Panel_member_1.E_id = Emp_2.E_id INNER JOIN Panel ON Panel.P_id = Panel_member_1.P_id INNER JOIN group_fyp ON group_fyp.GF_id = Panel.Fyp_id INNER JOIN student ON student.GF_id = group_fyp.GF_id where St_id =" + Session["ID"] + ";", con);
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