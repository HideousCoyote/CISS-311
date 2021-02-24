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
    public partial class addUpdateCourseForm : Form
    {
        string connectionString;
        BindingSource courseBindingSource = new BindingSource();
        SqlDataAdapter adapter;
        public addUpdateCourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
              ["dropbox14.Properties.Settings.TeachingDBConnectionString"]
              .ConnectionString;
        }

        private void addUpdateCourseForm_Load(object sender, EventArgs e)
        {
            // binds the datagridview to binding source
            courseDataGridView.DataSource = courseBindingSource;
            // stores sql statement into adapter
            adapter = new SqlDataAdapter("SELECT courseID AS 'COURSE ID', courseTitle AS 'Course Title', "+
                "instructorId AS 'Instructor Id' FROM course", connectionString);
            SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapter);
            // creates table and fills the information
            DataTable courseTable = new DataTable();
            adapter.Fill(courseTable);
            // sets datasource for binding source to created table
            courseBindingSource.DataSource = courseTable;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            adapter.Update((DataTable)courseBindingSource.DataSource);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
