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
    public partial class Fm9editinvoice : Form
    {
        public Fm9editinvoice()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void Fm9editinvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMSCsharpDataSet10.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter1.Fill(this.bMSCsharpDataSet10.sellclothes);
            string s1 = F6sellclothes.passingtext1;
            textBox1.Text = s1;
            // TODO: This line of code loads data into the 'bMSCsharpDataSet9.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.Fill(this.bMSCsharpDataSet9.sellclothes,s1);
           
           
           
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from sellclothes where invoiceno='" + textBox1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sellclothes");
            string s3 = ds.Tables[0].Rows[0][0].ToString();
            cmbclthid.Text = s3;
            string s4 = ds.Tables[0].Rows[0][1].ToString();
            cmbclthname.Text = s4;
            string s6 = ds.Tables[0].Rows[0][6].ToString();
            cmbcustid.Text = s6;
            string s7 = ds.Tables[0].Rows[0][7].ToString();
            cmbcustname.Text = s7;
            string s5 = ds.Tables[0].Rows[0][2].ToString();
            txtclthdesc.Text = s5;
            string s8 = ds.Tables[0].Rows[0][9].ToString();
            dateTimePicker1.Text = s8;
            string s9 = ds.Tables[0].Rows[0][3].ToString();
            txtavialable.Text = s9;
            string s10 = ds.Tables[0].Rows[0][4].ToString();
            cmbclthtype.Text = s10;
            string s11 = ds.Tables[0].Rows[0][5].ToString();
            txtsinglprice.Text = s11;
            string s12 = ds.Tables[0].Rows[0][11].ToString();
            txtqnt.Text = s12;
            string s13 = ds.Tables[0].Rows[0][10].ToString();
            txtsellprice.Text = s13;
            textBox1.Enabled = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from sellclothes where clthid = '" + cmbclthid.Text + "' and clthname ='" + cmbclthname.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item removed successfully");
                con.Close();
                cmbclthid.Text = "";
                cmbclthname.Text = "";
                txtclthdesc.Text = "";
                txtavialable.Text = "";
                txtqnt.Text = "";
                txtsellprice.Text = "";
                txtsinglprice.Text = "";
            }
            catch (Exception E)
            {
                MessageBox.Show("Error! Please try again", E.ToString());
            }
        }

        
    }
}
