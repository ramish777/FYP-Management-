<%@ Page Language="C#" AutoEventWireup="true" CodeFile="givereview.aspx.cs" Inherits="givereview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #99FF99">
    <form id="form1" runat="server">
        <div>
            <strong><h1>Give Review<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 791px" Text="Home" />
&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" />
            </h1></strong><br />
            <br />
            Fyp ID :<asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 7px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Field Required" ForeColor="Red" CausesValidation="false"></asp:RequiredFieldValidator>
            <br />
            <br />
            Review/Suggestions:<br />
            <br />
            <label class="radio-inline">
            <asp:TextBox ID="TextBox1" runat="server" BorderWidth="10px" Height="114px" style="margin-left: 163px" Width="587px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
&nbsp;</label></div>
    </form>
</body>
</html>
