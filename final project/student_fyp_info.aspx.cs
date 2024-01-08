using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class student_fyp_info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("select student.s_name as 'Student Name',student.St_id as 'ID',student.email as 'Email' from student INNER JOIN group_fyp ON student.GF_id = group_fyp.GF_id where student.GF_id = " + Session["ID2"] + "; ", con);
        SqlDataReader reader = com.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        reader.Close();

        com = new SqlCommand("select group_fyp.proj_descrip as 'Project Description'  from student INNER JOIN group_fyp ON student.GF_id = group_fyp.GF_id where St_id = " + Session["ID"] + "; ", con);
        reader = com.ExecuteReader();
        GridView2.DataSource = reader;
        GridView2.DataBind();
        reader.Close();

        com = new SqlCommand("SELECT Emp_2.Ename as 'NAME',Emp_2.Department as 'Depatment',Emp_2.Contact_no as 'Contact',Emp_2.Email from Emp_2 INNER JOIN supervisor_1 ON supervisor_1.E_id = Emp_2.E_id INNER JOIN group_fyp ON group_fyp.sup_id = supervisor_1.S_id INNER JOIN student ON student.GF_id = group_fyp.GF_id where St_id = " + Session["ID"] + "; ", con);
        reader = com.ExecuteReader();
        GridView3.DataSource = reader;
        GridView3.DataBind();
        reader.Close();



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