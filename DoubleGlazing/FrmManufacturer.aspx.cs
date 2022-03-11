using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoubleGlazing
{
    public partial class FrmManufacturer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var manufacturer = db.Manufacturers.Find(grdManufacturer.SelectedValue);

            manufacturer.Manufacturer_Name_ = txtManufacturerName.Text;

            manufacturer.Address_ = txtManufacturerAddress.Text;

            manufacturer.Telephone_Number = txtManufacturerNum.Text;

            db.SaveChanges();

            grdManufacturer.DataBind();


        }

        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var manufacturer = new Manufacturer();

            manufacturer.Manufacturer_Name_ = txtManufacturerName.Text;

            manufacturer.Address_ = txtManufacturerAddress.Text;

            manufacturer.Telephone_Number = txtManufacturerNum.Text;

            db.Manufacturers.Add(manufacturer);

            db.SaveChanges();

            grdManufacturer.DataBind();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var manufacturer = new Manufacturer();

            manufacturer.Manufacturer_Name_ = txtManufacturerName.Text;

            manufacturer.Address_ = txtManufacturerAddress.Text;

            manufacturer.Telephone_Number = txtManufacturerNum.Text;

            db.SaveChanges();

            grdManufacturer.DataBind();

            btnUpdate.Enabled = true;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var manufacturer = db.Manufacturers.Find(grdManufacturer.SelectedValue);

            db.Entry(manufacturer).State = System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();

            grdManufacturer.DataBind();
        }
    }
}