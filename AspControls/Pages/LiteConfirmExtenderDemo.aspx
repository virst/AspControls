<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LiteConfirmExtenderDemo.aspx.cs" Inherits="AspControls.Pages.LiteConfirmExtenderDemo" %>
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
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <br />
        <uc1:ConfirmExtender ID="LiteConfirmExtender1" runat="server" TargetControlID="Button1" MessageText="Уверен ?" />
    </div>
    </form>
</body>
</html>
