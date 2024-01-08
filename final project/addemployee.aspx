<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addemployee.aspx.cs" Inherits="addemployee" %>

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
           <h1> Supervisor Registration&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home" CausesValidation = "false"/>
&nbsp;&nbsp;
               <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" CausesValidation = "false"/>
            </h1></div>
        <p>
            Supervisor ID:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Employee ID:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        </p>
        <p>
            Group id:
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
        </p>
        <p>
            <strong>LOGIN FOR FYP MANAGEMENT SYSTEM is <span class="auto-style1"><em>UNIVERSITY USERNAME</em></span> WITH <span class="auto-style1">PASSWORD: fastnu </span></strong>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </p>
        </form>
</body>
</html>
