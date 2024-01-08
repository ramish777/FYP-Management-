<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

 <title></title>
    </head>
<body>
    <form id="form1" runat="server">
           <h1> <strong>FYP MANAGEMENT SYSTEM&nbsp; </strong></h1></p>
        <p style="margin-left: 132px">
            <strong>Login</strong></p>
        <p style="width: 374px; height: 26px; margin-left: 13px">
            Username</p>
        <p style="width: 374px; margin-top: 0px; margin-left: 12px;">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 14px; width: 328px;">
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            &nbsp;</p>
        <p style="margin-left: 14px; width: 391px;">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <div style="margin-left: 40px; width: 151px;">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 34px" Text="Sign in" />
        </div>
    </form>
    </body>
</html>

