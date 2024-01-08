<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
<body style="background-color: #FFFF00">  
    <form id="form1" runat="server">  
    <div class="auto-style1">  
        <strong><span class="auto-style2"><h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome </span>
        <asp:Label ID="name1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;</h1>
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
            Committee Member ID:
            <asp:Label ID="c_id" runat="server" Text="c_id"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Add Student" OnClick="Button1_Click" Width="116px" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 13px; margin-bottom: 1px" Text="Add Supervisor" Width="177px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Create Panel" />
&nbsp;
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Add Panel member" />
        &nbsp;
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Add FYPs Information" />
        <br />
        <br />
&nbsp;<asp:Button ID="Button3" runat="server" Text="View Records" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Assign deadline" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Generate Report" Width="154px" OnClick="Button5_Click" />
    &nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" style="margin-left: 958px" Text="Logout" />
    </form>  
</body>  
</html>
