function ConfirmSubmit() {

    var hidepopup = function () {
        $(this).popover('hide');
    }

    if (Page_Validators != undefined && Page_Validators != null) {
        for (var i = 0; i < Page_Validators.length; i++) {
            ValidatorEnable(Page_Validators[i]);
            if (!Page_Validators[i].isvalid) {
                //ttip.set_targetControlID(Page_Validators[i].controltovalidate);
                var id = Page_Validators[i].controltovalidate;
                //alert(id);

                $("#" + id).popover({
                    trigger: 'manual',
                    animate: false,
                    placement: 'right',
                    html: 'true',
                    // title: '<span class="text-info"><strong>title</strong></span>' +
                    //  '<button type="button" id="close" class="close pull-right" onclick="$(&quot;#' + id + '&quot;).popover(&quot;hide&quot;);">&times;</button>',
                    content: Page_Validators[i].errormessage
                })
                .keyup(hidepopup);
                $("#" + id).popover('show');

                return false;
            } else {
                var tt = Page_Validators[i].controltovalidate;
                //alert(id+"  true");
                $("#" + tt).popover('hide');
            }
        }
    }

}