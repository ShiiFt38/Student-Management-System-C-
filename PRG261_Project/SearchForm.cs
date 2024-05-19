using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG261_Project
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataHandler1 handler1 = new DataHandler1();

            Student student = new Student();
            student.studentID = txtSearch.Text;
           
            dataGridView1.DataSource = handler1.Search(student.studentID);
        }
    }
}
