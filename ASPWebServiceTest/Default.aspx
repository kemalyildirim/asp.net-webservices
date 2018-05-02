<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html runat="server" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body runat="server">
    <form id="form1" runat="server">
        <p>
        <asp:Label runat="server" ID="UsernameLabel" Text="Username"></asp:Label>
        <asp:TextBox  runat="server" ID="UsernameTextBox"></asp:TextBox>
        </p>
        <p>
            <asp:Label  runat="server" ID="PassLabel" Text="Password"></asp:Label>
            <asp:TextBox runat="server" ID="PassTextBox"></asp:TextBox>
        </p>
        <p>
            <asp:Button runat="server" ID="LoginButton" Text="Login" OnClick="Login_Click" />
        </p>
    </form>

</body>
</html>
