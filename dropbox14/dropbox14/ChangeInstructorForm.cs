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
    public partial class ChangeInstructorForm : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public ChangeInstructorForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox14.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void ChangeInstructorForm_Load(object sender, EventArgs e)
        {
            // creates connecton and sql statment
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT * FROM instructor", conn))
            {
                // creates table and fill
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                // sets parameters for the combobox
                newInstructorComboBox.DisplayMember = "instructorName";
                newInstructorComboBox.ValueMember = "instructorId";
                newInstructorComboBox.DataSource = instructorTable;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // creates connection and stores sql statemnet
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT courseId, courseTitle, instructor.instructorName FROM course" +
                " JOIN instructor ON instructor.instructorId = course.instructorId WHERE " +
                "courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // passes data with parameters
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                // creates a datatable and fills the information in the table
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                if (instructorTable.Rows.Count < 1)
                {
                    // shows message when instructor id is not found
                    courseTitleLabel.Text = "No Course Found.";
                    newInstructorComboBox.Enabled = false;
                    updateButton.Enabled = false;
                    currentInstructorLabel.Text = string.Empty;
                }
                else
                {
                    // creates a datarow object 
                    DataRow dr = instructorTable.Rows[0];
                    // stores courseid as varible to store
                    courseId = int.Parse(dr["courseId"].ToString());
                    courseTitleLabel.Text = dr["courseTitle"].ToString();
                    currentInstructorLabel.Text = dr["instructorName"].ToString();
                    // enables combo box and update button
                    newInstructorComboBox.Enabled = true;
                    updateButton.Enabled = true;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // sets connection and stores sql statement
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "UPDATE course SET instructorId = @instructorId " +
                "WHERE courseId = @courseId", conn))
            {
                // opens connection and passes parameters
                conn.Open();
                comd.Parameters.AddWithValue("@instructorId", 
                                                                        newInstructorComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                // executes sql statement
                comd.ExecuteScalar();
                // message box to confirm update
                MessageBox.Show("Record Updated.");
                // clears textbox, labels, un enables combobox and delete button
                courseIdTextBox.Clear();
                courseTitleLabel.Text = string.Empty;
                currentInstructorLabel.Text = string.Empty;
                newInstructorComboBox.Enabled = false;
                updateButton.Enabled = false;
                // focus on id textbox
                courseIdTextBox.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

