<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBilling.aspx.cs" Inherits="ElectricityBill.AddBilling" %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div style="width:400px; margin:auto; margin-top:50px;">
<h2>Add Deatails</h2>
<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
<br /><br />
<asp:Label ID="lblConsumerNumber" runat="server" Text="Consumer Number:"></asp:Label><br />
<asp:TextBox ID="txtConsumerNumber" runat="server"></asp:TextBox><br /><br />
 
            <asp:Label ID="lblConsumerName" runat="server" Text="Consumer Name:"></asp:Label><br />
<asp:TextBox ID="txtConsumerName" runat="server"></asp:TextBox><br /><br />
 
            <asp:Label ID="lblUnitsConsumed" runat="server" Text="Units Consumed:"></asp:Label><br />
<asp:TextBox ID="txtUnitsConsumed" runat="server"></asp:TextBox><br /><br />
 
            <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" OnClick="btnAddBill_Click" /><br /><br />
 
            <asp:Label ID="lblBillAmount" runat="server" ForeColor="Green"></asp:Label>
</div>
</form>
</body>
</html>

 