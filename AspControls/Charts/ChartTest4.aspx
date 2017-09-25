<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartTest4.aspx.cs" Inherits="AspControls.Charts.ChartTest4" %>
<%@ Register TagPrefix="mcc" Namespace="jsChartLib" Assembly="jsChartLib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <mcc:jsChart runat="server" ID="jsChart1" Height="400px" Width="600px" BackColor="Red"/>
    </div>
    </form>
</body>
</html>
