using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class Deleteuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue=="SELECT")
            {
                Label1.Visible = false;
                Label2.Visible = false;
                DropDownList2.Visible = false;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
            }
            else if(DropDownList1.SelectedValue=="ADMIN")
            {
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                
            }
            else if(DropDownList1.SelectedValue=="STAFF")
            {
                DropDownList2.Visible = false;
                DropDownList3.Visible = true;
                DropDownList4.Visible = false;
               
            }
            else
            {
                DropDownList2.Visible = false;
                DropDownList3.Visible = false;
                DropDownList4.Visible = true;
                
            }
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "SELECT")
            {
                Label2.Visible = true;
                Label1.Visible = false;
            }
            else if((DropDownList1.SelectedValue!="SELECT")&(Label1.Visible==true))
            {
                Label2.Visible = true;
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = false;
                SqlCommand cmd = new SqlCommand("delete from login where username = '" + DropDownList2.Text + "'", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('User has been removed successfully');</script>");
                    //Response.Write("User removed successfully");
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
        }
    }
}