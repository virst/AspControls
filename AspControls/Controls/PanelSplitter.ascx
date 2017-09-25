<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PanelSplitter.ascx.cs" Inherits="AspControls.Controls.PanelSplitter" %>

<script type="text/javascript">
    $(document).ready(function () {
        $('#<%=MySplitter.ClientID%>').jqxSplitter({ width: '<%=MySplitter.Width.ToString()%>', height: '<%=MySplitter.Height.ToString()%>',
            panels: [{ size: '<%=Size_P1.ToString()%>' },
                { size: '<%=Size_P2.ToString()%>'}]
        });
    });
</script>


<asp:Panel ID="MySplitter" runat="server" Width="400px" Height="400px"></asp:Panel>