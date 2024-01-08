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
    int s1;
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
            String str = "select max(Pm_id) from panel_member_1; ";
            com = new SqlCommand(str, con);
            s1 = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()))+1;
            Label1.Text = Convert.ToString(s1);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        
        string s2 = TextBox2.Text;
        string s3 = TextBox3.Text;
        string s4 = TextBox4.Text;
        string s5 = DropDownList1.Text;
        int x = Int32.Parse(s5);
        String query = ("insert into deadline_1 values(" + s1 + ",'" + s2 + "','" + s3+ "','" + s4 + "'," + x + ");");
        cm = new SqlCommand(query, con);
        cm.ExecuteNonQuery();
        Response.Write("Deadline given");
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