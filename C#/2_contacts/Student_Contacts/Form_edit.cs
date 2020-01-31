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
    public partial class Form_edit : Form
    {
        public Form_edit()
        {
            InitializeComponent();
        }
        public int studentid_edit = 0;
        public void initControl()
        {
            StudentInfo studentinfo = stinfoBLL.GetStudentInfo(studentid_edit);
            if(studentinfo != null)
            {
                t_num.Text = studentinfo.StudentId.ToString();
                t_name.Text = studentinfo.Name;
                if(studentinfo.Sex == "男")
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                else
                {
                    female.Checked = true;
                    male.Checked = false;
                }
                t_age.Text = studentinfo.Age.ToString();
                dateTimePicker1.Text = studentinfo.BirthDate.ToString();
                t_tel.Text = studentinfo.Phone;
                t_email.Text = studentinfo.Email;
                t_address.Text = studentinfo.HomeAddress;
                t_major.Text = studentinfo.Profession;
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_edit_Load(object sender, EventArgs e)
        {
            initControl();
        }

        

        private void b_update_Click_1(object sender, EventArgs e)
        {
            StudentInfo studentinfo = stinfoBLL.GetStudentInfo(studentid_edit);
            studentinfo.StudentId = Int32.Parse(t_num.Text);
            studentinfo.Name = t_name.Text;
            if (male.Checked)
                studentinfo.Sex = "男";
            else if (female.Checked)
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(t_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dateTimePicker1.Text);
            studentinfo.Phone = t_tel.Text;
            studentinfo.Email = t_email.Text;
            studentinfo.HomeAddress = t_address.Text;
            studentinfo.Profession = t_major.Text;
            if (stinfoBLL.UpdateStudentInfo(studentinfo))
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
