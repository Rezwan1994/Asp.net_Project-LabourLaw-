var Device = {
    Android: function () {
        return navigator.userAgent.match(/Android/i) ? true : false;
    },
    BlackBerry: function () {
        return navigator.userAgent.match(/BlackBerry/i) || navigator.userAgent.match(/BB/i) ? true : false;
    },
    iOS: function () {
        return navigator.userAgent.match(/iPhone|iPod/i) ? true : false;
    },
    iPad: function () {
        return navigator.userAgent.match(/iPad/i) ? true : false;
    },
    Windows: function () {
        return navigator.userAgent.match(/IEMobile/i) ? true : false;
    },
    All: function () {
        return (Device.Android() || Device.BlackBerry() || Device.iOS() || Device.Windows() || Device.iPad());
    },
    Mobile: function () {
        return (Device.Android() || Device.BlackBerry() || Device.iOS() || Device.Windows());
    },
    MobileGadget: function () {
        if (navigator.userAgent.match(/SmartTV/i)) {
            return false;
        }
        return (Device.Android() || Device.BlackBerry() || Device.iOS() || Device.Windows() || window.innerWidth < 769);
    },
    Desktop: function () {
        return (!Device.Android() && !Device.BlackBerry() && !Device.iOS() && !Device.Windows() && !Device.iPad() && !(window.innerWidth > 768));
    }
};

