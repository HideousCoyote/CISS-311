/*Mark Chambers
CISS 311
Advanced Agile Development
02/15/2021*/

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

namespace dropbox12
{
    public partial class RemoveCourseForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public RemoveCourseForm()
        {
            //Initializes the database for use on the form
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox12.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {
            // sets up connection
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM instructor", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                instructorComboBox.DisplayMember = "instructorName";
                instructorComboBox.ValueMember = "instructorId";
                instructorComboBox.DataSource = instructorTable;
            }
        }

        private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT courseId, courseTitle FROM course" +
                " WHERE course.instructorId = @instructorId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@instructorId",
                    instructorComboBox.SelectedValue.ToString());
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseListBox.DisplayMember = "courseTitle";
                courseListBox.ValueMember = "courseId";
                courseListBox.DataSource = courseTable;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Strings for messagebox message and warning message
            const string message = "Are you sure you want to delete selected course?";
            const string caption = "WARNING";
            // Message box with yes no buttons, warning icon and warning message
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            // what to do if no is pressed
            if (result == DialogResult.No)
            {
                // left blank so the "NO" button only closes the MessageBox
            }
            else
            {
                // uses the yes button to perform the SQL statement
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand
                    ("DELETE FROM course WHERE courseId = @courseId", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@courseId", courseListBox.SelectedValue);
                    comd.ExecuteScalar();
                    // method created to refresh the listbox to update the deleted course
                    RefreshForm();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();// closes RemoveCourseForm 
            
            
        }
        // Method created to reload form after deleting a course this updates the listbox
        public  void RefreshForm()
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM instructor", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                instructorComboBox.DisplayMember = "instructorName";
                instructorComboBox.ValueMember = "instructorId";
                instructorComboBox.DataSource = instructorTable;
            }
        }
    }
}


