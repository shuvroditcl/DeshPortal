// JavaScript Document

// De3velopment Logic For Setting Page Title.
//Add Folder Name First The Add ':' The Add Rest Of The Title


$(document).ready(function () {
    //var vhref = $(location).attr('href');
    //var QStringOriginal = window.location.search.substring(1);
    //var opt = '<%= Request.QueryString["q"]%>';
    //var qrStr = window.location.search;

    //alert(1);
    //var spQrStr = window.location.search.substring(1);
    //var arrQrStr = new Array();
    //var arr = spQrStr.split('&');
    //var s = arr[0].split('=');

    var vTitle = document.title;
    // var arr = vTitle.split(':');
    if (vTitle.indexOf(":") != -1) {
        var arr = vTitle.split(':');
        vTitle = arr[0];
       // alert(vTitle);
    } else {
        vTitle = vTitle;
       // alert(vTitle);
    }
    //alert(vTitle);
 // s[1] = $('#MainContent_pnlId').val();


    //alert(s[1] + "-" + $('#MainContent_pnlId').val());


    //if (vTitle == "Policy") {
    //    //vTitle = "Policy";
    //    $('#MainContent_pnlId').val("1");
    //}
    //else if (s[1] == "2") {
    //    vTitle = "UnderWriting";
    //}
    //else if (s[1] == "3") {
    //    vTitle = "Accounts";
    //}
    //else if (s[1] == "4") {
    //    vTitle = "HR";
    //}
    //else if (s[1] == "5") {
    //    vTitle = "Agency";
    //}

    //var vTitle = $(this).attr('title');
    $('#' + vTitle).show();

    $('#' + vTitle).accordion({
        heightStyle: "Content",
        collapsible: true,
        autoHeight: true
    });

});

$('.btn_custom').click(function () {
  

    var currId = '#' + $(this).attr("id");
    var count = 2;
   
   // $(currId).children('.circle').text(count).show();
});

var icons = {
    header: "ui-icon-circle-arrow-e",
    activeHeader: "ui-icon-circle-arrow-s"
};






