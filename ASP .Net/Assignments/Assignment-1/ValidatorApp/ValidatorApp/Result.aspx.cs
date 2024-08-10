using System;

namespace ValidatorApp
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve query parameters
                string name = Request.QueryString["name"];
                string familyName = Request.QueryString["familyName"];
                string address = Request.QueryString["address"];
                string city = Request.QueryString["city"];
                string zipCode = Request.QueryString["zipCode"];
                string phone = Request.QueryString["phone"];
                string email = Request.QueryString["email"];

                // Display the data
                lblResult.Text = $"Name: {name}<br />Family Name: {familyName}<br />Address: {address}<br />City: {city}<br />Zip Code: {zipCode}<br />Phone: {phone}<br />E-mail Address: {email}";
            }
        }
    }
}
