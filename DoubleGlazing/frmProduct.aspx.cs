 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoubleGlazing
{
    public partial class P : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var product = new Product();

            product.Item_Price = txtProductPrice.Text;

            product.Item_Name = txtProductName.Text;

            db.Products.Add(product);

            db.SaveChanges();




        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var product = new Product();

            product.Item_Price = txtProductPrice.Text;

            product.Item_Name = txtProductName.Text;

            db.SaveChanges();

            grdProduct.DataBind();

            btnUpdate.Enabled = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var product = db.Products.Find(grdProduct.SelectedValue);

            db.Entry(product).State = System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();

            grdProduct.DataBind();
        }

        protected void grdProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoublePaneEntities db = new DoublePaneEntities();

            var product = db.Products.Find(grdProduct.SelectedValue);

            product.Item_Price = txtProductPrice.Text;

            product.Item_Name = txtProductName.Text;

            product.ManufacturerID = txtManufacturerID.Text;

            db.SaveChanges();

            grdProduct.DataBind();
        }

        
    }
}