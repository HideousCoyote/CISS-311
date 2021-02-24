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

namespace dropbox11
{
    public partial class AddAdviseeForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public AddAdviseeForm()
        {
            InitializeComponent();
            // initialize the connection
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox11.Properties.Settings.AdvisingDBConnectionString"]
                .ConnectionString;
        }

        private void AddAdviseeForm_Load(object sender, EventArgs e)
        {
            // set up connection
            using (conn = new SqlConnection(connectionString))
                // sets the adapter and sql statement
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM advisor", conn))
            {
                // creates table and fills
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);
                // sets display value
                advisorComboBox.DisplayMember = "advisorName";
                //adds value for columns
                advisorComboBox.ValueMember = "advisorId";
                // sets data source for table
                advisorComboBox.DataSource = advisorTable;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // set up connection
            using (conn = new SqlConnection(connectionString))
                // adds sql command with statement
            using (SqlCommand comd = new SqlCommand
                ("INSERT INTO advisee (adviseeName, advisorId) " +
                "VALUES (@adviseeName, @advisorId)", conn))
            {
                // opens connecton
                conn.Open();
                // adds value
                comd.Parameters.AddWithValue("@adviseeName",
                    adviseeNameTextbox.Text);
                comd.Parameters.AddWithValue("@advisorId",
                    advisorComboBox.SelectedValue);
                // executes the command
                comd.ExecuteScalar();
                // displays message box
                MessageBox.Show("Advisee Added.");
                // clears textbox to add new data
                adviseeNameTextbox.Clear();
                // brings focus to textbox
                adviseeNameTextbox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
