using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryWF
{
    public partial class SearchDialogForm : System.Web.UI.Page
    {
        public void SearchPage_Load(object sender, EventArgs e)
        {
            Salesman salesman = new Salesman();
            salesman.BindGridView();
        }
    }
}