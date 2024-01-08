<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addfyp.aspx.cs" Inherits="addfyp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body style="background-color: #666699">
    <form id="form1" runat="server">
        <div>
           <h1> FYPS INFORMATION &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 303px" Text="Home" CausesValidation = "false" />
&nbsp;
               <asp:Button ID="Button3" runat="server" Text="Logout" CausesValidation = "false" OnClick="Button3_Click"/>
            </h1></div>
        <p>
            FYP ID:&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="TextBox2" CausesValidation="false"></asp:RequiredFieldValidator>
        </p>
        <p class="auto-style1">
            Description:
            <asp:TextBox ID="TextBox6" runat="server" BorderWidth="5px" Height="68px" style="margin-left: 8px; margin-top: 3px" TextMode="MultiLine" Width="253px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Field Required" ForeColor="Red" CausesValidation="false" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
        </p>
        <p class="auto-style1">
            Grade:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <div>
        </div>
    </form>
</body>
</html>
