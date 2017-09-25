<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FixedHeaderGridExpanderDemo.aspx.cs" Inherits="AspControls.Pages.FixedHeaderGridExpanderDemo" %>
<%@ Register TagPrefix="uc1" Namespace="ViControlsLib" Assembly="ViControlsLib" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../JS/jquery-1.11.3.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"  EnableScriptGlobalization="True">
    </asp:ScriptManager>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="id" DataSourceID="SqlDataSource1" BorderColor="Black" BorderStyle="Solid" >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nm" HeaderText="nm" SortExpression="nm" />
                <asp:BoundField DataField="val1" HeaderText="val1" SortExpression="val1" />
                <asp:BoundField DataField="val2" HeaderText="val2" SortExpression="val2" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Table1]"></asp:SqlDataSource>


  
        <br />
        <uc1:FixedHeaderGridExtender ID="FixedHeaderGridExpander1" runat="server" TargetControlID="GridView1" />


  
    </div>
    </form>
</body>
</html>
