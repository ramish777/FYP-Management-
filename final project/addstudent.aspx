<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addstudent.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-style: italic;
            text-decoration: underline;
        }
    </style>
</head>
<body style="background-color: #66FF66">
    <form id="form1" runat="server">
        <div>
           <h1> Student Registration&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 398px" Text="Home" CausesValidation = "false" />
&nbsp;
               <asp:Button ID="Button3" runat="server" Text="Logout" CausesValidation = "false" OnClick="Button3_Click"/>
            </h1></div>
        <p>
            University ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        </p>
        <p>
            Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        </p>
        <p>
            CNIC:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
        </p>
        <p>
            University username:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
        </p>
        <p>
            Department:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
        </p>
        <p>
            Group id:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>LOGIN FOR FYP MANAGEMENT SYSTEM is <span class="auto-style1"><em>UNIVERSITY USERNAME</em></span> WITH <span class="auto-style1">PASSWORD: fastnu </span></strong>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
