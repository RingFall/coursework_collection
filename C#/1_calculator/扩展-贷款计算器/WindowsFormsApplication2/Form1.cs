using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xx, yy, zz;
            xx=Convert.ToDouble(textBox1.Text)*12;
            yy=Convert.ToDouble(textBox2.Text)*10000;
            zz=Convert.ToDouble(textBox3.Text)*0.01;
            double x=0, y=0, z=0;
            double m=1+zz;
            double xxx=xx;
            while(xxx-->0)
            {
                m*=(1+zz);
            }
            if (a==1)
            {
                x = (yy * zz * m) / (m - 1);
                y = xx * (yy * zz * m - (m / (1 + zz)) / (m - 1));
                z = xx * x;
            }
            if (a == 2)
            {
                x=(yy/xx)+(yy*zz);
                y = (yy/xx+yy*zz+yy/xx*(1+zz))/2*xx-yy;
                z = xx * x;
            }
            textBox4.Text = Convert.ToString(x);
            textBox5.Text = Convert.ToString(y);
            textBox6.Text = Convert.ToString(z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double xx, yy, zz;
            xx = Convert.ToDouble(textBox1.Text) * 12;
            yy = Convert.ToDouble(textBox2.Text) * 10000;
            zz = Convert.ToDouble(textBox3.Text) * 0.01;
            double x = 0, y = 0, z = 0;
            double m = 1 + zz;
            double xxx = xx;
            while (xxx-- > 0)
            {
                m *= (1 + zz);
            }
            if (a == 1)
            {
                x = (yy * zz * m) / (m - 1);
                y = xx * (yy * zz * m - (m / (1 + zz)) / (m - 1));
                z = xx * x;
            }
            if (a == 2)
            {
                x = (yy / xx) + (yy * zz);
                y = (yy / xx + yy * zz + yy / xx * (1 + zz)) / 2 * xx - yy;
                z = xx * x;
            }
            textBox4.Text = Convert.ToString(x);
            textBox5.Text = Convert.ToString(y);
            textBox6.Text = Convert.ToString(z);
        }
    }
}
