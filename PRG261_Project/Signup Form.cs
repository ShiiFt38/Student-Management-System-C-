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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form1 = new LoginForm();
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        DataHandler1 handler = new DataHandler1();
        Admin User = new Admin();


        private void button2_Click(object sender, EventArgs e)//Save button
        {
            string u = textBox1.Text;
            string p = textBox2.Text;
            handler.newAdmin(u, p);
            


        }
    }
}
