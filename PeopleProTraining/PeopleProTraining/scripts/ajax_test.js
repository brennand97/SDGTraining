//Load Data in Table when documents is ready  
$(document).ready(function () {
    loadData();
});

function loadData() {
    LoadDatabaseData();
}

function GetData(table, success_func, error_func) {
    $.ajax({
        url: "/Ajax/List?table=" + table,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: success_func,
        error: error_func
    });
}

function LoadDatabaseData() {
    // Get department data
    GetData("departments",
        function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '</tr>';
            });
            $('.tbody-departments').html(html);
        },
        function (errormessage) {
            alert(errormessage.responseText);
        }
    );

    // Get building data
    GetData("buildings",
        function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.Address + '</td>';
                html += '</tr>';
            });
            $('.tbody-buildings').html(html);
        },
        function (errormessage) {
            alert(errormessage.responseText);
        }
    );

    // Get employee data
    GetData("employees",
        function (result) {
            var html = '';
            $.each(result, function (key, item) {
                date = new Date(parseInt(item.StartDate.substring(item.StartDate.indexOf("(") + 1, item.StartDate.indexOf(")"))));
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.FirstName + '</td>';
                html += '<td>' + item.LastName + '</td>';
                html += '<td>' + item.Salary + '</td>';
                html += '<td>' + date.toUTCString() + '</td>';
                html += '<td>' + item.DepartmentId + '</td>';
                html += '<td>' + item.BuildingId + '</td>';
                html += '</tr>';
            });
            $('.tbody-employees').html(html);
        },
        function (errormessage) {
            alert(errormessage.responseText);
        }
    );
}