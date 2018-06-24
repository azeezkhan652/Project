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
    public partial class Fm3stckalert : Form
    {
        public Fm3stckalert()
        {
            InitializeComponent();
        }

        private void Fm3stckalert_Load(object sender, EventArgs e)
        {
            this.clothesTableAdapter.FillByIN(this.BMSCsharpDataSet7.clothes);
            TextBox1.Text = System.DateTime.Now.ToString();
            this.reportViewer1.RefreshReport();
        }
    }
}
