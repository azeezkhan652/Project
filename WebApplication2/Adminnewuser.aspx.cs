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
    public partial class Adminnewuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtphone.Text) || 
                string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text)  || string.IsNullOrWhiteSpace(txtconfirmpassword.Text) || string.IsNullOrWhiteSpace(txtdob.Text) || string.IsNullOrWhiteSpace(txtdynamic.Text) || (listtype.SelectedValue=="SELECT") )
            {
                Response.Write("<script>alert('Please provide complete details below');</script>");
                //Label1.Visible = true;
                //Response.Write("Please Fill complete details");
            }
            else
            {
                if (txtpassword.Text != txtconfirmpassword.Text)
                {
                    Response.Write("<script>alert('Password do not match');</script>");
                    //Label1.Text = "Password do not match";
                }
                else
                {
                    if (listtype.SelectedValue == "ADMIN")
                    {
                        SqlCommand cmd = new SqlCommand("insert into admindetails values('" + txtname.Text + "','" + txtid.Text + "','" +
                            RadioBtn.SelectedValue + "','" + txtphone.Text + "','" + txtdob.Text + "','" + txtaddress.Text + "','"+txtdynamic.Text+"','" + txtusername.Text + "','" + txtpassword.Text + "')", con);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Response.Write("New user added successfully");
                            /* int a = 0;
                             int b = 1;
                             if (a == int.Parse(listtype.SelectedIndex.ToString()))
                             {
                                 Response.Write("admin");
                             }
                             else if (b == int.Parse(listtype.SelectedIndex.ToString()))
                             {
                                 Response.Write("staff");
                             }
                             else
                             {
                                 Response.Write("student");
                             }*/
                            con.Close();
                            txtconfirmpassword.Text = "";
                            txtid.Text = "";
                            txtname.Text = "";
                            txtpassword.Text = "";
                            txtphone.Text = "";
                            txtusername.Text = "";
                            txtsemester.Text = "";
                            txtdynamic.Text = "";
                            listtype.SelectedValue = "SELECT";
                            Label2.Visible = false;
                            Label3.Visible = false;
                            txtdynamic.Visible = false;
                            txtsemester.Visible = false;
                            txtdob.Text = "";
                            txtaddress.Text = "";


                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex);
                            con.Close();
                        }
                    }
                    else if(listtype.SelectedValue=="STAFF")
                    {
                        SqlCommand cmd = new SqlCommand("insert into staffdetails values('" + txtname.Text + "','" + txtid.Text + "','" +
                           RadioBtn.SelectedValue + "','" + txtphone.Text + "','" + txtdob.Text + "','" + txtaddress.Text + "','" + txtdynamic.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Response.Write("New FACULTY added successfully");
                            con.Close();
                            txtconfirmpassword.Text = "";
                            txtid.Text = "";
                            txtname.Text = "";
                            txtpassword.Text = "";
                            txtphone.Text = "";
                            txtusername.Text = "";
                            txtsemester.Text = "";
                            txtdynamic.Text = "";
                            listtype.SelectedValue = "SELECT";
                            Label2.Visible = false;
                            Label3.Visible = false;
                            txtdynamic.Visible = false;
                            txtsemester.Visible = false;
                            txtdob.Text = "";
                            txtaddress.Text = "";
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex);
                            con.Close();
                        }
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into studentdetails values('" + txtname.Text + "','" + txtid.Text + "','" +
                          RadioBtn.SelectedValue + "','" + txtphone.Text + "','" + txtdob.Text + "','" + txtaddress.Text + "','" + txtdynamic.Text + "','"+txtsemester.Text+"','" + txtusername.Text + "','" + txtpassword.Text + "')", con);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Response.Write("New STUDENT added successfully");
                            con.Close();
                            txtconfirmpassword.Text = "";
                            txtid.Text = "";
                            txtname.Text = "";
                            txtpassword.Text = "";
                            txtphone.Text = "";
                            txtusername.Text = "";
                            txtsemester.Text = "";
                            txtdynamic.Text = "";
                            listtype.SelectedValue = "SELECT";
                            Label2.Visible = false;
                            Label3.Visible = false;
                            txtdynamic.Visible = false;
                            txtsemester.Visible = false;
                            txtdob.Text = "";
                            txtaddress.Text = "";

                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex);
                            con.Close();
                        }
                    }
                }
            }
        }

        protected void listtype_TextChanged(object sender, EventArgs e)
        {
            if (listtype.SelectedValue == "SELECT")
            {
                Label2.Visible = false;
                Label3.Visible = false;
                txtdynamic.Visible = false;
                txtsemester.Visible = false;
            }
            else if (listtype.SelectedValue == "ADMIN")
            {
                Label2.Visible = true;
                Label3.Visible = false;
                txtdynamic.Visible = true;
                txtsemester.Visible = false;
                Label2.Text = "BRANCH";
            }
            else if (listtype.SelectedValue == "STAFF")
            {
                Label2.Visible = true;
                Label3.Visible = false;
                txtdynamic.Visible = true;
                txtsemester.Visible = false;

                Label2.Text = "DESIGNATION";
            }
            else
            {
                Label2.Visible = true;
                Label3.Visible = true;
                txtdynamic.Visible = true;
                txtsemester.Visible = true;

                Label2.Text = "COURSE";
            }
        }
    }
}