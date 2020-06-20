<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
CodeBehind="ReverseSearchStart.aspx.cs"
Inherits="Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp.ReverseSearchStart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-fluid asposetools pb5">
                <div class="container">
                    <div class="row">

                        <div class="col-md-12 pt-5 pb-5">
                            <asp:HiddenField ID="hdnSearchId" runat="server"/>
                            <asp:HiddenField ID="hdnAsposeProductName" runat="server"/>

                            <h1><%= this.Resources["ReverseSearchStartPageTitle"] %></h1>
                            <h4><%= this.Resources["ReverseSearchStartSubPageTitle"] %></h4>

                            <div class="form">
                                <div class="uploadfile">

                                    <div class="filedropdown">
                                        <div class="filedrop">
                                            <label class="dz-message needsclick"><% = this.Resources["DropOrUploadFile"] %></label>
                                            <h4 style="color:black"><% = this.Resources["DontSaveImagesDisclaimer"] %></h4>
                                            <input type="file" name="FileUpload1" id="FileUpload1" runat="server" class="uploadfileinput"/>

                                            <asp:RequiredFieldValidator ID="rfvFile" SetFocusOnError="true" ValidationGroup="uploadFile" runat="server"
                                                                        ErrorMessage="*" ControlToValidate="FileUpload1" Display="Dynamic"
                                                                        ForeColor="Red" />
                                            <asp:RegularExpressionValidator ValidationGroup="uploadFile" ID="ValidateFileType"
                                                                            ControlToValidate="FileUpload1" runat="server" ForeColor="Red"
                                                                            Display="Dynamic"/>

                                            <asp:HiddenField ID="hdnAllowedFileTypes" runat="server" Value=""/>
                                            <asp:HiddenField ID="hdnDownloadFileName" runat="server" Value=""/>
                                            <asp:HiddenField ID="hdnFileName" ClientIDMode="Static" runat="server" Value=""/>
                                            <asp:HiddenField ID="hdnDownloadFileURL" runat="server" Value=""/>

                                            <div class="fileupload">
                                                <span class="filename">
                                                    <a onclick="removefile()">
                                                        <label for="uploadfileinput" class="custom-file-upload"/>
                                                        <i class="fa fa-times"></i>
                                                    </a>
                                                </span>
                                            </div>
                                        </div>

                                        <div class="watermark" id="dvInputIdOrSite" runat="server">
                                            <textarea id="txtInputIdOrSite" runat="server"  class="form-control" aria-describedby="basic-addon2"/>
                                            <br />
                                            <asp:RequiredFieldValidator ID="rfvvInputIdOrSite" EnableClientScript="true" runat="server"
                                                                        ControlToValidate="txtInputIdOrSite" Display="Dynamic"
                                                                        ValidationGroup="uploadFile"/>
                                            <br/>
                                        </div>
                                    </div>

                                    <div>
                                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                            <ProgressTemplate>
                                                <div style="padding-top: 20px;">
                                                    <img height="59" width="59" alt="Please wait..." src="~/img/loader.gif" runat="server"/>
                                                </div>
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </div>

                                    <p runat="server" id="pMessage" visible="false" style="color: red; margin: 50px auto 30px; position: relative; width: 65%;"/>
                                    
                                    <div class="convertbtn">
                                        <asp:Button class="btn btn-success btn-lg" id="btnStart"  runat="server" onclick="btnStart_Click" ></asp:Button>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnStart"/>
        </Triggers>
    </asp:UpdatePanel>

    <div class="col-md-12 pt-5 app-product-section  tl">
        <div class="container">
            <div class="col-md-3 pull-right">
                <img runat="server" id="imgProductImage"/>
            </div>

            <div class="col-md-9 pull-left">
                <h3 runat="server" id="hAsposeProductTitle"/>
                <ul>
                    <li runat="server" id="liProductFeature3"/>
                </ul>
            </div>

        </div>
    </div>

 






     <!-- HowTo Section -->
    <div class="col-md-12 tl bg-darkgray howtolist" style="padding-bottom: 0px;" id="dvHowToSection" visible="true" runat="server">
        <div class="container tl dflex">

            <div class="col-md-4 howtosectiongfx">
                <img src="https://products.aspose.app/img/howto.png">
            </div>
            <div class="howtosection col-md-8">
                <div>
                    <h4><i class="fa fa-question-circle"></i> <b><%= Resources["HowtoReverseSearchTitle"] %></b></h4>
                    <ul>
                        <li><%= Resources["HowtoReverseSearch1"] %></li>
                        <li><%= Resources["HowtoReverseSearch2"] %></li>
                        <li><%= Resources["HowtoReverseSearch3"] %></li>
                        <li><%= Resources["HowtoReverseSearch4"] %></li>
                        <li><%= Resources["HowtoReverseSearch5"] %></li>
                        <li><%= Resources["HowtoReverseSearch6"] %></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <div class="col-md-12 pt-5 app-features-section">
        <div class="container tc pt-5">
            <div class="col-md-4">
                <div class="imgcircle fasteasy">
                    <img src= "~/img/fast-easy.png" runat="server"/>
                                </div>
                                <h4><%= this.Resources["FastEasyReverseSearchHeader"] %></h4>
                <p><%= this.Resources["FastEasyReverseSearchDescription"] %></p>
            </div>

            <div class="col-md-4">
                <div class="imgcircle anywhere">
                    <img src="~/img/anywhere.png" runat="server"/>
                                </div>
                                <h4><%= this.Resources["AnywhereReverseSearchHeader"] %></h4>
                <p><%= this.Resources["Feature2Description"] %>.</p>
            </div>

            <div class="col-md-4">
                <div class="imgcircle quality">
                    <img src="~/img/quality.png" runat="server"/>
                                </div>
                                <h4><%= this.Resources["QualityReverseSearchHeader"] %></h4>
                <p>
                    <%= this.Resources["PoweredBy"] %>
                    <a runat="server" target="_blank" id="aPoweredBy"/>
                    <%= this.Resources["Feature3Description"] %>.
                </p>
            </div>
        </div>
    </div>
    
    <script type="text/javascript">
        window.onsubmit = function() {
            if (Page_IsValid) {

                var updateProgress = $find("<%= this.UpdateProgress1.ClientID %>");
                if (updateProgress) {
                    window.setTimeout(function() {
                            updateProgress.set_visible(true);
                            document.getElementById('<%= this.pMessage.ClientID %>').style.display = 'none';
                        },
                        100);
                }
            }
        }
    </script>
    <script type="text/javascript">

        $('.fileupload').hide();
     

        $('.uploadfileinput').change(function() {
            var file = $('.uploadfileinput')[0].files[0].name;
            var ext = file.split('.').pop();

            if (document.getElementById('<%= this.hdnAllowedFileTypes.ClientID %>').value.includes(ext.toUpperCase())) {

                document.getElementById('hdnFileName').value = file;
                $('.filename label').text(file);
                $('.fileupload').show();
            }
        });
       

        function removefile() {

            $('.fileupload').hide();
            $('.uploadfileinput').show();
        }

        function PerformAnotherOperation() {

            $('.fileupload').hide();
            $('.filedropdown').show();
            $('.fileformatsico').show();
        }       

    </script>

    

</asp:Content>