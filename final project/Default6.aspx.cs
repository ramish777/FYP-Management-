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

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataReader reader;
        string str;
        SqlCommand cm;
        if (!this.IsPostBack)
        {
            Session["ps"] = "1";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            str = "select c.S_id,c.E_id,e.Ename,e.Department,e.Email,e.Contact_no from supervisor_1 as c,Emp_2 as e where e.E_id=c.E_id and e.Email='" + Session["New"] + "';";
            cm = new SqlCommand(str, con);
            
            using (reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    name.Text = reader["Ename"].ToString();
                    name1.Text = reader["Ename"].ToString();
                    contact.Text = reader["Contact_no"].ToString();
                    dept.Text = reader["Department"].ToString();
                    email.Text = reader["Email"].ToString() + "@nu.edu.pk";
                    e_id.Text = reader["E_id"].ToString();
                    c_id.Text = reader["S_id"].ToString();
                    Session["ID"] = reader["S_id"].ToString();
                }
            }
            string str1 = "SELECT pm.Pm_id,p.P_id FROM panel_member_1 as pm,Panel as p,Emp_2 as e where pm.P_id=p.P_id and e.E_id=pm.E_id and e.Email='" + Session["New"] + "';";
            SqlCommand cm2 = new SqlCommand(str1, con);
            SqlDataReader reader1;
            using (reader1 = cm2.ExecuteReader())
            {
                while (reader1.Read())
                {
                    Label1.Text = reader1["Pm_id"].ToString();
                    Label2.Text = reader1["P_id"].ToString();
                    Session["Fyp"] = reader1["Pm_id"].ToString();
                }
            }
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("sup_info.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("review_eval.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        Response.Redirect("viewdeadline.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("givereview.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewfyp.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("evaluation.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search.aspx");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}