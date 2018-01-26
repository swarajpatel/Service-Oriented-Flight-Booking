<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member_reg.aspx.cs" Inherits="Assignment5_2.Member_reg" %>
<%@ Register TagPrefix = "project" TagName="img_verifier" src="ucImage.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Member Registration</h1> <hr/>
	 <form id="form2" runat="server">
		<table>
			<tr> 	
                <td>User Name:</td>      	
          	    <td> <asp:TextBox ID="UserName" RunAt="server" /></td> 

			</tr>
            <tr> 	
                <td>Email Id:</td>      	
          	    <td> <asp:TextBox ID="Email" RunAt="server" /></td> 
			</tr>
        	<tr> 	
                <td> Password: </td>
				<td><asp:TextBox ID="Password" TextMode="password" RunAt="server" /></td>

        	</tr>
            <tr>
                <td>
			        <project:img_verifier ID="control" runat = "server" />
                </td>
                <td>
                    <asp:Label ID="Label2" Visible="false" runat ="server" />
                </td>
            </tr>
			<tr>
				<td><asp:Button ID="submit" Text="Submit" RunAt="server" OnClick="submit_Click"  /></td>
        	</tr>
		</table>
	</form>
    

    <hr/> <h3><asp:Label ID="Output" RunAt="server" /></h3>
</body>
</html>
