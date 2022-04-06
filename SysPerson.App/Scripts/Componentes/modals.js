$(function () {
    if ($('#divModal').is(':visible')) {
        var color = $(this).data('color');
        $('#defaultModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#defaultModal').modal('show');
    }
});