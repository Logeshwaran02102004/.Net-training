<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowingTheBill.aspx.cs" Inherits="ElectricityBill.ShowingTheBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
body {
    font-family: 'Poppins', sans-serif;
    background: linear-gradient(135deg, #e0f2fe, #eef2ff, #fdf4ff);
    margin: 0;
    padding: 0;
    min-height: 100vh;
}

.header {
    background: linear-gradient(135deg, #2563eb, #7c3aed);
    color: #ffffff;
    padding: 16px 35px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    box-shadow: 0 8px 25px rgba(0, 0, 0, 0.25);
}

.header h2 {
    margin: 0;
    font-weight: 600;
    letter-spacing: 0.5px;
}

.header a {
    color: #ffffff;
    margin-left: 18px;
    text-decoration: none;
    font-weight: 500;
    position: relative;
}

.header a::after {
    content: "";
    position: absolute;
    left: 0;
    bottom: -4px;
    width: 0;
    height: 2px;
    background: #facc15;
    transition: width 0.3s ease;
}

.header a:hover::after {
    width: 100%;
}

.container {
    width: 420px;
    margin: 70px auto;
    padding: 38px;
    background: rgba(255, 255, 255, 0.95);
    backdrop-filter: blur(12px);
    border-radius: 20px;
    border: 1px solid rgba(99, 102, 241, 0.25);
    box-shadow: 0 20px 50px rgba(0, 0, 0, 0.18), inset 0 0 0 1px rgba(255, 255, 255, 0.4);
}

input[type=text],
input[type=password] {
    width: 100%;
    padding: 12px 14px;
    margin-bottom: 18px;
    border-radius: 12px;
    border: 1px solid #c7d2fe;
    background: #f8fafc;
    font-size: 14px;
    transition: all 0.25s ease;
}

input::placeholder {
    color: #94a3b8;
}

input:focus {
    outline: none;
    border-color: #6366f1;
    background: #ffffff;
    box-shadow: 0 0 0 3px rgba(99, 102, 241, 0.25);
}

button,
input[type=submit] {
    width: 100%;
    padding: 14px;
    background: linear-gradient(135deg, #38bdf8, #6366f1);
    border: none;
    border-radius: 14px;
    color: #ffffff;
    font-weight: 600;
    font-size: 15px;
    cursor: pointer;
    transition: transform 0.15s ease, box-shadow 0.15s ease;
}

button:hover,
input[type=submit]:hover {
    transform: translateY(-1px);
    box-shadow: 0 12px 30px rgba(99, 102, 241, 0.45);
}

.link {
    display: block;
    text-align: center;
    margin-top: 18px;
    color: #4f46e5;
    font-weight: 500;
    text-decoration: none;
}

.link:hover {
    text-decoration: underline;
}

</style>

<body>
<form runat="server">

<div class="header">
    <h2>Recent Bills</h2>
    <div>
        <a href="AddBilling.aspx">Back</a>
        <a href="Logout.aspx">Logout</a>
    </div>
</div>

<div class="container">
    <asp:TextBox ID="txtN" runat="server" Placeholder="Enter number of bills"></asp:TextBox>
    <asp:Button ID="btnFetch" runat="server" Text="Fetch Bills" OnClick="btnFetch_Click" />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
            <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
            <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
            <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" />
        </Columns>
    </asp:GridView>
</div>

</form>
</body>
</html>