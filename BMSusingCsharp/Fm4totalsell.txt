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
    public partial class Fm4totalsell : Form
    {
        public Fm4totalsell()
        {
            InitializeComponent();
        }

        private void Fm4totalsell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMSCsharpDataSet7.sellclothes' table. You can move, or remove it, as needed.
            this.sellclothesTableAdapter.FillBy1(this.BMSCsharpDataSet7.sellclothes);
            TextBox1.Text = System.DateTime.Now.ToString();
            this.reportViewer1.RefreshReport();
        }
    }
}
