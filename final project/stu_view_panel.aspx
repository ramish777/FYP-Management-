<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stu_view_panel.aspx.cs" Inherits="stu_view_panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFFF00">
    <form id="form1" runat="server">
        <div>
        <div style="height: 28px; margin-bottom: 0px;">
            <strong><h1>Panel Information</h1>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" style="margin-left: 824px" Text="Home" OnClick="Button1_Click1" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            <br/>
                <br/>
                <br/>
        </div>
        
       
            
        
        <p>
            <strong>Panel Members</strong></p>

              <p>
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </p>
       
        </div>
    </form>
</body>
</html>