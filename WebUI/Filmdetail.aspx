<%@ Page Title="Filmdetail" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Filmdetail.aspx.cs" Inherits="WebUI.Filmdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div>
                <h1><asp:Label ID ="nazev" runat="server" Text="Label"></asp:Label> </h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/" style="border:solid; height:300px" alt="Ilustrační obrázek"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Popis:</b><br />
                        <asp:Label ID="popis" runat="server" Text="Label"></asp:Label>
                        <br />
                        <span><b>Rok vydání:</b>&nbsp;</span><asp:Label ID="rok" runat="server" Text="Label"></asp:Label>
                        <br />
                        <span><b>Žánr:</b>&nbsp;</span><asp:Label ID="zanr" runat="server" Text="Label"></asp:Label>
                        <br />
                        <span><b>Věkové omezení:</b>&nbsp;</span><asp:Label ID="vek" runat="server" Text="Label"></asp:Label>
                        <br />
                        <span><b>Ucinkujici:</b>&nbsp;</span><asp:Label ID="ucinkujici" runat="server" Text=""></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Vaše hodnocení: <br />
                    <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:listitem text="*" value="1"></asp:listitem>
                            <asp:listitem text="**" value="2"></asp:listitem>
                            <asp:listitem text="***" value="3"></asp:listitem>
                            <asp:listitem text="****" value="4"></asp:listitem>
                            <asp:listitem text="*****" value="5"></asp:listitem>
                    </asp:DropDownList>
                    <br />
                    <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="2"></textarea>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Odeslat" OnClick="Button1_Click" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="upozorneni" runat="server" Text="Label"></asp:Label>
</asp:Content>