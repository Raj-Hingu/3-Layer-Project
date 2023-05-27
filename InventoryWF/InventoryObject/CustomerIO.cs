using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryObject
{
    public class CustomerIO
    {
        private string _CustomerId;
        private string _CustomerName;
        private string _City;
        private int _Grade;
        private string _SalesmanId;

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
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }
        public int Grade
        {
            get
            {
                return _Grade;
            }
            set
            {
                _Grade = value;
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
