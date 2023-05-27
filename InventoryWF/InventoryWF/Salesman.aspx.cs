
using InventoryLogic;
using InventoryObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryWF
{
    public partial class Salesman : System.Web.UI.Page
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
            var name = txtSalesmanName.Text;
            var city = txtCity.Text;
            var commission = txtCommission.Text;
            var salesmanId = txtID.Text;

            SalesmanIO newSalesman = new SalesmanIO()
            {
                Name = name,
                City = city,
                Commission = commission,
            };
 
            SalesmanIL logic = new SalesmanIL();
             logic.InsertNewSalesman(newSalesman);


           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int salesId = Convert.ToInt32(txtEnterSalesman.Text);

            SalesmanIO sales = new SalesmanIO()
            {
                SalesId = salesId
            };

            SalesmanIL logic = new SalesmanIL();
            logic.GetSalesmanById(sales);

            
            


        }

        public void BindGridView()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                string selectQuery = "select * from salesman";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

               if (dt.Rows.Count > 0)
                {
                    gvSalesman.DataSource = dt;
                    gvSalesman.DataBind();
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
            txtID.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCommission.Text = string.Empty;
            txtSalesmanName.Text = string.Empty;
            txtID.Focus();
        }

      
    }
}