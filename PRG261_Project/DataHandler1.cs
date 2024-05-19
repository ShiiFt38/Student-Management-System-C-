using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace PRG261_Project
{
    internal class DataHandler1
    {
        
        public DataHandler1() { }

        string connect = @"Server=(local); Initial Catalog=StudentsManager; Integrated Security=SSPI";

        SqlDataAdapter adapter;
        SqlConnection connector;
        SqlCommand cmd;

     

        public void newAdmin(string u, string p) //Adding new users
        {
            string query = $"INSERT INTO [dbo].[Users] VALUES ('{u}', '{p}')";

            connector = new SqlConnection(connect);
            connector.Open();
            cmd = new SqlCommand(query, connector);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your user account has been created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                connector.Close(); 
            }
        }

        public void Register(string n, string s, string d, int p, string c, string g, string a, string si) //method to register students
        {
            string query3 = $"INSERT INTO [dbo].[Students] VALUES ('{n}', '{s}', '{d}', '{p}', '{c}', '{g}', '{a}', '{si}')";

            connector = new SqlConnection(connect);
            connector.Open();
            cmd = new SqlCommand(query3, connector);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{n} has been registered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failure to register student " + ex.Message);
            }
            finally
            {
                connector.Close();
            }
        }

        public DataTable Search(string si)// serach for data in database method
        {
            string query4 = $"SELECT * FROM Students WHERE [StudentNumber] = '{si}'";
            connector = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query4 , connector);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        public DataTable View() //view data in database method
        {
            string query5 = $"SELECT * FROM Students";
            connector = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query5, connector);

            DataTable tab = new DataTable();
            adapter.Fill(tab);

            return tab;

        }

        public void Delete(string si) //Delete method
        {
            string query6 = $"DELETE FROM Students WHERE StudentNumber = '{si}'";

            connector = new SqlConnection(connect);
            cmd = new SqlCommand(query6, connector);
            connector.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete student" + ex.Message);
            }
            finally
            {
                connector.Close();
            }

        }

        public void update(string n, string s, string d, int p, string c, string g, string a, string si) //update method
        {
            string query7 = $"UPDATE Students SET [FirstName] = '{n}', [Surname] = '{s}', [DOB] = '{d}', [Phone] = '{p}', [CourseID] = '{c}', [Gender] = '{g}', [StudentAddress] = '{a}' WHERE [StudentNumber] = '{si}'";
            connector = new SqlConnection(connect);
            cmd = new SqlCommand(query7, connector);
            connector.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Student {si} details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student details not updated" + ex.Message);
            }
            finally
            {
                connector.Close();
            }
        }

   
    }
}

