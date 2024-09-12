$(document).ready(function () {
    $('#frmPage').on('submit', function (e) {
        SetPageName(e);
    });
});

function SetPageName(e) {
    debugger
    e.preventDefault();

    $.ajax({
        url: '/Home/GetPageName',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data.success)
                $('#txtpage').val(data.result);
        }
    });
}