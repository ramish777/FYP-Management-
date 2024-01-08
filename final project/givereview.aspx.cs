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

public partial class givereview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand com;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        if (!this.IsPostBack)
        {
            com = new SqlCommand("select * from group_fyp where sup_id = " + Session["ID"] + "; ", con);
            // table name   
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["GF_id"].ToString();
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();

            com = new SqlCommand("select r_des from review_supervisor where S_id =  " + Session["ID"] + "; ", con);
            string s3 = Convert.ToString(com.ExecuteScalar());
            if (s3 == "")
            {
                Response.Write("Missing Review");
            }
            else
            {
                Response.Write("Review can be Updated");
            }
            con.Close();
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s1 = TextBox1.Text;
        string s2 = DropDownList1.Text;
        String s3="";
        int x = Int32.Parse(s2);
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand com = new SqlCommand("select * from group_fyp where sup_id = " + Session["ID"] + "; ", con);
        com.ExecuteNonQuery();
        com = new SqlCommand("UPDATE review_supervisor SET Gf_id = "+x+", r_des = '"+s1+"' where S_id="+Session["ID"]+";", con);
        com.ExecuteNonQuery();
        if (s3 == "")
        {
            Response.Write("Review Sent");
        }
        else
        {
            Response.Write("Review Updated");
        }
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("supervisor.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}