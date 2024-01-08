<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viewgrade.aspx.cs" Inherits="Viewgrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFCCCC">
    <form id="form1" runat="server">
        <div>
            <h1>View Grade</h1><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Home" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            <br />
            <br />
        </div>
        <h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
    </form>
</body>
</html>
