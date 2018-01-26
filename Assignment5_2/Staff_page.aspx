<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff_page.aspx.cs" Inherits="Assignment5_2.Staff_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Staff Page</h1> <hr/>
    <form id="form2" runat="server">
	<p>Welcome, <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" Text="Logout" />
        <br />
        You can add new Staff here:
	</p>
&nbsp;<table>
			<tr> 	
                <td>Staff Member Name:</td>      	
          	    <td> <asp:TextBox ID="UserName" RunAt="server" /></td> 

			</tr>
            
        	<tr> 	
                <td> Password: </td>
				<td><asp:TextBox ID="Password" TextMode="password" RunAt="server" /></td>

        	</tr>
            
			<tr>
				<td><asp:Button ID="submit" Text="Submit" RunAt="server" OnClick="submit_Click"  /></td>
        	</tr>
		</table>
	</form>
     <hr/> <h3><asp:Label ID="Output" RunAt="server" /></h3>
</body>
</html>
