<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="StateManagement.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <asp:label id="label1" runat="server">UserName:-</asp:label>
            <asp:textbox id="textBox1" runat="server" ></asp:textbox>  
            <asp:HiddenField ID="hiddenField1" runat="server" />
            
            <asp:label id="label2" runat="server">Password:-</asp:label>
            <asp:textbox id="textBox2" runat="server" ></asp:textbox>
            <asp:HiddenField ID="hiddenField2" runat="server" />
            
            <asp:button id="button1" runat="server" OnClientClick="javascript: return hdnFields()" onclick="Submit" text="Submit" />  
            <asp:button id="button2" runat="server" onclick="viewState" text="Restore with view state" />
            <asp:button id="button3" runat="server" onclick="hiddenFields" text="Restore with hidden fields" />
        </div>
    </form>

    <script>
        function hdnFields() {
            document.getElementById("hiddenField1").value = document.getElementById("textBox1").value;
            document.getElementById("hiddenField2").value = document.getElementById("textBox2").value;
            return true;
        }
    </script>
</body>
</html>
