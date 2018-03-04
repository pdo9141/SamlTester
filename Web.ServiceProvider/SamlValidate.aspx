<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SamlValidate.aspx.cs" Inherits="Web.ServiceProvider._SamlValidate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Xome</h1>
        <p>SSO from LoanDepot was <asp:Literal runat="server" ID="ltrSSOStatus"></asp:Literal></p>
    </div>
</asp:Content>
