<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie_tryit.aspx.cs" Inherits="Assignment5_2.Cookie_tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2> Cookie component Try it Page</h2>
    <p>
        We have used cookies to remember manage user sessions. If the user checks &#39;Keep me signed&#39; checkbox in the Member login page. Then the cookie is generated and stored.<br />
        You can login <a href="Member_login.aspx">here</a> and then come back to this page to check if the below label is updated.
        Make sure to check Keep me signed in box!
    </p>
    <form id="form1" runat="server">
        Check the value below:<br />
        <asp:Label ID="sessioncheck" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
