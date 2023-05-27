using DataAccess;
using InventoryObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLogic
{
    public class OrderIL
    {
        public void InsertNewOrder(OrderIO order)
        {

            OrderDA dataAccess = new OrderDA();
            dataAccess.InsertOrder(order);

        }
    }
}
