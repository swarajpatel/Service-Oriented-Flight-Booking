<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail_tryit.aspx.cs" Inherits="Assignment5_2.SendEmail_tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
           <h2>Send Email Try it page</h2></p>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label">This is a service that sends an email to the recepient mentioned along with the message specified. </asp:Label>
            <br />
            <asp:Label ID="URL" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Method1" runat="server">Method 1 <br /> Name : sendEmail <br /> Input :String recepient,String message <br /> Output : Boolean result</asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Recepient Email ID"></asp:Label> &nbsp
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp
            <br />
            <br />
            Message:&nbsp
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp
            <asp:Button ID="Button1" runat="server" Text="Send Email" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
    
    </form>
</body>
</html>
