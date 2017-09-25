<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridRowClickExtenderDemo.aspx.cs" Inherits="AspControls.Pages.GridRowClickExtenderDemo" EnableEventValidation="false"%>
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
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="id" DataSourceID="SqlDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nm1" HeaderText="nm1" SortExpression="nm1" />
                <asp:BoundField DataField="nm2" HeaderText="nm2" SortExpression="nm2" />
                <asp:BoundField DataField="val" HeaderText="val" SortExpression="val" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Table2]"></asp:SqlDataSource>
        <br />
        <uc1:GridRowClickExtender ID="GridRowClickExtender1" runat="server" TargetControlId="GridView1" ToolTip="Нажми и выбери" />
    </div>
    </form>
</body>
</html>
