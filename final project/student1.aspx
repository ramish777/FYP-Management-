<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student1.aspx.cs" Inherits="student1" %>


<!DOCTYPE html>
<script runat="server">

</script>


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
            Student ID:
            <asp:Label ID="Student_ID" runat="server" Text="Student_ID"></asp:Label>
        </p>
        <p>
            Department:
            <asp:Label ID="department" runat="server" Text="department"></asp:Label>
        </p>
        <p>
            Uni Email:
            <asp:Label ID="email" runat="server" Text="email"></asp:Label>
        </p>
        <p>
            CNIC:
            <asp:Label ID="CNIC" runat="server" Text="CNIC"></asp:Label>
        </p>
        <p>
            Group ID:
            <asp:Label ID="Group_ID" runat="server" Text="group_id"></asp:Label>
        </p>
            <p>
                &nbsp;</p>
        </div>
         <asp:Button ID="Button4" runat="server" Text="View Fyp Information" OnClick="Button4_Click" />
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="View Panel" OnClick="Button1_Click"  />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="View Reviews" OnClick="Button2_Click"  />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="View Deadline" OnClick="Button3_Click"  />
&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="View Grade" />
    </form>
</body>
</html>
