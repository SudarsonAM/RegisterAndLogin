<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginRegistration.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
    body {
      display: flex;
      flex-direction:column;
      justify-content: center;
      align-items: center;
      height: 100vh;
    }
  </style>
</head>
<body>
    <h1>Login</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" ID="UserNameLabel" Text="Enter The UserName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="UserName" required="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="PasswordLabel"  Text="Enter The Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" required="true"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Sumbit" runat="server" OnClick="CheckLogin" Text="Login"/>
    </form>
    <br />
    <br />
    <asp:Label runat="server" Text="" ForeColor="Red" ID="Error"></asp:Label>
</body>
</html>
