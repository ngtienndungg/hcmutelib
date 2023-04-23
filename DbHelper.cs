using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class DbHelper
    {
        public static String StaffId = "";
        public static String Username = "";
        public static String Password = "";
        
        public static SqlConnection Connect()
        {
                String connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = " + Username + "; Password = " + Password;
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
        }
    }
}
