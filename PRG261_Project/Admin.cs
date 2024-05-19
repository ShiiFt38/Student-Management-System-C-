using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG261_Project
{
    internal class Admin
    {
        public string username { get; set; }
        public string password { get; set; }
        
        //constructor
        public Admin(string u, string p) 
        {
            this.username = u;
            this.password = p;
        }

        //default constructor
        public Admin() { }

    }
}
