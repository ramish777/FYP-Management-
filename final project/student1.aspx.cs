using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class student1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataReader reader;
        string str;
        SqlCommand cm;
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            str = "select* from student where email = '" + Session["New"] + "';";
            cm = new SqlCommand(str, con);
            using (reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    name.Text = reader["s_name"].ToString();
                    name1.Text = reader["s_name"].ToString();
                    Student_ID.Text = reader["St_id"].ToString();
                    department.Text = reader["department"].ToString();
                    email.Text = reader["email"].ToString() + "@nu.edu.pk";
                    CNIC.Text = reader["cnic"].ToString();
                    Group_ID.Text = reader["GF_id"].ToString();
                    Session["ID"] = reader["St_id"].ToString();
                    Session["ID2"] = reader["GF_id"].ToString();


                }
            }
            con.Close();
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("student_fyp_info.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("stu_view_panel.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("review_student.aspx");

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("view_student_deadline.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewgrade.aspx");
    }
}