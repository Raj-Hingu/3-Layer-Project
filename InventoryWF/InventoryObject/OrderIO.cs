using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryObject
{
    public class OrderIO
    {
        private string _OrderId;
        private decimal _PurchaseAmount;
        private string _OrderDate;
        private string _CustomerId;
        private string _SalesmanId;

        public string OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                _OrderId = value;
            }
        }

        public decimal PurchaseAmount
        {
            get
            {
                return _PurchaseAmount;
            }
            set
            {
                _PurchaseAmount = value;
            }
        }

        public string OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                _OrderDate = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                _CustomerId = value;
            }
        }

        public string SalesmanId
        {
            get
            {
                return _SalesmanId;
            }
            set
            {
                _SalesmanId = value;
            }
        }
    }
}
