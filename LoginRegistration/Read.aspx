<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="LoginRegistration.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display</title>
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
    <h1>ALL STUDENT DETAILS</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <th> </th>
                <th><b>Student Name</b></th>
                <th><b>Course</b></th>
                <th><b>Gender</b></th>
                <th><b>Age</b></th>
                <th><b>Edit</b></th>
                <th><b>Delete</b></th>
            </tr>
            <asp:Repeater runat="server" ID="StudentDetails" ><%--OnItemDataBound="studentRepeater_ItemDataBound">--%>
                <ItemTemplate>
                    <tr>
                        <td>
                            <b>*</b>
                        </td>
                        <td>
                            <%#Eval("StudentName") %>
                        </td>
                        <td>
                            <%#Eval("Course") %>
                        </td>
                        <td>
                            <%#Eval("Gender") %>
                        </td>
                        <td>
                            <%#Eval("Age") %>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="Edit" ID="btnEdit" OnClick="EditDetails" CommandArgument='<%# Eval("Id") %>'/>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="Delete" ID="btnDelete" OnClick="DeleteDetails" CommandArgument='<%# Eval("Id") %>'/>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <asp:Button ID="GoBack" Text="GoBack" OnClick="Back" runat="server"/>
    </form>
</body>
</html>
