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
            tbAvg.Text = StudentsWith4Or5.Count().ToString();
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
            var numberOfStudents = (from cource in cw
                                    group cource by cource.professorName into cnt
                                    select new { name = cnt.Key, count = cnt.Count() }).ToList();
            dgStudentsWithSameProfessor.DataSource = numberOfStudents;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var Students = (from cource in cw
                                    orderby cource.professorName
                            select new { ProfessorName = cource.professorName }).Distinct().ToList();
            dgSorted.DataSource = Students;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            var avg = (from work in cw join student in st on work.studentId equals student.Id
                       where student.course == 3
                       select work.mark ).Average();
            tbAvg.Text = avg.ToString();
        }
    }
}
