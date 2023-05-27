using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryObject
{
    public class SalesmanIO
    {
        private string _SalesmanId;
        private string _Name;
        private string _City;
        private string _Commission;
        private int _SalesId;

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
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
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
        public string Commission
        {
            get
            {
                return _Commission;
            }
            set
            {
                _Commission = value;
            }
        }

        public int SalesId
        {
            get
            {
                return _SalesId;
            }
            set
            {
                _SalesId = value;
            }
        }

    }
}
