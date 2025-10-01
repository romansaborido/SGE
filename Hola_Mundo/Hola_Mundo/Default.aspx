<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hola_Mundo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <p>
            <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
    </main>

</asp:Content>
