<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member_page.aspx.cs" Inherits="Assignment5_2.Member_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome,
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="Logoutbtn" runat="server" OnClick="Logoutbtn_Click" Text="Logout" />


        </div>
    <hr/>
		<table cellpadding="8">
			<tr> 	
                <td>From:</td>      	
          	    <td> 
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                        <asp:ListItem Value="NY">New York</asp:ListItem>
                        <asp:ListItem Value="BO">Boston</asp:ListItem>
                    </asp:DropDownList>
                </td>
			</tr>
        	<tr>
                <td> To: </td>
				<td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                        <asp:ListItem Value="NY">New York</asp:ListItem>
                        <asp:ListItem Value="BO">Boston</asp:ListItem>
                    </asp:DropDownList>
				</td> 

        	</tr>
            <tr>
                <td>Select date:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
			<tr>
				<td><asp:Button ID="submit" Text="Submit" RunAt="server" OnClick="Unnamed1_Click" /></td>
        	</tr>
		</table>
        <hr />
        <h2>Flights available:</h2>
	    <asp:CheckBoxList ID = "CheckBoxList1" runat = "server" AutoPostBack="True">
            
	    </asp:CheckBoxList>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <hr />
        <h2>Weather on selected day and next 4 days:</h2>
	    <br />
	    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
	    <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
	    <br />
        <asp:Button ID="Button1" runat="server" Text="Send details" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
        <br />
        <br />
	</form>
</body>
</html>
