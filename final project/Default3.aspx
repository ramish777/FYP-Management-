<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #00CC00">
    <form id="form1" runat="server">
    <p class="auto-style1">
        <h1 class="auto-style1">
        Welcome
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </h1>
        <strong>Personal Information</strong></p>
        <div>
        <p>
            Name:
            <asp:Label ID="name" runat="server" Text="name"></asp:Label>
        </p>
        <p>
            Contact no:
            <asp:Label ID="contact" runat="server" Text="contact"></asp:Label>
        </p>
        <p>
            Department:
            <asp:Label ID="dept" runat="server" Text="dept"></asp:Label>
        </p>
        <p>
            Uni Email:
            <asp:Label ID="email" runat="server" Text="email"></asp:Label>
        </p>
        <p>
            Employee ID:
            <asp:Label ID="e_id" runat="server" Text="e_id"></asp:Label>
        </p>
        <p>
            Panel Member ID:
            <asp:Label ID="p_id" runat="server" Text="p_id"></asp:Label>
        </p>
            <p>
                Panel ID:
                <asp:Label ID="Label2" runat="server" Text="P_ID"></asp:Label>
        </p>
        </div>
        <asp:Button ID="Button1" runat="server" Text="View FYPs" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Fill Evaluation" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" />
    &nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 783px" Text="Logout" />
    </form>
</body>
</html>
