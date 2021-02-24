/*Mark Chambers
CISS-311
Advanced Agile Developement
02/22/2021*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void updateCourseTitleButton_Click(object sender, EventArgs e)
        {
            UpdateCourseTitleForm updateCourseTitleForm = new UpdateCourseTitleForm();
            updateCourseTitleForm.ShowDialog();
        }

        private void changeCourseInstructorButton_Click(object sender, EventArgs e)
        {
            ChangeInstructorForm changeInstructorForm = new ChangeInstructorForm();
            changeInstructorForm.ShowDialog();
        }

        private void updateInstructorInfoButton_Click(object sender, EventArgs e)
        {
            UpdateInstructorForm updateInstructorForm = new UpdateInstructorForm();
            updateInstructorForm.ShowDialog();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUpdateCourseFormButton_Click(object sender, EventArgs e)
        {
            addUpdateCourseForm addupdateCourseForm = new addUpdateCourseForm();
            addupdateCourseForm.ShowDialog();
        }
    }
}
