<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="LoginRegistration.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Edit Karo</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Student Name" ID="StudentNameLabel"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="StudentName" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="validator" ControlToValidate="StudentName" ErrorMessage="Student Name is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Gender" ID="GenderLabel"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="Gender" required="true">
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                        <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="Gender" ErrorMessage="Gender is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Age" ID="AgeLabel"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="Age" TextMode="Number" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="Age" ErrorMessage="Age is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label runat="server" Text="Course" ID="CourseLabel"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="Course" required="true">
                        <asp:ListItem Text="CSE" Value="CSE"></asp:ListItem>
                        <asp:ListItem Text="IT" Value="IT"></asp:ListItem>
                        <asp:ListItem Text="AIDS" Value="AIDS"></asp:ListItem>
                        <asp:ListItem Text="AIML" Value="AIML"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="Course" ErrorMessage="Course is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
        </table>
        <asp:Button runat="server" ID="submit" OnClick="edit" Text="Edit"/>
        <br />
        <a href="Read.aspx">Go Back</a>
    </form>
</body>
</html>
