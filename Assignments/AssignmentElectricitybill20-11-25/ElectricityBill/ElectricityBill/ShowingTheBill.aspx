<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowingTheBill.aspx.cs" Inherits="ElectricityBill.ShowingTheBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
body {
    font-family: 'Poppins', sans-serif;
    background: radial-gradient(circle at top, #1f2933, #0f172a);
    margin: 0;
    padding: 0;
    min-height: 100vh;
}

.form-container {
    width: 460px;
    margin: 70px auto;
    padding: 40px;
    background: rgba(255, 255, 255, 0.08);
    backdrop-filter: blur(12px);
    border-radius: 18px;
    box-shadow: 0 15px 40px rgba(0, 0, 0, 0.5);
    color: #e5e7eb;
}

.form-container h2 {
    text-align: center;
    margin-bottom: 28px;
    font-weight: 600;
    color: #f9fafb;
}

.form-container label {
    display: block;
    font-size: 13px;
    letter-spacing: 0.5px;
    margin-bottom: 6px;
    color: #cbd5f5;
}

.txtInput {
    width: 100%;
    padding: 11px 14px;
    margin-bottom: 20px;
    background-color: rgba(15, 23, 42, 0.9);
    border: 1px solid rgba(148, 163, 184, 0.3);
    border-radius: 10px;
    color: #f1f5f9;
    font-size: 14px;
}

.txtInput:focus {
    outline: none;
    border-color: #38bdf8;
    box-shadow: 0 0 8px rgba(56, 189, 248, 0.6);
}

.btnSubmit {
    width: 100%;
    padding: 13px;
    background: linear-gradient(135deg, #38bdf8, #6366f1);
    border: none;
    border-radius: 12px;
    color: #ffffff;
    font-size: 15px;
    font-weight: 600;
    cursor: pointer;
}

.btnSubmit:hover {
    box-shadow: 0 8px 25px rgba(99, 102, 241, 0.5);
}

#GridView1 {
    width: 100%;
    border-collapse: collapse;
    margin-top: 25px;
    color: #e5e7eb;
}

#GridView1 th,
#GridView1 td {
    padding: 12px;
    border-bottom: 1px solid rgba(148, 163, 184, 0.25);
}

#GridView1 th {
    background-color: rgba(99, 102, 241, 0.35);
    font-weight: 500;
}

#GridView1 tr:hover {
    background-color: rgba(148, 163, 184, 0.15);
}
</style>

<body>
    <form id="form1" runat="server">
        <div class="form-container">
<h2>Search for Recently added files</h2>
<asp:Label ID="lblN" runat="server" Text="Enter number of bills:" CssClass="lbl"></asp:Label>
<asp:TextBox ID="txtN" runat="server" CssClass="txtInput"></asp:TextBox>
<asp:Button ID="btnFetch" runat="server" Text="Fetch Bills" CssClass="btnSubmit" OnClick="btnFetch_Click" />
 
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="grid">
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