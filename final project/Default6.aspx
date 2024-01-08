<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

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
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-decoration: underline;
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #CC9900">
    <form id="form1" runat="server">
    <div class="auto-style1">  
        <strong><span class="auto-style2"><h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome </span>
        <asp:Label ID="name1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button11" runat="server" OnClick="Button11_Click" style="margin-left: 379px" Text="Logout" />
        </h1>
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
            Panel ID:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Panel Member ID:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style5">
            <strong>As a Supervisor</strong></p>
            <div class="auto-style4">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Fyps as Supervisor" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Reviews by Panel Member" style="margin-left: 19px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Deadline" style="margin-left: 16px" />
                <asp:Button ID="Button4" runat="server" Text="Give your review given to Fyps" OnClick="Button4_Click" style="margin-left: 18px" />
                <br />
                <br />
                <br />
                <span class="auto-style3"><strong>As a Panel Member<br />
                </strong></span>
                <br />
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="View Fyps as Panel Member" />
&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Fill Evaluation" />
&nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Search as Panel Member" />
        </div>
            </form>
</body>
</html>
