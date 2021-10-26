<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WepAppTwoTier_SP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>ID</td>
                    <td><asp:TextBox ID="id" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salary</td>
                    <td><asp:TextBox ID="Salary" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
