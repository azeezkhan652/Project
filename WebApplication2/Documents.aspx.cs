using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class Documents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        protected void opendocument(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            GridViewRow gr = (GridViewRow)lnk.NamingContainer;
            // string 
            // string id = gvdocuments.DataKeys[gr.RowIndex].Value.ToString();
            // int id = int.Parse(id1.ToString());
            string id = gvdocuments.DataKeys[gr.RowIndex].Value.ToString();
            Download(id);
        }

        private void Download(string id)
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
        private void FillData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("getdocuments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }
            if (dt.Rows.Count > 0)
            {
                gvdocuments.DataSource = dt;
                gvdocuments.DataBind();
            }

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            if ((DropDownList3.SelectedItem.Text == "SELECT") || string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text) || string.IsNullOrWhiteSpace(TextBox3.Text) || (FileUpload1.FileBytes.ToString()==""))
            {
                Response.Write("<script>alert('Please provide complete details');</script>");
            }
            else
            {
                try
                {
                    FileInfo fi = new FileInfo(FileUpload1.FileName);
                    byte[] documentcontent = FileUpload1.FileBytes;
                    string name = fi.Name;
                    string extn = fi.Extension;

                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
                    {
                        SqlCommand cmd = new SqlCommand("savedocument", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox1.Text;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@content", SqlDbType.VarBinary).Value = documentcontent;
                        cmd.Parameters.Add("@extn", SqlDbType.VarChar).Value = extn;

                        cmd.Parameters.Add("@course", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                        cmd.Parameters.Add("@semester", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        cmd.Parameters.Add("@subject", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                        cmd.Parameters.Add("@documenttype", SqlDbType.VarChar).Value = DropDownList3.SelectedItem.Text;
                        cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = TextBox2.Text;
                        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        Response.Write("<script>alert('New File uploaded successfully');</script>");
                       // Response.Write("FIle uploaded successfully");
                    }
                }
                catch(Exception)
                {
                    Response.Write("<script>alert('Error while uploading the file!!!!!!Reload the page');</script>");
                }
            }
            FillData();
        }
    }
}