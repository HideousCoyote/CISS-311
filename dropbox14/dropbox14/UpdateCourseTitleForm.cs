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
    public partial class UpdateCourseTitleForm : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public UpdateCourseTitleForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox14.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // new Sql COnnection and Sql Statement
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT courseId, courseTitle FROM course WHERE courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // assigns value form textbox to sql statemnt parameter
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                DataTable courseTable = new DataTable();
                // fills the table 
                adapter.Fill(courseTable);
                if (courseTable.Rows.Count < 1)
                    // sets text if no course is found
                    currentTitleLabel.Text = "No Course Found.";
                else
                {
                    // enable title textbox, updatebutton, and focus textbox
                    newTitleTextBox.Enabled = true;
                    newTitleTextBox.Focus();
                    updateButton.Enabled = true;
                    // 
                    DataRow dr = courseTable.Rows[0];
                    courseId = int.Parse(dr["courseId"].ToString());
                    currentTitleLabel.Text = dr["courseTitle"].ToString();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "UPDATE course SET courseTitle = @courseNewTitle WHERE courseId = @courseId",
                conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseNewTitle", newTitleTextBox.Text);
                comd.Parameters.AddWithValue("@courseId", courseId);
                comd.ExecuteScalar();
                MessageBox.Show("Record Updated.");
                //clears the information once the update button is pressed
                courseIdTextBox.Clear();
                currentTitleLabel.Text = string.Empty;
                newTitleTextBox.Clear();
                updateButton.Enabled = false;
                newTitleTextBox.Enabled = false;
                courseIdTextBox.Focus();
            }
        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
