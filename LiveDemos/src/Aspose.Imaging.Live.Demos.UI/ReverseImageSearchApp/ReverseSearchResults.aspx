<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReverseSearchResults.aspx.cs" Inherits=" Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp.ReverseSearchResults" %>
<%@ Import Namespace="Aspose.Imaging.Live.Demos.UI.Config" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="container-fluid asposetools pb5">
            <div class="container">
                <div class="row">

                    <div class="col-md-12 pt-5 pb-5">
                        <asp:HiddenField ID="hdnSearchId" runat="server"/>
                        <asp:HiddenField ID="hdnAsposeProductName" runat="server"/>
                        <asp:HiddenField ID="hdnSearchStatus" runat="server"/>

                        <h1><%= this.Resources["ReverseSearchStartPageTitle"] %></h1>

                        <asp:PlaceHolder ID="IndexingPlaceHolder" runat="server">

                            <h4><%= this.Resources["ReverseSearchProcessingImages"] %></h4>
                            <h4><%= this.ViewState["site"] %></h4>
                            <h4><%= this.Resources["ReverseSearchInProgress"] %></h4>
                            <br/>
                            <h4><%= this.Resources["ReverseSearchSaveId"] %></h4>
                            <h4><%= this.ViewState["searchId"] %></h4>
                            <h4><%= this.Resources["ReverseSearchUseId"] %></h4>
                            <br/>
                            
                             
                            <div style="padding-top: 20px;">
                                <img height="59" width="59" alt="Please wait..." src="~/img/loader.gif" runat="server"/>
                            </div>
                            
                            <h4 runat="server" ID="IndexingStatus"></h4>

                           

                        </asp:PlaceHolder>
                        
                          <asp:PlaceHolder ID="SearchingPlaceHolder" runat="server">

                            <h4><%= this.Resources["ReverseSearchSearchingImages"] %></h4>
                            <h4><%= this.ViewState["site"] %></h4>
                            <h4><%= this.Resources["ReverseSearchInProgress"] %></h4>                           
                            
                             
                            <div style="padding-top: 20px;">
                                <img height="59" width="59" alt="Please wait..." src="~/img/loader.gif" runat="server" />
                            </div>
                            
                              <h4 runat="server" ID="SearchingStatus"></h4>

                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="ResultsPlaceHolder" runat="server" Visible="false">
                            <div class="imagelist">

                                <div class="row">
                                    <div class="column">
                                        <asp:Image ID="imgSearchImage" runat="server" width="128px" height="128px"/>
                                    </div>
                                    <div class="column">
                                        <h3 id="hResultsCount" style="color: black" runat="server"/>
                                        <h5 id="hTotalImagesCount" runat="server"/> 
                                        <h5 id="hSiteName" runat="server"/> 
                                    </div>
                                </div>

                                <hr style="border: 0; border-top: 2px solid lightgray; height: 2px;"/>

                                <div id="dvGrid" style="height: 270px; overflow-x: auto;">

                                    <ContentTemplate>

                                        <asp:ListView ID="listview1" runat="server" OnPagePropertiesChanging="ListView1_PagePropertiesChanging">
                                            <ItemTemplate>
                                                <td>
                                                    <Image src="<%#this.Eval("Image") %>" style="margin: 30px"
                                                            width="128px" height="128px"/>
                                                    <h5 style="text-align:left">
                                                        <%= this.Resources["ReverseSearchFileName"] %> 
                                                        <br>
                                                        <a style="color: black; margin-right:15px" 
                                                           href="<%#this.Eval("Url") %>"><%#this.Eval("ImageName") %></a>
                                                    </h5>
                                                    
                                                </td>
                                            </ItemTemplate>
                                            <LayoutTemplate>
                                                <table style="display: inline-block;">
                                                    <tr>
                                                        <asp:PlaceHolder ID="itemPlaceholder" runat="server"/>
                                                    </tr>
                                                </table>
                                            </LayoutTemplate>
                                            <EmptyDataTemplate>
                                                <%= this.Resources["ReverseSearchImagesNotFound"] %>
                                            </EmptyDataTemplate>
                                        </asp:ListView>

                                    </ContentTemplate> 
                                    <br/>
                               
                                    <asp:DataPager runat="server" ID="ContactsDataPager" PagedControlID="listview1" PageSize="3">
                                            <Fields>
                                                <asp:NumericPagerField ButtonType="Link" 
                                                                       NumericButtonCssClass="numeric_button"
                                                                       CurrentPageLabelCssClass="current_page"
                                                                       NextPreviousButtonCssClass="next_button"/>
                                            </Fields>
                                    </asp:DataPager>
                                    
                                    <style type="text/css">
                                        .current_page{color:whitesmoke;}
                                         .numeric_button{color:black;}
                                        .next_button{color:whitesmoke;}
                                    </style>

                                </div>
                            </div>
                            
                            <div class="convertbtn">
                                <br />
                                <asp:Button class="btn btn-success btn-lg" id="btnNewSearch" runat="server" onclick="btnNewSearch_Click" />
                            </div>
                        </asp:PlaceHolder>
                    </div>
                </div>
            </div>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>





