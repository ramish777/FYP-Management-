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

public partial class addpm : System.Web.UI.Page
{
    int s1;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select * from Emp_2", con);
            // table name   
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["E_id"].ToString(); // text field name of table dispalyed in dropdown       
                                                                                    // to retrive specific  textfield name   
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();
            con.Close();

            con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
            con.Open();
            com = new SqlCommand("select * from Panel", con);
            // table name   
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList2.DataTextField = ds.Tables[0].Columns["P_id"].ToString(); // text field name of table dispalyed in dropdown       
                                                                                   // to retrive specific  textfield name   
            DropDownList2.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList2.DataBind();
            String str = "select max(Pm_id) from panel_member_1; ";
            com = new SqlCommand(str, con);
            s1 = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()))+1;
            Label1.Text = Convert.ToString(s1);
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        SqlCommand cm;
        String str4 = "select max(Pm_id) from panel_member_1; ";
        cm = new SqlCommand(str4, con);
        int x2 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar())) + 1;

        string s2 = DropDownList1.Text;
        int x = Int32.Parse(s2);
        string s3 = DropDownList2.Text;
        int y = Int32.Parse(s3);
        String str = "select count(*) from panel_member_1 where Pm_id = " + s1 + "; ";
        cm = new SqlCommand(str, con);
        int temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
        if (temp > 0)
        {
            Response.Write("Panel member ID already exist");
        }
        else
        { 
            str = "select count(*) from panel_member_1 where E_id = " + s2 + "; ";
            cm = new SqlCommand(str, con);
            temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
            if (temp == 0)
            {
                int temp2;
                String str1 = "select count(*) from panel_member_1 where E_id = " + y + " and Pm_id=" + s1 + "; ";
                cm = new SqlCommand(str1, con);
                temp2 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                if (temp2 == 0)
                {
                    str1 = "select count(*) from Emp_2 as e, Committee_member_1 as c where c.E_id = e.E_id and e.E_id = " + x + "; ";
                    cm = new SqlCommand(str1, con);
                    int temp3 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                    if (temp3 == 1)
                    {
                        Response.Write("Employee is a Committee  Member cannot be a Panel member");
                    }
                    else
                    {
                        str1 = "select count(*) from Emp_2 as e,supervisor_1 as s where s.E_id = e.E_id and e.E_id = " + x + ";";
                        cm = new SqlCommand(str1, con);
                        temp3 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                        str1 = "select e.Email from Emp_2 as e,supervisor_1 as s where s.E_id = e.E_id and e.E_id =" + x + ";";
                        cm = new SqlCommand(str1, con);
                        string str2 = Convert.ToString(cm.ExecuteScalar());
                        if (temp3 == 1)
                        {
                            String query = ("insert into Panel_member_1 values(" + x2 + "," + x + "," + y + ");");
                            cm = new SqlCommand(query, con);
                            cm.ExecuteNonQuery();
                            query = ("insert into evaluation_2 values(NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,"+s1+");");
                            cm = new SqlCommand(query, con);
                            cm.ExecuteNonQuery();
                            String q3 = ("alter role panel_member add member " + str2 + ";");
                            cm = new SqlCommand(q3, con);
                            cm.ExecuteNonQuery();
                            Response.Write("Record added Successfully");
                        }
                        else
                        {
                            str1 = "select e.Email from Emp_2 as e where e.E_id =" + x + ";";
                            cm = new SqlCommand(str1, con);
                            str2 = Convert.ToString(cm.ExecuteScalar());
                            str = "CREATE LOGIN " + str2 + " WITH PASSWORD = 'fastnu';";
                            cm = new SqlCommand(str, con);
                            cm.ExecuteNonQuery();
                            str = "create user " + str2 + " for login " + str2 + " with default_schema = FYP; ";
                            cm = new SqlCommand(str, con);
                            cm.ExecuteNonQuery();
                            String query = ("insert into Panel_member_1 values(" + x2 + "," + x + "," + y + ");");
                            cm = new SqlCommand(query, con);
                            cm.ExecuteNonQuery();
                            query = ("insert into evaluation_2 values(NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL," + x2 + ");");
                            cm = new SqlCommand(query, con);
                            cm.ExecuteNonQuery();
                            str = "alter role panel_member add member " + str2 + "; ";
                            cm = new SqlCommand(str, con);
                            cm.ExecuteNonQuery();
                            Response.Write("Record added Successfully");

                        }
                    }

                }
                else
                {
                    Response.Write("Record already entered");
                }
            }
            else
            {
                Response.Write("Record already entered");
            }

        }
        Response.Redirect("addpm.aspx");
        cm.Dispose();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}