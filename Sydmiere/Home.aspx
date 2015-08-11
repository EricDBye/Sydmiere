<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Sydmiere.Home" MasterPageFile="Sydmiere.Master" %>

<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="Body">
        <asp:Calendar runat="server" ID="calNotes" OnDayRender="myDayRenderMethod">
        </asp:Calendar>
    </div>
    <div class="Body">
        <asp:LinkButton runat="server" ID="lnkCreateNotes" OnClick="lnkCreateNotes_OnClick">Create Note</asp:LinkButton>
    </div>
</asp:Content>
