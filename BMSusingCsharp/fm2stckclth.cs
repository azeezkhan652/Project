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
    public partial class fm2stckclth : Form
    {
        public fm2stckclth()
        {
            InitializeComponent();
        }

        private void fm2stckclth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.clothes' table. You can move, or remove it, as needed.
            this.clothesTableAdapter.Fill(this.BMSCsharpDataSet7.clothes);
            TextBox1.Text = System.DateTime.Now.ToString();
            this.reportViewer1.RefreshReport();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
