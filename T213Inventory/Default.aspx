﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%-- Add content controls here --%>
<asp:Content ID="content1" ContentPlaceHolderID="bodyContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

</asp:Content>