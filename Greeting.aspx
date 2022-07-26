<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greeting.aspx.cs" Inherits="StateManagement.Greeting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet3.css" />
    <title>LogOut</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container1">
            <h1 id="welcomeMsg" runat="server"></h1>
            <asp:button id="button2" runat="server" onclick="LogOut" text="LogOut" />
        </div>
    </form>
</body>
</html>
