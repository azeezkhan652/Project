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
    public partial class Fm6invoice : Form
    {
        public Fm6invoice()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");

        private void Fm6invoice_Load(object sender, EventArgs e)
        {
            string s1 = F8reports.passingtext5;
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.FillByout(this.BMSCsharpDataSet7.sellclothes, s1);
            //this.sellclothesTableAdapter.Fill(this.bMSCsharpDataSet3.sellclothes);
            this.reportViewer1.RefreshReport();
            con.Open();
            txtinvoicenno.Text = F8reports.passingtext5;
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
    }
}
