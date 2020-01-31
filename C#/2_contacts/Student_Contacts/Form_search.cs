using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Contacts
{
    public partial class Form_search : Form
    {
        public Form_search()
        {
            InitializeComponent();
        }

        void InitHeadTitle()
        {
            sdgv.Columns[0].HeaderText = "学生编号";
            sdgv.Columns[1].HeaderText = "学生姓名";
            sdgv.Columns[2].HeaderText = "学生性别";
            sdgv.Columns[3].HeaderText = "学生年龄";
            sdgv.Columns[4].HeaderText = "出生日期";
            sdgv.Columns[5].HeaderText = "学生编号";
            sdgv.Columns[6].HeaderText = "学生编号";
            sdgv.Columns[7].HeaderText = "学生编号";
            sdgv.Columns[8].HeaderText = "学生编号";
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_search_Load(object sender, EventArgs e)
        {

        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                sdgv.DataSource = stinfoBLL.GetAllStudentInfo();
                InitHeadTitle();
            }
            else
            {
                if (textBox1.Text != string.Empty)
                {
                    StudentInfo studentsearch = new StudentInfo();
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: studentsearch.StudentId = Int32.Parse(textBox1.Text); break;
                        case 1: studentsearch.Name = textBox1.Text; break;
                    }
                    sdgv.DataSource = stinfoBLL.GetStudentInfoList(studentsearch);
                    InitHeadTitle();
                }
                else
                {
                    MessageBox.Show("请输入要查询的" + comboBox1.Text);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