<div class="col-md-12 pt-5 app-product-section  tl">
    <div class="container">
        <div class="col-md-3 pull-right">
            <img runat="server" id="imgProductImage"/>
        </div>

        <div class="col-md-9 pull-left">
            <h3 runat="server" id="hAsposeProductTitle"/>
        </div>
    </div>
</div>

    <div class="col-md-12 pt-5 app-features-section">
        <div class="container tc pt-5">
            <div class="col-md-4">
                <div class="imgcircle fasteasy">
                    <img src="~/img/fast-easy.png" runat="server"/>
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

    function pageLoad() {
        if (parseInt('<%= hdnSearchStatus.Value %>') != 2)
            UpdateState();
    }

     function UpdateState() {
         var url = '<%=Aspose.Imaging.Live.Demos.UI.Config.Configuration.AsposeReverseSearchApiURL %>'+"/reverseSearch/" + '<%= hdnSearchId.Value %>';
         jQuery.ajax({
             dataType: "json",
             type: 'GET',
             url: url,
             async: false,
             crossDomain: true,
             context: document.body,
             processData: true,
             success: function (data) {
                 var statusId = "";
                 var stateValue = "";
                 var isReady = false;
                 var waitTimeout = 0;
                 var state = data.State;

                 var lastState = parseInt('<%= hdnSearchStatus.Value %>');
                 document.getElementById('<%= hdnSearchStatus.ClientID %>').value = state;
                 if (lastState > -1 && lastState != state) {
                     window.location.reload();
                 }

                 if (state == 0) {
                     // indexing
                     stateValue += "State: indexing; ";
                     waitTimeout = 5000;
                     statusId = '<%= this.IndexingStatus.ClientID %>';
                 } else if (state == 1) {
                     //searching
                     stateValue += "State: searching; ";
                     waitTimeout = 1000;
                     statusId = '<%= this.SearchingStatus.ClientID %>';
                 } else {
                     // ready
                     isReady = true;
                     stateValue = "State: ready";
                 }
  // alert(JSON.stringify(data));

                 if (!isReady) {

                     if (data.Progress != null) {
                         var timeStr = data.Progress.Duration.split('.')[0];
                         stateValue += "Duration: " + timeStr + "; ";

                         if (data.Progress.TotalImagesCount != null && data.Progress.TotalImagesCount > 0) {
                             stateValue += "Progress: " +
                                 Math.round(data.Progress.ProcessedImagesCount / data.Progress.TotalImagesCount * 100) +
                                 "%;";
                         }

                         if (state == 0) {
                             var timeParts = timeStr.split(':');
                             var seconds = (+timeParts[0]) * 60 * 60 + (+timeParts[1]) * 60 + (+timeParts[2]);
                             if (seconds > 0) {
                                 stateValue += " Rate: " +
                                     Math.round(data.Progress.ProcessedImagesCount / seconds * 100) / 100 +
                                     " images/sec";
                             }
                         }
                     }

                     document.getElementById(statusId).innerHTML = stateValue;

                     setTimeout("UpdateState()", waitTimeout);
                 }
             },
             error: function (errorThrown) {
                 var element = document.getElementById('<%= this.IndexingStatus.ClientID %>');
                 if (element != null)
                     element.innerHTML = errorThrown;
                 else
                     element = document.getElementById('<%= this.SearchingStatus.ClientID %>');
                 if (element != null)
                     element.innerHTML = errorThrown;
             }
         });
    };

</script>



</asp:Content>