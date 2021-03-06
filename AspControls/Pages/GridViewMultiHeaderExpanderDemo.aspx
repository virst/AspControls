﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewMultiHeaderExpanderDemo.aspx.cs" Inherits="AspControls.Pages.GridViewMultiHeaderExpanderDemo" %>
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
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nm1" HeaderText="NMS|nm1" SortExpression="nm1" />
                <asp:BoundField DataField="nm2" HeaderText="NMS|nm2" SortExpression="nm2" />
                <asp:BoundField DataField="val" HeaderText="val" SortExpression="val" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Table2]"></asp:SqlDataSource>

    
        <br />
        <uc1:FixedHeaderGridExtender ID="GridViewMultiHeaderExpander1" GridViewID="GridView1"
            runat="server" />

    
        <br />

    
    </div>
    </form>
</body>
</html>
