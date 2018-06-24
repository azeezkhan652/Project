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
    public partial class F11Main : Form
    {
        public F11Main()
        {
            InitializeComponent();
        }

        private void F11Main_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            Timer2.Start();
            Timer3.Start();
            Timer4.Start();
            Timer5.Start();
            Timer6.Start();
            Timer7.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
                pictureBox6.Image = Image.FromFile("6.jpg");
                label2.Text = "1";
            }
            else if (label1.Text == "1")
            {
                label1.Text = "2";
                pictureBox6.Image = Image.FromFile("2.jpg");
                label2.Text = "2";
            }
            else if (label1.Text == "2")
            {
                label1.Text = "3";
                pictureBox6.Image = Image.FromFile("3.jpg");
                label2.Text = "3";
            }
            else if (label1.Text == "3")
            {
                label1.Text = "4";
                pictureBox6.Image = Image.FromFile("4.jpg");
                label2.Text = "4";
            }
            else if (label1.Text == "4")
            {
                label1.Text = "5";
                pictureBox6.Image = Image.FromFile("5.jpg");
                label2.Text = "5";
            }
            else if (label1.Text == "5")
            {
                label1.Text = "6";
                pictureBox6.Image = Image.FromFile("6.jpg");
                label2.Text = "6";
            }
            else if (label1.Text == "6")
            {
                label1.Text = "7";
                pictureBox6.Image = Image.FromFile("7.jpg");
                label2.Text = "7";
            }
            else if (label1.Text == "7")
            {
                label1.Text = "8";
                pictureBox6.Image = Image.FromFile("8.jpg");
                label2.Text = "8";
            }
            else if (label1.Text == "8")
            {
                label1.Text = "9";
                pictureBox6.Image = Image.FromFile("9.jpg");
                label2.Text = "9";
            }
            else if (label1.Text == "9")
            {
                label1.Text = "10";
                pictureBox6.Image = Image.FromFile("2.jpg");
                label2.Text = "10";
            }
            else if (label1.Text == "10")
            {
                label1.Text = "11";
                pictureBox6.Image = Image.FromFile("10.jpg");
                label2.Text = "11";
            }
            else if (label1.Text == "11")
            {
                label1.Text = "12";
                pictureBox6.Image = Image.FromFile("11.jpg");
                label2.Text = "12";
            }
            else if (label1.Text == "12")
            {
                label1.Text = "13";
                pictureBox6.Image = Image.FromFile("12.jpg");
                label2.Text = "13";
            }
            else if (label1.Text == "13")
            {
                label1.Text = "14";
                pictureBox6.Image = Image.FromFile("13.jpg");
                label2.Text = "14";
            }
            else if (label1.Text == "14")
            {
                label1.Text = "15";
                pictureBox6.Image = Image.FromFile("14.jpg");
                label2.Text = "15";
            }
            else if (label1.Text == "15")
            {
                label1.Text = "0";
                pictureBox6.Image = Image.FromFile("15.jpg");
                label2.Text = "0";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label3.Text == "0")
            {
                label3.Text = "1";
                pictureBox5.Image = Image.FromFile("1a.jpg");
                label4.Text = "1";
            }
            else if (label3.Text == "1")
            {
                label3.Text = "2";
                pictureBox5.Image = Image.FromFile("2a.jpg");
                label4.Text = "2";
            }
            else if (label3.Text == "2")
            {
                label3.Text = "3";
                pictureBox5.Image = Image.FromFile("3a.jpg");
                label4.Text = "3";
            }
            else if (label3.Text == "3")
            {
                label3.Text = "4";
                pictureBox5.Image = Image.FromFile("4a.jpg");
                label4.Text = "4";
            }
            else if (label3.Text == "4")
            {
                label3.Text = "5";
                pictureBox5.Image = Image.FromFile("5a.jpg");
                label4.Text = "5";
            }
            else if (label3.Text == "5")
            {
                label3.Text = "6";
                pictureBox5.Image = Image.FromFile("6a.jpg");
                label4.Text = "6";
            }
            else if (label3.Text == "6")
            {
                label3.Text = "7";
                pictureBox5.Image = Image.FromFile("7a.jpg");
                label4.Text = "7";
            }
            else if (label3.Text == "7")
            {
                label3.Text = "8";
                pictureBox5.Image = Image.FromFile("8a.jpg");
                label4.Text = "8";
            }
            else if (label3.Text == "8")
            {
                label3.Text = "9";
                pictureBox5.Image = Image.FromFile("9a.jpg");
                label4.Text = "9";
            }
            else if (label3.Text == "9")
            {
                label3.Text = "10";
                pictureBox5.Image = Image.FromFile("2a.jpg");
                label4.Text = "10";
            }
            else if (label3.Text == "10")
            {
                label3.Text = "11";
                pictureBox5.Image = Image.FromFile("10a.jpg");
                label4.Text = "11";
            }
            else if (label3.Text == "11")
            {
                label3.Text = "12";
                pictureBox5.Image = Image.FromFile("11a.jpg");
                label4.Text = "12";
            }
            else if (label3.Text == "12")
            {
                label3.Text = "13";
                pictureBox5.Image = Image.FromFile("12a.jpg");
                label4.Text = "13";
            }
            else if (label3.Text == "13")
            {
                label3.Text = "14";
                pictureBox5.Image = Image.FromFile("13a.jpg");
                label4.Text = "14";
            }
            else if (label3.Text == "14")
            {
                label3.Text = "15";
                pictureBox5.Image = Image.FromFile("14a.jpg");
                label4.Text = "15";
            }
            else if (label3.Text == "15")
            {
                label3.Text = "0";
                pictureBox5.Image = Image.FromFile("15a.jpg");
                label4.Text = "0";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label5.Text == "0")
            {
                label5.Text = "1";
                pictureBox4.Image = Image.FromFile("1b.jpg");
                label6.Text = "1";
            }
            else if (label5.Text == "1")
            {
                label5.Text = "2";
                pictureBox4.Image = Image.FromFile("2b.jpg");
                label6.Text = "2";
            }
            else if (label5.Text == "2")
            {
                label5.Text = "3";
                pictureBox4.Image = Image.FromFile("3b.jpg");
                label6.Text = "3";
            }
            else if (label5.Text == "3")
            {
                label5.Text = "4";
                pictureBox4.Image = Image.FromFile("4b.jpg");
                label6.Text = "4";
            }
            else if (label5.Text == "4")
            {
                label5.Text = "5";
                pictureBox4.Image = Image.FromFile("5b.jpg");
                label6.Text = "5";
            }
            else if (label5.Text == "5")
            {
                label5.Text = "6";
                pictureBox4.Image = Image.FromFile("6b.jpg");
                label6.Text = "6";
            }
            else if (label5.Text == "6")
            {
                label5.Text = "7";
                pictureBox4.Image = Image.FromFile("7b.jpg");
                label6.Text = "7";
            }
            else if (label5.Text == "7")
            {
                label5.Text = "8";
                pictureBox4.Image = Image.FromFile("8b.jpg");
                label6.Text = "8";
            }
            else if (label5.Text == "8")
            {
                label5.Text = "9";
                pictureBox4.Image = Image.FromFile("9b.jpg");
                label6.Text = "9";
            }
            else if (label5.Text == "9")
            {
                label5.Text = "10";
                pictureBox4.Image = Image.FromFile("2b.jpg");
                label6.Text = "10";
            }
            else if (label5.Text == "10")
            {
                label5.Text = "11";
                pictureBox4.Image = Image.FromFile("10b.jpg");
                label6.Text = "11";
            }
            else if (label5.Text == "11")
            {
                label5.Text = "12";
                pictureBox4.Image = Image.FromFile("11b.jpg");
                label6.Text = "12";
            }
            else if (label5.Text == "12")
            {
                label5.Text = "13";
                pictureBox4.Image = Image.FromFile("12b.jpg");
                label6.Text = "13";
            }
            else if (label5.Text == "13")
            {
                label5.Text = "14";
                pictureBox4.Image = Image.FromFile("13b.jpg");
                label6.Text = "14";
            }
            else if (label5.Text == "14")
            {
                label5.Text = "15";
                pictureBox4.Image = Image.FromFile("14b.jpg");
                label6.Text = "15";
            }
            else if (label5.Text == "15")
            {
                label5.Text = "0";
                pictureBox4.Image = Image.FromFile("15b.jpg");
                label6.Text = "0";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (label7.Text == "0")
            {
                label7.Text = "1";
                pictureBox3.Image = Image.FromFile("1c.jpg");
                label8.Text = "1";
            }
            else if (label7.Text == "1")
            {
                label7.Text = "2";
                pictureBox3.Image = Image.FromFile("2c.jpg");
                label8.Text = "2";
            }
            else if (label7.Text == "2")
            {
                label7.Text = "3";
                pictureBox3.Image = Image.FromFile("3c.jpg");
                label8.Text = "3";
            }
            else if (label7.Text == "3")
            {
                label7.Text = "4";
                pictureBox3.Image = Image.FromFile("4c.jpg");
                label8.Text = "4";
            }
            else if (label7.Text == "4")
            {
                label7.Text = "5";
                pictureBox3.Image = Image.FromFile("5c.jpg");
                label8.Text = "5";
            }
            else if (label7.Text == "5")
            {
                label7.Text = "6";
                pictureBox3.Image = Image.FromFile("6c.jpg");
                label8.Text = "6";
            }
            else if (label7.Text == "6")
            {
                label7.Text = "7";
                pictureBox3.Image = Image.FromFile("7c.jpg");
                label8.Text = "7";
            }
            else if (label7.Text == "7")
            {
                label7.Text = "8";
                pictureBox3.Image = Image.FromFile("8c.jpg");
                label8.Text = "8";
            }
            else if (label7.Text == "8")
            {
                label7.Text = "9";
                pictureBox3.Image = Image.FromFile("9c.jpg");
                label8.Text = "9";
            }
            else if (label7.Text == "9")
            {
                label7.Text = "10";
                pictureBox3.Image = Image.FromFile("2c.jpg");
                label8.Text = "10";
            }
            else if (label7.Text == "10")
            {
                label7.Text = "11";
                pictureBox3.Image = Image.FromFile("10c.jpg");
                label8.Text = "11";
            }
            else if (label7.Text == "11")
            {
                label7.Text = "12";
                pictureBox3.Image = Image.FromFile("11c.jpg");
                label8.Text = "12";
            }
            else if (label7.Text == "12")
            {
                label7.Text = "13";
                pictureBox3.Image = Image.FromFile("12c.jpg");
                label8.Text = "13";
            }
            else if (label7.Text == "13")
            {
                label7.Text = "14";
                pictureBox3.Image = Image.FromFile("13c.jpg");
                label8.Text = "14";
            }
            else if (label7.Text == "14")
            {
                label7.Text = "15";
                pictureBox3.Image = Image.FromFile("14c.jpg");
                label8.Text = "15";
            }
            else if (label7.Text == "15")
            {
                label7.Text = "0";
                pictureBox3.Image = Image.FromFile("15c.jpg");
                label8.Text = "0";
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (label9.Text == "0")
            {
                label9.Text = "1";
                pictureBox2.Image = Image.FromFile("1d.jpg");
                label10.Text = "1";
            }
            else if (label9.Text == "1")
            {
                label9.Text = "2";
                pictureBox2.Image = Image.FromFile("2d.jpg");
                label10.Text = "2";
            }
            else if (label9.Text == "2")
            {
                label9.Text = "3";
                pictureBox2.Image = Image.FromFile("3d.jpg");
                label10.Text = "3";
            }
            else if (label9.Text == "3")
            {
                label9.Text = "4";
                pictureBox2.Image = Image.FromFile("4d.jpg");
                label10.Text = "4";
            }
            else if (label9.Text == "4")
            {
                label9.Text = "5";
                pictureBox2.Image = Image.FromFile("5d.jpg");
                label10.Text = "5";
            }
            else if (label9.Text == "5")
            {
                label9.Text = "6";
                pictureBox2.Image = Image.FromFile("6d.jpg");
                label10.Text = "6";
            }
            else if (label9.Text == "6")
            {
                label9.Text = "7";
                pictureBox2.Image = Image.FromFile("7d.jpg");
                label10.Text = "7";
            }
            else if (label9.Text == "7")
            {
                label9.Text = "8";
                pictureBox2.Image = Image.FromFile("8d.jpg");
                label10.Text = "8";
            }
            else if (label9.Text == "8")
            {
                label9.Text = "9";
                pictureBox2.Image = Image.FromFile("9d.jpg");
                label10.Text = "9";
            }
            else if (label9.Text == "9")
            {
                label9.Text = "10";
                pictureBox2.Image = Image.FromFile("2d.jpg");
                label10.Text = "10";
            }
            else if (label9.Text == "10")
            {
                label9.Text = "11";
                pictureBox2.Image = Image.FromFile("10d.jpg");
                label10.Text = "11";
            }
            else if (label9.Text == "11")
            {
                label9.Text = "12";
                pictureBox2.Image = Image.FromFile("11d.jpg");
                label10.Text = "12";
            }
            else if (label9.Text == "12")
            {
                label9.Text = "13";
                pictureBox2.Image = Image.FromFile("12d.jpg");
                label10.Text = "13";
            }
            else if (label9.Text == "13")
            {
                label9.Text = "14";
                pictureBox2.Image = Image.FromFile("13d.jpg");
                label10.Text = "14";
            }
            else if (label9.Text == "14")
            {
                label9.Text = "15";
                pictureBox2.Image = Image.FromFile("14d.jpg");
                label10.Text = "15";
            }
            else if (label9.Text == "15")
            {
                label9.Text = "0";
                pictureBox2.Image = Image.FromFile("15d.jpg");
                label10.Text = "0";
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (label11.Text == "0")
            {
                label11.Text = "1";
                pictureBox1.Image = Image.FromFile("1e.jpg");
                label12.Text = "1";
            }
            else if (label11.Text == "1")
            {
                label11.Text = "2";
                pictureBox1.Image = Image.FromFile("2e.jpg");
                label12.Text = "2";
            }
            else if (label11.Text == "2")
            {
                label11.Text = "3";
                pictureBox1.Image = Image.FromFile("3e.jpg");
                label12.Text = "3";
            }
            else if (label11.Text == "3")
            {
                label11.Text = "4";
                pictureBox1.Image = Image.FromFile("4e.jpg");
                label12.Text = "4";
            }
            else if (label11.Text == "4")
            {
                label11.Text = "5";
                pictureBox1.Image = Image.FromFile("5e.jpg");
                label12.Text = "5";
            }
            else if (label11.Text == "5")
            {
                label11.Text = "6";
                pictureBox1.Image = Image.FromFile("6e.jpg");
                label12.Text = "6";
            }
            else if (label11.Text == "6")
            {
                label11.Text = "7";
                pictureBox1.Image = Image.FromFile("7e.jpg");
                label12.Text = "7";
            }
            else if (label11.Text == "7")
            {
                label11.Text = "8";
                pictureBox1.Image = Image.FromFile("8e.jpg");
                label12.Text = "8";
            }
            else if (label11.Text == "8")
            {
                label11.Text = "9";
                pictureBox1.Image = Image.FromFile("9e.jpg");
                label12.Text = "9";
            }
            else if (label11.Text == "9")
            {
                label11.Text = "10";
                pictureBox1.Image = Image.FromFile("2e.jpg");
                label12.Text = "10";
            }
            else if (label11.Text == "10")
            {
                label11.Text = "11";
                pictureBox1.Image = Image.FromFile("10e.jpg");
                label12.Text = "11";
            }
            else if (label11.Text == "11")
            {
                label11.Text = "12";
                pictureBox1.Image = Image.FromFile("11e.jpg");
                label12.Text = "12";
            }
            else if (label11.Text == "12")
            {
                label11.Text = "13";
                pictureBox1.Image = Image.FromFile("12e.jpg");
                label12.Text = "13";
            }
            else if (label11.Text == "13")
            {
                label11.Text = "14";
                pictureBox1.Image = Image.FromFile("13e.jpg");
                label12.Text = "14";
            }
            else if (label11.Text == "14")
            {
                label11.Text = "15";
                pictureBox1.Image = Image.FromFile("14e.jpg");
                label12.Text = "15";
            }
            else if (label11.Text == "15")
            {
                label11.Text = "0";
                pictureBox1.Image = Image.FromFile("15e.jpg");
                label12.Text = "0";
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (label13.Text == "0")
            {
                label13.Text = "1";
                this.BackgroundImage = Image.FromFile("112.jpg");
                label14.Text = "1";
            }
            else if (label13.Text == "1")
            {
                label13.Text = "2";
                this.BackgroundImage = Image.FromFile("117.jpg");
                label14.Text = "2";
            }
            else if (label13.Text == "2")
            {
                label13.Text = "3";
                this.BackgroundImage = Image.FromFile("118.jpg");
                label14.Text = "3";
            }
            else if (label13.Text == "3")
            {
                label13.Text = "4";
                this.BackgroundImage = Image.FromFile("119.jpg");
                label14.Text = "4";
            }
            else if (label13.Text == "4")
            {
                label13.Text = "5";
                this.BackgroundImage = Image.FromFile("121.jpg");
                label14.Text = "5";
            }
            else if (label13.Text == "5")
            {
                label13.Text = "6";
                this.BackgroundImage = Image.FromFile("122.jpg");
                label14.Text = "6";
            }
            else if (label13.Text == "6")
            {
                label13.Text = "7";
                this.BackgroundImage = Image.FromFile("123.jpg");
                label14.Text = "7";
            }
            else if (label13.Text == "7")
            {
                label13.Text = "0";
                this.BackgroundImage = Image.FromFile("124.jpg");
                label14.Text = "0";
            }
        }

        private void this_MouseMove(object sender, MouseEventArgs e)
        {
            btnemp.BackColor = Color.Gray;
            btnclothes.BackColor = Color.Navy;
            btncust.BackColor = Color.Red;
            btnsales.BackColor = Color.Maroon;
            btnreport.BackColor = Color.Purple;
            btnlogout.BackColor = Color.Lime;
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            F5customer ob1 = new F5customer();
            ob1.ShowDialog();
        }

        private void btnclothes_Click(object sender, EventArgs e)
        {
            F4clothes ob1 = new F4clothes();
            ob1.ShowDialog();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            Fm8employee ob1 = new Fm8employee();
            ob1.ShowDialog();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            F8reports ob1 = new F8reports();
            ob1.ShowDialog();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            F6sellclothes ob1 = new F6sellclothes();
            ob1.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            F1login ob1 = new F1login();
            this.Hide();
            ob1.FormClosed += (s, args) => this.Close();
            ob1.Show();
            ob1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
