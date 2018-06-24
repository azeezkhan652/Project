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
    public partial class F1login : Form
    {
        public F1login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void F1login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BMSCsharpDataSet8.employeeS' table. You can move, or remove it, as needed.
            //this.employeeSTableAdapter.Fill(this.BMSCsharpDataSet8.employeeS);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                lblmsg.Text = "Please enter compplete details";
            }
            else
            {
                try
                {
                    string s3 = txtusername.Text;
                    SqlDataAdapter da = new SqlDataAdapter("select * from loginnew where username='" + txtusername.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "loginnew");

                    try
                    {
                        string s1 = ds.Tables[0].Rows[0][0].ToString();
                        string s2 = ds.Tables[0].Rows[0][1].ToString();
                        if (txtusername.Text == s1 & txtpassword.Text == s2)
                        {
                            lblmsg.Text = "ACCESS GRANTED";
                            //MDIParent1 ob1 = new MDIParent1();
                            // ob1.Show();

                            timer1.Enabled = true;
                            txtpassword.Text = "";
                            txtusername.Text = "";
                        }
                        else
                        {
                            lblmsg.Text = "ACCESS DENIED";
                            txtusername.Text = "";
                            txtpassword.Text = "";
                        }
                    }
                    catch (Exception)
                    {

                        lblmsg.Text = "Invalid user";
                    }
                }
                catch(Exception)
                {
                    Application.Restart();
                }
              
            }
        }

        private void btnnewuser_Click(object sender, EventArgs e)
        {
           
            F2newuser ob1 = new F2newuser();
            ob1.ShowDialog();
        }

        private void btnfrgtpass_Click(object sender, EventArgs e)
        {
            F3frgtpass ob1 = new F3frgtpass();
            ob1.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F4clothes ob1 = new F4clothes();
            ob1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F5customer ob1 = new F5customer();
            ob1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F6sellclothes ob1 = new F6sellclothes();
            ob1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F7sellinvoice ob1 = new F7sellinvoice();
            ob1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F8reports ob1 = new F8reports();
            ob1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            F9profitstt ob1 = new F9profitstt();
            ob1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fm1sellstt ob1 = new Fm1sellstt();
            ob1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fm2stckclth ob1 = new fm2stckclth();
            ob1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fm3stckalert ob1 = new Fm3stckalert();
            ob1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fm4totalsell ob1 = new Fm4totalsell();
            ob1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fm5totalprofit ob1 = new Fm5totalprofit();
            ob1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Fm6invoice ob1 = new Fm6invoice();
            ob1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fm7allcustomer ob1 = new Fm7allcustomer();
            ob1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Fm8employee ob1 = new Fm8employee();
            ob1.ShowDialog();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            //Its for robot animations
            //pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
            progressBar1.Value = progressBar1.Value + 2;
            if(progressBar1.Value>20)
            {
                label1.Visible = true;
            }
            if(progressBar1.Value>99)
            { 
                F11Main ob1 = new F11Main();
                ob1.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //MDIParent1 ob1 = new MDIParent1();
            //ob1.Show();
            Form11main ob1 = new Form11main();
            ob1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            F11Main ob1 = new F11Main();
            this.Hide();
            ob1.FormClosed += (s, args) => this.Close();
            ob1.Show();
            ob1.Focus();
        }
    }
}
