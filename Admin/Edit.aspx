<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="esuspomogiv2.Admin.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1 class="chiller">ADMIN TOOLS SCARY</h1>
    <asp:Label ID="ErrorLabel" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    <br />
    <h6>2 puta select proizvod da bi se selectovalo, ne znam zasto je tako ali tako radi<br /> ako nije selectovano iz liste, ne moze se brisati ni updateovati, ako je selectovano, ne moze se insertovati....<br /> malo baguje</h6>
   
    <asp:Panel ID="Panel1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Naziv"></asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Jedinica Mere"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Kolicina"></asp:Label><br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Cena"></asp:Label><br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Slika"></asp:Label><br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click"/>
        <br /><br />
        <asp:Panel ID="Panel2" runat="server" Visible="false">
            <asp:Button ID="Button2" runat="server" Text="Update"  OnClick="Button2_Click"/>
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click"/>
            <asp:Button ID="Button4" runat="server" Text="Clear" OnClick="Button4_Click" />
            <br /><br />
        </asp:Panel>
    </asp:Panel>
        <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="false" Width="60%" AutoGenerateSelectButton="true">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID"></asp:BoundField>
        <asp:ImageField DataImageUrlField="Slika" ControlStyle-Width="50px" ControlStyle-Height="50px" HeaderText="Slika">
            <ControlStyle Height="75px" Width="75px"></ControlStyle>
        </asp:ImageField>
        <asp:BoundField DataField="Naziv" HeaderText="Naziv proizvoda"></asp:BoundField>
        <asp:BoundField DataField="JedinicaMere" HeaderText="Jedinica mere"></asp:BoundField>
        <asp:BoundField DataField="Cena" HeaderText="Cena [RSD]"></asp:BoundField>
        <asp:BoundField DataField="Kolicina" HeaderText="Kolicina na stanju"></asp:BoundField>
        <asp:BoundField DataField="Cena" HeaderText="Cena"></asp:BoundField>
    </Columns>
</asp:GridView>


</asp:Content>
