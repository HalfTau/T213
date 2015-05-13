<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%-- Add content controls here --%>
<asp:Content ID="content1" ContentPlaceHolderID="bodyContent" Runat="Server">
    
    <asp:ScriptManager ID="scriptmanager1" EnablePartialRendering="true" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="updatepanel1" runat="server">
    <ContentTemplate>
    <asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
    <br /><br /><asp:Button ID="Button1" runat="server" onClick="btnSearch_onClick" Text="Button"></asp:Button>
    <br /><br /><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </ContentTemplate>
    </asp:UpdatePanel>
    
    </asp:Content>