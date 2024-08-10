<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ValidatorApp.Validator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Validator Form</h2>

            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" ForeColor="Red" /><br />
            <asp:Label ID="lblName" runat="server" Text="Name:" />
            <asp:TextBox ID="txtName" runat="server" /><br />

            <asp:RequiredFieldValidator ID="rfvFamilyName" runat="server" ControlToValidate="txtFamilyName" ErrorMessage="Family Name is required" ForeColor="Red" /><br />
            <asp:Label ID="lblFamilyName" runat="server" Text="Family Name:" />
            <asp:TextBox ID="txtFamilyName" runat="server" /><br />
            <asp:CompareValidator ID="cvFamilyName" runat="server" ControlToCompare="txtName" ControlToValidate="txtFamilyName" Operator="NotEqual" ErrorMessage="Family Name must be different from Name" ForeColor="Red" /><br />

            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" ForeColor="Red" /><br />
            <asp:Label ID="lblAddress" runat="server" Text="Address:" />
            <asp:TextBox ID="txtAddress" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address must be at least 2 characters" ForeColor="Red" ValidationExpression="^.{2,}$" /><br />

            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required" ForeColor="Red" /><br />
            <asp:Label ID="lblCity" runat="server" Text="City:" />
            <asp:TextBox ID="txtCity" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revCity" runat="server" ControlToValidate="txtCity" ErrorMessage="City must be at least 2 characters" ForeColor="Red" ValidationExpression="^.{2,}$" /><br />

            <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="Zip Code is required" ForeColor="Red" /><br />
            <asp:Label ID="lblZipCode" runat="server" Text="Zip Code:" />
            <asp:TextBox ID="txtZipCode" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="Invalid Zip Code format" ForeColor="Red" ValidationExpression="^\d{5}$" /><br />

            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number is required" ForeColor="Red" /><br />
            <asp:Label ID="lblPhone" runat="server" Text="Phone:" />
            <asp:TextBox ID="txtPhone" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid phone number format" ForeColor="Red" ValidationExpression="^\d{2}-\d{7}$|^\d{3}-\d{7}$" /><br />

            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="Red" /><br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail Address:" />
            <asp:TextBox ID="txtEmail" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email format" ForeColor="Red" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" /><br />

            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
        </div>
    </form>
</body>
</html>
