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
    public partial class Modifyuser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
        // string cs = ConfigurationManager.ConnectionStrings["connecet"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "SELECT")
            {
                Response.Write("<script>alert('Please provide complete details');</script>");
                //Label14.Visible = true;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label16.Visible = false;

                listtype.Visible = false;
                RadioBtn.Visible = false;

                txtaddress.Visible = false;
                txtconfirmpassword.Visible = false;
                txtdob.Visible = false;
                txtdynamic.Visible = false;
                txtname.Visible = false;
                txtid.Visible = false;
                txtpassword.Visible = false;
                txtphone.Visible = false;
                txtsemester.Visible = false;
                txtusername.Visible = false;
            }
            else if (DropDownList1.SelectedValue == "ADMIN")
            {

                string query1 = "select count(*) from admindetails where username='" + txtusernamefirst.Text + "'";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(query1, con);
                string output = cmd2.ExecuteScalar().ToString();

                if (output == "1")
                {
                    Session["user"] = txtusernamefirst.Text;
                    txtaddress.Visible = true;
                    txtconfirmpassword.Visible = true;
                    txtdob.Visible = true;
                    txtdynamic.Visible = true;
                    txtid.Visible = true;
                    txtname.Visible = true;
                    txtpassword.Visible = true;
                    txtphone.Visible = true;
                    txtusername.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label2.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label16.Visible = false;
                    Label2.Text = "BRANCH";
                    listtype.Visible = true;
                    Label3.Visible = false;
                    txtsemester.Visible = false;
                    RadioBtn.Visible = true;

                    txtaddress.Text = "";
                    txtconfirmpassword.Text = "";
                    txtdob.Text = "";
                    txtdynamic.Text = "";
                    txtid.Text = "";
                    txtname.Text = "";
                    txtpassword.Text = "";
                    txtphone.Text = "";
                    txtusername.Text = "";

                    Label16.Visible = false;
                    Label2.Text = "BRANCH";
                    listtype.SelectedValue = "SELECT";
                    Label3.Visible = false;
                    txtsemester.Visible = false;


                    SqlDataAdapter da = new SqlDataAdapter("select * from admindetails where username = '" + txtusernamefirst.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "admindetails");
                    string s1 = ds.Tables[0].Rows[0][0].ToString();
                    string s2 = ds.Tables[0].Rows[0][1].ToString();
                    string s3 = ds.Tables[0].Rows[0][2].ToString();
                    string s4 = ds.Tables[0].Rows[0][3].ToString();
                    string s5 = ds.Tables[0].Rows[0][4].ToString();
                    string s6 = ds.Tables[0].Rows[0][5].ToString();
                    string s7 = ds.Tables[0].Rows[0][6].ToString();
                    string s8 = ds.Tables[0].Rows[0][7].ToString();
                    string s9 = ds.Tables[0].Rows[0][8].ToString();

                    txtname.Text = s1;
                    txtid.Text = s2;
                    RadioBtn.SelectedValue = s3;
                    txtphone.Text = s4;
                    txtdob.Text = s5;
                    txtaddress.Text = s6;
                    txtdynamic.Text = s7;
                    txtusername.Text = s8;
                    txtpassword.Text = s9;
                }
                else
                {
                    Response.Write("<script>alert('User Not Found');</script>");
                    //Label15.Visible = true;
                }
            }
            else if (DropDownList1.SelectedValue == "STAFF")
            {

                string query1 = "select count(*) from staffdetails where username='" + txtusernamefirst.Text + "'";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(query1, con);
                string output = cmd2.ExecuteScalar().ToString();

                if (output == "1")
                {
                    Session["user"] = txtusernamefirst.Text;
                    txtaddress.Visible = true;
                    txtconfirmpassword.Visible = true;
                    txtdob.Visible = true;
                    txtdynamic.Visible = true;
                    txtid.Visible = true;
                    txtname.Visible = true;
                    txtpassword.Visible = true;
                    txtphone.Visible = true;
                    txtusername.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label2.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label16.Visible = false;
                    Label2.Text = "DESIGNATION";
                    listtype.Visible = true;
                    Label3.Visible = false;
                    txtsemester.Visible = false;
                    RadioBtn.Visible = true;

                    txtaddress.Text = "";
                    txtconfirmpassword.Text = "";
                    txtdob.Text = "";
                    txtdynamic.Text = "";
                    txtid.Text = "";
                    txtname.Text = "";
                    txtpassword.Text = "";
                    txtphone.Text = "";
                    txtusername.Text = "";

                    Label16.Visible = false;
                    Label2.Text = "DESIGNATION";
                    listtype.SelectedValue = "SELECT";
                    Label3.Visible = false;
                    txtsemester.Visible = false;

                    SqlDataAdapter da = new SqlDataAdapter("select * from staffdetails where username = '" + txtusernamefirst.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "staffdetails");
                    string s1 = ds.Tables[0].Rows[0][0].ToString();
                    string s2 = ds.Tables[0].Rows[0][1].ToString();
                    string s3 = ds.Tables[0].Rows[0][2].ToString();
                    string s4 = ds.Tables[0].Rows[0][3].ToString();
                    string s5 = ds.Tables[0].Rows[0][4].ToString();
                    string s6 = ds.Tables[0].Rows[0][5].ToString();
                    string s7 = ds.Tables[0].Rows[0][6].ToString();
                    string s8 = ds.Tables[0].Rows[0][7].ToString();
                    string s9 = ds.Tables[0].Rows[0][8].ToString();

                    txtname.Text = s1;
                    txtid.Text = s2;
                    RadioBtn.SelectedValue = s3;
                    txtphone.Text = s4;
                    txtdob.Text = s5;
                    txtaddress.Text = s6;
                    txtdynamic.Text = s7;
                    txtusername.Text = s8;
                    txtpassword.Text = s9;
                }
                else
                {
                    Response.Write("<script>alert('User Not Found');</script>");
                    //Label15.Visible = true;
                }
            }
            else if (DropDownList1.SelectedValue == "STUDENT")
            {

                string query1 = "select count(*) from studentdetails where username='" + txtusernamefirst.Text + "'";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(query1, con);
                string output = cmd2.ExecuteScalar().ToString();

                if (output == "1")
                {
                    Session["user"] = txtusernamefirst.Text;
                    txtaddress.Visible = true;
                    txtconfirmpassword.Visible = true;
                    txtdob.Visible = true;
                    txtdynamic.Visible = true;
                    txtid.Visible = true;
                    txtname.Visible = true;
                    txtpassword.Visible = true;
                    txtphone.Visible = true;
                    txtusername.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label2.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label9.Visible = true;
                    Label3.Visible = true;
                    Label16.Visible = false;
                    txtsemester.Visible = true;
                    listtype.Visible = true;
                    RadioBtn.Visible = true;

                    txtaddress.Text = "";
                    txtconfirmpassword.Text = "";
                    txtdob.Text = "";
                    txtdynamic.Text = "";
                    txtid.Text = "";
                    txtname.Text = "";
                    txtpassword.Text = "";
                    txtphone.Text = "";
                    txtusername.Text = "";

                    Label16.Visible = false;
                    txtsemester.Text = "";
                    listtype.SelectedValue = "SELECT";

                    SqlDataAdapter da = new SqlDataAdapter("select * from studentdetails where username = '" + txtusernamefirst.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "studentdetails");
                    string s1 = ds.Tables[0].Rows[0][0].ToString();
                    string s2 = ds.Tables[0].Rows[0][1].ToString();
                    string s3 = ds.Tables[0].Rows[0][2].ToString();
                    string s4 = ds.Tables[0].Rows[0][3].ToString();
                    string s5 = ds.Tables[0].Rows[0][4].ToString();
                    string s6 = ds.Tables[0].Rows[0][5].ToString();
                    string s7 = ds.Tables[0].Rows[0][6].ToString();
                    string s8 = ds.Tables[0].Rows[0][7].ToString();
                    string s9 = ds.Tables[0].Rows[0][8].ToString();
                    string s10 = ds.Tables[0].Rows[0][8].ToString();

                    txtname.Text = s1;
                    txtid.Text = s2;
                    RadioBtn.SelectedValue = s3;
                    txtphone.Text = s4;
                    txtdob.Text = s5;
                    txtaddress.Text = s6;
                    txtdynamic.Text = s7;
                    txtusername.Text = s9;
                    txtpassword.Text = s10;
                    txtsemester.Text = s8;
                }
                else
                {
                    Response.Write("<script>alert('User Not Found');</script>");
                    //Label15.Visible = true;
                }
            }
        }
        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
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

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtphone.Text) ||
                string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) || string.IsNullOrWhiteSpace(txtconfirmpassword.Text) || string.IsNullOrWhiteSpace(txtdob.Text) || string.IsNullOrWhiteSpace(txtdynamic.Text) || (listtype.SelectedValue == "SELECT"))
            {
                Response.Write("<script>alert('Please fill in complete details below');</script>");
                //Label17.Visible = true;
                //Response.Write("Please Fill complete details");
            }
            else
            {
                if (txtpassword.Text != txtconfirmpassword.Text)
                {
                    Response.Write("<script>alert('Password do not match!!!');</script>");
                   // Label18.Text = "Password do not match";
                }
                else
                {
                    if (listtype.SelectedValue == "ADMIN")
                    {
                        /*          SqlCommand cmd = new SqlCommand("insert into admindetails values('" + txtname.Text + "','" + txtid.Text + "','" +
                                      RadioBtn.SelectedValue + "','" + txtphone.Text + "','" + txtdob.Text + "','" + txtaddress.Text + "','" + txtdynamic.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con); */
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("update admindetails set aname=@n, aid=@i, gender=@g, phoneno=@pn, dob=@d, address=@a, branch=@b, password=@p where username=@u", con))
                        {

                            cmd.Parameters.AddWithValue("@n", txtusername.Text);
                            cmd.Parameters.AddWithValue("@i", txtid.Text);
                            cmd.Parameters.AddWithValue("@g", RadioBtn.SelectedItem.Text);
                            cmd.Parameters.AddWithValue("@pn", txtphone.Text);
                            cmd.Parameters.AddWithValue("@d", txtdob.Text);
                            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
                            cmd.Parameters.AddWithValue("@b", txtdynamic.Text);
                            cmd.Parameters.AddWithValue("@u", txtusername.Text);
                            cmd.Parameters.AddWithValue("@p", txtpassword.Text);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                Response.Write("<script>alert('User Details Updated Successfully');</script>");
                                //Label19.Visible = true;

                                //making everything invisible
                                {
                                    Label10.Visible = false;
                                    Label11.Visible = false;
                                    Label12.Visible = false;
                                    Label13.Visible = false;
                                    Label2.Visible = false;
                                    Label3.Visible = false;
                                    Label4.Visible = false;
                                    Label5.Visible = false;
                                    Label6.Visible = false;
                                    Label7.Visible = false;
                                    Label8.Visible = false;
                                    Label9.Visible = false;
                                    Label16.Visible = false;

                                    listtype.Visible = false;
                                    RadioBtn.Visible = false;

                                    txtaddress.Visible = false;
                                    txtconfirmpassword.Visible = false;
                                    txtdob.Visible = false;
                                    txtdynamic.Visible = false;
                                    txtname.Visible = false;
                                    txtid.Visible = false;
                                    txtpassword.Visible = false;
                                    txtphone.Visible = false;
                                    txtsemester.Visible = false;
                                    txtusername.Visible = false;
                                }
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
                    else if (listtype.SelectedValue == "STAFF")
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("update staffdetails set aname=@n, aid=@i, gender=@g, phoneno=@pn, dob=@d, address=@a, designation=@b, password=@p where username=@u", con))
                        {

                            cmd.Parameters.AddWithValue("@n", txtusername.Text);
                            cmd.Parameters.AddWithValue("@i", txtid.Text);
                            cmd.Parameters.AddWithValue("@g", RadioBtn.SelectedItem.Text);
                            cmd.Parameters.AddWithValue("@pn", txtphone.Text);
                            cmd.Parameters.AddWithValue("@d", txtdob.Text);
                            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
                            cmd.Parameters.AddWithValue("@b", txtdynamic.Text);
                            cmd.Parameters.AddWithValue("@u", txtusername.Text);
                            cmd.Parameters.AddWithValue("@p", txtpassword.Text);
                            try
                            {
                                cmd.ExecuteNonQuery();
                                Response.Write("<script>alert('User details updated successfully');</script>");
                                //Label19.Visible = true;

                                {
                                    Label10.Visible = false;
                                    Label11.Visible = false;
                                    Label12.Visible = false;
                                    Label13.Visible = false;
                                    Label2.Visible = false;
                                    Label3.Visible = false;
                                    Label4.Visible = false;
                                    Label5.Visible = false;
                                    Label6.Visible = false;
                                    Label7.Visible = false;
                                    Label8.Visible = false;
                                    Label9.Visible = false;
                                    Label16.Visible = false;

                                    listtype.Visible = false;
                                    RadioBtn.Visible = false;

                                    txtaddress.Visible = false;
                                    txtconfirmpassword.Visible = false;
                                    txtdob.Visible = false;
                                    txtdynamic.Visible = false;
                                    txtname.Visible = false;
                                    txtid.Visible = false;
                                    txtpassword.Visible = false;
                                    txtphone.Visible = false;
                                    txtsemester.Visible = false;
                                    txtusername.Visible = false;
                                }
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
                    else
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("update studentdetails set aname=@n, aid=@i, gender=@g, phoneno=@pn, dob=@d, address=@a, course=@c, semester=@s, password=@p where username=@u", con))
                        {

                            cmd.Parameters.AddWithValue("@n", txtusername.Text);
                            cmd.Parameters.AddWithValue("@i", txtid.Text);
                            cmd.Parameters.AddWithValue("@g", RadioBtn.SelectedItem.Text);
                            cmd.Parameters.AddWithValue("@pn", txtphone.Text);
                            cmd.Parameters.AddWithValue("@d", txtdob.Text);
                            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
                            cmd.Parameters.AddWithValue("@c", txtdynamic.Text);
                            cmd.Parameters.AddWithValue("@s", txtdynamic.Text);
                            cmd.Parameters.AddWithValue("@u", txtusername.Text);
                            cmd.Parameters.AddWithValue("@p", txtpassword.Text);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                Response.Write("New STUDENT added successfully");
                                con.Close();

                                {
                                    Label10.Visible = false;
                                    Label11.Visible = false;
                                    Label12.Visible = false;
                                    Label13.Visible = false;
                                    Label2.Visible = false;
                                    Label3.Visible = false;
                                    Label4.Visible = false;
                                    Label5.Visible = false;
                                    Label6.Visible = false;
                                    Label7.Visible = false;
                                    Label8.Visible = false;
                                    Label9.Visible = false;
                                    Label16.Visible = false;

                                    listtype.Visible = false;
                                    RadioBtn.Visible = false;

                                    txtaddress.Visible = false;
                                    txtconfirmpassword.Visible = false;
                                    txtdob.Visible = false;
                                    txtdynamic.Visible = false;
                                    txtname.Visible = false;
                                    txtid.Visible = false;
                                    txtpassword.Visible = false;
                                    txtphone.Visible = false;
                                    txtsemester.Visible = false;
                                    txtusername.Visible = false;
                                }
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
        }
    }
}