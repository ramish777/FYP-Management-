<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panel.aspx.cs" Inherits="panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FF9933">
    <form id="form1" runat="server">
        <div>
            <h1>Panel Creation<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 710px" Text="Home" CauseValidation="false"/>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 28px" Text="Logout" CauseValidation="false"/>
            </h1></div>
        <p>
            Panel id: 
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Panel name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Panel alloted to Fyp:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" style="height: 29px" />
        </p>
    </form>
</body>
</html>
