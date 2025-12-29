<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssessdemoValidation.aspx.cs"
    Inherits="Validationdemo.AssessdemoValidation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Election Eligibility Validation</title>

   <script type="text/javascript">
       function ValidateAgeClient(sender, args) {
           var age = args.Value;

           if (age === "") {
               alert("Age cannot be empty");
               args.IsValid = false;
           }
           else if (parseInt(age) >= 18) {
               alert("Eligible to Vote");
               args.IsValid = true;
           }
           else {
               alert("Not Eligible to Vote. Age must be 18 or above");
               args.IsValid = false;
           }
       }
   </script>
</head>
<body>

<form id="form1" runat="server">

    Enter Your Age :
    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

    <br />

    <asp:CustomValidator
        ID="CustomValidator1"
        runat="server"
        ControlToValidate="txtAge"
        ErrorMessage="Age must be 18 or above"
        ForeColor="Red"
        ClientValidationFunction="ValidateAgeClient"
        OnServerValidate="CustomValidatorAge_ServerValidate"
        ValidateEmptyText="true" />

    <br /><br />

    <asp:Button ID="btnCheck" runat="server" Text="Check Eligibility"  OnClick="btnSave_Click" />

    <br /><br />

    <asp:Label ID="lblmsg" runat="server" ></asp:Label>

</form>

</body>
</html>
