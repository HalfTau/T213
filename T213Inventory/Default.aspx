<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%-- Add content controls here --%>
<asp:Content ID="content1" ContentPlaceHolderID="bodyContent" Runat="Server">
    <asp:ScriptManager ID="scriptmanager1" EnablePartialRendering="true" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
            <asp:TextBox ID="txtInput" runat="server" ontextchanged="TxtInput_TextChanged"></asp:TextBox>

            <br /><br />
            <asp:Button ID="btnSearch" runat="server" onClick="btnSearch_onClick" Text="Search" />
            <asp:Button ID="btnWrite" runat="server" OnClick="btnWrite_onClick" Text="Write" />

            <br /><br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel> 
</asp:Content>