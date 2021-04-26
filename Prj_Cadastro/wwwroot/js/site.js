// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).ready(function(){
    $(":input").inputmask();

    $("#phone").inputmask({
        mask: '(99) 99999 9999',
        placeholder: ' ',
        showMaskOnHover: false,
        showMaskOnFocus: false,
        onBeforePaste: function (pastedValue, opts) {
        var processedValue = pastedValue;

        //do something with it

        return processedValue;
        }
    });
});