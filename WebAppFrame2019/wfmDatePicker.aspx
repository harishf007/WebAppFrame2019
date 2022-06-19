<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmDatePicker.aspx.cs" Inherits="WebAppFrame2019.wfmDatePicker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap-5.1.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="jquery-ui-1.13.1/jquery-ui.css" rel="stylesheet" />
    <link href="jquery-ui-1.13.1/jquery-ui.structure.css" rel="stylesheet" />
    <link href="jquery-ui-1.13.1/jquery-ui.theme.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <script src="bootstrap-5.1.3-dist/jquery-3.6.0.min.js"></script>
    <script src="bootstrap-5.1.3-dist/popper.min.js"></script>
    <script src="jquery-ui-1.13.1/jquery-ui.js"></script>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDatePicker" ClientIDMode="Static" Placeholder="Click to select date" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetDate" runat="server" Text="Get Date" OnClick="btnGetDate_Click" />
            <asp:Label ID="lblWarning" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>The value returned by DatePicker :
            <asp:Label ID="lblDatePickValue" runat="server" Text=""></asp:Label></p>
        </div>
        <div>
            <p>The value modified for Oracle Date column :
            <asp:Label ID="lblDateForOracle" runat="server" Text=""></asp:Label></p>
        </div>
    </form>
    <script>
        $(function () {
            $("[id$=txtDatePicker]").datepicker({
                numberOfMonths: 1,
                changeYear: true,
                changeMonth: true,
                showOtherMonths: true,
                showAnim: "slide",
            })
        })
    </script>
</body>
</html>
