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
using System.Configuration;
using System.Data.SqlClient;

namespace dropbox14
{
    public partial class DeleteCourseForm : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public DeleteCourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox14.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
                // SQL statement with parameter
            using (SqlCommand comd = new SqlCommand("SELECT courseId, courseTitle, instructorName "+
                "FROM course JOIN instructor ON course.instructorId = instructor.instructorId WHERE courseId = " +
                "@courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // assigns valuse from textbox to the parameter in sql statement
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                // creates a datatable to hold data from database
                DataTable courseTable = new DataTable();
                // fills the table with data from database
                adapter.Fill(courseTable);
                // checks for a record in the table
                if (courseTable.Rows.Count < 1)
                {
                    // displays data for not record
                    courseTitleLabel.Text = "No Course Found.";
                    instructorLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                }
                else
                {
                    // creates a datarow and assigns first record
                    DataRow dr = courseTable.Rows[0];
                    // finds the data and assigns the variable courseId 
                    courseId = int.Parse(dr["courseId"].ToString());
                    // finds course title and assigns the label property
                    courseTitleLabel.Text = dr["courseTitle"].ToString();
                    // finds the instructor name and asigns it to the label
                    instructorLabel.Text = dr["instructorName"].ToString();
                    // enables the delete button
                    deleteButton.Enabled = true;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // string to hold the yes no dialog messgebox message
            const string message = "Are you sure you want to delete selected course?";
            // string to hold caption message
            const string caption = "WARNING";
            // yes no message box with parameters
            var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // closes dialog if no is selected
            if (result == DialogResult.No)
            {

            }
            // confirms delete if yes if selected
            else
            {
                // sets conn and sql statement
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand(
                    "DELETE FROM course WHERE courseId = @courseId", conn))
                {
                    // opens connection and passes parameters
                    conn.Open();
                    comd.Parameters.AddWithValue("@courseId", courseId);
                    // executes sql statement
                    comd.ExecuteScalar();
                    // clears textbox, label, unenables deletebutton and focuses in textbox 
                    courseIdTextBox.Clear();
                    courseTitleLabel.Text = string.Empty;
                    instructorLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                    courseIdTextBox.Focus();
                }
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
