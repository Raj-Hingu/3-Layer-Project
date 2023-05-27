using System;
using DataAccess;
using InventoryObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLogic
{
    public class CustomerIL
    {
        public void InsertNewCustomer(CustomerIO customer)
        {

            CustomerDA dataAccess = new CustomerDA();
            dataAccess.InsertCustomer(customer);
            


        }
    }
}
