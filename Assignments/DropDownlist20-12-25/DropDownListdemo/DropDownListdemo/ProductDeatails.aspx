<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDeatails.aspx.cs" Inherits="DropDownListdemo.ProductDeatails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Details</title>

    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            background-color: #eef2f7;
        }

        .product-box {
            width: 360px;
            margin: 80px auto;
            padding: 25px;
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 6px 20px rgba(0,0,0,0.15);
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
            color: #374151;
        }

        #ddlProducts {
            width: 100%;
            padding: 8px;
            border-radius: 6px;
        }

        #btnPrice {
            padding: 8px 16px;
            background-color: #2563eb;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
        }

        #btnPrice:hover {
            background-color: #1e40af;
        }

        #lblPrice {
            font-size: 16px;
            color: #111827;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="product-box">
            <h2>Product List</h2>

            <asp:DropDownList ID="dropdownProducts" runat="server" 
                AutoPostBack="true" 
                OnSelectedIndexChanged="ProductSelectingIndex">
                <asp:ListItem Text="Select Product" Value="0"></asp:ListItem>
                <asp:ListItem Text="Hoodie" Value="1"></asp:ListItem>
                <asp:ListItem Text="Sunglass" Value="2"></asp:ListItem>
                <asp:ListItem Text="Tshirt" Value="3"></asp:ListItem>


            </asp:DropDownList>

            <br /><br />



            <asp:Image ID="imgProduct" runat="server" Height="200px" Width="200px" />

            <br /><br />

            <asp:Button ID="btnPrice" runat="server" Text="Show Price" OnClick="btnPrice_Click" />

            <br /><br />

            <asp:Label ID="lblPrice" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
