<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightLookup_tryit.aspx.cs" Inherits="Assignment5_2.FlightLookup_tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <p>
           <h2>Flight Lookup Try it page</h2></p>
        <p>
        This service returns the flight between 2 destinations<br />
            <asp:Label ID="URL" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Method1" runat="server">Method 1 <br /> Name : flight_lookup <br /> Input :ToFrom <br /> Output :String flights</asp:Label>
            <br />
            <br />
            <asp:Label ID="info" runat="server">*Use any of "AZ,NY,BO" for both departure and arrival for successful implementation. Due to constraints of xml file.</asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="From: "></asp:Label> &nbsp
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="To: "></asp:Label> &nbsp
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> &nbsp
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Flights" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label> &nbsp
    </form>
</body>
</html>
