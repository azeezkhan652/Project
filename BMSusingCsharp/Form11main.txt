using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace BMSusingCsharp
{
    public partial class Form11main : Form
    {
        public Form11main()
        {
            InitializeComponent();
        }
        private void Form11main_Load(object sender, EventArgs e)
        {
            //  pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            timer1.Start();
            pictureBox9.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            timer2.Start();
            label3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            timer3.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

         else  if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }

           /* else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox2.Visible = true;
            }  */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button2.Visible = true;
            button3.Visible = true;
            F8reports ob1 = new F8reports();
            ob1.ShowDialog();
        }

      
        

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
           // button1.BackColor = Color.Black;
        }

        private void this_MouseMove(object sender, MouseEventArgs e)
        {
          //  button1.BackColor = Color.Blue;
        
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox11.Visible = true;
            }

            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
            }

            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
            }

            else if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
            }
            else if (pictureBox14.Visible == true)
            {
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
            }

            else if (pictureBox15.Visible == true)
            {
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
            }

            else if (pictureBox16.Visible == true)
            {
                pictureBox16.Visible = false;
                pictureBox9.Visible = true;
            }
        }
    //F:\Boutique\BMSusingCsharp\BMSusingCsharp\Untitled44.jpg
        private void timer3_Tick(object sender, EventArgs e)
        {
            if(label1.Text == "0")
            {
                label1.Text = "1";
                pictureBox6.Image = Image.FromFile("Untitled44.jpg");
                label2.Text="1";
            }
            else if (label1.Text == "1")
            {
                label1.Text = "2";
                pictureBox6.Image = Image.FromFile("Untitled118.jpg");
                label2.Text = "2";
            }
            else if (label1.Text == "2")
            {
                label1.Text = "3";
                pictureBox6.Image = Image.FromFile("Untitled53.jpg");
                label2.Text = "3";
            }
            else if (label1.Text == "3")
            {
                label1.Text = "4";
                pictureBox6.Image = Image.FromFile("Untitled56.jpg");
                label2.Text = "4";
            }
            else if (label1.Text == "4")
            {
                label1.Text = "5";
                pictureBox6.Image = Image.FromFile("Untitled61.jpg");
                label2.Text = "5";
            }
            else if (label1.Text == "5")
            {
                label1.Text = "0";
                pictureBox6.Image = Image.FromFile("Untitled93.jpg");
                label2.Text = "0";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
