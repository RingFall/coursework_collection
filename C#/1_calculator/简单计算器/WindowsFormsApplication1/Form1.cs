using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        Stack st = new Stack();

        public Calculator()
        {
            InitializeComponent();
        }

        private string cal(string t)
        {
            double res = 0;
            int len = t.Length;
            double co = 0;
            int xiao=0;
            int wait = 0;
            for (int i = 0; i < len; i++)
            {
                //string test = Convert.ToString(co);
                //MessageBox.Show(test);
                if (wait==0)
                {
                    if (t[i] >= '0' && t[i] <= '9')
                    {
                        if (xiao == 0)
                            co = co * 10 + t[i] - '0';
                        else
                        {
                            int xia = xiao;
                            double x = 1;
                            while (xia-- > 0)
                            {
                                x *= 0.1;
                            }
                            co = co + (t[i] - '0') * x;
                            xiao++;
                        }
                    }
                    else if (t[i] == '.')
                    {
                        if (xiao == 0)
                            xiao = 1;
                        else
                        {
                            MessageBox.Show("小数点多点了吧？");
                            textBox1.Text = null;
                            return null;
                        }
                    }
                    else if (t[i] == '+' || t[i] == '-')
                    {
                        st.Push(co);
                        co = 0;
                        xiao = 0;
                        st.Push(t[i]);
                    }
                    else if (t[i] == '*')
                    {
                        st.Push(co);
                        co = 0;
                        xiao = 0;
                        wait = 1;
                    }
                    else if (t[i] == '/')
                    {
                        st.Push(co);
                        co = 0;
                        xiao = 0;
                        wait = 2;
                    }
                    
                }
                else if (wait>0)
                {
                    if (t[i] >= '0' && t[i] <= '9')
                    {
                        if (xiao == 0)
                            co = co * 10 + t[i] - '0';
                        else
                        {
                            int xia = xiao;
                            double x = 1;
                            while (xia-- > 0)
                            {
                                x *= 0.1;
                            }
                            co = co + (t[i] - '0') * x;
                            xiao++;
                        }
                    }
                    else if (t[i] == '.')
                    {
                        if (xiao == 0)
                            xiao = 1;
                        else
                        {
                            MessageBox.Show("小数点多点了吧？");
                            textBox1.Text = null;
                            return null;
                        }
                    }
                    else if(t[i]=='+'||t[i]=='-'||t[i]=='*'||t[i]=='/')
                    {
                        double l = (double)st.Pop();
                        if (wait==1)
                        {
                            co = l * co;
                            xiao = 0;
                        }
                        else if (wait == 2)
                        {
                            co = l / co;
                            xiao = 0;
                        }
                        wait = 0;
                        i--;
                    }
                }
            }
            if (wait > 0)
            {
                double ll = (double)st.Pop();
                if (wait == 1)
                {
                    co = ll * co;
                    xiao = 0;
                }
                else if (wait == 2)
                {
                    co = ll / co;
                    xiao = 0;
                }
            }
            st.Push(co);
            while (st.Count > 2)
            {
                res = (double)st.Pop();
                char op = (char)st.Pop();
                double qian = (double)st.Pop();
                if (op == '+')
                    res = qian + res;
                else if (op == '-')
                    res = qian - res;
                st.Push(res);
            }
            res = (double)st.Pop();
            string r = Convert.ToString(res);
            return r;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("="))
            {
                MessageBox.Show("先清空再计算哟~");
                textBox1.Text = null;
            }
            else if (textBox1.Text.Length > 0)
            {
                textBox1.Text += "=";
                textBox1.Text += cal(textBox1.Text);
            }
            else
            {
                MessageBox.Show("还没有输入呐~");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/' || textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-')
            {
                MessageBox.Show("请勿连续输入运算符哟~");
            }
            else
                textBox1.Text += button13.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/' || textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-')
            {
                MessageBox.Show("请勿连续输入运算符哟~");
            }
            else
                textBox1.Text += button14.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/' || textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-')
            {
                MessageBox.Show("请勿连续输入运算符哟~");
            }
            else
                textBox1.Text += button15.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/' || textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-')
            {
                MessageBox.Show("请勿连续输入运算符哟~");
            }
            else
                textBox1.Text += button12.Text;
        }


        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else 
            {
                MessageBox.Show("还没有输入呐~");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
