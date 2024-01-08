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

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {
        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select *from group_fyp", con);
            // table name   
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["GF_id"].ToString(); // text field name of table dispalyed in dropdown       
                                                                                    // to retrive specific  textfield name   
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        int s1 = Convert.ToInt32(TextBox1.Text);
        string s2 = TextBox2.Text;
        string s3 = TextBox3.Text;
        string s4 = TextBox4.Text;
        string s5 = TextBox5.Text;
        string s6 = DropDownList1.Text;
        int x= Int32.Parse(s6);
        String str = "SELECT count(*) FROM student where email = '" + s4 + "';";
        cm = new SqlCommand(str, con);
        int temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
        if (temp == 0)
        {
            String query = ("insert into student values(" + s1 + ",'" + s4 + "','" + s2 + "','" + s3 + "','" + s5 + "'," + x + ");");
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            str = "CREATE LOGIN " + s4 + " WITH PASSWORD = 'fastnu';";
            cm = new SqlCommand(str, con);
            cm.ExecuteNonQuery();
            str = "create user " + s4 + " for login " + s4 + " with default_schema = FYP; ";
            cm = new SqlCommand(str, con);
            cm.ExecuteNonQuery();
            str = "alter role student add member " + s4 + "; ";
            cm = new SqlCommand(str, con);
            cm.ExecuteNonQuery();
            Response.Write("Record Saved Successfully");
        }
        else
        {
            Response.Write("Not Saved Successfully. Record already exist");
        }
        cm.Dispose();
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}