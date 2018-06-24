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
    public partial class F7sellinvoice : Form
    {
        public F7sellinvoice()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void F7sellinvoice_Load(object sender, EventArgs e)
        {
            /* // TODO: This line of code loads data into the 'bMSCsharpDataSet3.sellclothes' table. You can move, or remove it, as needed.
             this.sellclothesTableAdapter.Fill(this.bMSCsharpDataSet3.sellclothes);
             // TODO: This line of code loads data into the 'sellclothes._sellclothes' table. You can move, or remove it, as needed.
             //this.sellclothesTableAdapter.Fill(this.sellclothes._sellclothes);
             //  F6sellclothes ob2 = new F6sellclothes();
             //  textBox1.Text= ob2.txtinvoiceno.Text;
             //  MessageBox.Show(textBox1.Text);
             // string s2 = ob2.txtinvisible.Text;
             // MessageBox.Show(s2);
             con.Open();
             // txtinvoicenno.Text = s2;
             //[clthid][clthname][clthdesc][available][clthtype][singlprice][custid][custname][invoiceno][selldate][sellprice][qntpurchased]
             txtinvoicenno.Text = F6sellclothes.passingtext;
             SqlDataAdapter da = new SqlDataAdapter("select * from sellclothes where invoiceno='" +txtinvoicenno.Text+ "'", con);
             DataSet ds = new DataSet();
             da.Fill(ds, "sellclothes");
             string s3 = ds.Tables[0].Rows[0][7].ToString();
             txtcustomer.Text = s3;
             string s4 = ds.Tables[0].Rows[0][12].ToString();
             txtphone.Text = s4;
             string s5 = ds.Tables[0].Rows[0][13].ToString();
             txtaddress.Text = s5;
             //dateTimePicker1.Text = ds.Tables[0].Rows[0][11].ToString();
             // dateTimePicker1.Text = s6;*/
            string s1 = F6sellclothes.passingtext;
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.FillByout(this.BMSCsharpDataSet7.sellclothes, s1);
            //this.sellclothesTableAdapter.Fill(this.bMSCsharpDataSet3.sellclothes);
            this.reportViewer1.RefreshReport();
            con.Open();
            txtinvoicenno.Text = F6sellclothes.passingtext;
            SqlDataAdapter da = new SqlDataAdapter("select * from sellclothes where invoiceno='" + txtinvoicenno.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sellclothes");
            string s3 = ds.Tables[0].Rows[0][7].ToString();
            txtcustomer.Text = s3;
            string s4 = ds.Tables[0].Rows[0][12].ToString();
            txtphone.Text = s4;
            string s5 = ds.Tables[0].Rows[0][13].ToString();
            txtaddress.Text = s5;
            this.reportViewer1.RefreshReport();
            con.Close();

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
