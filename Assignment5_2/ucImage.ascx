<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucImage.ascx.cs" Inherits="Assignment5_2.ucImage" %>
<asp:Image ID="Image1" Visible="false" runat="server" Height="46px" style="margin-right: 0px" Width="334px" />
        &nbsp &nbsp &nbsp
        <asp:Button ID="Button1" runat="server" Text="Show Image" OnClick="Button1_Click" />
        <br />
        <br /> 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br /> 
        <asp:Button ID="Button2" runat="server" Text="Check" OnClick="Button2_Click" />
        &nbsp &nbsp &nbsp
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
