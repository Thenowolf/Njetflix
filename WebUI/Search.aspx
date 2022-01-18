<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebUI.Search" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Název Filmu</p><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <p>Účinkující</p><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <p>Kategorie</p><asp:DropDownList ID="DropDownList1" runat="server">
             <asp:listitem text="Komedie" value="Komedie"></asp:listitem>
             <asp:listitem text="Drama" value="Drama"></asp:listitem>
             <asp:listitem text="Horror" value="Horror"></asp:listitem>
             <asp:listitem text="Sci-fi" value="Sci-fi"></asp:listitem>
             <asp:listitem text="Dokumentární" value="Dokumentární"></asp:listitem>
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Hledat" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
</asp:Content>
