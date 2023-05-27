using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using InventoryObject;
using InventoryLogic;

namespace InventoryWF
{
    public partial class Order : System.Web.UI.Page
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal purchaseAmount = Convert.ToDecimal(txtPurchaseAmount.Text);
            var orderDate = txtOrderDate.Text;
            var customerId = txtCustomerID.Text;
            var salesmanId = txtID.Text;

            OrderIO newOrder = new OrderIO()
            {
                PurchaseAmount = purchaseAmount,
                OrderDate = orderDate,
                CustomerId = customerId,
                SalesmanId = salesmanId,

            };


            OrderIL logic = new OrderIL();
            logic.InsertNewOrder(newOrder);

            
        }
        private void BindGridView()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                string selectQuery = "select * from orders";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // gvCustomer.DataSource = dt;
                    tblOrder.DataBind();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearFields()
        {
            txtCustomerID.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            txtPurchaseAmount.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtID.Text = string.Empty;
            txtID.Focus();
        }
    }
}