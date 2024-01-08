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


public partial class addemployee : System.Web.UI.Page
{
    int ID;
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

            com = new SqlCommand("select *from group_fyp", con);
            // table name   
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            CheckBoxList1.DataTextField = ds.Tables[0].Columns["GF_id"].ToString(); // text field name of table dispalyed in dropdown       
                                                                                    // to retrive specific  textfield name   
            CheckBoxList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            CheckBoxList1.DataBind();

            String str = "select max(S_id) from supervisor_1; ";
            com = new SqlCommand(str, con);
            ID = Convert.ToInt32(Convert.ToString(com.ExecuteScalar()))+1;
            Label1.Text = Convert.ToString(ID);
            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCOLAL7\\SQLEXPRESS;Initial Catalog=FYP;Integrated Security=True");
        con.Open();
        
        SqlCommand cm;
        int s1=ID;
        int temp;
        string s2 = DropDownList1.Text;
        int x = Int32.Parse(s2);
        string s3 = CheckBoxList1.Text;
        int y = CheckBoxList1.Items.Count;
        int count = 0;
        for(int i = 0; i < y; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                count++;
            }
        }
        String str6 = "select max(S_id) from supervisor_1; ";
        cm = new SqlCommand(str6, con);
        int x22 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar())) + 1;
        String str = "select count(*) from supervisor_1 where S_id = " + s1+"; ";
        cm = new SqlCommand(str, con);
        temp = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
        if (temp == 0)
        {
            int temp2;
            str = " select count(*) from supervisor_1 where E_id = " + x + "; ";
            cm = new SqlCommand(str, con);
            temp2 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
            if (temp2 == 0)
            {
                String str1 = "select count(*) from Emp_2 as e, Committee_member_1 as c where c.E_id = e.E_id and e.E_id = " + x + "; ";
                cm = new SqlCommand(str1, con);
                int temp3 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                if (temp3 == 1)
                {
                    Response.Write("Employee is a Committee  Member cannot be a Supervisor");
                }
                else
                {
                    str1 = "select count(*) from Emp_2 as e,panel_member_1 as s where s.E_id = e.E_id and e.E_id = " + x + ";";
                    cm = new SqlCommand(str1, con);
                    temp3 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                    str1 = "select e.Email from Emp_2 as e,panel_member_1 as s where s.E_id = e.E_id and e.E_id =" + x + ";";
                    cm = new SqlCommand(str1, con);
                    string str2 = Convert.ToString(cm.ExecuteScalar());
                    if (temp3 == 1)
                    {
                        str1 = "select count(*) from group_fyp where GF_id=" + y+ " and sup_id IS NULL;";
                        cm = new SqlCommand(str1, con);
                        temp3 = Convert.ToInt32(Convert.ToString(cm.ExecuteScalar()));
                        if (temp3 == 0)
                        {
                            Response.Write("Supervisor is already alloted to this group");
                        }
                        else
                        {

                            if (count < 7)
                            {
                                
                                string str5;
                                for (int i = 0; i < y; i++)
                                {
                                    if (CheckBoxList1.Items[i].Selected)
                                    {
                                        str5 = CheckBoxList1.Items[i].Text;
                                        int x3 = Int32.Parse(str5);
                                        String query1 = ("update group_fyp set sup_id=" + x22 + " where GF_id=" + x3 + " and sup_id IS NULL;");
                                        cm = new SqlCommand(query1, con);
                                        cm.ExecuteNonQuery();
                                    }
                                }
                                String query = ("insert into supervisor_1 values(" + x22 + "," + x + ");");
                                cm = new SqlCommand(query, con);
                                cm.ExecuteNonQuery();
                                query = ("insert into review_supervisor values(NULL," + x22 + ",NULL);");
                                cm = new SqlCommand(query, con);
                                cm.ExecuteNonQuery();
                                String q3 = (" alter role supervisor add member " + str2 + " ;");
                                cm = new SqlCommand(q3, con);
                                cm.ExecuteNonQuery();
                                Response.Write("Record added Successfully");

                            }
                            else
                            {
                                Response.Write("Supervisor cannot supervise more than 6 Fyps");
                            }
                        }
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
                        String query = ("insert into supervisor_1 values(" + x22 + "," + x + ");");
                        cm = new SqlCommand(query, con);
                        cm.ExecuteNonQuery();
                        query = ("insert into review_supervisor values(NULL," + x22 + ",NULL);");
                        cm = new SqlCommand(query, con);
                        cm.ExecuteNonQuery();
                        string str5;
                        for (int i = 0; i < y; i++)
                        {
                            if (CheckBoxList1.Items[i].Selected)
                            {
                                str5 = CheckBoxList1.Items[i].Selected.ToString();
                                int x3 = Int32.Parse(str5);
                                query = ("update group_fyp set sup_id=" + x22 + " where GF_id=" + x3 + " and sup_id IS NULL;");
                                cm = new SqlCommand(query, con);
                                cm.ExecuteNonQuery();
                            }
                        }
                        String q3 = ("alter role supervisor add member " + str2 + ";");
                        cm = new SqlCommand(q3, con);
                        cm.ExecuteNonQuery();
                        Response.Write("Record added Successfully");
                        str = "alter role supervisor add member " + str2 + "; ";
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