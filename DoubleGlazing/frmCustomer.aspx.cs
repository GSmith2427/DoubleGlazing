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

            var customer = db.Customers.Find(grdCustomer.SelectedValue);

            customer.First_Name_ = TxtFirstName.Text;

            customer.Last_Name = TxtLastName.Text;

            customer.DOB = calCustomer.SelectedDate;

            customer.Address = txtAddress.Text;

            customer.Email = txtEmail.Text;

            customer.Telephone_Number = txtTelephoneNumber.Text;

            db.SaveChanges();

            grdCustomer.DataBind(); 
        }

        
     
        
        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var customer = new Customer();

            customer.First_Name_ = TxtFirstName.Text;

            customer.Last_Name = TxtLastName.Text;

            //customer.DOB = DateTime.Parse(txtDOB.Text); 
            customer.DOB = calCustomer.SelectedDate;

            customer.Address = txtAddress.Text;

            customer.Telephone_Number = txtTelephoneNumber.Text;

            customer.Email = txtEmail.Text;

            db.Customers.Add(customer);

            db.SaveChanges();

            grdCustomer.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var customer = db.Customers.Find(grdCustomer.SelectedValue);

            db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();

            grdCustomer.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var customer = db.Customers.Find(grdCustomer.SelectedValue);

            customer.First_Name_= TxtFirstName.Text;

            customer.Last_Name = TxtLastName.Text;

            customer.DOB = calCustomer.SelectedDate;

            customer.Address = txtAddress.Text;

            customer.Email = txtEmail.Text;

            customer.Telephone_Number = txtTelephoneNumber.Text;

            db.SaveChanges();

            grdCustomer.DataBind();
        }

        protected void grdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var customer = db.Customers.Find(grdCustomer.SelectedValue);

            customer.First_Name_ = TxtFirstName.Text;

            customer.Last_Name = TxtLastName.Text;

            customer.DOB = calCustomer.SelectedDate;

            customer.Address = txtAddress.Text;

            customer.Email = txtEmail.Text;

            customer.Telephone_Number = txtTelephoneNumber.Text;

            db.SaveChanges();

            grdCustomer.DataBind();



        }
    }
    }
