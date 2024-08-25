<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emailloginotp.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbluname" runat="server" style="z-index: 1; left: 664px; top: 184px; position: absolute" Text="User Name:"></asp:Label>
            <asp:Label ID="lblpwd" runat="server" style="z-index: 1; left: 678px; top: 241px; position: absolute" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtuname" runat="server" style="z-index: 1; left: 781px; top: 181px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtpwd" runat="server" style="z-index: 1; left: 785px; top: 240px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="z-index: 1; left: 825px; top: 290px; position: absolute" Text="Log-In" />
            <asp:Label ID="lbldisplay" runat="server" style="z-index: 1; left: 574px; top: 324px; position: absolute"></asp:Label>
        </div>
    </form>
</body>
</html>
