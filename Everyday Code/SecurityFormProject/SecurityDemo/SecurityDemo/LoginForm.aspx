<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="SecurityDemo.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="Username :"></asp:Label>
            
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            <br />
            
            <br />
            &nbsp;<br />
            <asp:Label ID="Label1" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server" OnTextChanged="txtpass_TextChanged" Width="175px"></asp:TextBox>
            <br />
            
        </div>
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
