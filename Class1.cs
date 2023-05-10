
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace Kursa4
{
    public class Class1
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=pks-199;database=airportnew;");

        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if(conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
        

    }
}
