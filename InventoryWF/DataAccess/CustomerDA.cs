using InventoryObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDA
    {
        SqlConnection _connection;

        public CustomerDA()
        {

            /* if (!IsPostBack)
              {
                  BindGridView();
              }*/

            string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
            _connection = new SqlConnection(connectionString);
        }

        public void InsertCustomer(CustomerIO customer)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "customerIdAutoincremnt";
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = customer.CustomerName;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = customer.City;
            cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = customer.Grade;
            cmd.Parameters.Add("@SalesmanId", SqlDbType.VarChar).Value = customer.SalesmanId;
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Connection = _connection;
            _connection.Open();
            cmd.ExecuteNonQuery();
            string id = cmd.Parameters["@CustomerId"].Value.ToString();

            cmd.Dispose();
            _connection.Close();
        }
    }
}
