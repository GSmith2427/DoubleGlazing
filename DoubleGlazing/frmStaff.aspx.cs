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

                var staff = db.Staffs.Find(grdStaff.SelectedValue);

                staff.First_Name = TxtFirstName.Text;

                staff.Last_Name_ = TxtLastName.Text;

                staff.DOB = calStaff.SelectedDate;

                staff.Email = txtEmail.Text;

                staff.Telephone_Number = txtTelephoneNumber.Text;

                db.SaveChanges();

                grdStaff.DataBind();
            }




            protected void btnNewEntry_Click(object sender, EventArgs e)
            {
                DoublePaneEntities db = new DoublePaneEntities();

                var staff = new Staff();

                staff.First_Name = TxtFirstName.Text;

                staff.Last_Name_ = TxtLastName.Text;

                //staff.DOB = DateTime.Parse(txtDOB.Text); 
                staff.DOB = calStaff.SelectedDate;

                staff.Telephone_Number = txtTelephoneNumber.Text;

                staff.Email = txtEmail.Text;

                db.Staffs.Add(staff);

                db.SaveChanges();

                grdStaff.DataBind();
            }

            protected void btnDelete_Click(object sender, EventArgs e)
            {
                DoublePaneEntities db = new DoublePaneEntities();

                var staff = db.Staffs.Find(grdStaff.SelectedValue);

                db.Entry(staff).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                grdStaff.DataBind();


            }

            protected void btnUpdate_Click(object sender, EventArgs e)
            {
                DoublePaneEntities db = new DoublePaneEntities();

                var staff = db. Staffs.Find(grdStaff.SelectedValue);

                staff.First_Name = TxtFirstName.Text;

                staff.Last_Name_ = TxtLastName.Text;

                staff.DOB = calStaff.SelectedDate;

                staff.Email = txtEmail.Text;

                staff.Telephone_Number = txtTelephoneNumber.Text;

                db.SaveChanges();

                grdStaff.DataBind();

                btnUpdate.Enabled = true;
            }

       
        protected void grdStaff_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var staff = db.Staffs.Find(grdStaff.SelectedValue);

            TxtFirstName.Text = staff.First_Name;

            TxtLastName.Text = staff.Last_Name_;

            calStaff.SelectedDate = (DateTime)staff.DOB;

            txtEmail.Text = staff.Email;

            txtTelephoneNumber.Text = staff.Telephone_Number;

            db.SaveChanges();

            grdStaff.DataBind();

        }
    }
}