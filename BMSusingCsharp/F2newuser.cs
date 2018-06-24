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
    public partial class F2newuser : Form
    {
        public F2newuser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void F2newuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMSCsharpDataSet.login' table. You can move, or remove it, as needed.
            // this.loginTableAdapter.Fill(this.bMSCsharpDataSet.login);

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtquestion.Text==""||txtanswer.Text=="")
            {
                lblmsg.Text = "Please enter all details";
                txtanswer.Text = "";
                txtpassword.Text = "";
                txtanswer.Text = "";
                txtquestion.Text = "Your childhood friend?";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into loginnew values('" + txtusername.Text + "','" + txtpassword.Text + "','" + txtquestion.Text + "','" + txtanswer.Text + "')", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    lblmsg.Text = "New user has been addedd successfully";
                    txtanswer.Text = "";
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    con.Close();
                }
                catch(Exception)
                {
                    lblmsg.Text = "Username already exist";
                    txtusername.Text = "";
                }
                //F1login ob1 = new F1login();
                //ob1.Show();
                //this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
