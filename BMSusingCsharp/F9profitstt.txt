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
    public partial class F9profitstt : Form
    {
        public F9profitstt()
        {
            InitializeComponent();
        }

        private void F9profitstt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.sellclothes' table. You can move, or remove it, as needed.
            
            string s1 = F8reports.passingtext3;
            string s2 = F8reports.passingtext4;
            TextBox1.Text = s1;
            TextBox2.Text = s2;
            this.sellclothesTableAdapter.FillByin(this.BMSCsharpDataSet7.sellclothes, TextBox1.Text.ToString(), TextBox2.Text.ToString());
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
