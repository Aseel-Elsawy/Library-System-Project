using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemNew
{
    class DBConnect
    {
        public static SqlConnection con = new SqlConnection
           ($@"Server=DESKTOP-678O052\Aseel;Database=library;User Id=sa;Password=samah;");
        public SqlCommand cmd = new SqlCommand();
        public DBConnect()
        {
            openConnection();
        }
        void openConnection()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
    }
}

