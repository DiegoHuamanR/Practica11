<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Esperiencia_03_B._Default" %>

<form id="form1" runat="server"> 
    <asp:Label ID="Label1" runat="server" Text="Select Brand Preferences"></asp:Label> 
    <br /> 
    <br /> 
    <asp:CheckBox ID="apple" runat="server" Text="Apple" /> 
    <br /> 
    <asp:CheckBox ID="dell" runat="server" Text="Dell" /> 
    <br /> 
    <asp:CheckBox ID="lenevo" runat="server" Text="Lenevo" /> 
    <br /> 
    <asp:CheckBox ID="acer" runat="server" Text="Acer" /> 
    <br /> 
    <asp:CheckBox ID="sony" runat="server" Text="Sony" /> 
    <br /> 
    <asp:CheckBox ID="wipro" runat="server" Text="Wipro" /> 
    <br /> 
    <br /> <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    <p> 
        <asp:Label ID="Label2" runat="server"></asp:Label> 

    </p> 

</form>
