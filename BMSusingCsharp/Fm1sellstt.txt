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
    public partial class Fm1sellstt : Form
    {
        public Fm1sellstt()
        {
            InitializeComponent();
        }

        private void Fm1sellstt_Load(object sender, EventArgs e)
        {
            string s1 = F8reports.passingtext1;
            string s2 = F8reports.passingtext2;
            TextBox1.Text = s1;
            textBox4.Text = s2;

            // TODO: This line of code loads data into the 'dataSet1.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.Fill(this.BMSCsharpDataSet7.sellclothes,TextBox1.Text.ToString(),textBox4.Text.ToString());

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
