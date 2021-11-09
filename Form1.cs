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

namespace LinqFormPMI32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            st = new List<Student>();
            cw = new List<Сoursework>();
        }
        class Student
        {
            public int Id { set; get; }
            public string name { set; get; }
            public int yearOfBirth { set; get; }
            public int course { set; get; }
            public Student(int StudentId, string Name,int Year, int Course)
            {
                Id = StudentId;
                name = Name;
                yearOfBirth = Year;
                course = Course;
            }
            public override string ToString()
            {
                return String.Format("{0} {1} {2}", Id, name, course);
            }
        }
        class Сoursework
        {
            public int studentId { set; get; }
            public string professorName{ set; get; }
            public string title { set; get; }
            public int mark { get; set; }
            public Сoursework(int Code, string ProfessorName, string Title, int Mark)
            {
                studentId = Code;
                professorName = ProfessorName;
                title = Title;
                mark = Mark;
            }
        }
        List<Student> st = null;
        List<Сoursework> cw = null;
        public void readStudents(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] fields;
                while ((line = sr.ReadLine()) != null)
                {
                    fields = line.Split(new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                    Student wr = new Student(int.Parse(fields[0]), fields[1].Trim(),
                        int.Parse(fields[2]), int.Parse(fields[3]));
                    st.Add(wr);
                }
                dgStudnets.DataSource = st;
            }

        }
        public void readCourseWork(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] fields;
                while ((line = sr.ReadLine()) != null)
                {
                    fields = line.Split(new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                    Сoursework cw = new Сoursework(int.Parse(fields[0]),
                       fields[1], fields[2], int.Parse(fields[3]));
                    this.cw.Add(cw);
                }
                dgCourseWork.DataSource = cw;
            }

        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                readStudents(fileName);
            }
        }

        private void SalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                readCourseWork(fileName);
            }
        }

        private void MarkBiggerThen3_Click(object sender, EventArgs e)
        {
            var StudentsWith4Or5 = from student in st join work in cw 
                                   on student.Id equals work.studentId
                                   where work.mark > 3
                                   select new { fio = student.name, mark = work.mark};
            dgMoreThen3.DataSource = StudentsWith4Or5.ToList();
        }

        private void btnAfter2000_Click(object sender, EventArgs e)
        {
            var Students = from student in st
                           where student.yearOfBirth > 2000
                           select new { name = student.name, fullYears = DateTime.Today.Year - student.yearOfBirth };
            dgBornAfter2000.DataSource = Students.ToList();
        }

        private void StudentsWithSameProfessor_Click(object sender, EventArgs e)
        {
            var numberOfStudents = cw.Count(item => item.mark)
            dgStudentsWithSameProfessor.DataSource = numberOfStudents.ToList();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    var workersLess35 = from item in st
        //                        where item.year > DateTime.Now.Year - 35
        //                        select new { fio = item.name, profession = item.profession };
        //    dgResult.DataSource = workersLess35.ToList();
        //}

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    float maxSalary2 = cw.Max(t=>t.salary2);
        //    //var result = (from it_lw in st
        //    //              from it_ls in cw
        //    //              let maxSalary2 = cw.Max(t => t.salary2)
        //    //              where it_lw.StudentId == it_ls.StudentId && it_ls.salary2 == maxSalary2
        //    //              select new { fio = it_lw.name,
        //    //                  department = it_lw.department,
        //    //                  maxSalary = it_ls.salary2 }).ToList();
        //    var result = st.Join(cw,
        //        first => first.code,
        //        second => second.StudentId,
        //        (first, second) => new
        //        {
        //            fio = first.name,
        //            department = first.department,
        //            maxsalary = second.salary2
        //        }).Where(t => t.maxsalary == maxSalary2).ToList();
        //    dgResult.DataSource = result;
        //}

        //private void Button3_Click(object sender, EventArgs e)
        //{
        //    var result = from item in st
        //                 group item by item.department;
        //    listBox1.Items.Clear();
        //    foreach(IGrouping<string,Student> gr in result)
        //    {
        //        listBox1.Items.Add(gr.Key);
        //        foreach(var it in gr)
        //        {
        //            listBox1.Items.Add("   " + it);
        //        }
        //    }
        //}
    }
}
