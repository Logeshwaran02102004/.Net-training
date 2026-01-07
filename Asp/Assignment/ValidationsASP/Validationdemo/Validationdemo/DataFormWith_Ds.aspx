<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataFormWith_Ds.aspx.cs" Inherits="Validationdemo.DataFormWith_Ds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="acc_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="acc_id" HeaderText="acc_id" ReadOnly="True" SortExpression="acc_id" />
                <asp:BoundField DataField="acc_name" HeaderText="acc_name" SortExpression="acc_name" />
                <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQL_DAY_1ConnectionString %>" SelectCommand="SELECT * FROM [BankAccount]"></asp:SqlDataSource>
    </form>
</body>
</html>
