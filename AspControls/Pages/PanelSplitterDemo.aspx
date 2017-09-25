<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelSplitterDemo.aspx.cs" Inherits="AspControls.Pages.PanelSplitterDemo" %>

<%@ Register src="../Controls/PanelSplitter.ascx" tagname="PanelSplitter" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Css/jqx.base.css" rel="stylesheet" type="text/css" />
    <script src="../JS/jquery-1.11.3.js" type="text/javascript"></script>
    <script src="../JS/jqx-all.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"  EnableScriptGlobalization="True">
    </asp:ScriptManager>
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Panel ID="Panel2" runat="server" BackColor="Red" Height="300px" Width="250px">
            123213
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server" BackColor="Green" Height="300px" Width="250px">
                sdqweq
            </asp:Panel>      
            <uc1:PanelSplitter ID="PanelSplitter1" runat="server" innerPanel1 ="Panel2" innerPanel2 ="Panel3" Size_P1="40%" Size_P2="60%"/>
        </asp:Panel>

    </div>
    </form>
</body>
</html>
