using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;//////////////////////////
using System.Text;
using System.Threading.Tasks;

namespace Student_Contacts
{
    public class stinfoBLL
    {
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
        private static string _basePath2 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/back_up/Students.xml";
        public static void CreateStudentXml()
        {
            XDocument studentDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            studentDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("studentcontact");
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath);
        }
        public static void CreateStudentXml2()
        {
            XDocument studentDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            studentDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("studentcontact");
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath2);
        }
        public static bool AddStudentInfo(StudentInfo param)
        {
            XElement xml = XElement.Load(_basePath);
            XElement studentXml = new XElement("student");
            studentXml.Add(new XAttribute("studentid", param.StudentId));
            studentXml.Add(new XElement("name", param.Name));
            studentXml.Add(new XElement("sex", param.Sex));
            studentXml.Add(new XElement("age", param.Age.ToString()));
            studentXml.Add(new XElement("birthdate", param.BirthDate.ToString("yyyy-MM-dd")));////////////////////mm
            studentXml.Add(new XElement("phone", param.Phone));
            studentXml.Add(new XElement("homeaddress", param.HomeAddress));
            studentXml.Add(new XElement("email", param.Email));
            studentXml.Add(new XElement("profession", param.Profession));
            xml.Add(studentXml);
            xml.Save(_basePath);
            return true;
        }

        public static bool UpdateStudentInfo(StudentInfo param)
        {
            bool result = false;
            if (param.StudentId > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentid").Value == param.StudentId.ToString()
                                       select db).Single();
                studentXml.SetElementValue("name", param.Name);
                studentXml.SetElementValue("sex", param.Sex);
                studentXml.SetElementValue("name", param.Name);
                studentXml.SetElementValue("age", param.Age.ToString());
                studentXml.SetElementValue("birthdate", param.BirthDate.ToString("yyyy- MM- dd"));
                studentXml.SetElementValue("phone", param.Phone);
                studentXml.SetElementValue("homeaddress", param.HomeAddress);
                studentXml.SetElementValue("email", param.Email);
                studentXml.SetElementValue("profession", param.Profession);
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }

        public static bool DeleteStudentInfo(int studentid)
        {
            bool result = false;
            if (studentid > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentid").Value == studentid.ToString()
                                       select db).Single();////////////////////////ID?id?
                studentXml.Remove();
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }

        //查询全部学生列表
        public static List<StudentInfo> GetAllStudentInfo()
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }

        //根据学号查询学生信息
        public static StudentInfo GetStudentInfo(int studentid)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
            studentinfo = (from student in xml.Descendants("student")
                           where student.Attribute("studentid").Value == studentid.ToString()
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }

        //获取列表（查询）
        public static List<StudentInfo> GetStudentInfoList(StudentInfo param)
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            if (param.StudentId != 0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString());
            }
            else if (!String.IsNullOrEmpty(param.Name))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
            }
            else if(!String.IsNullOrEmpty(param.Profession))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);
            }
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }
    }
}
