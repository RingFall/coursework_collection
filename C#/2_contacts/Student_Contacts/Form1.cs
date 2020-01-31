using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        void initContacts()
        {
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml"))
            {
                dgv1.DataSource = stinfoBLL.GetAllStudentInfo();
            }
            else
            {
                stinfoBLL.CreateStudentXml();
                dgv1.Columns[0].HeaderText = "学生编号";
                dgv1.Columns[1].HeaderText = "学生姓名";
                dgv1.Columns[2].HeaderText = "学生性别";
                dgv1.Columns[3].HeaderText = "学生年龄";
                dgv1.Columns[4].HeaderText = "出生日期";
                dgv1.Columns[5].HeaderText = "手机号码";
                dgv1.Columns[6].HeaderText = "家庭地址";
                dgv1.Columns[7].HeaderText = "电子邮箱";
                dgv1.Columns[8].HeaderText = "专    业";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form_add form_Add = new Form_add();
            //form_Add.Show();
            form_Add.ShowDialog();
            initContacts();

        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 1)
            {
                Form_edit form_Edit = new Form_edit();
                int selectrow = Int32.Parse(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                form_Edit.studentid_edit = selectrow;//////////////////////////////////
                form_Edit.ShowDialog();
                initContacts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮！");
        }
        private void search_Click(object sender, EventArgs e)
        {
            Form_search form_Search = new Form_search();
            form_Search.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void del_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定要删除此学生信息？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(selectrow.ToString());
                    if (stinfoBLL.DeleteStudentInfo(selectrow)) MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("删除失败，请检查是否选中学生信息！");
                    initContacts();//////////////////////////////////////////////////////
                }
            }
            else
                MessageBox.Show("请选中一行后再点击删除按钮！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initContacts();
        }

        private void update_Click(object sender, EventArgs e)
        {
            initContacts();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentInfo studentsearch = new StudentInfo();
            //bool isfind = false;
            if (treeView1.SelectedNode.Name == "计算机科学与技术")
            {
                studentsearch.Profession = "计算机科学与技术";
            }
            else if (treeView1.SelectedNode.Name == "信息安全")
            {
                studentsearch.Profession = "信息安全";
            }
            else if (treeView1.SelectedNode.Name == "信息科学与技术")
            {
                studentsearch.Profession = "信息科学与技术";
            }
            dgv1.DataSource = stinfoBLL.GetStudentInfoList(studentsearch);
            //MessageBox.Show("cs!");
        }


        private void backup_Click(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/back_up/Students.xml"))
            {
                stinfoBLL.CreateStudentXml2();
            }
            /*StreamReader sr = new StreamReader(@"D:\vs2017\Student_Contacts\Student_Contacts\bin\Debug\xml\students.xml", Encoding.UTF8);
            string s = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(@"D:\vs2017\Student_Contacts\Student_Contacts\bin\Debug\backup\students.xml",true, Encoding.UTF8);
            sw.Write(s);
            sw.Close();*/
            string[] s = File.ReadAllLines(@"D:\==\C#\2_contacts\骆信智_08163337_实验二\Student_Contacts\bin\Debug\xml\students.xml");
            File.WriteAllLines(@"D:\==\C#\2_contacts\骆信智_08163337_实验二\Student_Contacts\bin\Debug\back_up\students.xml", s);
           MessageBox.Show("备份成功！");
        }

        private void recover_Click(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/back_up/Students.xml"))
            {
                stinfoBLL.CreateStudentXml2();
            }
            string[] s = File.ReadAllLines(@"D:\==\C#\2_contacts\骆信智_08163337_实验二\Student_Contacts\bin\Debug\back_up\students.xml");
            File.WriteAllLines(@"D:\==\C#\2_contacts\骆信智_08163337_实验二\Student_Contacts\bin\Debug\xml\students.xml", s);
            initContacts();
            MessageBox.Show("恢复成功！");
        }
    }
}
