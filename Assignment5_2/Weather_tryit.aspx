<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather_tryit.aspx.cs" Inherits="Assignment5_2.Weather_tryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
           <h2>Weather Try it page</h2></p>
        <p>
            <asp:Label ID="Head" runat="server">This is a service that returns the maximum and minimum temperatures for the current day and the next 4 days.(in total 5 days)</asp:Label>
            <br />
            <br />
            <asp:Label ID="URL" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Method1" runat="server">Method 1 <br /> Name : LatLonListZipCode <br /> Input :String zipcode <br /> Output : String listLatLonOut</asp:Label>
            <br />
            <br />
            <asp:Label ID="Method2" runat="server">Method 2 <br /> Name : NDFDgenByDay <br /> Input :Decimal Latitude, Decimal Longitude, Date startDate, Integer numDays, String unit, String format <br /> Output : String dwmlByDayOut</asp:Label>
            <br />
            <br />
            ZIPCODE:&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server" Height="33px" ></asp:TextBox>
            &nbsp
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Invoke" Height="33px" />
            <br />
            <br />
            <asp:Label ID="val1" runat="server" Text="The Latitude of the Zipcode is : "></asp:Label>
            <br />
            <asp:Label ID="val2" runat="server" Text="The Longitude of the Zipcode is : "></asp:Label>
            <br />
            <br />
            <asp:Label ID="val3" runat="server" Text="The Maximum temperatures for the next 5 days are : "></asp:Label>
            <br />
            <asp:Label ID="val4" runat="server" Text="The Maximum temperatures for the next 5 days are : "></asp:Label>
        </p>
    </form>
</body>
</html>
