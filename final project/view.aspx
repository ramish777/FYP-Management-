<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #00FFFF">
    <form id="form1" runat="server">
        <h1>View Records&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 777px" Text="Home" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" style="margin-left: 26px" />
        </h1>Student Records:</p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
    </form>
</body>
</html>
