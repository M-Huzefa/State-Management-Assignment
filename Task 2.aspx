<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task 2.aspx.cs" Inherits="StateManagement.Task_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--User Name:-<asp:textbox id="TextBox1" runat="server" ></asp:textbox>  <br />  
        <asp:HiddenField ID="Hiddenfield1" runat="server" />
        Password  :-<asp:textbox id="TextBox2" runat="server" ></asp:textbox>  <br />
        <asp:HiddenField ID="Hiddenfield2" runat="server" />--%>
        <input id="Textbox3" runat="server" text="text"/>       
        <input id="Textbox4" runat="server" />    
        <button>Html button</button>
        <asp:button id="Button1" runat="server" onclick="Button1_Click" text="Submit" />  
        <asp:button id="Button2" runat="server" onclick="Button2_Click" text="Restore with view state" />
        <%--<asp:button id="Button3" runat="server" onclick="Button3_Click" text="Restore with hidden fields" />--%>
    </form>
</body>
</html>
