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
    public partial class Fm5totalprofit : Form
    {
        public Fm5totalprofit()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = System.DateTime.Now.ToString();
        }

        private void Fm5totalprofit_Load(object sender, EventArgs e)
        {
            TextBox1.Text = System.DateTime.Now.ToString();
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.FillBy2(this.BMSCsharpDataSet7.sellclothes);

            this.reportViewer1.RefreshReport();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
