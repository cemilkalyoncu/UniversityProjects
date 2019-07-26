$(document).ready(function () {
    $(".menus").click(function () {
        $(".submenus").each(function (index) {
            $(this).hide("slow");
        });
        $(".menus").each(function (index) {
            $(this).attr("class", "menus");
        });
        $(this).attr("class", "menus menus_active");
        $("#menu_" + $(this).attr("id")).show("normal", function () { $(".menu").height($(document).height()) });
        $.cookie("active_menu", $(this).attr('id'));
    });
    $(".submenus li").click(function () {
        $(".submenus li").each(function (index) {
            $(this).attr("class", "");
        });
        $(this).attr("class", "active");
        $.cookie("active_page", $(this).attr('page'));
        var url = $(this).attr('page');
        $(".path").html("YÃ¶netici Paneli > " + $(this).html());
        window.location = url;
    });
    var url = $(location).attr('href').split("/");
    if ($.cookie("active_menu") && url[4].indexOf($.cookie("active_page")) != '-1') {
        $("#" + $.cookie("active_menu")).click();
        if ($.cookie("active_page")) {
            $(".submenus li[page='" + $.cookie("active_page") + "']").attr("class", "active");
            $(".path").html("YÃ¶netici Paneli > " + $(".submenus li[page='" + $.cookie("active_page") + "']").html());
        }
    }
    $(".menu").height($(document).height());
    jQuery(function ($) {
        $.datepicker.regional['tr'] = {
            closeText: 'Kapat',
            prevText: '&#x3c; Geri',
            nextText: 'Ä°leri &#x3e',
            currentText: 'BugÃ¼n',
            monthNames: ['Ocak', 'Åubat', 'Mart', 'Nisan', 'MayÄ±s', 'Haziran',
            'Temmuz', 'AÄŸustos', 'EylÃ¼l', 'Ekim', 'KasÄ±m', 'AralÄ±k'],
            monthNamesShort: ['Oca', 'Åub', 'Mar', 'Nis', 'May', 'Haz',
            'Tem', 'AÄŸu', 'Eyl', 'Eki', 'Kas', 'Ara'],
            dayNames: ['Pazar', 'Pazartesi', 'SalÄ±', 'Ã‡arÅŸamba', 'PerÅŸembe', 'Cuma', 'Cumartesi'],
            dayNamesShort: ['Pz', 'Pt', 'Sa', 'Ã‡a', 'Pe', 'Cu', 'Ct'],
            dayNamesMin: ['Pz', 'Pt', 'Sa', 'Ã‡a', 'Pe', 'Cu', 'Ct'],
            dateFormat: 'yy-mm-dd', firstDay: 1,
            isRTL: false
        };
        $.datepicker.setDefaults($.datepicker.regional['tr']);
    });
    $(".showdate").datepicker();
});