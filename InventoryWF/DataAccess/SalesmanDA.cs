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
    public class SalesmanDA
    {
        SqlConnection _connection;
        string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public SalesmanDA()
        {
            _connection = new SqlConnection(connectionString);
        }

        public void InsertSalesman(SalesmanIO salesman)
        {
           SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "salesmanIdAutoincremnt";
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = salesman.Name;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = salesman.City;
            cmd.Parameters.Add("@Commission", SqlDbType.Float).Value = salesman.Commission;
            cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Connection = _connection;
            _connection.Open();
            cmd.ExecuteNonQuery();
            string id = cmd.Parameters["@id"].Value.ToString();

          //  cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
            
        }
     


        public void GetSalesmanById(SalesmanIO getSalesman)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FindSalesmanByID";
            cmd.Parameters["@SalesmanId"].Value = getSalesman.SalesId;
            cmd.Connection = _connection;
            _connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            _connection.Close();
        }


    }
}
