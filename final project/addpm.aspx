<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addpm.aspx.cs" Inherits="addpm" %>

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
<body style="background-color: #99FF66">
    <form id="form1" runat="server">
        <div>
        <div>
           <h1> Panel Member Registration&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               
               <asp:Button ID="Button2" runat="server" Text="Home" CauseValidation="false" OnClick="Button2_Click" CausesValidation = "false"/>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" CausesValidation="false"/>
               
            </h1></div>
        <p>
            Panel Member ID:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Employee ID:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="DropDownList1" causeValidation="False"></asp:RequiredFieldValidator>
        </p>
        <p>
            Panel id:
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Field Required" ForeColor="Red" ControlToValidate="DropDownList2" causeValidation="False"></asp:RequiredFieldValidator>
        </p>
        <p>
            <strong>LOGIN FOR FYP MANAGEMENT SYSTEM is <span class="auto-style1"><em>UNIVERSITY USERNAME</em></span> WITH <span class="auto-style1">PASSWORD: fastnu </span></strong>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </p>
        </div>
    </form>
</body>
</html>
