<%@ Page Language="C#" AutoEventWireup="true" CodeFile="evaluation.aspx.cs" Inherits="evaluation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .RBL {
            margin-left: 156px;
        }
    </style>
</head>
<body style="background-color: #FF9933">
        <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 style="text-align: left">Evaluation of Group&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 707px" Text="Home" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
            </h1>
            <br />
            Group id:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
        <p>
            FYP name:
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            1. FYP Poster<br/>
                <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" onClick="handleClick(this)">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
    </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
            2. Iteration Definition, FYP Plan, Work Breakdown<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL" Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
    </label>
        
            <br />
            3. Work completed for the iteration(s) including design &amp; implementation<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" Width="639px" style="margin-left: 164px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
    </label>
            <br />
        4. Slide Design and Content Quality<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL" Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
    </label>
        5. Style (Delivery, Confidence, Clarity)<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
    </label>
        6. Clarity of Project Scope<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
    </label>
            
                7. Definition of Project Features<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
    </label>
            <br />
            8. Team Dynamics (Coordination among team members)<br />
            <br />
            <label class="radio-inline"><asp:RadioButtonList ID="RadioButtonList8" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL" Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            9. Timing of Presentation<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList9" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            10. Implementation Work Completion<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList10" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            11. Overall work quality and impression<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList11" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            12. Code Quality<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList12" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL" Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            13. Level of code integration<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList13" runat="server" RepeatDirection="Horizontal" Width="639px" style="margin-left: 160px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            14. Class Diagram/DFD (provided in the report) correctly maps to the Code Implemented<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList14" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            15. Handling of Questions<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList15" runat="server" RepeatDirection="Horizontal"  RepeatLayout="Table" CssClass="RBL"  Width="639px" >
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            Review/Suggestions<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" BorderWidth="10px" Height="114px" style="margin-left: 163px" Width="587px" TextMode="MultiLine"></asp:TextBox>
                <br />
            <br />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 22px" Text="Update" />
                </p>
    </label>
        </form>
</body>
</html>
