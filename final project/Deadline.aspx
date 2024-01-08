<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deadline.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FF66FF">
    <form id="form1" runat="server">
        <div>
            <h1>Assign Deadline<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 729px" Text="Home" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 24px" Text="Logout" />
            </h1>
            <p>Deadline ID: 
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
            <p>Description:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>Date:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>Time:
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <p>Group id:
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p></div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
    </form>
    </body>
</html>
