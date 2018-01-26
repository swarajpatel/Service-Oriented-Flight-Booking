<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff_login.aspx.cs" Inherits="Assignment5_2.Staff_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Staff Log In</h1> <hr/>
	 <form id="form2" runat="server">
		<table>
			<tr> 	<td>User Name:</td>      	
          	    		  	<td> <asp:TextBox ID="UserName" RunAt="server" /></td> </tr>
        		<tr> 	<td> Password: </td>
					<td><asp:TextBox ID="Password" TextMode="password" 
							RunAt="server" /> </td> </tr>	
			<tr>
				<td><asp:Button Text="Log In" OnClick="LoginFunc" 
						RunAt="server" /></td>
				<td>&nbsp;</td>
        		</tr>
		</table>
	</form>
    <hr/> <h3><asp:Label ID="Output" RunAt="server" /></h3>
</body>
</html>
