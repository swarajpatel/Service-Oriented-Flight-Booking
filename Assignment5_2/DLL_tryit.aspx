<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DLL_tryit.aspx.cs" Inherits="Assignment5_2.DLL_tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2> DLL component Try it Page</h2>
    <p>
        We have implemented Encryption and Decryption as a DLL component.
    </p>
    <form id="form1" runat="server">
        <div>
            Encryption:
            <br />
            Input:<br />
            <asp:TextBox ID="inputB" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Encrypt" />
            <br />
            <br />
            Output:<br />
            <asp:Label ID="encryptLbl" runat="server" Text="[Output]"></asp:Label>
            <br />
            <br />
            Decryption:<br />
            Input:<br />
            <asp:TextBox ID="input2B" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Decrypt" />
            <br />
            <br />
            Output:<br />
            <asp:Label ID="decryptLbl" runat="server" Text="[Output]"></asp:Label>
        </div>
    </form>
</body>
</html>
