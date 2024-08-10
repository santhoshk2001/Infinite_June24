<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="ProductApp.ProductPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product Selection</h2>

            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
            </asp:DropDownList><br />

            <asp:Image ID="imgProduct" runat="server" Width="300px" Height="300px" /><br />

            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" /><br />

            <asp:Label ID="lblPrice" runat="server" Text="" Font-Bold="True" />
        </div>
    </form>
</body>
</html>
