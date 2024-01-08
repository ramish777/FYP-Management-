<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_student_deadline.aspx.cs" Inherits="view_student_deadline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div style="height: 28px">
            <strong>Deadline &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" style="margin-left: 824px" Text="Home" OnClick="Button1_Click1" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            <br />
            <br/>
                <br/>
                <br/>
        </div>
        
       
            
        
        <p>

              <p>
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </p>
       
        </div>
    </form>
</body>
</html>
