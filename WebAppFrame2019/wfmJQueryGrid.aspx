<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmJQueryGrid.aspx.cs" Inherits="WebAppFrame2019.wfmJQueryGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnShowData" runat="server" Text="Show Data" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
