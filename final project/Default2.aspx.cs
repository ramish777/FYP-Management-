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

public partial class Default2 : System.Web.UI.Page
{
    SqlDataReader reader;
    string str;
    SqlCommand cm;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            str = "select c.C_id,c.E_id,e.Ename,e.Department,e.Email,e.Contact_no from Committee_member_1 as c,Emp_2 as e where e.E_id=c.E_id and e.Email='" + Session["New"] + "';";
            cm = new SqlCommand(str, con);
            using (reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    name.Text = reader["Ename"].ToString();
                    name1.Text = reader["Ename"].ToString();
                    contact.Text = reader["Contact_no"].ToString();
                    dept.Text = reader["Department"].ToString();
                    email.Text = reader["Email"].ToString()+"@nu.edu.pk";
                    e_id.Text = reader["E_id"].ToString();
                    c_id.Text = reader["C_id"].ToString();
                }
            }
            con.Close();
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("addstudent.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("addemployee.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("panel.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("addpm.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("deadline.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("addfyp.aspx");
    }
}