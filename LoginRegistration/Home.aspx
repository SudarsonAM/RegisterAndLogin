<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginRegistration.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>head</title>
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
    <h1>Login using session Completed</h1>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="Comment"></asp:Label>
        <asp:Button runat="server" ID="submit" Text="Insert Content" OnClick="CreateText"/>
        <asp:Button runat="server" ID="Read" Text="View All" OnClick="GoToRead"/>
    </form>
</body>
</html>
