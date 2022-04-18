// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var PlaceHolderElement = $('#PlaceHolderPopup')
    $('button[data-toggle="ajax-modal"]').click(function (event){

        $.ajax({
            type: 'GET',
            url: $(this).data('url'),
            success: function (result) {
                PlaceHolderElement.html(result);
                PlaceHolderElement.find('.modal').modal('show');
            },
            error: function (Error) {
                alert(Error.responseText);
                console.log('Failed ');
            }
        })
    })

    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
                
        $.ajax({
            type: 'POST',
            url: form.attr('action'),
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: form.serialize(),
            success: function (result) {
                location.reload(true);
            },
            error: function (Error) {
                alert(Error.responseText);
                console.log('Failed ');
            }
        })
    })

    PlaceHolderElement.on('click', '[data-dismiss="modal"]', function (event) {
        PlaceHolderElement.find('.modal').modal('hide');
    })
})