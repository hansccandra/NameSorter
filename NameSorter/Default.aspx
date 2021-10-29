<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NameSorter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <br />
            <asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click" />
        </div>
    </div>
</asp:Content>
