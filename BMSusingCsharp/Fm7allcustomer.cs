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
    public partial class Fm7allcustomer : Form
    {
        public Fm7allcustomer()
        {
            InitializeComponent();
        }

        private void Fm7allcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.BMSCsharpDataSet7.customer);
            TextBox1.Text = System.DateTime.Now.ToString();
            this.reportViewer1.RefreshReport();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
