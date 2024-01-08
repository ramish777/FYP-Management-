<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewdeadline.aspx.cs" Inherits="viewdeadline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 28px">
            <strong><h1>Deadlines&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 815px" Text="Home" />
&nbsp;<strong><asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 11px" Text="Logout" />
                </strong></h1>
            </strong><br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" style="margin-top: 48px">
        </asp:GridView>
    </form>
</body>
</html>
