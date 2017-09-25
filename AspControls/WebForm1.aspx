<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspControls.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<%@ Register TagPrefix="mcc" Namespace="ViControlsLib" Assembly="ViControlsLib" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        <mcc:PanelSplitter ID="ConfirmExtender1" runat="server">
            <ContentTemplate1>
                <asp:Label ID="Label1" runat="server" Text="Label12321312"></asp:Label>
            </ContentTemplate1>
              <ContentTemplate2>
                <asp:Label ID="Label2" runat="server" Text="rwq124wqr"></asp:Label>
            </ContentTemplate2>
        </mcc:PanelSplitter>


    </div>
    </form>
</body>
</html>
