<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddEvent.aspx.cs" Inherits="AddEvent" %>

<!DOCTYPE html>

<html runat="server" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body runat="server">
    <form id="form1" runat="server">
    <asp:Label ID="NameLabel" runat="server" Text="Event name"></asp:Label>
        <asp:TextBox ID="ENameTextBox" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="DateLabel" runat="server" Text="Event date"></asp:Label>
            <asp:TextBox ID="EDateTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="AccLabel" runat="server" Text="Event accomadation"></asp:Label>
        <asp:TextBox ID="EAccTextBox" runat="server"></asp:TextBox>
            </div>
        <div>
            <asp:Label ID="TimeLabel" runat="server" Text="Event time"></asp:Label>
            <asp:TextBox ID="ETimeTextBox" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
    </form>
</body>
</html>
