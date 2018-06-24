using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSusingCsharp
{
    public partial class F8reports : Form
    {
        public F8reports()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F8reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMSCsharpDataSet4.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.Fill(this.bMSCsharpDataSet4.sellclothes);

        }
        public static String passingtext1;
        public static string passingtext2;
        private void btnsellstt_Click(object sender, EventArgs e)
        {
            passingtext1 = dtpfrom2.Text;
            passingtext2 = dtpto2.Text;
            Fm1sellstt ob1 = new Fm1sellstt();
            ob1.ShowDialog();
        }
        public static String passingtext3;
        public static string passingtext4;
        private void btnprintstt_Click(object sender, EventArgs e)
        {
            passingtext3 = dtpfrom1.Text;
            passingtext4 = dtpto1.Text;
            F9profitstt ob1 = new F9profitstt();
            ob1.ShowDialog();
        }
        public static string passingtext5;
        private void btnprint_Click(object sender, EventArgs e)
        {
            passingtext5 = comboBox1.Text;
            Fm6invoice ob1 = new Fm6invoice();
            ob1.ShowDialog();
        }

        private void btnstkcloth_Click(object sender, EventArgs e)
        {
            fm2stckclth ob1 = new fm2stckclth();
            ob1.ShowDialog();
        }

        private void btnstkalert_Click(object sender, EventArgs e)
        {
            Fm3stckalert ob1 = new Fm3stckalert();
            ob1.ShowDialog();
        }

        private void btntotalsell_Click(object sender, EventArgs e)
        {
            Fm4totalsell ob1 = new Fm4totalsell();
            ob1.ShowDialog();
        }

        private void btntotalprint_Click(object sender, EventArgs e)
        {
            Fm5totalprofit ob1 = new Fm5totalprofit();
            ob1.ShowDialog();
        }

        private void btnallcust_Click(object sender, EventArgs e)
        {
            Fm7allcustomer ob1 = new Fm7allcustomer();
            ob1.ShowDialog();
        }
    }
}
