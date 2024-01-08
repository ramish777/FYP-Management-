<%@ Page Language="C#" AutoEventWireup="true" CodeFile="review_eval.aspx.cs" Inherits="review_eval" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #33CCFF">
    <form id="form1" runat="server">
        <div>
        <div style="height: 28px; background-color: #33CCFF;">
            <strong><h1>Review By&nbsp; Panel Members for Fyps</h1>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 751px" Text="Home" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            Your FYPs>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" style="margin-top: 127px">
        </asp:GridView>
        <p>
            &nbsp;</p>
        </div>
    </form>
</body>
</html>
