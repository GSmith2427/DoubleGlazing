using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoubleGlazing
{
    public partial class frmStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            protected void grdSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
            {
               DoublePaneEntities db = new DoublePaneEntities();

                var staff = db.Staff.Find(grdStaff.SelectedValue);

                staff.First_Name = TxtFirstName.Text;

                customer.Last_Name = TxtLastName.Text;

                customer.DOB = calStaff.SelectedDate;

                customer.Address = txtAddress.Text;

                customer.Email = txtEmail.Text;

                customer.Telephone_Number = txtTelephoneNumber.Text;

                db.SaveChanges();

                grdStaff.DataBind();
            }




            protected void btnNewEntry_Click(object sender, EventArgs e)
            {
                DoublePaneEntities db = new DoublePaneEntities();

                var staff = new Staff();

                Staff.First_Name_ = TxtFirstName.Text;

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

                customer.First_Name_ = TxtFirstName.Text;

                customer.Last_Name = TxtLastName.Text;

                customer.DOB = calCustomer.SelectedDate;

                customer.Address = txtAddress.Text;

                customer.Email = txtEmail.Text;

                customer.Telephone_Number = txtTelephoneNumber.Text;

                db.SaveChanges();

                grdCustomer.DataBind();

                btnUpdate.Enabled = true;
            }

            protected void grdStaff_SelectedIndexChanged(object sender, EventArgs e)
            {
                DoublePaneEntities db = new DoublePaneEntities();

                var staff = db.Staff.Find(grdStaff.SelectedValue);

                TxtFirstName.Text = customer.First_Name_;

                TxtLastName.Text = customer.Last_Name;

                calCustomer.SelectedDate = (DateTime)customer.DOB;

                txtAddress.Text = customer.Address;

                txtEmail.Text = customer.Email;

                txtTelephoneNumber.Text = customer.Telephone_Number;

                db.SaveChanges();

                grdCustomer.DataBind();
            }

       
    }
}