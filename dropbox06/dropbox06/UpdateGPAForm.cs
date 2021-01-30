/*Mark Chambers
    CISS-311
    Advanced Agile Development
    1/25/2021*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox06
{
    public partial class UpdateGPAForm : Form
    {
        private Student s;
        public UpdateGPAForm(Student  s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void UpdateGPAForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = s.StudentID;
            nameTextBox.Text = s.StudentName;
            ActiveControl = gradeTextBox;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            char grade;
            double hours;
            if(char.TryParse(gradeTextBox.Text, out grade) && double.TryParse(hoursTextBox.Text, out hours))
            {
                s.UpdateGPA(grade, hours);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid grade or credit hours.");
            }
        }
    }
}
