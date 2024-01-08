<%@ Page Language="C#" AutoEventWireup="true" CodeFile="supervisor.aspx.cs" Inherits="supervisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            text-align: center;
            height: 56px;
        }
        .auto-style2 {
            background-color: #FFFF00;
        }
    </style>
</head>
<body style="background-color: #9966FF">
    <form id="form1" runat="server">
        <div>
    <div class="auto-style1">  
        <strong><span class="auto-style2"><h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome </span>
        <asp:Label ID="name1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 287px" Text="Logout" />
&nbsp;</h1>
        <br />
            </strong>
    </div>
        <p>
            <strong>Personal Information</strong></p>
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
            Supervisor ID:
            <asp:Label ID="c_id" runat="server" Text="c_id"></asp:Label>
        </p>
            <p>
                &nbsp;</p>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Fyps" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Reviews by Panel Member" />
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Deadline" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Give your review given to Fyps" OnClick="Button4_Click" />
    </form>
</body>
</html>
