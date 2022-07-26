<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task1.aspx.cs" Inherits="StateManagement.Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="textbox" runat="server"></asp:TextBox>
            <asp:Button ID="button" runat="server" Text="Counter" OnClick="Button" />
        </div>
    </form>
</body>
</html>