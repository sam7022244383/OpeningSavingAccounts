using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    internal class DbConnection
    {
        public string  GetConnection()
        {
            //string connection;
            //connection = ConfigurationManager.AppSettings["SavingAccountDB"].ToString();
            //return connection;

            string connection;
            connection = "data source =LAPTOP-H2IJ3S8S\\SQLEXPRESS; Initial Catalog = SavingAccount; Integrated Security = True;";
            return connection;
            
        }
    }
}
