<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body style="background-color: #00FFFF">
    <form id="form1" runat="server">
        <div>
            <h1>Reports<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 787px" Text="Home" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            </h1>
            <p>&nbsp;</p>
            <p class="auto-style1" style="background-color: #00FFFF"><strong>Missing Evaluation of students by Panel members</strong></p>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
            <p>&nbsp;</p></div>
        <p class="auto-style1">
            <strong>Faculty member that are supervising FYPS</strong></p>
        <p>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </p>
        <p class="auto-style1">
            <strong>&nbsp;Supervisor Workload count</strong></p>
        <p>
            <asp:GridView ID="GridView3" runat="server" Height="103px" style="margin-top: 0px">
            </asp:GridView>
        </p>
        <p class="auto-style1">
            <strong>Grade report</strong></p>
        <p>
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="225px">
            </asp:DropDownList>
        &nbsp;
            <asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" />
        </p>
        <p class="auto-style1">
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
