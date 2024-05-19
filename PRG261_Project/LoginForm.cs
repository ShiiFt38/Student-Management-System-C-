using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG261_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit app button
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e) //Sign up button to bring signup form
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e) //Login button
        {
            
            string connect = @"Server=(local); Initial Catalog=StudentsManager; Integrated Security=SSPI";
            string query2 = $"SELECT * FROM [dbo].[Users] WHERE Username='{textBox1.Text}' AND PasswordID='{textBox2.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful");
                    this.Hide();
                    MainForm f3 = new MainForm();
                    f3.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("User does not exist/password is wrong, Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
