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
    public partial class DeleteAdviseeForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public DeleteAdviseeForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox11.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;
        }

        private void DeleteAdviseeForm_Load(object sender, EventArgs e)
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
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT adviseeId, adviseeName FROM advisee" +
                " WHERE advisee.advisorId = @advisorId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@advisorId",
                    advisorComboBox.SelectedValue.ToString());
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                adviseeListBox.DisplayMember = "adviseeName";
                adviseeListBox.ValueMember = "adviseeId";
                adviseeListBox.DataSource = adviseeTable;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
            ("DELETE FROM advisee WHERE adviseeId = @adviseeId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@adviseeId", adviseeListBox.SelectedValue);
                comd.ExecuteScalar();
                this.Close();
                DeleteAdviseeForm deleteAdviseeForm = new DeleteAdviseeForm();
                deleteAdviseeForm.ShowDialog();
            }
            
    }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
