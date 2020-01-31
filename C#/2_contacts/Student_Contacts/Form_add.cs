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
    public partial class Form_add : Form
    {
        public Form_add()
        {
            InitializeComponent();
        }

        private void Form_add_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = new StudentInfo();
            studentinfo.StudentId = Int32.Parse(t_num.Text);
            studentinfo.Name = t_name.Text;
            if(male.Checked)
                studentinfo.Sex = "男";
            else if(female.Checked)
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(t_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dateTimePicker1.Text);
            studentinfo.Phone = t_tel.Text;
            studentinfo.Email = t_email.Text;
            studentinfo.HomeAddress = t_address.Text;
            studentinfo.Profession = t_major.Text;
            if (stinfoBLL.AddStudentInfo(studentinfo))
            {
                MessageBox.Show("添加成功！");
            }
        }
    }
}
