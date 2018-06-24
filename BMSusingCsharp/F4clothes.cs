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
    public partial class F4clothes : Form
    {
        public F4clothes()
        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            //needed
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            cmd2clthtype.Text = "";
            cmd1selectclthname.Text = "";
            cmb1selectclthid.Text = "";
            txt2clthdesc.Text = "";
            txt2qnt.Text = "";
            txt2singlprice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            cmd2clthtype.Text = "";
            cmd1selectclthname.Text = "";
            cmb1selectclthid.Text = "";
            txt2clthdesc.Text = "";
            txt2qnt.Text = "";
            txt2singlprice.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void F4clothes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMSCsharpDataSet7.clothes' table. You can move, or remove it, as needed.
            this.clothesTableAdapter1.Fill(this.bMSCsharpDataSet7.clothes);
            // TODO: This line of code loads data into the 'dss.clothes' table. You can move, or remove it, as needed.
            //this.clothesTableAdapter.Fill(this.dss.clothes);
            // TODO: This line of code loads data into the 'bMSCsharpDataSet2.clothes' table. You can move, or remove it, as needed.
            // this.clothesTableAdapter.Fill(this.bMSCsharpDataSet2.clothes);
            cmd2clthtype.Text = "";
            cmd1selectclthname.Text = "";
            cmb1selectclthid.Text = "";
            txt2clthdesc.Text = "";
            txt2qnt.Text = "";
            txt2singlprice.Text = "";

        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtclthno.Text == "" || txtclthname.Text == "" || txtqnt.Text == "" || txtsinglprice.Text == "")
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                Refresh();
                SqlCommand cmd = new SqlCommand("insert into clothes values('" + txtclthno.Text + "','" + txtclthname.Text + "','" + txtclthdesc.Text + "','" + txtqnt.Text + "','"+txtsinglprice.Text+"','" + cmbclthtype.Text + "')", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Cloth addedd successfully");
                    con.Close();
                    txtclthdesc.Text = "";
                    txtclthname.Text = "";
                    txtclthno.Text = "";
                    txtqnt.Text = "";
                    txtsinglprice.Text = "";
                    cmbclthtype.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid cloth Number");
                }
                con.Close();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //Below are columns of database BMSCsharp and table clothes
            //[clothnumber][clothname][clothdesc][quantity][singleprice][clothtype]
            cmd2clthtype.Text = "";
            cmd1selectclthname.Text = "";
            cmb1selectclthid.Text = "";
            txt2clthdesc.Text = "";
            txt2qnt.Text = "";
            txt2singlprice.Text = "";
        }

        private void btn2update_Click(object sender, EventArgs e)
        {
            if (txt2singlprice.Text == "" || txt2qnt.Text == "" || txt2clthdesc.Text == "")
            {
                MessageBox.Show("Please enter completete details");
            }
            else
            {
                Refresh();
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE clothes SET clothname=@cnmVal, clothdesc=@cd, quantity=@q, singleprice=@sp, clothtype=@ct WHERE clothnumber=@cn", con))
                {
                    cmd.Parameters.AddWithValue("@cnmVal", cmd1selectclthname.Text);
                    cmd.Parameters.AddWithValue("@cd", txt2clthdesc.Text);
                    cmd.Parameters.AddWithValue("@q", txt2qnt.Text);
                    cmd.Parameters.AddWithValue("@sp", txt2singlprice.Text);
                    cmd.Parameters.AddWithValue("@ct", cmd2clthtype.Text);
                    cmd.Parameters.AddWithValue("@cn", cmb1selectclthid.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record updated successfully");
                con.Close();
                Refresh();
                cmb1selectclthid.Text = "";
                cmd1selectclthname.Text = "";
                txt2clthdesc.Text = "";
                txt2qnt.Text = "";
                txt2singlprice.Text = "";
                cmd2clthtype.Text = "";
            }
            this.Refresh();
        }

        private void cmb1selectclthid_SelectedIndexChanged(object sender, EventArgs e)
        { 
            SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothnumber='" + cmb1selectclthid.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "clothes");
            string s1 = ds.Tables[0].Rows[0][2].ToString();
            string s2 = ds.Tables[0].Rows[0][3].ToString();
            string s3 = ds.Tables[0].Rows[0][4].ToString();
            string s4 = ds.Tables[0].Rows[0][1].ToString();
            string s5 = ds.Tables[0].Rows[0][5].ToString();
            cmd1selectclthname.Text = s4;
            txt2clthdesc.Text = s1;
            txt2qnt.Text = s2;
            txt2singlprice.Text = s3;
            cmd2clthtype.Text = s5;
        }

        private void cmd1selectclthname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            SqlDataAdapter da = new SqlDataAdapter("select * from clothes where clothname='" + cmd1selectclthname.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "clothes");
            try
            {
                string s1 = ds.Tables[0].Rows[0][2].ToString();
                string s2 = ds.Tables[0].Rows[0][3].ToString();
                string s3 = ds.Tables[0].Rows[0][4].ToString();
                string s5 = ds.Tables[0].Rows[0][5].ToString();
                string s4 = ds.Tables[0].Rows[0][0].ToString();
                cmb1selectclthid.Text = s4;
                txt2clthdesc.Text = s1;
                txt2qnt.Text = s2;
                txt2singlprice.Text = s3;
                cmd2clthtype.Text = s5;
            }
            catch(Exception)
            {
                MessageBox.Show("Please reload this form to see new changes");
            }
        }
//[clothnumber][clothname][clothdesc][quantity][singleprice][clothtype]
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from clothes where clothnumber = '"+cmb1selectclthid.Text+"'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Clothe removed successfully");
            con.Close();
            cmb1selectclthid.Text = "";
            cmb1selectclthid.Refresh();
        }
    }
}
