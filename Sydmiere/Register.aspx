<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Sydmiere.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblUsername">Username</asp:Label>
        <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="lblFirstName">First Name</asp:Label>
        <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="lblLastName">Last Name</asp:Label>
        <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="lblPassword">Password</asp:Label>
        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
        <br/>
        <asp:Label runat="server" ID="lblConfirmPassword">Confirm Password</asp:Label>
        <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnRegister" Text="Register" OnClick="btnRegister_OnClick"/>
    </div>
    </form>
</body>
</html>
