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
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox11.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;      
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM advisor", conn))
            {
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);
                advisorComboBox.DisplayMember = "advisorName";
                advisorComboBox.ValueMember = "advisorId";
                advisorComboBox.DataSource = advisorTable;
            }
        }

        private void advisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add the connection 
            using (conn = new SqlConnection(connectionString))
                // issue the SQL statement
            using (SqlCommand comd = new SqlCommand
                ("SELECT adviseeId, adviseeName FROM advisee" + 
                " WHERE advisee.advisorId = @advisorId", conn))
                // passes opject to adapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                // retrieves  the info from the combobox
                comd.Parameters.AddWithValue("@advisorId",
                    advisorComboBox.SelectedValue.ToString());
                // create and fill datatable
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                // set the values of column for display
                adviseeListBox.DisplayMember = "adviseeName";
                // adds values of column
                adviseeListBox.ValueMember = "adviseeId";
                // set the data source
                adviseeListBox.DataSource = adviseeTable;
            }
        }

        private void addAdviseeButton_Click(object sender, EventArgs e)
        {
            AddAdviseeForm addAdviseeForm = new AddAdviseeForm();
            addAdviseeForm.ShowDialog();
        }

        private void removeAdviseeButton_Click(object sender, EventArgs e)
        {
            DeleteAdviseeForm deleteAdviseeForm = new DeleteAdviseeForm();
            deleteAdviseeForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
