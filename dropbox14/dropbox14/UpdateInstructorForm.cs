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
    public partial class UpdateInstructorForm : Form
    {
        string connectionString;
        BindingSource instructorBindingSource = new BindingSource();
        SqlDataAdapter adapter;
        public UpdateInstructorForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox14.Properties.Settings.TeachingDBConnectionString"]
                .ConnectionString;
        }

        private void UpdateInstructorForm_Load(object sender, EventArgs e)
        {
            // binds the grid view to the binding source
            instructorDataGridView.DataSource = instructorBindingSource;
            // stores sql statement in adapter
            adapter = new SqlDataAdapter("SELECT instructorId AS 'Instructor ID', instructorName AS 'Instructor Name', " + 
           "instructorOffice AS 'Instructor Office' FROM instructor", connectionString);
            
            SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapter);
            DataTable instructorTable = new DataTable();
            adapter.Fill(instructorTable);
            // fills bindingsource with table
            instructorBindingSource.DataSource = instructorTable;

            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            adapter.Update((DataTable)instructorBindingSource.DataSource);
            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // creates an item to hold selected row
            foreach (DataGridViewRow item in this.instructorDataGridView.SelectedRows)
            {
                // deletes row from grid view using stored index
                instructorDataGridView.Rows.RemoveAt(item.Index);
            }
            // update the delete in the database
            adapter.Update((DataTable)instructorBindingSource.DataSource);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
