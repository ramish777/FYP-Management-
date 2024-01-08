<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #00CCFF">
    <form id="form1" runat="server">
        <div>
            <h1>Search Fyps Information<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 631px" Text="Home" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" />
            </h1><br />
            <br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="49px" Width="428px">
            <asp:ListItem>Students</asp:ListItem>
            <asp:ListItem>Evaluations</asp:ListItem>
            <asp:ListItem>Fyps</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <asp:GridView ID="GridView1" runat="server" style="margin-top: 46px">
        </asp:GridView>
    </form>
</body>
</html>
