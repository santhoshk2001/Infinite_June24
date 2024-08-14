using System;
using System.Collections.Generic;

namespace ProductApp
{
    public partial class ProductPage : System.Web.UI.Page
    {
        // Product data
        private Dictionary<string, (string ImageUrl, decimal Price)> products = new Dictionary<string, (string, decimal)>
        {
            { "Laptop", ("~/Images/laptop.jpg", 250000) },
            { "Smartphone", ("~/Images/smartphone.jpg", 150000) },
            { "Tablet", ("~/Images/tablet.jpg", 100000) }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the dropdown list with product names
                ddlProducts.DataSource = products.Keys;
                ddlProducts.DataBind();
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected product
            string selectedProduct = ddlProducts.SelectedItem.Text;

            // Display the image and reset the price label
            if (products.ContainsKey(selectedProduct))
            {
                var productInfo = products[selectedProduct];
                imgProduct.ImageUrl = productInfo.ImageUrl;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            // Get the selected product
            string selectedProduct = ddlProducts.SelectedItem.Text;

            // Display the price
            if (products.ContainsKey(selectedProduct))
            {
                var productInfo = products[selectedProduct];
                lblPrice.Text = $"Price: {productInfo.Price:F2}";
            }
        }
    }
}
