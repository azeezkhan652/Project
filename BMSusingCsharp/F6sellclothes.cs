using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMSusingCsharp
{
    public partial class F6sellclothes : Form
    {
        public F6sellclothes()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void F6sellclothes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clthsell2.clothes' table. You can move, or remove it, as needed.
            this.clothesTableAdapter.Fill(this.clthsell2.clothes);
            // TODO: This line of code loads data into the 'clthsell.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.clthsell.customer);
            btnprint.Visible = false;
            btnnewinvoice.Visible = false;
            btnnewinvoice.Enabled = false;
            btnprint.Enabled = false;
            cmbclthid.Text = "";
            cmbclthname.Text = "";
            txtavialable.Text = "";
            cmbcustid.Text = "";
            txtclthdesc.Text = "";
            txtinvoiceno.Text = "";
            txtsellprice.Text = "";
            txtsinglprice.Text = "";
            txtqnt.Text = "";
            cmbcustname.Text = "";
            cmbclthtype.Text = "";


        }

        //--  public class abc
        //--{
        //--  public int put(string ss)
        //-- {
        //--  int ss1 = int.Parse(ss);
        //--int ss2 = (ss1 * 10) / 100;
        //--int ss3 = ss1 + ss2;
        //--return (ss3);
        //--}


        //-- }
        private void cmbclthid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //.  if (label2.Enabled == true)
            //. {
            //.     MessageBox.Show("label 2 is enabled");
            //.    string ss1 = txtsinglprice.Text;
            //.    int ss2 = int.Parse(ss1);
            //.    int ss3 = (ss2 * 10) / 100;
            //.    string ss4 = ss3.ToString();
            //.    txtsellprice.Text = ss4;
            //. }
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothnumber='"+cmbclthid.Text+"'",con);
            //SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothnumber='" + cmbclthid.Text + "' and clothname='" + cmbclthname.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "clothes");
            string s4 = ds.Tables[0].Rows[0][1].ToString();
            cmbclthname.Text = s4;


            //string s5 = ds.Tables[0].Rows[0][4].ToString();
            //int s7 = int.Parse(s5);
            //int s8 = (s7 * 10) / 100;
            //int s9 = s8 + s7;
            //txtsellprice.Text = s9.ToString();

            try
            {
                //string s4 = ds.Tables[0].Rows[0][1].ToString();
                //cmbclthname.Text = s4;
                string s1 = ds.Tables[0].Rows[0][3].ToString();
                txtavialable.Text = s1;
                string s3 = ds.Tables[0].Rows[0][5].ToString();
                cmbclthtype.Text = s3;
                string s10 = ds.Tables[0].Rows[0][4].ToString();
                txtsinglprice.Text = s10;


                //-- abc ob1 = new abc();
                //--int s11 = ob1.put(txtsinglprice.Text);
                //--string s12 = s11.ToString();
                //--txtsellprice.Text = s12;
                //int s7 = int.Parse(s5);
                // int s8 = (s7 * 10) / 100;
                //int s9 = s8 + s7;
                // txtsellprice.Text = s9.ToString();
                string s6 = ds.Tables[0].Rows[0][2].ToString();
                txtclthdesc.Text = s6;
               /* int s2;
                s2 = int.Parse(s1);
                if (s2 > 0)
                {
                    txtavialable.Text = "Yes";
                    con.Close();
                    //.       label2.Enabled = true;
                }
                else
                {
                    txtavialable.Text = "No";
                    con.Close();
                    //.     label2.Enabled = true;
                }
                */
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!Reload the form");
            }
            con.Close();
        }

        private void cmbclthname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // con.Open();
            // SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothnumber='" + cmbclthid.Text + "' or clothname='" + cmbclthname.Text + "'", con);
            // DataSet ds = new DataSet();
            //  da.Fill(ds, "clothes");
            //try
            //{
            //  string s1 = ds.Tables[0].Rows[0][3].ToString();
            // int s2;
            //s2 = int.Parse(s1);
            //if (s2 > 0)
            //{
            //   txtavialable.Text = "Yes";
            // con.Close();
            //}
            //else
            //{
            //  txtavialable.Text = "No";
            // con.Close();
            //  }
            // }
            //catch (Exception)
            //{
            //  MessageBox.Show("Error!!!Reload the form");
            //con.Close();
            //}
            //con.Close();
            //selling price
            // string s5 = ds.Tables[0].Rows[0][4].ToString();
            //  int s7 = int.Parse(s5);
            //  int s8 = (s7 * 10) / 100;
            //  int s9 = s8 + s7;
            // txtsellprice.Text = s9.ToString();
            // con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtsellprice.Text == "" || txtqnt.Text == "" || txtinvoiceno.Text == "" || cmbclthid.Text == "" || cmbclthname.Text == "" || cmbclthtype.Text == "" || cmbcustid.Text == "" || cmbcustname.Text == "")
            {
                MessageBox.Show("Please provide complete details");
            }
            else
            //[clthid][clthname][clthdesc][available][clthtype][singlprice][custid][custname][invoiceno][selldate][sellprice][qntpurchased]
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from customer where custcode='" + cmbcustid.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                string s4 = ds.Tables[0].Rows[0][2].ToString();
                string s2 = ds.Tables[0].Rows[0][3].ToString();
                int s = int.Parse(txtavialable.Text);
                if (s == 0)
                {
                    MessageBox.Show("The selected product is out of stock");
                    cmbclthid.Text = "";
                    cmbclthname.Text = "";
                    txtavialable.Text = "";
                    txtclthdesc.Text = "";
                    txtsellprice.Text = "";
                    txtsinglprice.Text = "";
                    txtqnt.Text = "";
                    cmbclthtype.Text = "";


                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into sellclothes values('" + cmbclthid.Text + "','" + cmbclthname.Text + "','" + txtclthdesc.Text + "','" + txtavialable.Text + "','" + cmbclthtype.Text + "','" + txtsinglprice.Text + "','" + cmbcustid.Text + "','" + cmbcustname.Text + "','" + txtinvoiceno.Text + "','" + dateTimePicker1.Value + "','" + txtsellprice.Text + "','" + txtqnt.Text + "','" + s4 + "','" + s2 + "')", con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Selling details saved successfully");
                        btnnewinvoice.Enabled = true;
                        btnnewinvoice.Visible = true;
                        btnprint.Enabled = true;
                        btnprint.Visible = true;
                        string s1 = txtinvoiceno.Text;
                        txtinvisible.Text = s1;
                        txtinvoiceno.Enabled = false;
                        cmbcustname.Enabled = false;
                        cmbcustid.Enabled = false;
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error!!!Details were not saved");
                        con.Close();
                    }
                }
                con.Close();
            }
        }

        private void btnnewinvoice_Click(object sender, EventArgs e)
        {
            txtinvoiceno.Enabled = true;
            cmbcustname.Enabled = true;
            cmbcustid.Enabled = true;
            cmbclthid.Text = "";
            cmbclthname.Text = "";
            txtavialable.Text = "";
            cmbcustid.Text = "";
            txtclthdesc.Text = "";
            txtinvoiceno.Text = "";
            txtsellprice.Text = "";
            txtsinglprice.Text = "";
            txtqnt.Text = "";
            cmbcustname.Text = "";
            cmbclthtype.Text = "";
            txtinvisible.Text = "";
            btnprint.Visible = false;
            txtinvisible.Visible = false;
        }
        //[custcode][custname][address][phnno]
        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from customer where custcode='" + cmbcustid.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            string s1 = ds.Tables[0].Rows[0][1].ToString();
            cmbcustname.Text = s1;
            con.Close();
        }
        public static string passingtext;
        private void btnprint_Click(object sender, EventArgs e)
        {
            passingtext = txtinvisible.Text;
            F7sellinvoice ob1 = new F7sellinvoice();
            ob1.Show();
        }

        private void cmbcustname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con.Open();
            //   SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothname='"+cmbcustname.Text+"'",con);
            // DataSet ds = new DataSet();
            //  da.Fill(ds, "clothes");
            // string s1 = ds.Tables[0].Rows[0][6].ToString();
            //  int s2 = int.Parse(s1);
            // if (s2 == 1)
            //   {
            //      string s3 = ds.Tables[0].Rows[0][0].ToString();
            //      cmbclthid.Text = s3;
            //      con.Close();
            //  }
            //  con.Close();
        }

      
        private void txtsellprice_TextChanged(object sender, EventArgs e)
        {
        }
        public static string passingtext1;
        private void button1_Click(object sender, EventArgs e)
        {
            passingtext1 = txtinvoiceno.Text;
            Fm9editinvoice ob1 = new Fm9editinvoice();
            ob1.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
