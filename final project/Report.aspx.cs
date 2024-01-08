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

public partial class Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select s.s_name as 'Student name',e.Ename as 'Panel Member',pm.Pm_id as 'Panel Member ID' from panel_member_1 as pm,Panel as p,student as s,Emp_2 as e,evaluation_2 as v  where pm.P_id=p.P_id and s.GF_id=p.Fyp_id and e.E_id=pm.E_id and v.pm_id=pm.Pm_id and v.q1 is NULL", con);
            SqlDataReader reader = com.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();

            com = new SqlCommand("select s.S_id as 'Supervisor ID',e.Ename as 'Name', g.proj_name as 'FYP' from supervisor_1 as s, group_fyp as g, Emp_2 as e where s.S_id=g.sup_id and e.E_id=s.E_id", con);
            SqlDataReader reader2 = com.ExecuteReader();
            GridView2.DataSource = reader2;
            GridView2.DataBind();
            reader2.Close();

            com = new SqlCommand("select [Supervisor ID],[Name],count(*) as 'Number of FYPS' from supervisor_view as s, group_fyp as g where s.[Supervisor ID]=g.sup_id group by s.[Supervisor ID],s.[Name]", con);
            SqlDataReader reader3 = com.ExecuteReader();
            GridView3.DataSource = reader3;
            GridView3.DataBind();
            reader3.Close();

            com = new SqlCommand("select * from group_fyp", con);
            // table name   
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["GF_id"].ToString();
            DropDownList1.DataSource = ds.Tables[0];  
            DropDownList1.DataBind();

            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        int temp = 0;
        string s2 = DropDownList1.Text;
        int y = Int32.Parse(s2);
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        String str = "select count(*) from Panel as p, panel_member_1 as pm where pm.P_id=p.P_id and p.Fyp_id=" + y + "; ";
        SqlCommand com = new SqlCommand(str, con);
        temp = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()));
        int total = temp * 150;
        if (temp == 0)
        {
            str = "select GF_id as'Fyp ID', proj_name as 'Project Name', grade as 'Grade' from group_fyp where GF_id="+y+"; ";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            GridView4.DataSource = reader;
            GridView4.DataBind();
            reader.Close();
        }
        else
        {
            str = "select count(*) from evaluation_2 as e, panel_member_1 as pm where pm.Pm_id=e.pm_id and pm.P_id=1 and q1 is not null and q2 is not null and q3 is not null and q4 is not null and q5 is not null and q6 is not null and q7 is not null and q8 is not null and q9 is not null and q10 is not null and q11 is not null and q12 is not null and q13 is not null and q14 is not null and q15 is not null; ";
            com = new SqlCommand(str, con);
            int temp2 = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()));
            if (temp2 < temp)
            {
                Response.Write("Evaluation still in Progress");
                str = "select GF_id as'Fyp ID', proj_name as 'Project Name', grade as 'Grade' from group_fyp where GF_id=" + y + "; ";
                com = new SqlCommand(str, con);
                SqlDataReader reader = com.ExecuteReader();
                GridView4.DataSource = reader;
                GridView4.DataBind();
                reader.Close();
            }
            else if(temp2==temp)
            {
                str = "SELECT SUM(q1+q2+q3+q4+q5+q6+q7+q8+q9+q10+q11+q12+q13+q14+q15) FROM evaluation_2; ";
                com = new SqlCommand(str, con);
                int temp3 = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()));
                float x = (temp3 / total) * 100;
                if (x >= 90)
                {
                    str = "update group_fyp set grade = 'A+' where GF_id = "+y+"; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 85)
                {
                    str = "update group_fyp set grade = 'A' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 81)
                {
                    str = "update group_fyp set grade = 'A-' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 77)
                {
                    str = "update group_fyp set grade = 'B+' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 73)
                {
                    str = "update group_fyp set grade = 'B' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 69)
                {
                    str = "update group_fyp set grade = 'B-' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 65)
                {
                    str = "update group_fyp set grade = 'C+' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 61)
                {
                    str = "update group_fyp set grade = 'C' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 57)
                {
                    str = "update group_fyp set grade = 'C-' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 53)
                {
                    str = "update group_fyp set grade = 'D+' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else if (x > 49)
                {
                    str = "update group_fyp set grade = 'D' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                else
                {
                    str = "update group_fyp set grade = 'A-' where GF_id = " + y + "; ";
                    com = new SqlCommand(str, con);
                    com.ExecuteNonQuery();
                }
                Response.Write("Evaluation Completed !!!! Grade Generated !!!");
                str = "select GF_id as'Fyp ID', proj_name as 'Project Name', grade as 'Grade' from group_fyp where GF_id=" + y + "; ";
                com = new SqlCommand(str, con);
                SqlDataReader reader = com.ExecuteReader();
                GridView4.DataSource = reader;
                GridView4.DataBind();
                reader.Close();
            }

        }
    }
}