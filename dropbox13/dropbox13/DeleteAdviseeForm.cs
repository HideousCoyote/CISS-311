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

namespace dropbox13
{
    public partial class DeleteAdviseeForm : Form
    {
        string connectionString;
        SqlConnection conn;
        int adviseeId;
        public DeleteAdviseeForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox13.Properties.Settings.AdvisingDBConnectionString"]
                .ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Set up connection
            using (conn = new SqlConnection(connectionString))
                // Sql command to hold statement
            using (SqlCommand comd = new SqlCommand("SELECT adviseeId, adviseeName, advisor.advisorName " +
                "FROM advisee JOIN advisor ON advisee.advisorId = advisor.advisorId WHERE adviseeId = " +
                "@adviseeId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // set parameters
                comd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                // create a table and fill it with data from the table
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                if (adviseeTable.Rows.Count < 1)
                {
                    // set results if no student is found
                    adviseeNameLabel.Text = "No Student Found.";
                    advisorLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                }
                else
                {
                    // set datarow to hold info to fill labels of student and activate the delete button
                    DataRow dr = adviseeTable.Rows[0];
                    adviseeId = int.Parse(dr["adviseeId"].ToString());
                    adviseeNameLabel.Text = dr["adviseeName"].ToString();
                    advisorLabel.Text = dr["advisorName"].ToString();
                    deleteButton.Enabled = true;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // set up connection
            using (conn = new SqlConnection(connectionString))
            // SQL command
            using (SqlCommand comd = new SqlCommand(
                "DELETE FROM advisee WHERE adviseeId = @adviseeId", conn))
            {
                // open connection, set parameters and execute the query
                conn.Open();
                comd.Parameters.AddWithValue("@adviseeId", adviseeId);
                comd.ExecuteScalar();
                //Clear Contents of textbox, namelabel, and advisorlabel
                adviseeIdTextBox.Clear();
                adviseeNameLabel.Text = string.Empty;
                advisorLabel.Text = string.Empty;
                // unenable delete button
                deleteButton.Enabled = false;
                // focus text to id textbox
                adviseeIdTextBox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
