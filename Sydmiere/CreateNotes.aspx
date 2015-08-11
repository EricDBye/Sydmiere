<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNotes.aspx.cs" Inherits="Sydmiere.CreateNotes" MasterPageFile="Sydmiere.Master" %>
<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="body">
        <asp:Label runat="server" ID="lblNotes" CssClass="TopElements">Note Text</asp:Label>
        <asp:Button runat="server" Text="Save Note" ID="btnSaveNote" OnClick="btnSaveNote_OnClick" CssClass="TopElements"/>
    </div>
    <div class="body">
        <asp:TextBox runat="server" CssClass="EnterNote" ID="txtNotes"></asp:TextBox>
    </div>
</asp:Content>
