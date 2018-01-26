<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="loginsesscookie.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg .tg-yw4l{vertical-align:top}
</style>
</head>
<body>
    <h1> Group: Team_gc_Devils_gc_0<br />Project: Flight details lookup</h1>
    <form id="form1" runat="server">
        <div>
            <table>
              <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Member page" OnClick="Button1_Click" />
                  </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Staff page" OnClick="Button2_Click" />
                  </td>
              </tr>

              <tr>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Member Login" OnClick="Button4_Click" />
                  </td>
                <td>&nbsp;<asp:Button ID="Button5" runat="server" Text="Member Register" OnClick="Button5_Click" />
&nbsp; </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Staff Login" OnClick="Button3_Click" />
                  </td>
              </tr>
            </table>
        </div>
    </form>

    <h2>Service Directory</h2>
<p>Team name: Team_gc_Devils_gc_0</p>
<p>Directory Link: <a href="http://webstrar13.fulton.asu.edu/page2/default.aspx">http://webstrar13.fulton.asu.edu/page2/default.aspx</a></p>
<table class="tg">
  <tr>
    <th class="tg-yw4l">Provider Name</th>
    <th class="tg-yw4l">Type: Service/Component</th>
    <th class="tg-yw4l">Component/Service with input output</th>
    <th class="tg-yw4l">Try It Link</th>
    <th class="tg-yw4l">Service<br>Description</th>
    
  </tr>
  <tr>
    <td class="tg-yw4l">Swaraj Patel</td>
    <td class="tg-yw4l">Component</td>
    <td class="tg-yw4l">Global.asax Component</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/Global_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/Global_tryit.aspx</a></td>
    <td class="tg-yw4l">We have used event handler for session_start event. It checks if cookie for member sign in is present and creates a session for it. </td>
    
  </tr>

  <tr>
    <td class="tg-yw4l">Swaraj Patel </td>
    <td class="tg-yw4l">Component</td>
    <td class="tg-yw4l">Cookie Component</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/Cookie_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/Cookie_tryit.aspx</a></td>
    <td class="tg-yw4l">We have used cookies to remember manage user sessions. If the user checks 'Keep me signed' checkbox in the Member login page. Then the cookie is generated and stored. </td>
  </tr>
  <tr>
    <td class="tg-yw4l">Swaraj Patel</td>
    <td class="tg-yw4l">Service</td>
    <td class="tg-yw4l">Weather5day(string zipcode),Input: a U.S. zipcode,Output: An array (or list) of strings, storing5-day weather forecast for the given zipcode location.</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/Weather_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/Weather_tryit.aspx</a></td>
    <td class="tg-yw4l">Create a 5-day weather forecast service of zipcode location based on the national weather service</td>
  </tr>
  <tr>
    <td class="tg-yw4l">Swaraj Patel </td>
    <td class="tg-yw4l">Component</td>
    <td class="tg-yw4l">XML file manipulation</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/Staff_login.aspx">http://webstrar13.fulton.asu.edu/page2/Staff_login.aspx</a></td>
    <td class="tg-yw4l">XML file manipulation component is used for Member registration, member login and staff login pages for adding and searching values in xml files. Staff Login Details: Username:TA Password:cse445ta! </td>
  </tr>
  <tr>
    <td class="tg-yw4l">Santoshkumar Amisagada </td>
    <td class="tg-yw4l">Component</td>
    <td class="tg-yw4l">DLL Component</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/DLL_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/DLL_tryit.aspx</a></td>
    <td class="tg-yw4l">Cipher encryption and decryption of string (password) to authenticate user. </td>
  </tr>
  <tr>
    <td class="tg-yw4l">Santoshkumar Amisagada </td>
    <td class="tg-yw4l">Component</td>
    <td class="tg-yw4l">User Control Component</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/Member_reg.aspx">http://webstrar13.fulton.asu.edu/page2/Member_reg.aspx</a></td>
    <td class="tg-yw4l">Created image verifier user control for Member login page. Click the show Image button for displaying user control </td>
  </tr>
  <tr>
    <td class="tg-yw4l">Santoshkumar<br> Amisagadda</td>
    <td class="tg-yw4l">Service</td>
    <td class="tg-yw4l">Flight lookup service,Inputs:<br> departure_location as string,<br>destination_location as string,<br>Output: list of string, flights <br>available</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/FlightLookup_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/FlightLookup_tryit.aspx</a></td>
    <td class="tg-yw4l">A service to lookup available flights from departure to destination</td>
  </tr>
  <tr>
    <td class="tg-yw4l">Santoshkumar <br>Amisagadda</td>
    <td class="tg-yw4l">Service</td>
    <td class="tg-yw4l">sendEmail:,Input: <br>String(receiver email , <br>message),Output: <br>Boolean</td>
    <td class="tg-yw4l"><a href="http://webstrar13.fulton.asu.edu/page2/SendEmail_tryit.aspx">http://webstrar13.fulton.asu.edu/page2/SendEmail_tryit.aspx</a></td>
    <td class="tg-yw4l">Send the ticket confirmation to the user’s email</td>
  </tr>

  <tr>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
  </tr>
</table>
</body>
</html>
