using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class CustInfoOperation 
    {
        private string  Connection;

        
        public CustInfoOperation()
        {
            DbConnection con = new DbConnection();
            Connection = con.GetConnection();
        }

       

        public bool InsertCust(CustInfo Cust)
        {
            int executedStatement = 0;
            using(SqlConnection sqlcon = new SqlConnection(Connection))
            {
                SqlCommand cmd = new SqlCommand("InsertCustomerData", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MobileNumber",Cust.MobileNumber);
                cmd.Parameters.AddWithValue("@FirstName",Cust.FirstName);
                cmd.Parameters.AddWithValue("@LastName",Cust.LastName);
                cmd.Parameters.AddWithValue("@PanNumber",Cust.PANNumber);
                cmd.Parameters.AddWithValue("@AadharNumber",Cust.Aadhar_Card_Number);
                cmd.Parameters.AddWithValue("@CustState",Cust.State);
                cmd.Parameters.AddWithValue("@CustCity",Cust.CIty);
                cmd.Parameters.AddWithValue("@AddressInAadhar",Cust.Address_InAadhar);
                cmd.Parameters.AddWithValue("@Ocupation",Cust.Ocupation);
                cmd.Parameters.AddWithValue("@ApplicationStatus","Pending");
                sqlcon.Open();
                executedStatement = cmd.ExecuteNonQuery();
                if(executedStatement >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

        }

    }
}
