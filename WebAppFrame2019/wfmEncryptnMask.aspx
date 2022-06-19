<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmEncryptnMask.aspx.cs" Inherits="WebAppFrame2019.wfmEncryptnMask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCardNo" ClientIDMode="Static" runat="server" Placeholder="Enter a 16 digit card No."></asp:TextBox>
            <asp:Button ID="btnMask" runat="server" Text="Mask Value" OnClick="btnMask_Click" />
            <asp:Label ID="lblMask" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtPw" ClientIDMode="Static" runat="server" Placeholder="Enter a word to Encrypt."></asp:TextBox>
            <asp:Button ID="btnEncrypt" runat="server" Text="Encrypt" OnClick="btnEncrypt_Click" />
            <asp:Label ID="lblEncrypt" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
