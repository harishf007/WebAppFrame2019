<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmSimpleDataGrid.aspx.cs" Inherits="WebAppFrame2019.wfmSimpleDataGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInText" ClientIDMode="Static" runat="server"></asp:TextBox>
            <asp:Button ID="btnAddData" runat="server" Text="Add Data" OnClick="btnAddData_Click" />
            <asp:Button ID="btnClearTable" runat="server" Text="Clear DB Table" OnClick="btnClearTable_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
        <div>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
