<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="esuspomogiv2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="ErrorLabel" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    <h2 class="trojkacentar">U ponudi</h2>
    <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="false">


        <Columns>
            <asp:ImageField DataImageUrlField="Slika" ControlStyle-Width="50px" ControlStyle-Height="50px" HeaderText="Slika">
                <ControlStyle Height="75px" Width="75px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="Naziv" HeaderText="Naziv proizvoda"></asp:BoundField>
            <asp:BoundField DataField="JedinicaMere" HeaderText="Jedinica mere"></asp:BoundField>
            <asp:BoundField DataField="Cena" HeaderText="Cena [RSD]"></asp:BoundField>
        </Columns>
    </asp:GridView>

</asp:Content>