var Validation = {
    IsEmpty: function (ctrl) {
        var result = true;
        var value = $.trim($(ctrl).val());
        $(ctrl).val(value);
        var label;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    $('#isexist').hide();
                    label = $(labels[ind]);
                    break;
                }
            }
        }
        else
            label = labels;

        if (value == "") {
            $(ctrl).addClass('required');
            $(label).removeClass('hidden');
            return true;
        }
        $(label).addClass('hidden');
        $(ctrl).removeClass('required');
        
        return false;
    },
    IsEmail: function (ctrl) {
        var value = $.trim($(ctrl).val());

        var label;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    label = $(labels[ind]);
                    break;
                }
            }
        }
        else
            label = labels;

        $(ctrl).val(value);
        if ($(ctrl).val() != "") {
            var regexp = /^[\+a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
            if (RegularExpressionCheck($(ctrl).val(), regexp)) {
                $(ctrl).removeClass('required');
                $(label).addClass('hidden');
                
                return true;
            }
        }
        $(ctrl).addClass('required');
        $(label).removeClass('hidden');
       
        return false;
    },
    IsPassord: function (ctrl) {
        var value = $(ctrl).val();

        var label;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    label = $(labels[ind]);
                    break;
                }
            }
        }
        else
            label = labels;

        if ($(ctrl).val() != "") {
            if (value.length > 5) {
                $(ctrl).removeClass('required');
                $("#lblPasswordError").addClass('hidden');
                return true;
            }
            $(ctrl).addClass('required');
            $("#lblPasswordError").removeClass('hidden');
        }
        return false;
    },

    IsCnfPassord: function (ctrl) {
        var value = $(ctrl).val();

        var label;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    label = $(labels[ind]);
                    break;
                }
            }
        }
        else
            label = labels;

        if ($(ctrl).val() != "") {
            if (value.length > 5) {
                $(ctrl).removeClass('required');
                $("#lblPasswordError").addClass('hidden');
                return true;
            }
            $(ctrl).addClass('required');
            $("#lblPasswordError").removeClass('hidden');
        }
        return false;
    },

    IsPhone: function (ctrl) {
        var value = $.trim($(ctrl).val());
        var pCountry = $(ctrl).parent().parent();

        var plabel;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    plabel = $(labels[ind]);
                    break;
                }
            }
        }
        else
            plabel = labels;

        var pSelect = $(pCountry).find('select');
        if (typeof pSelect != 'undefined') {
            if ($(pSelect).val() == 'Others') {
                value = '+' + value;
            }
        }

        //validation 
        //$(ctrl).val(value);
        //if ($(ctrl).val() != "") {
        //    var regexp = /^(?:\+88|01)?(?:\d{11}|\d{13})$/;
        //    if (RegularExpressionCheck($(ctrl).val(), regexp)) {
        //        $(ctrl).removeClass('required');
        //        $(label).addClass('hidden');

        //        return true;
        //    }
        //}

        if ($(ctrl).val() != "") {
            if (this.IsPhoneNumber(value)) {
                $(plabel).addClass('hidden');
                $(ctrl).removeClass('required');
               
                return true;
            }
        }

        $(plabel).removeClass('hidden');
        $(ctrl).addClass('required');
        
        return false;

    },


    IsPhoneNumber: function (phone) {
        try {
            country = "MY";
            var phone = cleanPhone(phone);
            if (phone.length == 10 || phone.length == 11)
                return true;
            var phoneUtil = i18n.phonenumbers.PhoneNumberUtil.getInstance();
            var number = phoneUtil.parseAndKeepRawInput(phone, country);
            return phoneUtil.isValidNumber(number);
        }
        catch (e) {
            return false;
        }
    },

    IsPrice: function (ctrl) {
        var result = true;
        var value = $.trim($(ctrl).val());
        if (value == "") {
            $(this).addClass('required');
            return false;

        } else {
            $(ctrl).val(value);
            if (PropertyFor == "ForSale" || PropertyFor == "ForNew") {
                if (value >= 50000 && value <= 50000000) {
                    $(this).removeClass('required');
                    $("#lblPropertyPriceError").addClass("hidden");
                    return true;
                }
                else {
                    $(this).addClass('required');
                    $("#lblPropertyPriceError").removeClass("hidden");
                    return false;
                }
            }
            else if (PropertyFor == "ForRent") {
                if (value >= 100 && value <= 100000) {
                    $(ctrl).removeClass('required');
                    $("#lblPropertyPriceError").addClass("hidden");
                    return true;
                }
                else {
                    $(ctrl).addClass('required');
                    $("#lblPropertyPriceError").removeClass("hidden");
                    return false;
                }
            }
            else {
                return false;
            }
        }
    },
    IsBuiltUpArea: function (ctrl) {
        var result = true;
        var value = $.trim($(ctrl).val());
        $(ctrl).val(value);
        var label;
        var labels = $($(ctrl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctrl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    label = $(labels[ind]);
                    break;
                }
            }
        }
        else
            label = labels;
        if (value >= 500 && value <= 10000) {
            $(label).addClass('hidden');
            $(this).removeClass('required');
            return true;
        }
        else {
            $(this).addClass('required');
            $(label).removeClass('hidden');
            return false;
        }
    },
    ForTextbox: function (inputctl) {
        var result = true;
        var check = false;
        if ($(inputctl).attr('datarequired') == 'true') {
            check = !Validation.IsEmpty($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'email') {
            check = Validation.IsEmail($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'phone') {
            check = Validation.IsPhone($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'password') {
            check = Validation.IsPassord($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'confirmpassword') {
            check = Validation.IsCnfPassord($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'price') {
            check = Validation.IsPrice($(inputctl));
            if (!check)
                result = check;
        }
        if ($(inputctl).attr('dataformat') == 'builtuparea') {
            check = Validation.IsBuiltUpArea($(inputctl));
            if (!check)
                result = check;
        }
        return result;
    },
    ForSelect: function (ctl) {
        var tempCtl = ctl;
        var formctl = $(ctl).parent().parent();
        var inputvalue = $(formctl).find('select');
        var labelmgs;
        var labels = $($(ctl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    labelmgs = $(labels[ind]);
                    break;
                }
            }
        }
        else
            labelmgs = labels;
        var selectedvalue = '';
        for (var i = 0; i < inputvalue.length; i++) {
            if ($(inputvalue[i]).attr('name') == $(ctl).attr('name'))
                selectedvalue = $(inputvalue[i]).val();
        }
        if (selectedvalue == '' || selectedvalue == '-1') {
            $(ctl).addClass('required');
            $(labelmgs).removeClass('hidden');
            return false;
        }
        else {
            $(ctl).removeClass('required');
            $(labelmgs).addClass('hidden');
            return true;
        }
    },
    ForCheckBox: function (ctl) {
        var labelmgs;
        var labels = $($(ctl).parent().parent()).find('label');
        if (labels.length > 1) {
            var cltrName = $(ctl).attr('name');
            for (var ind = 0; ind < labels.length; ind++) {
                if ($(labels[ind]).attr('rel') == cltrName) {
                    labelmgs = $(labels[ind]);
                    break;
                }
            }
        }
        else
            labelmgs = labels;
        if (!$(ctl).is(':checked') && $(ctl).attr('checkedrequired') == 'true') {
            $(ctl).addClass('required');
            $(labelmgs).removeClass('hidden');
            return false;
        }
        else {
            $(ctl).removeClass('required');
            $(labelmgs).addClass('hidden');
            return true;
        }
    }
}
var RegularExpressionCheck = function (inputs, expression) {
    return expression.test(inputs);
};


var CommonUiValidation = function () {
    var result = true;
    var inputlist = $("input");
    var areaslist = $("textarea");
    var selectList = $("select");
    for (var i = 0; i < selectList.length; i++) {
        if ($(selectList[i]).attr('datarequired') == 'true' && $(selectList[i]).is(":visible")) {
            var check = Validation.ForSelect($(selectList[i]));
            if (!check)
                result = check;
        }
    }
    for (var i = 0; i < inputlist.length; i++) {
        if ($(inputlist[i]).attr('type') == 'checkbox' && $(inputlist[i]).is(":visible") && $(inputlist[i]).attr('checkedrequired') == 'true') {
            var check = Validation.ForCheckBox($(inputlist[i]));
            if (!check)
                result = check;
        }
        if ($(inputlist[i]).attr('datarequired') == 'true' && $(inputlist[i]).is(":visible")) {
            var check = Validation.ForTextbox($(inputlist[i]));
            if (!check)
                result = check;
        }
    }
    for (var i = 0; i < areaslist.length; i++) {
        
        if ($(areaslist[i]).attr('datarequired') == 'true' && $(areaslist[i]).is(":visible")) {
            var check = Validation.ForTextbox($(areaslist[i]));
            if (!check)
                result = check;
        }
    }
    return result;
}

$(document).ready(function () {
    $('input').focus(function () {
        var inputctl = this;
        if ($(inputctl).hasClass('required')) {
            $(inputctl).removeClass('required');
        }
    });
    $('input').blur(function () {
        var inputctl = this;
        if ($(inputctl).attr('datarequired') == 'true') {
            Validation.IsEmpty($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'email') {
            Validation.IsEmail($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'phone') {
            Validation.IsPhone($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'password') {
            Validation.IsPassord($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'confirmpassword') {
            Validation.IsCnfPassord($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'price') {
            Validation.IsPrice($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'builtuparea') {
            Validation.IsBuiltUpArea($(inputctl));
        }
        if ($(inputctl).attr('dataformat') == 'propertyname') {
            Validation.IsPropertyName($(inputctl));
        }
    });
    $('select').change(function () {
        var selectItem = this;
        if ($(this).attr('datarequired') == 'true')
            Validation.ForSelect($(selectItem));
        
    });
});