﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BMSusingCsharp
{
    public partial class Fm8employee : Form
    {
        
        public Fm8employee()
        {
            InitializeComponent();
        }

        private void cmb2custname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb2custcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2editcust_Click(object sender, EventArgs e)
        {

        }

        private void btn2newcust_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtaddemployee_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BMSCsharp;Integrated Security=True");
        private void btnsave1_Click(object sender, EventArgs e)
        {   if (txtempcode1.Text == "" ||txtphone1.Text==""|| txtempname1.Text == "" || txtadd1.Text == "" || txtsalary1.Text == "" || cmb1designation.Text == "")
            {
                MessageBox.Show("Please enter complete details");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into employeeS values('" + txtempcode1.Text + "', '" + txtempname1.Text + "','" + txtadd1.Text + "','"+txtphone1.Text+"','" + cmb1designation.Text + "','" + txtsalary1.Text + "','" + dtp1.Text.ToString() + "')", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Employee added successfully");
                    con.Close();
                    txtempcode1.Text = "";
                    txtempname1.Text = "";
                    txtadd1.Text = "";
                    cmb1designation.Text = "";
                    txtsalary1.Text = "";
                    txtphone1.Text = "";
                }
                catch (Exception )
                {
                    MessageBox.Show("Invalid employee name");
                    //MessageBox.Show(E.ToString() + "Employee code already exist");
                    con.Close();
                }
            }
        }

        private void Fm8employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMSCsharpDataSet8.employeeS' table. You can move, or remove it, as needed.
            this.employeeSTableAdapter.Fill(this.bMSCsharpDataSet8.employeeS);
            cmb2empcode.Text = "";
            cmb2empname.Text = "";

        }
        
        //[empcode][empname][address][phoneno][designation][salary][joindate]
        private void btnsave2_Click(object sender, EventArgs e)
        {
            if(cmb2designation.Text==""||cmb2empcode.Text==""||cmb2empname.Text==""||txtadd2.Text==""||txtphone2.Text==""||txtsalary2.Text=="")
            {
                MessageBox.Show("Please enter complete details");
            }
            else
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update employeeS set empname=@en, address=@ad, phoneno=@pn, designation=@dg, salary=@sal, joindate=@jd where empcode=@ec", con))
                {
                    cmd.Parameters.AddWithValue("@en",cmb2empname.Text);
                    cmd.Parameters.AddWithValue("@ad",txtadd2.Text);
                    cmd.Parameters.AddWithValue("@pn",txtphone2.Text);
                    cmd.Parameters.AddWithValue("@dg",cmb2designation.Text);
                    cmd.Parameters.AddWithValue("@sal",txtsalary2.Text);
                    cmd.Parameters.AddWithValue("@jd",dtp2.Text.ToString());
                    cmd.Parameters.AddWithValue("@ec", cmb2empcode.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Employee details updated successfully");
                con.Close();
                txtadd2.Text = "";
                cmb2designation.Text = "";
                txtsalary2.Text = "";
                txtphone2.Text = "";
                cmb2empcode.Text = "";
                cmb2empname.Text = "";
            }
        }

        //[empcode][empname][address][phoneno][designation][salary][joindate]
        private void cmb2empcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employeeS where empcode = '" + cmb2empcode.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employeeS");
            string s1 = ds.Tables[0].Rows[0][1].ToString(); 
            string s2 = ds.Tables[0].Rows[0][2].ToString();
            string s3 = ds.Tables[0].Rows[0][3].ToString();
            string s4 = ds.Tables[0].Rows[0][4].ToString();
            string s5 = ds.Tables[0].Rows[0][5].ToString();
            string s6 = ds.Tables[0].Rows[0][6].ToString();

            cmb2empname.Text = s1;
            txtadd2.Text = s2;
            txtphone2.Text = s3;
            cmb2designation.Text = s4;
            txtsalary2.Text = s5;
            dtp2.Text = s6;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmb2empname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employeeS where empname = '" + cmb2empname.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employeeS");
            string s1 = ds.Tables[0].Rows[0][0].ToString();
            string s2 = ds.Tables[0].Rows[0][2].ToString();
            string s3 = ds.Tables[0].Rows[0][3].ToString();
            string s4 = ds.Tables[0].Rows[0][4].ToString();
            string s5 = ds.Tables[0].Rows[0][5].ToString();
            string s6 = ds.Tables[0].Rows[0][6].ToString();

            cmb2empcode.Text = s1;
            txtadd2.Text = s2;
            txtphone2.Text = s3;
            cmb2designation.Text = s4;
            txtsalary2.Text = s5;
            dtp2.Text = s6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from employeeS where empcode = '" + cmb2empcode.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee removed successfully");
            con.Close();
            cmb2empcode.Text = "";
            txtadd2.Text = "";
            cmb2designation.Text = "";
            txtsalary2.Text = "";
            txtphone2.Text = "";
            cmb2empname.Text = "";
        }

        

        private void btnsavepic_Click(object sender, EventArgs e)
        {

        }

        private void txtempcode1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
