using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project.DAL
{
    public class BaseDAL
    {
        protected string connectionString;
        protected DataSet ds;
        protected MySqlCommand cmd;
        protected MySqlDataReader dr;
        protected MySqlConnection conn;
        protected MySqlDataAdapter adpt;
        
        public BaseDAL()
        {
            ds = new DataSet();
            connectionString = "server=studmysql01.fhict.local;database=dbi435115;uid=dbi435115;password=group3;";
            //connectionString = "server=localhost;database=dbi435115;uid=root;password=;";
        }

        public MySqlConnection CreateConnection()
        {
            conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
