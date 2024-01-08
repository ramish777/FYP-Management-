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

public partial class evaluation : System.Web.UI.Page
{
    SqlDataReader reader;
    string str;
    SqlCommand cm;
    int change = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con;
        con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        if (!this.IsPostBack)
        {
            con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            cm = new SqlCommand("select*from panel_member_1 as a,Panel as p where p.P_id=a.P_id and Pm_id="+Session["Fyp"]+"", con);
            // table name   
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["Fyp_id"].ToString(); // text field name of table dispalyed in dropdown       
                                                                                    // to retrive specific  textfield name   
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();
        }
        con.Close();
        con.Open();
        str = "select GF_id,proj_name from panel_member_1 as pm,Panel as p,group_fyp as g where p.P_id=pm.P_id and g.GF_id=p.Fyp_id and Pm_id= " + Session["Fyp"] + ";";
        cm = new SqlCommand(str, con);
        using (reader = cm.ExecuteReader())
        {
            while (reader.Read())
            {
                Label2.Text = reader["proj_name"].ToString();
            }
        }
        reader.Close();

        str = "select count(*) from evaluation_2 as e,panel_member_1 as pm,Panel as p where e.pm_id=pm.Pm_id and pm.Pm_id=" + Session["Fyp"] + " and pm.P_id=p.P_id and q1 is NULL and q2 is NULL and q3 is NULL and q4 is NULL and q4 is NULL and q5 is NULL and q6 is NULL and q7 is NULL and q8 is NULL and q9 is NULL and q10 is NULL and q11 is NULL and q12 is NULL and q13 is NULL and q14 is NULL and q15 is NULL; ";
        cm = new SqlCommand(str, con);
        int x = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
        if (x == 1)
        {
            change = 1;
            Response.Write("Evaluation Not Complete of group");
        }
        else
        {
            change = 0;
            Response.Write("Evaluation Completed !!!");
        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["ps"] == "1")
        {
            Response.Redirect("Default6.aspx");
        }
        Response.Redirect("Default3.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        if (change == 1)
        {
            string s1 = RadioButtonList1.SelectedValue;
            int x1 = Convert.ToInt32(s1);
            string s2 = RadioButtonList2.SelectedValue;
            int x2 = Convert.ToInt32(s2);
            string s3 = RadioButtonList3.SelectedValue;
            int x3 = Convert.ToInt32(s3);
            string s4 = RadioButtonList4.SelectedValue;
            int x4 = Convert.ToInt32(s4);
            string s5 = RadioButtonList5.SelectedValue;
            int x5 = Convert.ToInt32(s5);
            string s6 = RadioButtonList6.SelectedValue;
            int x6 = Convert.ToInt32(s6);
            string s7 = RadioButtonList7.SelectedValue;
            int x7 = Convert.ToInt32(s7);
            string s8 = RadioButtonList8.SelectedValue;
            int x8 = Convert.ToInt32(s8);
            string s9 = RadioButtonList9.SelectedValue;
            int x9 = Convert.ToInt32(s9);
            string s10 = RadioButtonList10.SelectedValue;
            int x10 = Convert.ToInt32(s10);
            string s11 = RadioButtonList11.SelectedValue;
            int x11 = Convert.ToInt32(s11);
            string s12 = RadioButtonList12.SelectedValue;
            int x12 = Convert.ToInt32(s12);
            string s13 = RadioButtonList13.SelectedValue;
            int x13 = Convert.ToInt32(s13);
            string s14 = RadioButtonList14.SelectedValue;
            int x14 = Convert.ToInt32(s14);
            string s15 = RadioButtonList15.SelectedValue;
            int x15 = Convert.ToInt32(s15);
            string s16 = TextBox1.Text;
            if (String.IsNullOrEmpty(s16))
            {
                str = "update evaluation_2 set q1=" + x1 + ",q2=" + x2 + ",q3=" + x3 + ",q4=" + x4 + ",q5=" + x5 + ",q6=" + x6 + ",q7=" + x7 + ",q8=" + x8 + ",q9=" + x9 + ",q10=" + x10 + ",q11=" + x11 + ",q12=" + x12 + ",q13=" + x13 + ",q14=" + x14 + ",q15=" + x15 + " where pm_id="+Session["Fyp"]+";";
                cm = new SqlCommand(str, con);
                cm.ExecuteNonQuery();
            }
            else
            {
                str = "update evaluation_2 set q1=" + x1 + ",q2=" + x2 + ",q3=" + x3 + ",q4=" + x4 + ",q5=" + x5 + ",q6=" + x6 + ",q7=" + x7 + ",q8=" + x8 + ",q9=" + x9 + ",q10=" + x10 + ",q11=" + x11 + ",q12=" + x12 + ",q13=" + x13 + ",q14=" + x14 + ",q15=" + x15 + ",review='"+s16+"' where pm_id=" + Session["Fyp"] + ";";
                cm = new SqlCommand(str, con);
                cm.ExecuteNonQuery();
            }
           
        }
        else
        {
            Response.Write("Cannot save plz press Update Button to update");
        }
        Response.Redirect("evaluation.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        string s1 = RadioButtonList1.SelectedValue;
        int x1 = Convert.ToInt32(s1);
        string s2 = RadioButtonList2.SelectedValue;
        int x2 = Convert.ToInt32(s2);
        string s3 = RadioButtonList3.SelectedValue;
        int x3 = Convert.ToInt32(s3);
        string s4 = RadioButtonList4.SelectedValue;
        int x4 = Convert.ToInt32(s4);
        string s5 = RadioButtonList5.SelectedValue;
        int x5 = Convert.ToInt32(s5);
        string s6 = RadioButtonList6.SelectedValue;
        int x6 = Convert.ToInt32(s6);
        string s7 = RadioButtonList7.SelectedValue;
        int x7 = Convert.ToInt32(s7);
        string s8 = RadioButtonList8.SelectedValue;
        int x8 = Convert.ToInt32(s8);
        string s9 = RadioButtonList9.SelectedValue;
        int x9 = Convert.ToInt32(s9);
        string s10 = RadioButtonList10.SelectedValue;
        int x10 = Convert.ToInt32(s10);
        string s11 = RadioButtonList11.SelectedValue;
        int x11 = Convert.ToInt32(s11);
        string s12 = RadioButtonList12.SelectedValue;
        int x12 = Convert.ToInt32(s12);
        string s13 = RadioButtonList13.SelectedValue;
        int x13 = Convert.ToInt32(s13);
        string s14 = RadioButtonList14.SelectedValue;
        int x14 = Convert.ToInt32(s14);
        string s15 = RadioButtonList15.SelectedValue;
        int x15 = Convert.ToInt32(s15);
        string s16 = TextBox1.Text;
        if (String.IsNullOrEmpty(s16))
        {
            str = "update evaluation_2 set q1=" + x1 + ",q2=" + x2 + ",q3=" + x3 + ",q4=" + x4 + ",q5=" + x5 + ",q6=" + x6 + ",q7=" + x7 + ",q8=" + x8 + ",q9=" + x9 + ",q10=" + x10 + ",q11=" + x11 + ",q12=" + x12 + ",q13=" + x13 + ",q14=" + x14 + ",q15=" + x15 + " where pm_id=" + Session["Fyp"] + ";";
            cm = new SqlCommand(str, con);
            cm.ExecuteNonQuery();
            Response.Write("Record Updated");
        }
        else
        {
            str = "update evaluation_2 set q1=" + x1 + ",q2=" + x2 + ",q3=" + x3 + ",q4=" + x4 + ",q5=" + x5 + ",q6=" + x6 + ",q7=" + x7 + ",q8=" + x8 + ",q9=" + x9 + ",q10=" + x10 + ",q11=" + x11 + ",q12=" + x12 + ",q13=" + x13 + ",q14=" + x14 + ",q15=" + x15 + ",review='" + s16 + "' where pm_id= " + Session["Fyp"] + ";";
            cm = new SqlCommand(str, con);
            cm.ExecuteNonQuery();
            Response.Write("Record Updated");
        }
    }
}