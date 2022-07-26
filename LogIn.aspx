<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="StateManagement.Task3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet3.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <asp:label id="label1" runat="server">UserName:-</asp:label>
            <asp:textbox id="textBox1" runat="server" ></asp:textbox>

            <asp:label id="label2" runat="server">Password:-</asp:label>
            <asp:textbox id="textBox2" runat="server" ></asp:textbox>

            <asp:button id="button1" runat="server" OnClientClick="javascript: return validation()" onclick="LogIn" text="LogIn" />
        </div>
    </form>

    <script>

        //Validate the entries in textboxes

        function validation() {
            if (document.getElementById("textBox1").value != "polar") {
                alert("UserName is not valid")
                return false;
            }
            if (document.getElementById("textBox2").value != "vezli") {
                alert("Password is not correct")
                return false
            }
            return true;
        }
    </script>
</body>
</html>
