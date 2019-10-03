using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Sqlcon
    {
        public string connectionStr = "server=.;user=sa;pwd=sqlwxg;database=HotelManagementSystem";
        public SqlConnection Sql_connection()
        {
            
            SqlConnection sql_connection = new SqlConnection(connectionStr);
            return sql_connection;
           
        } 
      
    }
}
