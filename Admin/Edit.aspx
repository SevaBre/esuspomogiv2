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
    <asp:Button ID="Button1" runat="server" Text="Panel" OnClick="Button1_Click"/>
    <br />
    <asp:Panel ID="Panel1" runat="server">
        
        <br />
        Naziv<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        Jedinica mere<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

        Cena<asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox><br />

        Kolicina<asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox><br />

        Slika<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="INSERT" OnClick="Button2_Click" />
        <br /><br /><br />





        ID<asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox><br />

        Naziv<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox> <asp:Button ID="Button5" runat="server" Text="Ucitaj ID" OnClick="Button5_Click" /><br />

        Jedinica mere<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />

        Cena<asp:TextBox ID="TextBox9" runat="server" TextMode="Number"></asp:TextBox><br />

        Kolicina<asp:TextBox ID="TextBox10" runat="server" TextMode="Number"></asp:TextBox><br />

        Slika<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click"/>
        <br /><br /><br />





        ID<asp:TextBox ID="TextBox12" runat="server" TextMode="Number"></asp:TextBox ><br />

        <br />
        <asp:Label ID="Del" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />

    </asp:Panel>




</asp:Content>
