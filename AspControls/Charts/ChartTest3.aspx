<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartTest3.aspx.cs" Inherits="AspControls.ChartTest3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register TagPrefix="mcc" Namespace="jsChartLib" Assembly="jsChartLib" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 750px; height: 750px; background-color: magenta">
         <mcc:jsChart runat="server" ID="jsChart1" Height="400px" Width="600px" BackColor="Red"/>
        <br/>
         <mcc:jsChart runat="server" ID="jsChart2" Height="400px" Width="600px" BackColor="Green"/>
            <br/>
        <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />
         <br />
         <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
