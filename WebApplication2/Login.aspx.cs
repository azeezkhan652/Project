using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.HtmlControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["user"] != null)
            {
                Response.Write("session");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpass.Text) || string.IsNullOrWhiteSpace(txtuser.Text))
            {
                Response.Write("<script>alert('Please provide complete details!!!!');</script>");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
                string query = "select count(*) from login where username='" + txtuser.Text + "' and Password='" + txtpass.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                string output = cmd.ExecuteScalar().ToString();

                if (output == "1")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from login where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "login");

                    string s1 = ds.Tables[0].Rows[0][3].ToString();

                    if (s1 == "admin")
                    {
                        // Response.Write("<script>alert('Welcome'"+txtuser.Text+"');</script>");
                        Session["user"] = txtuser.Text;
                        Response.Redirect("Adminhome.aspx");
                        //Response.Write("login successful as Admin");
                    }
                    else if (s1 == "staff")
                    {
                        //Response.Write("<script>alert('Welcome');</script>");
                        Session["user"] = txtuser.Text;
                        //  Response.Write("login successful as Staff");
                        Response.Redirect("Staffhome.aspx");
                    }
                    else if (s1 == "student")
                    {
                        // Response.Write("<script>alert('Welcome'" + txtuser.Text + "');</script>");
                        Session["user"] = txtuser.Text;
                        Response.Redirect("Studenthome.aspx");
                        // Response.Write("login successful as Student");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid login details!!!!!');</script>");
                        // Response.Write("INVALID USER");
                    }
                }
                else
                {
                    //  Response.Write("Login failed");
                    Response.Write("<script>alert('Invalid login details!!!!!');</script>");
                    txtpass.Text = "";
                    txtuser.Text = "";
                }
            }
          /*  string query = "select count(*) from studentlogin where username='" + txtuser.Text + "' and Password='" + txtpass.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string output = cmd.ExecuteScalar().ToString();

            string query2 = "select count(*) from adminlogin where username='" + txtuser.Text + "' and Password='" + txtpass.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            string output2 = cmd2.ExecuteScalar().ToString();

            string query3 = "select count(*) from stafflogin where username='" + txtuser.Text + "' and Password='" + txtpass.Text + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            string output3 = cmd3.ExecuteScalar().ToString();


            if (output == "1")
            {
                //WE    create a session
                Session["user"] = txtuser.Text;
                 Response.Write("login successful as Student");
                //Response.Redirect("Webform3.aspx");
            }

            else if (output2 == "1")
            {
                Session["user"] = txtuser.Text;
                //Response.Write("login successful as admin");
                Response.Redirect("Adminhome.aspx");
            }

            else if (output3 == "1")
            {
                Session["user"] = txtuser.Text;
                Response.Write("login successful as staff");
                //Response.Redirect("Webform7.aspx");
            }

            else
            {
              //  Response.Write("Login failed");
                txtpass.Text = "";
                txtuser.Text = "";
            }*/
        }
    }
}