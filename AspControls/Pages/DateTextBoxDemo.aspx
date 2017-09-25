<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateTextBoxDemo.aspx.cs" Inherits="AspControls.Pages.DateTextBoxDemo" %>
<%@ Register TagPrefix="uc1" Namespace="ViControlsLib" Assembly="ViControlsLib" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"  EnableScriptGlobalization="True">
    </asp:ScriptManager>
    <div>
    Выбор даты 

        <br />
        <br />
        <uc1:DateTextBox ID="DateTextBox1" runat="server" />
        <br />
        <uc1:DateTimeTextBox ID="DateTimeTextBox1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" onclick="Button1_Click" />
          <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
