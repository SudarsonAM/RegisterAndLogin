<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="LoginRegistration.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
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
<body >
    <h1>Register Karo</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="UserNameLabel" runat="server" Text="UserName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="UserName" runat="server" required="true" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="EmailLabel" runat="server" Text="Email" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Email" runat="server" required="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" required="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="ConfirmPassword"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" required="true"></asp:TextBox>
                </td>
            </tr>

        </table>
        <asp:Button runat="server" ID="submit1" Text="Register" OnClick="Register"/>
        <a href="Login.aspx" >Login</a>
    </form>
    <br />
    <%--<asp:Button runat="server" ID="login" Text="Login" OnClick="Login"/>--%>
    
    
    <br />
    <asp:Label runat="server" Text="" ID="Comment" ForeColor="Red"></asp:Label>
</body>
</html>
