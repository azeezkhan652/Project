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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedItem.Text == "SELECT")
            {
                Response.Write("<script>alert('Please select the appropriate document type');</script>");
            }
            else
            {
                string docstable = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                SqlConnection con = new SqlConnection(docstable);
                SqlDataAdapter da = new SqlDataAdapter("Select * from docs where semester='" + DropDownList1.SelectedItem + "' and subject='" + DropDownList2.SelectedItem + "' and documenttype='" + DropDownList3.SelectedItem + "'", con);
                SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
                string query = "Select count(*) from docs where semester='" + DropDownList1.SelectedItem + "' and subject='" + DropDownList2.SelectedItem + "' and documenttype='" + DropDownList3.SelectedItem + "'";
                con2.Open();
                SqlCommand cmd = new SqlCommand(query, con2);
                string output = cmd.ExecuteScalar().ToString();
                if (output == "1")
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    con.Close();
                }
                else
                {
                    Response.Write("<script>alert('Record Not Found!!!!!');</script>");
                    //Response.Write("REcord not found");
                    con.Close();

                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView1.SelectedRow;
            HyperLink1.Text = gr.Cells[1].Text;
            LinkButton1.Text = gr.Cells[2].Text;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if(LinkButton1.Text=="")
            {
                Response.Write("<script>alert('Record Not Found!!!!!');</script>");
                //Response.Write("NO records found");
            }
            {
                SqlCommand cmd = new SqlCommand("delete from docs where name = '" + LinkButton1.Text + "'", con1);
                con1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Document has been removed successfully');</script>");
                    // Response.Write("User removed successfully");
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
        }
    }
}