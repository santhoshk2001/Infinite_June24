using System;

namespace ValidatorApp
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Collect form data
                string name = txtName.Text;
                string familyName = txtFamilyName.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string zipCode = txtZipCode.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                // Redirect to Result.aspx with query parameters
                string url = $"Result.aspx?name={Server.UrlEncode(name)}&familyName={Server.UrlEncode(familyName)}&address={Server.UrlEncode(address)}&city={Server.UrlEncode(city)}&zipCode={Server.UrlEncode(zipCode)}&phone={Server.UrlEncode(phone)}&email={Server.UrlEncode(email)}";
                Response.Redirect(url);
            }
        }
    }
}
