<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DDcascading.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DDD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDD_SelectedIndexChanged" style="z-index: 1; left: 458px; top: 240px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"  style="z-index: 1; left: 460px; top: 307px; position: absolute">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
