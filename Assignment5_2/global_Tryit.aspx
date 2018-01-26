<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="global_Tryit.aspx.cs" Inherits="Assignment5_2.global_Tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2> Global.asax component Try it Page</h2>
    <p>
        We have used event handler for session_start event. It checks if cookie for member sign in is present and creates a session for it.
        <br />
        You can login <a href="Member_login.aspx">here</a> and then come back to this page to check if the below label is updated.
        Make sure to check Keep me signed in box!
    </p>

    <form id="form1" runat="server">
        Check the value below:<br />
        <asp:Label ID="sessioncheck" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
