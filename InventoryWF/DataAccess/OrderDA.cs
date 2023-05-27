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
    public class OrderDA
    {
        SqlConnection _connection;

        public OrderDA()
        {

            /* if (!IsPostBack)
              {
                  BindGridView();
              }*/

            string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
            _connection = new SqlConnection(connectionString);
        }

        public void InsertOrder(OrderIO order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "orderIdAutoincremnt";
            cmd.Parameters.Add("@PurchaseAmount", SqlDbType.VarChar).Value = order.PurchaseAmount;
            cmd.Parameters.Add("@OrderDate", SqlDbType.VarChar).Value = order.OrderDate;
            cmd.Parameters.Add("@CustomerId", SqlDbType.VarChar).Value = order.CustomerId;
            cmd.Parameters.Add("@SalesmanId", SqlDbType.VarChar).Value = order.SalesmanId;
            cmd.Parameters.Add("@OrderId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Connection = _connection;
            _connection.Open();
            cmd.ExecuteNonQuery();
            string id = cmd.Parameters["@OrderId"].Value.ToString();

            cmd.Dispose();
            _connection.Close();
        }
    }
}
