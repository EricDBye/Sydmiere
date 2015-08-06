<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Sydmiere.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server">Notes</asp:Label>
        <asp:TextBox runat="server" ID="txtNotes"></asp:TextBox>
        <asp:Button runat ="server" onclick="btnSaveClick" Text="Save Note"/>
    </div>
    </form>
</body>
</html>
