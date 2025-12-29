<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrationform.aspx.cs" Inherits="Validationdemo.Registrationform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
<style type="text/css">
 
        .self_style {
            height: 400px;
            width: 100%;
            margin-left: 40px;
            background-color: #f0f0f0;
            border: 1px solid #ccc;
        }
</style>
</head>
<body>
<form id="form1" runat="server">
<div class="self_style" >
 
<h1 style="color:saddlebrown; font-size:20px;text-align:center">Registration Form</h1> 
<br />
<br />
 
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
<asp:TextBox id="txtname" runat="server" Width="200px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="txtname" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
 
            Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtage" runat="server" Width="200px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Age is Required" ControlToValidate="txtage" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" Display="Dynamic" ErrorMessage="Age must be between 18 and 50" ForeColor="Red" MaximumValue="50" MinimumValue="18" Type="Integer"></asp:RangeValidator>
<br />
<br />
 
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtemail" runat="server" Width="200px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email is Required" ControlToValidate="txtemail" Display="Dynamic" ForeColor="#0000CC"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Provide correct email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
<br />
<br />
 
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtpassword" runat="server"  Width="200px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password is required" ControlToValidate="txtpassword" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
 
            Confirm Password:&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtcpass" runat="server"  Width="200px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Confirm the password" ControlToValidate="txtcpass" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtcpass" Display="Dynamic" ErrorMessage="Password is not matching" ForeColor="#000099"></asp:CompareValidator>
<br />
<br />
<br />
 
<asp:Button ID="BtnRegister" runat="server" text="Register" OnClick="BtnRegister_Click" />
 
 
<br />
<br />
 
 
</div>
</form>
</body>
</html>