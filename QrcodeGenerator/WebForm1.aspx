﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QrcodeGenerator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtcode" runat="server"></asp:TextBox>
            <asp:Button ID="btngenerate" runat="server" Text="Qrcode" OnClick="btngenerate_Click" />
            <br /><br />
            <asp:PlaceHolder ID="Placeholder" runat ="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
