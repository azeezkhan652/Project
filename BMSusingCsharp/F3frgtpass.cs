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
    public partial class F3frgtpass : Form
    {
        public F3frgtpass()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void F3frgtpass_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtanswer.Text == "" || txtquestion.Text == "" || txtusername.Text == "")
            {
                label1.Text = "";
                label1.Text = "PLEASE ENTER COMPLETE DETAILS";
                //MessageBox.Show("Please enter complete details");
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from loginnew where username='" + txtusername.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "loginnew");
                    try
                    {
                        string s1 = ds.Tables[0].Rows[0][3].ToString();
                        string s2 = ds.Tables[0].Rows[0][1].ToString();
                        if (txtanswer.Text == s1)
                        {
                            label1.Text = "CORRECT ANSWER";
                            //MessageBox.Show("Correct answer");
                            MessageBox.Show(s2);
                            this.Hide();
                        }
                        else
                        {
                            label1.Text = "INCORRECT ANSWER";
                            //  MessageBox.Show("Incorrect answer");
                            txtanswer.Text = "";
                        }
                    }
                    catch (Exception)
                    {
                        label1.Text = "USERNAME DOESNT EXIST";
                        //MessageBox.Show("Username doesnt exist");
                        txtanswer.Text = "";
                        txtusername.Text = "";
                    }
                }
                catch(Exception)
                {
                    label1.Text = "Error";
                    MessageBox.Show("Error in accessing database!!! System reloading");
                    Application.Restart();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
