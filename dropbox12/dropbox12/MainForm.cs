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
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public MainForm()
        {
            //Initializes database for the form
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox12.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }
   private void MainForm_Load(object sender, EventArgs e)
        {
            // sets uup connection
            //Sql SELECT to populate the combo box
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM instructor", conn))
            {
                //runs the SQL statement
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                // fills table with data from database
                instructorComboBox.DisplayMember = "instructorName";
                // adds values to columns for display
                instructorComboBox.ValueMember = "instructorId";
                // sets datasource
                instructorComboBox.DataSource = instructorTable;
            }
        }
 private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sets connection
            //SQL statement to pull from 
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT courseId, courseTitle FROM course" +
                " WHERE course.instructorId = @instructorId", conn))
                // sets adapter to sql command
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // retrieves data from selected data
                comd.Parameters.AddWithValue("@instructorId",
                    instructorComboBox.SelectedValue.ToString());
                DataTable courseTable = new DataTable();
                // fills table
                adapter.Fill(courseTable);
                // sets display
                courseListBox.DisplayMember = "courseTitle";
                // sets value 
                courseListBox.ValueMember = "courseId";
                // sets datasource
                courseListBox.DataSource = courseTable;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            // Load AddCourseForm on button click
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Load RemoveCourseForm on button click
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.ShowDialog();
        }
    }
}
