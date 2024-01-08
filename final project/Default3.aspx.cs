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

public partial class Default3 : System.Web.UI.Page
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
            str = "SELECT pm.Pm_id,e.E_id,p.P_id,Ename,Department,Contact_no,Email FROM panel_member_1 as pm,Panel as p,Emp_2 as e where pm.E_id=e.E_id and pm.P_id=p.P_id and e.Email='" + Session["New"] + "';";
            cm = new SqlCommand(str, con);
            
            using (reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    Label1.Text = reader["Ename"].ToString();
                    name.Text = reader["Ename"].ToString();
                    contact.Text = reader["Contact_no"].ToString();
                    dept.Text = reader["Department"].ToString();
                    email.Text = reader["Email"].ToString() + "@nu.edu.pk";
                    e_id.Text = reader["E_id"].ToString();
                    p_id.Text = reader["Pm_id"].ToString();
                    Label2.Text = reader["P_id"].ToString();
                }
            }
            cm = new SqlCommand("select Pm_id from panel_member_1 as p, Emp_2 as e where e.E_id = p.E_id and Email = '" + Session["New"] + "';", con);
            int temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
            Session["Fyp"] = temp;

            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewfyp.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("evaluation.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}