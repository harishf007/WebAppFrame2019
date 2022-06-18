<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmCSVFileUpload.aspx.cs" Inherits="WebAppFrame2019.wfmCSVFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click"  />
            <asp:Button ID="btnProcess" runat="server" Text="Process" OnClick="btnProcess_Click" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
