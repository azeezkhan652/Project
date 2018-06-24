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
    public partial class F5customer : Form
    {
        public F5customer()
        {
            InitializeComponent();
        }

        private void F5customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cust.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cust.customer);
            cmb2custcode.Text = "";
            cmb2custname.Text = "";
            txt2address.Text = "";
            txt2phnno.Text = "";
        }

        private void btn2exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void btn1save_Click(object sender, EventArgs e)
        {
            if (txt1address.Text==""||txt1custcode.Text==""||txt1custname.Text==""||txt1phnno.Text=="")
            {
                MessageBox.Show("Please enter complete details");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into customer values('"+txt1custcode.Text+"','"+txt1custname.Text+"','"+txt1address.Text+"','"+txt1phnno.Text+"')", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New customer added successfully");
                    con.Close();
                    txt1address.Text = "";
                    txt1custcode.Text = "";
                    txt1phnno.Text = "";
                    txt1custname.Text = "";
                }
                catch(Exception)
                {
                    MessageBox.Show("Customer code already exist");
                }
                con.Close();
            }
        }

        private void btn1newcust_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(1);
        }

        private void btn1editcust_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(0);

        }

        private void btn2newcust_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(1);
        }

        private void btn2editcust_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(0);
        }
        //[custcode][custname][address][phnno]
        private void btn2update_Click(object sender, EventArgs e)
        {
            if(txt2address.Text==""||txt2phnno.Text==""||cmb2custcode.Text==""||cmb2custname.Text=="")
            {
                MessageBox.Show("Please eneter complete details");
            }
            else
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update customer set custname=@cn, address=@ad, phnno=@pn where custcode=@cc", con) )
                {
                    cmd.Parameters.AddWithValue("@cn", cmb2custname.Text);
                    cmd.Parameters.AddWithValue("@ad", txt2address.Text);
                    cmd.Parameters.AddWithValue("@pn", txt2phnno.Text);
                    cmd.Parameters.AddWithValue("@cc", cmb2custcode.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Customer details updated successfully");
                con.Close();
                cmb2custcode.Text = "";
                cmb2custname.Text = "";
                txt2address.Text = "";
                txt2phnno.Text = "";
            }
        }

        private void cmb2custcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer where custcode='"+cmb2custcode.Text+"'",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            string s1 = ds.Tables[0].Rows[0][1].ToString();
            string s2 = ds.Tables[0].Rows[0][2].ToString();
            string s3 = ds.Tables[0].Rows[0][3].ToString();
            cmb2custname.Text = s1;
            txt2address.Text = s2;
            txt2phnno.Text = s3;
        }

        private void cmb2custname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer where custname='" + cmb2custname.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            try
            {
                string s1 = ds.Tables[0].Rows[0][0].ToString();
                string s2 = ds.Tables[0].Rows[0][2].ToString();
                string s3 = ds.Tables[0].Rows[0][3].ToString();
                cmb2custcode.Text = s1;
                txt2address.Text = s2;
                txt2phnno.Text = s3;
            }
            catch(Exception)
            {
                MessageBox.Show("Reload the form to see new updated details");
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            cmb2custcode.Text = "";
            cmb2custname.Text = "";
        }

        private void txt2phnno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from customer where custcode = '" + cmb2custcode.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Clothe removed successfully");
            con.Close();
            cmb2custcode.Text = "";
        }
    }
}
