<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CaptaSoma.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contato</h3>

    <asp:TextBox runat="server" ID="txtNome" placeholder="Digite o nome" />

    <br />

    <asp:TextBox runat="server" ID="txtEmail" placeholder="Digite o e-mail" />

    <br />

    <asp:TextBox runat="server" ID="txtDescricao" placeholder="Digite uma descrição" />

    <br />
    <asp:Label Text="" ID="lblSoma" runat="server" /> <asp:TextBox runat="server" ID="txtSoma" />

    <asp:Button Text="Enviar" ID="cmdEnviar" runat="server" OnClick="cmdEnviar_Click"
        />
    <asp:Label Text="" ID="lblResultado" ForeColor="Red" runat="server" />

</asp:Content>
