<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sup_info.aspx.cs" Inherits="sup_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #66FF66">
    <form id="form1" runat="server">
        <div>
        <div style="height: 28px">
            <strong>View FYPs Informations&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 824px" Text="Home" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            <br />
            Your FYPs</strong><br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" style="margin-top: 66px">
        </asp:GridView>
            <p>
                <strong>Panel members of your respective FYPs</strong></p>
        <p>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </p>
        <p>
            <strong>Group members of your respective FYPs</strong></p>
        <p>
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </p>
        </div>
    </form>
</body>
</html>
