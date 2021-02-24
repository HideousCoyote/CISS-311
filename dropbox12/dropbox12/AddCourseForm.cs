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
    public partial class AddCourseForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public AddCourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox12.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("INSERT INTO course (courseTitle, instructorId) " + 
                "VALUES (@courseTitle, @instructorId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseTitle",
                    courseTextBox.Text);
                comd.Parameters.AddWithValue("@instructorId",
                    instructorComboBox.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("Course Added.");
                // Clears the textbox for adding another course and focuses on textbox
                courseTextBox.Clear();
                courseTextBox.Focus();
              
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
