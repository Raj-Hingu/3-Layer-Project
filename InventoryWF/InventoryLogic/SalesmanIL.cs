using DataAccess;
using InventoryObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLogic
{
    public class SalesmanIL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public void InsertNewSalesman(SalesmanIO salesman)
        {

            SalesmanDA dataAccess = new SalesmanDA();
           dataAccess.InsertSalesman(salesman);

        }

        public void GetSalesmanById(SalesmanIO getSalesman)
        {
            SalesmanDA salesmanData = new SalesmanDA();
            salesmanData.GetSalesmanById(getSalesman);
        }


       

    }
}
