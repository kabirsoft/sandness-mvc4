
$(document).ready(function () {

//Menu 


    //info pages

    $('#instillinger span.change_pass_form').click(function () {
        $('#instillinger div.change_pass_form1').slideToggle('slow');
    });
     $('#instillinger span.change_email_form').click(function () {
        $('#instillinger div.change_email_form1').slideToggle('slow');
    });


    $('#infopages span.plus').click(function () {
        $('#infopages div.form_nyinfopage').slideToggle('slow');
        if ($("#infopages span.plus").text() == "-") {
            $("#infopages span.plus").text("+")
        }
        else {
            $("#infopages span.plus").text("-")
        }
    });

    //ny kunde
    $('#nykunde span.plus').click(function () {

        $('#form-nyKunde').slideToggle('slow');

        if ($("#nykunde span.plus").text() == "-") {
            $("#nykunde span.plus").text("+")
        }
        else {
            $("#nykunde span.plus").text("-")
        }
    });

    // ny Bestillingsfelter 
    $('#bestillingsfelter_new span.plus').click(function () {

        $('#bestillingsfelter_form').slideToggle('slow');

        if ($("#bestillingsfelter_new span.plus").text() == "-") {
            $("#bestillingsfelter_new span.plus").text("+")
        }
        else {
            $("#bestillingsfelter_new span.plus").text("-")
        }
    });

    // kunde start with first letter

    $('#kunde_list span.kunde_A').click(function () {

        //var selected = $(this).text();        
        //alert(selected);        
        $('div.kunde_start_with_A').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_A').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_A').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_A').css("background-color", "transparent");
        }
    });

    $('#kunde_list span.kunde_B').click(function () {
        $('div.kunde_start_with_B').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_B').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_B').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_B').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_C').click(function () {
        $('div.kunde_start_with_C').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_C').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_C').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_C').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_D').click(function () {
        $('div.kunde_start_with_D').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_D').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_D').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_D').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_E').click(function () {
        $('div.kunde_start_with_E').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_E').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_E').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_E').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_F').click(function () {
        $('div.kunde_start_with_F').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_F').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_F').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_F').css("background-color", "transparent");
        }
    });

    $('#kunde_list span.kunde_G').click(function () {
        $('div.kunde_start_with_G').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_G').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_G').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_G').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_H').click(function () {
        $('div.kunde_start_with_H').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_H').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_H').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_H').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_I').click(function () {
        $('div.kunde_start_with_I').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_I').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_I').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_I').css("background-color", "transparent");
        }

    });
    $('#kunde_list span.kunde_J').click(function () {
        $('div.kunde_start_with_J').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_J').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_J').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_J').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_K').click(function () {
        $('div.kunde_start_with_K').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_K').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_K').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_K').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_L').click(function () {
        $('div.kunde_start_with_L').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_L').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_L').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_L').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_M').click(function () {
        $('div.kunde_start_with_M').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_M').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_M').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_M').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_N').click(function () {
        $('div.kunde_start_with_N').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_N').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_N').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_N').css("background-color", "transparent");
        }
    });

    $('#kunde_list span.kunde_O').click(function () {
        $('div.kunde_start_with_O').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_O').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_O').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_O').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_P').click(function () {
        $('div.kunde_start_with_P').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_P').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_P').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_P').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_Q').click(function () {
        $('div.kunde_start_with_Q').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_Q').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_Q').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_Q').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_R').click(function () {
        $('div.kunde_start_with_R').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_R').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_R').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_R').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_S').click(function () {
        $('div.kunde_start_with_S').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_S').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_S').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_S').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_T').click(function () {
        $('div.kunde_start_with_T').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_T').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_T').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_T').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_U').click(function () {
        $('div.kunde_start_with_U').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_U').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_U').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_U').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_V').click(function () {
        $('div.kunde_start_with_V').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_V').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_V').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_V').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_W').click(function () {
        $('div.kunde_start_with_W').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_W').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_W').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_W').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_X').click(function () {
        $('div.kunde_start_with_X').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_X').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_X').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_X').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_Y').click(function () {
        $('div.kunde_start_with_Y').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_Y').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_Y').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_Y').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_Z').click(function () {
        $('div.kunde_start_with_Z').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_Z').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_Z').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_Z').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_AO').click(function () {
        $('div.kunde_start_with_AO').slideToggle('slow');

        var bgcolor = $('#kunde_list span.kunde_AO').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_AO').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_AO').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_AE').click(function () {
        $('div.kunde_start_with_AE').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_AE').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_AE').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_AE').css("background-color", "transparent");
        }
    });
    $('#kunde_list span.kunde_OO').click(function () {
        $('div.kunde_start_with_OO').slideToggle('slow');
        var bgcolor = $('#kunde_list span.kunde_OO').css("background-color");
        if (bgcolor == 'transparent') {
            $('#kunde_list span.kunde_OO').css("background-color", "#808080");
        } else {
            $('#kunde_list span.kunde_OO').css("background-color", "transparent");
        }
    });



    /* new project */
    //ny kunde
    $('#newproject span.plus').click(function () {

        $('#form-new-project').slideToggle('slow');

        if ($("#newproject span.plus").text() == "-") {
            $("#newproject span.plus").text("+")
        }
        else {
            $("#newproject span.plus").text("-")
        }
    });


    $('#kunde_filter').change(function () {
        var currentId = $(this).val();

        if (currentId == 'alle') {

            window.location.href = "/Byggeplass/index/";
        }
        /* 
        else {
          
        window.location.href = "/Byggeplass/index/?project_uid=" + currentId;
        //window.location.href = "/Byggeplass/index/id/"+currentId;
        }*/
    });



    // add dynamic text box


    $('.btnAdd').click(function () {
        $('.buttons').append('<div><input type="text" class="required email" name="added_email"><input type="button" class="btnRemove" value="Remove"><br></div>'); // end append
        $('div .btnRemove').last().click(function () {
            $(this).parent().last().remove();
        }); // end click
    }); // end click


    /* New user */
    $('#newuser span.plus').click(function () {
        $('#form-new-user').slideToggle('slow');

        if ($("#newuser span.plus").text() == "-") {
            $("#newuser span.plus").text("+")
        }
        else {
            $("#newuser span.plus").text("-")
        }
    });


    //var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    $("#login_Form").submit(function () {

        var isFormValid = true;
        if ($('#u_pass').val() == "") {
            $('.err_password').html('<span style="color:red"> Password er p&aring;krevd.</span>');
            isFormValid = false;
        } else {
            $('.err_password').html('');
        }

        if ($('#u_mail').val() == "") {
            $('.err_email').html('<span style="color:red"> E-post er p&aring;krevd.</span>');
            isFormValid = false;
        } else {
            $('.err_email').html('');
        }
        return isFormValid;
    });
   /*
    $("#nybestilling_form").submit(function () {

        var isFormValid = true;
        if ($('#date3').val() == "") {
            $('.err_date3').html('<span style="color:red"> Date er p&aring;krevd.</span>');
            isFormValid = false;
        } else {
            $('.err_date3').html('');
        }
       
        return isFormValid;
    }); */
   


    /* new Administrator */


    $('#newadministrator span.plus').click(function () {
        $('#form-new-administrator').slideToggle('slow');

        if ($("#newadministrator span.plus").text() == "-") {
            $("#newadministrator span.plus").text("+")
        }
        else {
            $("#newadministrator span.plus").text("-")
        }
    });

    /* new roller */

    $('#newroller span.plus').click(function () {
        $('#form-new-roller').slideToggle('slow');

        if ($("#newroller span.plus").text() == "-") {
            $("#newroller span.plus").text("+")
        }
        else {
            $("#newroller span.plus").text("-")
        }
    });



    $("#date1").datepicker({
        dateFormat: 'dd-mm-yy',
        firstDay: 1,
        changeYear: true
    });

    //for edit order

    $("#date2").datepicker({
        dateFormat: 'dd-mm-yy',
        firstDay: 1,
        changeYear: true
    });

    // for nybestilling (new order)
    $("#date3").datepicker({
        dateFormat: 'dd-mm-yy',
        firstDay: 1,
        changeYear: true
    });


    // for settings tab    
    var $ui_tabs = $(".ui-tabs").tabs();


    $(".ui-tabs ul li a").click(function (event) {
        var href = $(this).attr('href');
        $("#bestillinger_filter_form").attr("action", href);

    });
    // week day onclick
    
    $("#bestillinger_filter_form .bestillinger_date button").click(function (event) {
        var query_str = ($(this).attr('id'))
        var href = $(this).attr('href');
        var href1 = "";
        var selected = $ui_tabs.tabs('option', 'active');
       
        if (selected == 0) {
            href1 = "#status_1";
        } else if (selected == 1) {
            //href1 = "#status_2";
            href1 = "#status_1";
        } else if (selected == 2) {
            //href1 = "#status_3";
            href1 = "#status_1";
        }        
        $("#bestillinger_filter_form").attr("action", "?" + query_str + href1);
        this.form.submit();
    });
    
    $("#bestillinger_filter_company").change(function () {

        var href1 = "";
        var selected = $ui_tabs.tabs('option', 'active');
        if (selected == 0) {
            href1 = "#status_1";
        } else if (selected == 1) {
            href1 = "#status_2";
        } else if (selected == 2) {
            href1 = "#status_3";
        }
        $("#bestillinger_filter_form").attr("action", href1);
        this.form.submit();
    });

    $("#bestillinger_filter_project").change(function () {

        var href1 = "";
        var selected = $ui_tabs.tabs('option', 'active');
        if (selected == 0) {
            href1 = "#status_1";
        } else if (selected == 1) {
            href1 = "#status_2";
        } else if (selected == 2) {
            href1 = "#status_3";
        }
        $("#bestillinger_filter_form").attr("action", href1);
        this.form.submit();
    });

    $("#date1").change(function () {
        var href1 = "";

        var selected = $ui_tabs.tabs('option', 'active');

        if (selected == 0) {
            href1 = "#status_1";
        } else if (selected == 1) {
            href1 = "#status_2";
        } else if (selected == 2) {
            href1 = "#status_3";
        }
        var url = ($(location).attr('href'));
        url_arr = url.split("?");
        if (url_arr[1] != undefined) {
            qstr_date = url_arr[1].split("=");
            if (qstr_date.length == 1 && qstr_date[0].split("#").length > 0) {
                //alert(qstr_date[0].split("#").length);
                q_date = qstr_date[0].split("#");
                qstr_date[0] = q_date[0];
            }
            $("#bestillinger_filter_form").attr("action", "?" + qstr_date[0] + href1);
        }
        this.form.submit();
    });

    $(".BestillingsfelterDelete").click(function () {
        //var id = $(this).attr('data-id');
        var name = $(this).attr('data-name');
        if (! confirm('Are you suer to delete ??  " ' + name + ' "' )) {
            return false;
        } /*else {
            window.location.href = "/Bestillingsfelter/Delete/" + id;
        }*/
    });

});





