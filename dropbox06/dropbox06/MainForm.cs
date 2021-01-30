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

namespace dropbox06
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private Dictionary<string, Student> allStudents = new Dictionary<string, Student>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("student.txt"))
            {
                string studentID;
                while ((studentID = sr.ReadLine()) != null)
                {
                    Student s = new Student(studentID, sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()));
                    allStudents.Add(studentID, s);
                    studentListBox.Items.Add(s);
                }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string selectedStudent = "";
            string studentID = "";
            if (studentListBox.SelectedIndex != -1)
            {
                selectedStudent = studentListBox.SelectedItem.ToString();
                studentID = selectedStudent.Split(' ')[1];
                Student s = allStudents[studentID];
                UpdateGPAForm gpaForm = new UpdateGPAForm(s);
                gpaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select a Student.");
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            foreach (Student s in allStudents.Values)
            {
                studentListBox.Items.Add(s);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("student.txt"))
            {
                foreach(Student s in allStudents.Values)
                {
                    sw.WriteLine(s.StudentID);
                    sw.WriteLine(s.StudentName);
                    sw.WriteLine(s.GPA);
                    sw.WriteLine(s.CreditHours);
                }

            }
            Close();
        }
    }
}
