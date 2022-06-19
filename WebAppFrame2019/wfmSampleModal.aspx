<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmSampleModal.aspx.cs" Inherits="WebAppFrame2019.wfmSampleModal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap3/css/bootstrap.css" rel="stylesheet" />
    
    <title></title>
</head>
<body>
    <script src="bootstrap3/js/bootstrap.js"></script>
    <script src="bootstrap3/js/jquery-3.6.0.min.js"></script>
    <script src="bootstrap3/js/popper.min.js"></script>
    <form id="form1" runat="server">
        <div>
            <button type="button" data-toggle="modal" data-target="#modalInitiateProcess">Process</button>
            <asp:Button ID="Button1" runat="server" Text="Process" OnClick="Button1_Click" style="display:none"/>
        </div>
    </form>
    <!-- The Process Initiation Modal -->
    <div class="modal fade" data-keyboard="false" data-backdrop="static" id="modalInitiateProcess" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">

                <!--Modal Header-->
                <div class="modal-header">
                    <h5 class="modal-title" id="myModalLablel">Process</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">x</span></button>
                </div>
                <!--Modal Body-->
                <div class="modal-body">
                    <h5>Do you want to run the Process ?</h5>
                </div>
                <!--Modal Footer-->
                <div class="modal-footer">
                    <button type="button" data-dismiss="modal" onclick="fncProcess()">Yes</button>
                    <button type="button" data-dismiss="modal">No</button>
                </div>
            </div>
        </div>
    </div>
    <!-- The Processing Modal -->
    <div class="modal fade" data-keyboard="false" data-backdrop="static" id="modalProcessing" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <!--Modal Header-->
                <div class="modal-header">
                    <h4 class="modal-title" id="myModalLabel2">Process</h4>
                </div>
                <!--Modal Body-->
                <div class="modal-body">
                    <h5>Processing Data...</h5>
                </div>
                <!--Modal Footer-->
                <div class="modal-footer">

                </div>
            </div>
        </div>

    </div>
    <script>
        function fncProcess() {
            openModal();
            document.getElementById('<%= Button1.ClientID %>').click();
        }
        function openModal() {
            $('#modalProcessing').modal('show');
        }
        function closeModal() {
            $('#modalProcessing').modal('hide');
        }
    </script>
</body>
</html>
