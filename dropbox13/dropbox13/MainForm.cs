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

namespace dropbox13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void updateAdviseeButton_Click(object sender, EventArgs e)
        {
            UpdateAdviseeNameForm updateAdviseeNameForm = new UpdateAdviseeNameForm();
            updateAdviseeNameForm.ShowDialog();
        }

        private void changeAdvisorButton_Click(object sender, EventArgs e)
        {
            ChangeAdvisorForm changeAdvisorForm = new ChangeAdvisorForm();
            changeAdvisorForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdvisorForm updateAdvisorForm = new UpdateAdvisorForm();
            updateAdvisorForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteAdviseeForm deleteAdviseeForm = new DeleteAdviseeForm();
            deleteAdviseeForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
