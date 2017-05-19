//Load Data in Table when documents is ready  
$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/Ajax/List?table=departments",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Name + '</td>';
                html += '</tr>';
            });
            $('.tbody-departments').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}