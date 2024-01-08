<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student_fyp_info.aspx.cs" Inherits="student_fyp_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CCFFCC">
    <form id="form1" runat="server">
        <div>
        <div style="height: 28px">
            <strong>View FYP Information&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" style="margin-left: 824px; height: 29px;" Text="Home" OnClick="Button1_Click1" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            <br />
            Group Members</strong><br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" style="margin-top: 66px">
        </asp:GridView>
        <p>
            <strong>Project Description</strong></p>
        <p>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </p>
            <p>
                <strong>Supervisor</strong></p>
        <p>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </p>
        
    </form>
</body>
</html>

