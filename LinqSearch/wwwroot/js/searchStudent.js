
$('[data-attr="submit"]').on('click', function () {
    $.ajax(
        {
            type: "GET",
            url: "/Search/SearchByName",
            data: { 'name': $('#SearchId').val() },
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);
            },
            error: function (err) {
                console.log(err);
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(err.statusText);
            }
        });
});