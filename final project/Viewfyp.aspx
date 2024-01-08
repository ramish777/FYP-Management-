<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viewfyp.aspx.cs" Inherits="Viewfyp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #00FFFF">
    <form id="form1" runat="server">
        <div style="height: 28px">
            <strong>View FYPs Informations<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 744px" Text="Home" />
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
            <strong>Supervisor of your repective FYPs</strong></p>
        <p>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </p>
        <p>
            <strong>Group members of your respective FYPs</strong></p>
        <p>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
