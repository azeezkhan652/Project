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
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView1.SelectedRow;
            HyperLink1.Text = gr.Cells[1].Text;
            LinkButton1.Text = gr.Cells[2].Text;
            //  LinkButton2.Text = gr.Cells[3].Text;
        }
        protected void opendocument(object sender, EventArgs e)
        {
           
                LinkButton lnk = sender as LinkButton;
                GridViewRow gr1 = GridView1.Rows[GridView1.SelectedIndex];
                //GridViewRow gr1 = (GridViewRow)lnk.NamingContainer;
                //error here 
                string id = GridView1.DataKeys[gr1.RowIndex].Value.ToString();
                Download1(id);
           
                  
        }
        private void Download1(string id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("getdocument", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            string name = dt.Rows[0]["name"].ToString();
            byte[] documentBytes = (byte[])dt.Rows[0]["content"];
            Response.ClearContent();
            Response.ContentType = "application/octetstream";
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}", name));
            Response.AddHeader("Content-Length", documentBytes.Length.ToString());
            Response.BinaryWrite(documentBytes);
            Response.Flush();
            Response.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            string query = "Select count(*) from docs where semester='" + DropDownList1.SelectedItem + "' and subject='" + DropDownList2.SelectedItem + "' and documenttype='" + DropDownList3.SelectedItem + "'";
            con2.Open();
            SqlCommand cmd = new SqlCommand(query, con2);
            string output = cmd.ExecuteScalar().ToString();
            if (output == "1")
            {
                string docstable = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                SqlConnection con = new SqlConnection(docstable);
                SqlDataAdapter da = new SqlDataAdapter("Select * from docs where semester='" + DropDownList1.SelectedItem + "' and subject='" + DropDownList2.SelectedItem + "' and documenttype='" + DropDownList3.SelectedItem + "'", con);

                DataSet ds = new DataSet();
                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Record Not Found!!!!!');</script>");
                //Response.Write("REcord not found");
                con2.Close();

            }
           
        }
    }
}