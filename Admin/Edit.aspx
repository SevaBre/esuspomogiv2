<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="esuspomogiv2.Admin.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1 class="chiller">SCARY ADMIN TOOLS</h1>
    <asp:Label ID="ErrorLabel" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    <br />
    
        <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="false" Width="60%">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID"></asp:BoundField>
        <asp:ImageField DataImageUrlField="Slika" ControlStyle-Width="50px" ControlStyle-Height="50px" HeaderText="Slika">
            <ControlStyle Height="75px" Width="75px"></ControlStyle>
        </asp:ImageField>
        <asp:BoundField DataField="Slika" HeaderText="Slika"></asp:BoundField>
        <asp:BoundField DataField="Naziv" HeaderText="Naziv proizvoda"></asp:BoundField>
        <asp:BoundField DataField="JedinicaMere" HeaderText="Jedinica mere"></asp:BoundField>
        <asp:BoundField DataField="Cena" HeaderText="Cena [RSD]"></asp:BoundField>
        <asp:BoundField DataField="Kolicina" HeaderText="Kolicina na stanju"></asp:BoundField>
    </Columns>
</asp:GridView>
    <br />

    <asp:Panel ID="Panel1" runat="server">

        <h2>Admin mora da zna sta radi, nije dzabe dobio admin privilegije</h2>
        


        ID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>(int, koristi se za EDIT i DELETE)<br />
        NAZIV<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>(string, koristi se za INSERT i UPDATE)<br />
        JEDINICA MERA<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>(string, koristi se za INSERT i UPDATE)<br />
        KOLICINA<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>(int, koristi se za INSERT i UPDATE)<br />
        CENA<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>(float,decimale se odvajaju sa ',' , koristi se za INSERT i UPDATE)<br />
        SLIKA<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> (string, samo naziv ex: kebab.jpg , koristi se za INSERT i UPDATE)<br />

        <br /><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Clear" />
    </asp:Panel>


    <br /><br /><br /><br /><br /><br /><br /><br />

</asp:Content>
