using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoubleGlazing
{
    public partial class frmCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();


        }

        
     
        
        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var customer = new Customer();

            customer.First_Name_ = TxtFirstName.Text;

            customer.Last_Name = TxtLastName.Text;

            DateTime.Parse(txtDOB.Text);

            customer.Address = txtAddress.Text;

            customer.Telephone_Number = txtTelephoneNumber.Text;

            customer.Email = txtEmail.Text;

            db.Customers.Add(customer);

            db.SaveChanges();

            grdCustomer.DataBind();
        }
    }
    }
