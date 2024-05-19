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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)//Exit button
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)//Add button
        {
            Student student = new Student();
            DataHandler1 handler1 = new DataHandler1();
            
            student.name = txtName.Text;
            student.surname = txtSurname.Text;
            student.DOB = dateTimePicker1.Value.ToString();
            student.phone = int.Parse(txtPhone.Text);
            student.courseID = txtCourseCode.Text;
            student.gender = comboBox1.Text;
            student.address = txtAddress.Text;
            student.studentID = txtStNumber.Text;

            handler1.Register(student.name, student.surname, student.DOB, student.phone, student.courseID, student.gender, student.address, student.studentID);
            
        }

        private void button4_Click(object sender, EventArgs e)//Search button 
        {
            DataHandler1 handler = new DataHandler1();

            Student student = new Student();

            SearchForm sf = new SearchForm();
            sf.Show();

        }

        private void button3_Click(object sender, EventArgs e)//View button
        {
            DataHandler1 handler = new DataHandler1();

            dataGridView1.DataSource = handler.View();
        }

        private void button2_Click(object sender, EventArgs e)//Delete button in the main form
        {
            DeleteForm df = new DeleteForm();
            df.Show();
        }

        private void button5_Click(object sender, EventArgs e)// Clear button
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtCourseCode.Clear();
            comboBox1.Text = string.Empty;
            txtAddress.Clear();
            txtStNumber.Clear();
            txtAddress.Clear();
        }

        private void button6_Click(object sender, EventArgs e)//Log out button
        {
            this.Hide();
            LoginForm form1 = new LoginForm();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)//Update button
        {
            DataHandler1 handler = new DataHandler1();
            Student student = new Student();

            student.name = txtName.Text;
            student.surname = txtSurname.Text;
            student.DOB = dateTimePicker1.Value.ToString();
            student.phone = int.Parse(txtPhone.Text);
            student.courseID = txtCourseCode.Text;
            student.gender = comboBox1.Text;
            student.address = txtAddress.Text;
            student.studentID = txtStNumber.Text;

            handler.update(student.name, student.surname, student.DOB, student.phone, student.courseID, student.gender, student.address, student.studentID);
        }
    }
}
