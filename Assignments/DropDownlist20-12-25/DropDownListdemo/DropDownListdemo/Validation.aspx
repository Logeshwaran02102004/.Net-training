<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="DropDownListdemo.Validation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Form</title>

    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            background: linear-gradient(135deg, #e0e7ff, #f8fafc);
        }

        .form-box {
            width: 420px;
            margin: 60px auto;
            padding: 30px;
            background-color: #ffffff;
            border-radius: 12px;
            box-shadow: 0 8px 25px rgba(0, 0, 0, 0.15);
        }

        h3 {
            text-align: center;
            margin-bottom: 25px;
            color: #1f2937;
        }

        label {
            display: inline-block;
            width: 120px;
            color: #374151;
        }

        input[type="text"] {
            width: 200px;
            padding: 6px;
            border-radius: 5px;
            border: 1px solid #cbd5e1;
        }

        input[type="text"]:focus {
            outline: none;
            border-color: #6366f1;
            box-shadow: 0 0 4px rgba(99, 102, 241, 0.5);
        }

        #btnCheck {
            padding: 8px 18px;
            background-color: #4f46e5;
            color: #ffffff;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            display: block;
            margin: 0 auto;
        }

        #btnCheck:hover {
            background-color: #4338ca;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="form-box">

            <h3>Insert your details:</h3>

            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server"
                ControlToValidate="txtName"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <br /><br />





            <asp:Label ID="lblFamilyName" runat="server" Text="Family Name:"></asp:Label>
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFamilyName" runat="server"
                ControlToValidate="txtFamilyName"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:CustomValidator ID="cvFamilyNameDiff" runat="server"
                ControlToValidate="txtFamilyName"
                OnServerValidate="FamilyNamedifference"
                ErrorMessage="Must differ from name"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />




            <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server"
                ControlToValidate="txtAddress"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:CustomValidator ID="cvAddressLength" runat="server"
                ControlToValidate="txtAddress"
                OnServerValidate="AddressLength"
                ErrorMessage="At least 2 characters"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />





            <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCity" runat="server"
                ControlToValidate="txtCity"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:CustomValidator ID="cvCityLength" runat="server"
                ControlToValidate="txtCity"
                OnServerValidate="CityValidation"
                ErrorMessage="At least 2 characters"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />




            <asp:Label ID="lblZipCode" runat="server" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvZipCode" runat="server"
                ControlToValidate="txtZipCode"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revZipCode" runat="server"
                ControlToValidate="txtZipCode"
                ValidationExpression="^\d{5}$"
                ErrorMessage="Must be exactly 5 digits"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />




            <asp:Label ID="lblPhone" runat="server" Text="Phone:"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server"
                ControlToValidate="txtPhone"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revPhone" runat="server"
                ControlToValidate="txtPhone"
                ValidationExpression="^\d{2,3}-\d{7}$"
                ErrorMessage="Format XX-XXXXXXX or XXX-XXXXXXX"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />





            <asp:Label ID="lblEmail" runat="server" Text="E-Mail:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="* Required" ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail"
                ValidationExpression="^[^\s@]+@[^\s@]+\.[^\s@]+$"
                ErrorMessage="Invalid email"
                ForeColor="Red" Display="Dynamic" />
            <br /><br />




            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />

            <br /><br />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <asp:Label ID="lblMsg" runat="server" ForeColor="green"></asp:Label>

        </div>
    </form>
</body>
</html>
